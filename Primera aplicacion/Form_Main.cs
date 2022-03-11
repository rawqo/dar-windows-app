/* 
 * 1/10
 * Ya esta todo lo basico funcionando, ahora me faltan detalles y cosas extra.
 * Tengo que hacer el rango de la bateria. Primero calcular a cuanta distancia equivale una unidad del circulo y despues
 * implementarlo bien en el codigo.
 * Cosas a considerar son el protocolo y un trazador de ruta (algo que quede fachero), ademas de obtener una posicion
 * inicial flexible, pidiendole los datos al dron.
 * 
 * 4/10
 * Se habia creado una interfaz para la comunicacion entre los dos Forms (compartir las coordenadas del puerto serie) pero eso
 * no era necesario. La solucion final fue declarar al Form_Conexion como hijo y hacer que este "reconozca" al Form_Main como padre.
 * De esta forma se pueden compartir variables y funciones entre los dos Form.
 * 
 * 8/10
 * Se comenzo a definir la comunicacion entre la pc y el arduino y se empezo a crear los metodos de comunicacion en el
 * programa.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;

using GMap.NET;

using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace Primera_aplicacion
{
    public partial class Form_Main : Form
    {
        //Declaro los marcadores, la capa donde los voy a colocar y 
        //una tabla de datos para almacenar posiciones
        GMarkerGoogle markerDron;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        public Boolean DronConectado = false;   //Variable booleana, sirve como verificacion para ciertos controles

        int fila_seleccionada;

        //Declaracion de variables double que representan las coordenadas iniciales del mapa
        double LatInicial = -34.706845093052735;
        double LngInicial = -58.23879250387637;

        //Simulacion de una ubicacion obtenida
        double LatRecibida = -34.706845093052735;
        double LngRecibida = -58.23879250387637;

        int cont = 1;   //contador

        

        //variables utilizadas para la creacion de poligonos
        List<PointLatLng> listaCirculo = new List<PointLatLng>();
        List<PointLatLng> listaLinea = new List<PointLatLng>();
        GMapOverlay layerCirculo = new GMapOverlay("Capa Circulo");
        GMapOverlay layerLineas = new GMapOverlay("Capa Linea");

        Graphics Grafico;
        Bitmap ImagenBMP;
        Pen Lapiz;
        //Capa para los marcadores creados desde el puerto serie
        //GMapOverlay overlaySerial;

        //Creo el objeto del Form de conexion con el XBee para poder acceder a sus parametros
        Form_Conexion Form_Conexion;

        //Declaro un mapa de bits que representa a la imagen del marcador del dron
        Bitmap MarkerDron_Imagen;
        
        

        //contador para la descripcion de los datos recibidos por puerto serie
        //int contData = 1;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Junto ambas coordenadas de latitud y longitud en una variable, las cuales componen un punto
            PointLatLng puntoInicial = new PointLatLng(LatInicial, LngInicial);
            
            //Inicializacion del Mapa
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap; //Proovedor de servicios del mapa
            gMapControl1.Position = puntoInicial;   //Posicion inicial del mapa
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;
            gMapControl1.ShowCenter = true;        //Quita la cruz roja del medio del mapa

            ImagenBMP = new Bitmap(gMapControl1.Width, gMapControl1.Height);
            Grafico = Graphics.FromImage(ImagenBMP);
            Lapiz = new Pen(Color.Blue, 1);

            //Marcador del Dron
            MarkerDron_Imagen = (Bitmap)Primera_aplicacion.Properties.Resources.MarkerDron;
            markerOverlay = new GMapOverlay("Marcador"); //genera una capa por encima del mapa creado
            markerDron = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), MarkerDron_Imagen); //crea el marcador
            markerOverlay.Markers.Add(markerDron); //Añadir el marker del dron a la capa de dibujo de marcadores
            markerDron.Tag = "Ubicacion Drone";
            

            //Añadir un Tooltip (texto) al marcador
            markerDron.ToolTipMode = MarkerTooltipMode.OnMouseOver; //el tooltip aparece cuando se le pone el mouse encima
            markerDron.ToolTipText = "Descripcion: Ubicacion Drone \n Latitud: " + LatInicial + "\n Longitud: " + LngInicial;

            //añadir el overlay al mapa principal
            gMapControl1.Overlays.Add(markerOverlay);

            //Añadir el DataTable
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Latitud", typeof(double)));
            dt.Columns.Add(new DataColumn("Longitud", typeof(double)));

            //Agregar la primera fila y exhibir todo en la interfaz
            dt.Rows.Add(markerDron.Tag, LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            //hacer invisible en la interfaz la latitud y la longitud
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.ReadOnly = true;

            //Agrego los marcadores a los combobox para que se puedan seleccionar puntos de partida y destino
            comboBox_Desde.Items.Add(dataGridView1.Rows[0].Cells[0].Value.ToString());
            comboBox_Hacia.Items.Add(dataGridView1.Rows[0].Cells[0].Value.ToString());

        }

        private void Seleccionar_registro(object sender, DataGridViewCellMouseEventArgs e)
        {
            fila_seleccionada = e.RowIndex; //devuelve la fila seleccionada

            //inserta los datos seleccionados en el dt y los pone en los textbox
            if (fila_seleccionada >= 0)
            {
                txtDescripcion.Text = dataGridView1.Rows[fila_seleccionada].Cells[0].Value.ToString();
                txtLatitud.Text = dataGridView1.Rows[fila_seleccionada].Cells[1].Value.ToString();
                txtLongitud.Text = dataGridView1.Rows[fila_seleccionada].Cells[2].Value.ToString();
            }

            //centrar el mapa          
            gMapControl1.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));


        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //obtener los datos de lat y lng del lugar donde se hizo doble click
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //inicializar el marcador
            marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_dot);
            markerOverlay.Markers.Add(marker);//Añadir al marcador

            //Añado los datos a los textbox
            txtDescripcion.Text = "Waypoint " + cont;
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();
            cont++;

            //Añade la posicion seleccionada al dt
            dt.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text);

            //Crear el marcador
            marker.Position = new PointLatLng(lat, lng);

            //agregar el tooltip
            marker.ToolTipText = "Descripcion: " + txtDescripcion.Text + "\n Latitud: " + lat + "\n Longitud: " + lng;

            //Agregarle un Tag al marker
            marker.Tag = txtDescripcion.Text;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(gMapControl1.Width / 2, gMapControl1.Height / 2).Lat;
            double lng = gMapControl1.FromLocalToLatLng(gMapControl1.Width / 2, gMapControl1.Height / 2).Lng;

            string descripcion;
            if (txtDescripcion.Text != "")
                descripcion = txtDescripcion.Text;
            else
            { descripcion = "Waypoint " + cont; cont++; }

            if (txtLatitud.Text == "" || txtLongitud.Text == "")
            {
                txtLatitud.Text = lat.ToString();
                txtLongitud.Text = lng.ToString();
            }
            
            //Agregar los datos al dt
            dt.Rows.Add(descripcion, txtLatitud.Text, txtLongitud.Text);

            //Inicializar el marcador
            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng)), GMarkerGoogleType.red_dot);
            markerOverlay.Markers.Add(marker);//Añadir al marcador

            //Colocar el marcador
            marker.Position = new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng));

            //agregar el tooltip
            marker.ToolTipText = "Descripcion: " + descripcion + "\n Latitud: " + txtLatitud.Text + "\n Longitud: " + txtLongitud.Text;

            //centrar el mapa
            gMapControl1.Position = marker.Position;

            //Agregarle un Tag al marker
            marker.Tag = descripcion;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Elimina la fila seleccionada en el dt y su marcador correspondiente
                if (txtDescripcion.Text != "Ubicacion Drone")
                {
                    dataGridView1.Rows.RemoveAt(fila_seleccionada);
                    markerOverlay.Markers.RemoveAt(fila_seleccionada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            double lat = item.Position.Lat;
            double lng = item.Position.Lng;

            int fila = 0;

            //encuentra la fila en la que se ubica el marcador
            for (int x = 0; dataGridView1.Rows[x].Cells[0].Value.ToString() != item.Tag.ToString(); x++) fila = x+1;

            //Deselecciona todas las filas del dt primero y luego selecciona la fila actual
            for (int i = 0; i != dataGridView1.RowCount; i++) dataGridView1.Rows[i].Selected = false;
            dataGridView1.Rows[fila].Selected = true;

            //Cuando se hace click sobre un marcador se muestran sus datos en los label
            txtDescripcion.Text = item.Tag.ToString();
            txtLatitud.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();

            gMapControl1.Position = new PointLatLng(lat, lng);
        }

        private void btn_Conexion_Click(object sender, EventArgs e)
        {
            Form_Conexion = new Form_Conexion(this);
            //Abrir el Form de conexion
            Form_Conexion.Show(this);
        }

       /* 
        private void btn_circle_Click(object sender, EventArgs e)
        {
            double radio = 1;
            double divisor = 1000;
            int distancia; //es la distancia en metros que se quiere que sea el radio del circulo

            if (txt_dist.Text != "")
            {
                distancia = Convert.ToInt16(txt_dist.Text);
                
                 // Haciendo calculos para convertir los valores de coordenadas a distancia en metros la unidad
                 // de radio del circulo es de aproximadamente 89m
         
                radio = distancia / 89.0;
            }
            else
            {
                //Si no hay nada en el txt de distancia entonces revisa el resto
                if (txt_radio.Text != "")
                {
                        //Obtener el valor en el textbox
                        radio = Convert.ToDouble(txt_radio.Text);
                }
                else
                {
                    //Si no se ingreso nada en el textbox, se utiliza la seleccion de los checkbox
                    divisor = 100;
                    if (cbx_corto.Checked == true) { divisor = 1000; }
                    else if (cbx_medio.Checked == true) { divisor = 500; }
                    else if (cbx_largo.Checked == true) { divisor = 100; }
                    else radio = 1;
                }
            }

            //Cant de puntos para dibujar el circulo
            int puntos = 360;

            //Angulo entre dos puntos, en radianes
            double angSegmentos = 2 * Math.PI / puntos;

            PointLatLng centro = new PointLatLng();
            centro.Lat = LatInicial;
            centro.Lng = LngInicial;

            double ang;

            for (int i = 1; i <= puntos ; i++)
            {
                //Se crean los puntos variando el angulo y se los agrega a la lista
                ang = angSegmentos * i;
                double a = centro.Lat + Math.Sin(ang) * radio  / divisor;
                double b = centro.Lng + Math.Cos(ang) * radio / divisor;

                PointLatLng marca = new PointLatLng(a, b);
                listaCirculo.Add(marca);

            }

            /
        */
        public void enviarCoordenadas(string dato)
        {
            //Si esta conectado, envia los datos de las textbox
            if (DronConectado)
            {
                serialPort1.WriteLine(dato);

            }
        }

        #region ComunicacionSerie
        public void coordenadasSerie(double dataLat, double dataLng)
        {
            PointLatLng CoordSerie = new PointLatLng(dataLat, dataLng);

            marker = new GMarkerGoogle(CoordSerie, GMarkerGoogleType.red_dot);
            marker.Tag = "Marcador Serie " + cont;
            marker.Position = CoordSerie;

            markerOverlay.Markers.Add(marker);
 
            gMapControl1.Position = marker.Position;
            
            txtDescripcion.Text = "Waypoint " + cont;
            txtLatitud.Text = CoordSerie.Lat.ToString();
            txtLongitud.Text = CoordSerie.Lng.ToString();

            dt.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text);

            cont++;
        }

        public void coordenadasIniciales(double lat, double lng)
        {
            LatInicial = lat;
            LngInicial = lng;

            //centrar el mapa
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);

            //Elimina el marcador y modifica los valores de las celdas
            markerOverlay.Markers.RemoveAt(0);
            dataGridView1.Rows[0].Cells[1].Value = LatInicial;
            dataGridView1.Rows[0].Cells[2].Value = LngInicial;
            dataGridView1.DataSource = dt;

            //Marcador
            markerOverlay = new GMapOverlay("Marcador"); //genera una capa por encima del mapa creado
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.lightblue_dot); //crea el marcador
            markerOverlay.Markers.Add(marker);//Añadir al marcador
            marker.Tag = "Ubicacion Inicial";

            //Añadir un Tooltip (texto) al marcador
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver; //el tooltip aparece cuando se le pone el mouse encima
            marker.ToolTipText = "Descripcion: Ubicacion Inicial \n Latitud: " + LatInicial + "\n Longitud: " + LngInicial;

            //añadir el overlay al mapa principal
            gMapControl1.Overlays.Add(markerOverlay);
   
        }
        #endregion

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            //PointLatLng coord = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
            string dato = txtLatitud.Text + ";" + txtLongitud.Text;

            enviarCoordenadas(dato);
            textBox_SerialLog.Text = string.Format(textBox_SerialLog.Text + dato, Environment.NewLine);
        }

        private void btnTrazarLinea_Click(object sender, EventArgs e)
        {

            PointLatLng puntoInicial = new PointLatLng(LatInicial, LngInicial);
               // puntoInicial = comboBox_Desde.SelectedIndex;
               // puntoFinal = comboBox_Hacia.SelectedIndex;
            //PointLatLng puntoDestino = new PointLatLng()

            //listaLinea.Add(puntoDePartida);
            //listaLinea.Add(puntoDestino);
            listaLinea.Add(markerDron.Position);
            listaLinea.Add(marker.Position);
                
            //Se crea el poligono Circulo
            GMapRoute linea = new GMapRoute(listaLinea, "Linea");
            linea.Stroke = new Pen(Color.Salmon, 3);
            
            //Se agrega el circulo a la capa
            layerLineas.Routes.Add(linea);
            //Se agrega la capa al mapa
            gMapControl1.Overlays.Add(layerLineas);
            //Se actualiza el mapa
            //gMapControl1.Refresh();
            gMapControl1.Zoom++;
            gMapControl1.Zoom--;

            //Se limpia la lista para el proximo circulo
            listaLinea.Clear();      
        }

        private void btn_zoomMas_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom++;
        }

        private void btn_zoomMenos_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom--;
        }

        private void gMapControl1_OnMapDrag()
        {
            double lat = gMapControl1.FromLocalToLatLng(gMapControl1.Width / 2, gMapControl1.Height / 2).Lat;
            double lng = gMapControl1.FromLocalToLatLng(gMapControl1.Width / 2, gMapControl1.Height / 2).Lng;
            label_latitud.Text = "Latitud: " + lat;
            label_longitud.Text = "Longitud: " + lng;

            txtDescripcion.Text = "";
            txtLatitud.Text = "";
            txtLongitud.Text = "";

        }
        
        private void btnEliminarLinea_Click(object sender, EventArgs e)
        {
            layerLineas.Routes.Clear();
        }

        
        private void btn_conectarDron_Click(object sender, EventArgs e)
        {
            if (!DronConectado)  //Si no esta conectado el puerto, realizar la conexión
            {
                try
                {
                    //Definir los parámetros de la comunicación serial 
                    serialPort1.PortName = comboBox_ports.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();  //Abrir la conexión
                    btn_conectarDron.BackgroundImage = Primera_aplicacion.Properties.Resources.LOGO_V2_USB_DESCONECTAR;
                    label_status.Text = "Conectado en " + serialPort1.PortName;
                    label_status.ForeColor = Color.ForestGreen;
                    //label_status_colorpoint.ForeColor = Color.ForestGreen;
                    DronConectado = true;
                    textBox_SerialLog.Text = "Serial iniciado correctamente \n";
                }
                catch (Exception ex)   // Código de error
                {
                    MessageBox.Show("Error en la conexión: " + ex.Message);
                    serialPort1.Close(); //Cerrar la conexión
                }
            }
            else   //Cerrar conexión.
            {
                //label_status_colorpoint.ForeColor = Color.Red;
                label_status.ForeColor = Color.Red;
                label_status.Text = "Desconectado";
                DronConectado = false;
                btn_conectarDron.BackgroundImage = Primera_aplicacion.Properties.Resources.LOGO_V2_USB_CONECTAR;    
                if (serialPort1 != null)
                    serialPort1.Close();
            }
 
        }

        private void btnObtenerUbicacion_Click(object sender, EventArgs e)
        {
            // Se utilizan las coordenadas recibidas por el modulo gps
            // para determinar la posicion del dron y ajustarla
             
            LatRecibida = -34.707345093052735;
            LngRecibida = -58.23879250387637;
            markerDron.Position = new PointLatLng(LatRecibida,LngRecibida);

        }

        private void Serial_enviarCMD_Click(object sender, EventArgs e)
        {
            if (DronConectado)
            {
                //serialPort1.Write(textBox_enviarCMD.Text);  //Descomentar para enviar el comando
                textBox_SerialLog.Text = textBox_SerialLog.Text + "\r\n>>> " + textBox_enviarCMD.Text;
                serialPort1.Write(textBox_enviarCMD.Text);
            }
        }

        /*
        private void textBox_SerialLog_Enter(object sender, EventArgs e)
        {
            textBox_SerialLog.Text = ">>> ";
        }
        */

        private void comboBox_Desde_Click(object sender, EventArgs e)
        {
            comboBox_Desde.Items.Clear();
            for (int conpoints = 0; conpoints < dataGridView1.RowCount; conpoints++)
            {
                comboBox_Desde.Items.Add(dataGridView1.Rows[conpoints].Cells[0].Value.ToString());
            }
            
        }

        private void comboBox_Hacia_Click(object sender, EventArgs e)
        {
            
            comboBox_Hacia.Items.Clear();
            for (int conpoints = 0; conpoints < dataGridView1.RowCount; conpoints++)
            {
                comboBox_Hacia.Items.Add(dataGridView1.Rows[conpoints].Cells[0].Value.ToString());
            }
             
        }

        private void gMapControl1_MouseEnter(object sender, EventArgs e)
        {
            label_consejo.Text = "Consejo: Puede agregar un marcador haciendo doble click donde desea agregarlo en el mapa";
        }

        private void gMapControl1_MouseLeave(object sender, EventArgs e)
        {
            label_consejo.Text = "";
        }

        private void btnObtenerUbicacion_MouseEnter(object sender, EventArgs e)
        {
            label_consejo.Text = "Descripcion: Permite obtener la ubicacion actual del dron si se encuentra conectado";
        }

        private void btnObtenerUbicacion_MouseLeave(object sender, EventArgs e)
        {
            label_consejo.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            //textBox_SerialLog.Text = textBox_SerialLog.Text + "\r\n" + serialPort1.ReadExisting();
            serialPort1.ReadExisting();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label_longitud_Click(object sender, EventArgs e)
        {

        }

    }
}

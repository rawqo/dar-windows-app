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

using GMap.NET;

using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace Primera_aplicacion
{
    public partial class Form_Main : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        

        int fila_seleccionada;
        double LatInicial = -34.706845093052735;
        double LngInicial = -58.23879250387637;
        int cont = 1;

        //variables utilizadas para la creacion de poligonos
        List<PointLatLng> listaCirculo = new List<PointLatLng>();
        List<PointLatLng> listaLinea = new List<PointLatLng>();
        GMapOverlay layerCirculo = new GMapOverlay("Capa Circulo");
        GMapOverlay layerLineas = new GMapOverlay("Capa Linea");

        Graphics Grafico;
        Bitmap ImagenBMP;
        Pen Lapiz;
        GMapRoute ruta;
        //Capa para los marcadores creados desde el puerto serie
        //GMapOverlay overlaySerial;

        //Creo el objeto del Form de conexion con el XBee para poder acceder a sus parametros
        Form_Conexion Form_Conexion;
        
        //contador para la descripcion de los datos recibidos por puerto serie
        //int contData = 1;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inicializacion del mapa
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;
            gMapControl1.ShowCenter = true;        //Quita la cruz roja del medio del mapa
            ImagenBMP = new Bitmap(gMapControl1.Width, gMapControl1.Height);
            Grafico = Graphics.FromImage(ImagenBMP);
            Lapiz = new Pen(Color.Blue, 1);
            //Marcador
            markerOverlay = new GMapOverlay("Marcador"); //genera una capa por encima del mapa creado
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue); //crea el marcador
            markerOverlay.Markers.Add(marker);//Añadir al marcador
            marker.Tag = "Ubicacion Inicial";

            //Añadir un Tooltip (texto) al marcador
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver; //el tooltip aparece cuando se le pone el mouse encima
            marker.ToolTipText = "Ubicacion: Ubicacion Inicial \n Latitud: " + LatInicial + "\n Longitud: " + LngInicial;

            //añadir el overlay al mapa principal
            gMapControl1.Overlays.Add(markerOverlay);

            //Añadir el DataTable
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Latitud", typeof(double)));
            dt.Columns.Add(new DataColumn("Longitud", typeof(double)));

            //Agregar la primera fila y exhibir todo en la interfaz
            dt.Rows.Add("Ubicacion Inicial", LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            //hacer invisible en la interfaz la latitud y la longitud
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.ReadOnly = true;
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
            marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);//Añadir al marcador

            //Añado los datos a los textbox
            txtDescripcion.Text = "Ubicacion " + cont;
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();
            cont++;

            //Añade la posicion seleccionada al dt
            dt.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text);

            //Crear el marcador
            marker.Position = new PointLatLng(lat, lng);

            //agregar el tooltip
            marker.ToolTipText = "Ubicacion: " + txtDescripcion.Text + "\n Latitud: " + lat + "\n Longitud: " + lng;

            //Agregarle un Tag al marker
            marker.Tag = txtDescripcion.Text;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion;
            if (txtDescripcion.Text != "")
                descripcion = txtDescripcion.Text;
            else
            { descripcion = "Ubicacion " + cont; cont++; }

            if (txtLatitud.Text == "" || txtLongitud.Text == "")
            {
                txtLatitud.Text = LatInicial.ToString();
                txtLongitud.Text = LngInicial.ToString();
            }
            
            //Agregar los datos al dt
            dt.Rows.Add(descripcion, txtLatitud.Text, txtLongitud.Text);

            //Inicializar el marcador
            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text)), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);//Añadir al marcador

            //Colocar el marcador
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));

            //agregar el tooltip
            marker.ToolTipText = "Ubicacion: " + descripcion + "\n Latitud: " + txtLatitud.Text + "\n Longitud: " + txtLongitud.Text;

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
                dataGridView1.Rows.RemoveAt(fila_seleccionada);
                markerOverlay.Markers.RemoveAt(fila_seleccionada);
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
            for (int x = 0; dataGridView1.Rows[x].Cells[0].Value.ToString() != item.Tag.ToString(); x++) fila = x + 1;

            //Deselecciona todas las filas del dt primero y luego selecciona la fila actual
            for (int i = 0; i != dataGridView1.RowCount; i++) dataGridView1.Rows[i].Selected = false;
            dataGridView1.Rows[fila].Selected = true;

            //Cuando se hace click sobre un marcador se muestran sus datos en los label
            txtDescripcion.Text = item.Tag.ToString();
            txtLatitud.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();
        }

        private void btn_Conexion_Click(object sender, EventArgs e)
        {
            Form_Conexion = new Form_Conexion(this);
            //Abrir el Form de conexion
            Form_Conexion.Show(this);
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            double radio = 1;
            double divisor = 1000;
            int distancia; //es la distancia en metros que se quiere que sea el radio del circulo

            if (txt_dist.Text != "")
            {
                distancia = Convert.ToInt16(txt_dist.Text);
                /*
                 * Haciendo calculos para convertir los valores de coordenadas a distancia en metros la unidad
                 * de radio del circulo es de aproximadamente 89m
                 */
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

            //Agrego un comentario


            //Se crea el poligono Circulo
            GMapPolygon circulo = new GMapPolygon(listaCirculo, "Circulo");
            //Se agrega el circulo a la capa
            layerCirculo.Polygons.Add(circulo);
            //Se agrega la capa al mapa
            gMapControl1.Overlays.Add(layerCirculo);
            //Se actualiza el mapa
            //gMapControl1.Refresh();
            gMapControl1.Zoom++;
            gMapControl1.Zoom--;

            //Se limpia la lista para el proximo circulo
            listaCirculo.Clear();            
        }

        private void btn_cricleBorrar_Click(object sender, EventArgs e)
        {
            layerCirculo.Polygons.Clear();
            layerLineas.Routes.Clear();
        }
       
        //public void reasignarData(double dataLat, double dataLng)
        //{
        //    /*
        //     * Tuve problemas porque al ejecutar esta funcion, al principio tiraba error de
        //     * "referencia a objeto no establecida como instancia de un objeto", con respecto al dataTable.
        //     * Luego el problema pasaba porque la funcion se ejecutaba pero no ocurria nada. 
        //     * Puse un breakpoint y al observar las variables, estas estaban bien asignadas pero no ocurrian
        //     * cambios en el form.
        //     */

        //    //obtener los datos de lat y lng del lugat donde se hizo doble click

        //    //Crear el punto recibido por serial
        //    PointLatLng CoordSerial = new PointLatLng(dataLat,dataLng);

        //    Form_Main formMain = new Form_Main();
        //    //inicializar la capa
        //    //formMain.markerOverlay = new GMapOverlay("MarcadorSerial"); //genera una capa por encima del mapa creado

        //    //inicializar el marcador
        //    formMain.marker = new GMarkerGoogle(CoordSerial, GMarkerGoogleType.red);
        //    formMain.markerOverlay.Markers.Add(formMain.marker);//Añadir al marcador

        //    //Añado los datos a los textbox
        //    formMain.txtDescripcion.Text = "Ubicacion " + formMain.cont;
        //    formMain.txtLatitud.Text = dataLat.ToString();
        //    formMain.txtLongitud.Text = dataLng.ToString();
        //    formMain.cont++;

        //    //Añade la posicion seleccionada al dt
        //    formMain.dt.Rows.Add(formMain.txtDescripcion.Text, formMain.txtLatitud.Text, formMain.txtLongitud.Text);

        //    //Colocar el marcador
        //    formMain.marker.Position = CoordSerial;

        //    //agregar el tooltip
        //    formMain.marker.ToolTipText = "Ubicacion: " + formMain.txtDescripcion.Text + "\n Latitud: " + dataLat + "\n Longitud: " + dataLng;

        //    //Agregarle un Tag al marker
        //    formMain.marker.Tag = formMain.txtDescripcion.Text;

        //    formMain.gMapControl1.Refresh();

        //}

        #region ComunicacionSerie
        public void coordenadasSerie(double dataLat, double dataLng)
        {
            PointLatLng CoordSerie = new PointLatLng(dataLat, dataLng);

            marker = new GMarkerGoogle(CoordSerie, GMarkerGoogleType.red);
            marker.Tag = "Marcador Serie " + cont;
            marker.Position = CoordSerie;

            markerOverlay.Markers.Add(marker);
 
            gMapControl1.Position = marker.Position;
            
            txtDescripcion.Text = "Ubicacion " + cont;
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
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue); //crea el marcador
            markerOverlay.Markers.Add(marker);//Añadir al marcador
            marker.Tag = "Ubicacion Inicial";

            //Añadir un Tooltip (texto) al marcador
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver; //el tooltip aparece cuando se le pone el mouse encima
            marker.ToolTipText = "Ubicacion: Ubicacion Inicial \n Latitud: " + LatInicial + "\n Longitud: " + LngInicial;

            //añadir el overlay al mapa principal
            gMapControl1.Overlays.Add(markerOverlay);
   
        }
        #endregion

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            //PointLatLng coord = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
            string dato = txtLatitud.Text + ";" + txtLongitud.Text;

            Form_Conexion.enviarCoordenadas(dato);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTrazarLinea_Click(object sender, EventArgs e)
        {

            
                //Se crean los puntos variando el angulo y se los agrega a la lista
                
                PointLatLng puntoInicial = new PointLatLng(LatInicial,LngInicial);
                PointLatLng puntoFinal = new PointLatLng(-34.706845093052735, -58.23890350387637);

                
                listaLinea.Add(puntoInicial);
                listaLinea.Add(puntoFinal);

            //Agrego un comentario

                
            //Se crea el poligono Circulo
            GMapRoute linea = new GMapRoute(listaLinea, "Linea");
            linea.Stroke = new Pen(Color.Red, 3);
            
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

        private void gMapControl1_Load(object sender, EventArgs e)
        {
        
        }
    }
}

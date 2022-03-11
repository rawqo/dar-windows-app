namespace Primera_aplicacion
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Conexion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_latitud = new System.Windows.Forms.Label();
            this.label_longitud = new System.Windows.Forms.Label();
            this.label_puntoActual = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarLinea = new System.Windows.Forms.Button();
            this.label_Hacia = new System.Windows.Forms.Label();
            this.comboBox_Hacia = new System.Windows.Forms.ComboBox();
            this.label_Desde = new System.Windows.Forms.Label();
            this.comboBox_Desde = new System.Windows.Forms.ComboBox();
            this.btnTrazarLinea = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_consejo = new System.Windows.Forms.Label();
            this.btn_zoomMas = new System.Windows.Forms.Button();
            this.btn_zoomMenos = new System.Windows.Forms.Button();
            this.btnObtenerUbicacion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Serial_enviarCMD = new System.Windows.Forms.Button();
            this.textBox_enviarCMD = new System.Windows.Forms.TextBox();
            this.textBox_SerialLog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_conectarDron = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_version = new System.Windows.Forms.Label();
            this.btnUbicacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gMapControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(159)))));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(2, 2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(544, 544);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.OnMapDrag += new GMap.NET.MapDrag(this.gMapControl1_OnMapDrag);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            this.gMapControl1.MouseEnter += new System.EventHandler(this.gMapControl1_MouseEnter);
            this.gMapControl1.MouseLeave += new System.EventHandler(this.gMapControl1_MouseLeave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDescripcion.Location = new System.Drawing.Point(3, 61);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(192, 13);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtLatitud
            // 
            this.txtLatitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.txtLatitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLatitud.Enabled = false;
            this.txtLatitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtLatitud.Location = new System.Drawing.Point(3, 101);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.ReadOnly = true;
            this.txtLatitud.Size = new System.Drawing.Size(192, 13);
            this.txtLatitud.TabIndex = 4;
            // 
            // txtLongitud
            // 
            this.txtLongitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.txtLongitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLongitud.Enabled = false;
            this.txtLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtLongitud.Location = new System.Drawing.Point(3, 142);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.ReadOnly = true;
            this.txtLongitud.Size = new System.Drawing.Size(192, 13);
            this.txtLongitud.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Latitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Longitud";
            // 
            // btn_Conexion
            // 
            this.btn_Conexion.Enabled = false;
            this.btn_Conexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btn_Conexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Conexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Conexion.ForeColor = System.Drawing.Color.Salmon;
            this.btn_Conexion.Location = new System.Drawing.Point(304, 11);
            this.btn_Conexion.Name = "btn_Conexion";
            this.btn_Conexion.Size = new System.Drawing.Size(141, 28);
            this.btn_Conexion.TabIndex = 11;
            this.btn_Conexion.Text = "MENU CONEXION";
            this.btn_Conexion.UseVisualStyleBackColor = true;
            this.btn_Conexion.Click += new System.EventHandler(this.btn_Conexion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tabla de Posiciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Size = new System.Drawing.Size(192, 316);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar_registro);
            // 
            // label_latitud
            // 
            this.label_latitud.AutoSize = true;
            this.label_latitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label_latitud.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_latitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label_latitud.Location = new System.Drawing.Point(3, 18);
            this.label_latitud.Name = "label_latitud";
            this.label_latitud.Size = new System.Drawing.Size(188, 17);
            this.label_latitud.TabIndex = 27;
            this.label_latitud.Text = "Latitud: -34.706845093052735";
            // 
            // label_longitud
            // 
            this.label_longitud.AutoSize = true;
            this.label_longitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label_longitud.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_longitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label_longitud.Location = new System.Drawing.Point(3, 33);
            this.label_longitud.Name = "label_longitud";
            this.label_longitud.Size = new System.Drawing.Size(193, 17);
            this.label_longitud.TabIndex = 28;
            this.label_longitud.Text = "Longitud: -58.23879250387637";
            this.label_longitud.Click += new System.EventHandler(this.label_longitud_Click);
            // 
            // label_puntoActual
            // 
            this.label_puntoActual.AutoSize = true;
            this.label_puntoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label_puntoActual.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_puntoActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label_puntoActual.Location = new System.Drawing.Point(3, 4);
            this.label_puntoActual.Name = "label_puntoActual";
            this.label_puntoActual.Size = new System.Drawing.Size(88, 17);
            this.label_puntoActual.TabIndex = 29;
            this.label_puntoActual.Text = "Punto Actual";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnEliminarLinea);
            this.panel2.Controls.Add(this.label_Hacia);
            this.panel2.Controls.Add(this.comboBox_Hacia);
            this.panel2.Controls.Add(this.label_Desde);
            this.panel2.Controls.Add(this.comboBox_Desde);
            this.panel2.Controls.Add(this.btnTrazarLinea);
            this.panel2.Location = new System.Drawing.Point(774, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 154);
            this.panel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "RUTA DE VUELO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarLinea
            // 
            this.btnEliminarLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarLinea.FlatAppearance.BorderSize = 0;
            this.btnEliminarLinea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEliminarLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEliminarLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLinea.ForeColor = System.Drawing.Color.White;
            this.btnEliminarLinea.Location = new System.Drawing.Point(160, 114);
            this.btnEliminarLinea.Name = "btnEliminarLinea";
            this.btnEliminarLinea.Size = new System.Drawing.Size(35, 35);
            this.btnEliminarLinea.TabIndex = 34;
            this.btnEliminarLinea.Text = "X";
            this.btnEliminarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarLinea.UseVisualStyleBackColor = true;
            this.btnEliminarLinea.Click += new System.EventHandler(this.btnEliminarLinea_Click);
            // 
            // label_Hacia
            // 
            this.label_Hacia.AutoSize = true;
            this.label_Hacia.BackColor = System.Drawing.Color.Transparent;
            this.label_Hacia.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Hacia.ForeColor = System.Drawing.Color.White;
            this.label_Hacia.Location = new System.Drawing.Point(3, 69);
            this.label_Hacia.Name = "label_Hacia";
            this.label_Hacia.Size = new System.Drawing.Size(42, 17);
            this.label_Hacia.TabIndex = 33;
            this.label_Hacia.Text = "Hacia";
            // 
            // comboBox_Hacia
            // 
            this.comboBox_Hacia.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Hacia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Hacia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Hacia.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Hacia.FormattingEnabled = true;
            this.comboBox_Hacia.Location = new System.Drawing.Point(6, 87);
            this.comboBox_Hacia.Name = "comboBox_Hacia";
            this.comboBox_Hacia.Size = new System.Drawing.Size(189, 23);
            this.comboBox_Hacia.TabIndex = 32;
            this.comboBox_Hacia.Click += new System.EventHandler(this.comboBox_Hacia_Click);
            // 
            // label_Desde
            // 
            this.label_Desde.AutoSize = true;
            this.label_Desde.BackColor = System.Drawing.Color.Transparent;
            this.label_Desde.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Desde.ForeColor = System.Drawing.Color.White;
            this.label_Desde.Location = new System.Drawing.Point(3, 27);
            this.label_Desde.Name = "label_Desde";
            this.label_Desde.Size = new System.Drawing.Size(46, 17);
            this.label_Desde.TabIndex = 31;
            this.label_Desde.Text = "Desde";
            // 
            // comboBox_Desde
            // 
            this.comboBox_Desde.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Desde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Desde.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Desde.FormattingEnabled = true;
            this.comboBox_Desde.Location = new System.Drawing.Point(6, 45);
            this.comboBox_Desde.Name = "comboBox_Desde";
            this.comboBox_Desde.Size = new System.Drawing.Size(189, 23);
            this.comboBox_Desde.TabIndex = 25;
            this.comboBox_Desde.Click += new System.EventHandler(this.comboBox_Desde_Click);
            // 
            // btnTrazarLinea
            // 
            this.btnTrazarLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrazarLinea.FlatAppearance.BorderSize = 0;
            this.btnTrazarLinea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnTrazarLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTrazarLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazarLinea.ForeColor = System.Drawing.Color.White;
            this.btnTrazarLinea.Location = new System.Drawing.Point(6, 114);
            this.btnTrazarLinea.Name = "btnTrazarLinea";
            this.btnTrazarLinea.Size = new System.Drawing.Size(151, 35);
            this.btnTrazarLinea.TabIndex = 24;
            this.btnTrazarLinea.Text = "TRAZAR RUTA";
            this.btnTrazarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrazarLinea.UseVisualStyleBackColor = true;
            this.btnTrazarLinea.Click += new System.EventHandler(this.btnTrazarLinea_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.txtLatitud);
            this.panel3.Controls.Add(this.txtLongitud);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Location = new System.Drawing.Point(568, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 550);
            this.panel3.TabIndex = 31;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "INFORMACION DEL MARCADOR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(3, 513);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 22);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "NUEVO MARCADOR";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(169, 513);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(22, 22);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "X";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(67, 10);
            this.label_status.Name = "label_status";
            this.label_status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_status.Size = new System.Drawing.Size(101, 18);
            this.label_status.TabIndex = 40;
            this.label_status.Text = "Desconectado";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_ports.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.comboBox_ports.Location = new System.Drawing.Point(738, 23);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(59, 23);
            this.comboBox_ports.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(735, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Puerto:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label_consejo);
            this.panel4.Controls.Add(this.label_latitud);
            this.panel4.Controls.Add(this.btn_zoomMas);
            this.panel4.Controls.Add(this.btn_zoomMenos);
            this.panel4.Controls.Add(this.label_longitud);
            this.panel4.Controls.Add(this.label_puntoActual);
            this.panel4.Controls.Add(this.btnObtenerUbicacion);
            this.panel4.Controls.Add(this.gMapControl1);
            this.panel4.Location = new System.Drawing.Point(12, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 550);
            this.panel4.TabIndex = 39;
            // 
            // label_consejo
            // 
            this.label_consejo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_consejo.AutoSize = true;
            this.label_consejo.BackColor = System.Drawing.Color.Transparent;
            this.label_consejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_consejo.ForeColor = System.Drawing.Color.White;
            this.label_consejo.Location = new System.Drawing.Point(3, 530);
            this.label_consejo.Name = "label_consejo";
            this.label_consejo.Size = new System.Drawing.Size(421, 15);
            this.label_consejo.TabIndex = 47;
            this.label_consejo.Text = "Coloque el cursor sobre los items en pantalla para obtener mas informacion";
            // 
            // btn_zoomMas
            // 
            this.btn_zoomMas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zoomMas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_zoomMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_zoomMas.BackgroundImage = global::Primera_aplicacion.Properties.Resources.LOGO_V2_ZOOM_MAS;
            this.btn_zoomMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_zoomMas.FlatAppearance.BorderSize = 0;
            this.btn_zoomMas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_zoomMas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_zoomMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zoomMas.ForeColor = System.Drawing.Color.Salmon;
            this.btn_zoomMas.Location = new System.Drawing.Point(507, 473);
            this.btn_zoomMas.Name = "btn_zoomMas";
            this.btn_zoomMas.Size = new System.Drawing.Size(35, 35);
            this.btn_zoomMas.TabIndex = 25;
            this.btn_zoomMas.UseVisualStyleBackColor = false;
            this.btn_zoomMas.Click += new System.EventHandler(this.btn_zoomMas_Click);
            // 
            // btn_zoomMenos
            // 
            this.btn_zoomMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zoomMenos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_zoomMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_zoomMenos.BackgroundImage = global::Primera_aplicacion.Properties.Resources.LOGO_V2_ZOOM_MENOS;
            this.btn_zoomMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_zoomMenos.FlatAppearance.BorderSize = 0;
            this.btn_zoomMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_zoomMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_zoomMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zoomMenos.ForeColor = System.Drawing.Color.Salmon;
            this.btn_zoomMenos.Location = new System.Drawing.Point(507, 509);
            this.btn_zoomMenos.Name = "btn_zoomMenos";
            this.btn_zoomMenos.Size = new System.Drawing.Size(35, 35);
            this.btn_zoomMenos.TabIndex = 26;
            this.btn_zoomMenos.UseVisualStyleBackColor = false;
            this.btn_zoomMenos.Click += new System.EventHandler(this.btn_zoomMenos_Click);
            // 
            // btnObtenerUbicacion
            // 
            this.btnObtenerUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObtenerUbicacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObtenerUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnObtenerUbicacion.BackgroundImage = global::Primera_aplicacion.Properties.Resources.LOGO_V2_OBTENER_UBICACION;
            this.btnObtenerUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObtenerUbicacion.FlatAppearance.BorderSize = 0;
            this.btnObtenerUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnObtenerUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnObtenerUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtenerUbicacion.ForeColor = System.Drawing.Color.Salmon;
            this.btnObtenerUbicacion.Location = new System.Drawing.Point(466, 509);
            this.btnObtenerUbicacion.Name = "btnObtenerUbicacion";
            this.btnObtenerUbicacion.Size = new System.Drawing.Size(35, 35);
            this.btnObtenerUbicacion.TabIndex = 30;
            this.btnObtenerUbicacion.UseVisualStyleBackColor = false;
            this.btnObtenerUbicacion.Click += new System.EventHandler(this.btnObtenerUbicacion_Click);
            this.btnObtenerUbicacion.MouseEnter += new System.EventHandler(this.btnObtenerUbicacion_MouseEnter);
            this.btnObtenerUbicacion.MouseLeave += new System.EventHandler(this.btnObtenerUbicacion_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Serial_enviarCMD);
            this.panel1.Controls.Add(this.textBox_enviarCMD);
            this.panel1.Controls.Add(this.textBox_SerialLog);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(774, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 390);
            this.panel1.TabIndex = 45;
            // 
            // Serial_enviarCMD
            // 
            this.Serial_enviarCMD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Serial_enviarCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Serial_enviarCMD.Location = new System.Drawing.Point(173, 353);
            this.Serial_enviarCMD.Name = "Serial_enviarCMD";
            this.Serial_enviarCMD.Size = new System.Drawing.Size(22, 22);
            this.Serial_enviarCMD.TabIndex = 50;
            this.Serial_enviarCMD.UseVisualStyleBackColor = true;
            this.Serial_enviarCMD.Click += new System.EventHandler(this.Serial_enviarCMD_Click);
            // 
            // textBox_enviarCMD
            // 
            this.textBox_enviarCMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.textBox_enviarCMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_enviarCMD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.textBox_enviarCMD.Location = new System.Drawing.Point(3, 353);
            this.textBox_enviarCMD.Name = "textBox_enviarCMD";
            this.textBox_enviarCMD.Size = new System.Drawing.Size(164, 20);
            this.textBox_enviarCMD.TabIndex = 49;
            // 
            // textBox_SerialLog
            // 
            this.textBox_SerialLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.textBox_SerialLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SerialLog.ForeColor = System.Drawing.Color.White;
            this.textBox_SerialLog.Location = new System.Drawing.Point(3, 32);
            this.textBox_SerialLog.Multiline = true;
            this.textBox_SerialLog.Name = "textBox_SerialLog";
            this.textBox_SerialLog.ReadOnly = true;
            this.textBox_SerialLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SerialLog.Size = new System.Drawing.Size(192, 316);
            this.textBox_SerialLog.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "MONITOR SERIE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Primera_aplicacion.Properties.Resources.LOGO_DRONE_FINAL_CON_FONDO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btn_conectarDron
            // 
            this.btn_conectarDron.BackColor = System.Drawing.Color.Transparent;
            this.btn_conectarDron.BackgroundImage = global::Primera_aplicacion.Properties.Resources.LOGO_V2_USB_CONECTAR;
            this.btn_conectarDron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_conectarDron.FlatAppearance.BorderSize = 0;
            this.btn_conectarDron.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btn_conectarDron.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_conectarDron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectarDron.ForeColor = System.Drawing.Color.Salmon;
            this.btn_conectarDron.Location = new System.Drawing.Point(814, 5);
            this.btn_conectarDron.Name = "btn_conectarDron";
            this.btn_conectarDron.Size = new System.Drawing.Size(160, 40);
            this.btn_conectarDron.TabIndex = 42;
            this.btn_conectarDron.UseVisualStyleBackColor = false;
            this.btn_conectarDron.Click += new System.EventHandler(this.btn_conectarDron_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.BackColor = System.Drawing.Color.Transparent;
            this.label_version.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.ForeColor = System.Drawing.Color.LightGray;
            this.label_version.Location = new System.Drawing.Point(67, 28);
            this.label_version.Name = "label_version";
            this.label_version.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_version.Size = new System.Drawing.Size(117, 18);
            this.label_version.TabIndex = 40;
            this.label_version.Text = "Version 2021.8.26";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.Location = new System.Drawing.Point(826, 607);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(148, 32);
            this.btnUbicacion.TabIndex = 23;
            this.btnUbicacion.Text = "Enviar Ubicacion";
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_ports);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_conectarDron);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Conexion);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAR - Drone Autonomo de Rescate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Conexion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTrazarLinea;
        private System.Windows.Forms.Button btn_zoomMas;
        private System.Windows.Forms.Button btn_zoomMenos;
        private System.Windows.Forms.Label label_latitud;
        private System.Windows.Forms.Label label_longitud;
        private System.Windows.Forms.Label label_puntoActual;
        private System.Windows.Forms.Button btnObtenerUbicacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Hacia;
        private System.Windows.Forms.ComboBox comboBox_Hacia;
        private System.Windows.Forms.Label label_Desde;
        private System.Windows.Forms.ComboBox comboBox_Desde;
        private System.Windows.Forms.Button btnEliminarLinea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button btn_conectarDron;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_SerialLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_enviarCMD;
        private System.Windows.Forms.Button Serial_enviarCMD;
        private System.Windows.Forms.Label label_consejo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Button btnUbicacion;
    }
}


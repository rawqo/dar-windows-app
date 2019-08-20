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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Conexion = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.lbl_radio = new System.Windows.Forms.Label();
            this.btn_cricleBorrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_corto = new System.Windows.Forms.CheckBox();
            this.cbx_medio = new System.Windows.Forms.CheckBox();
            this.cbx_largo = new System.Windows.Forms.CheckBox();
            this.txt_radio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_dist = new System.Windows.Forms.TextBox();
            this.lbl_dist = new System.Windows.Forms.Label();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnTrazarLinea = new System.Windows.Forms.Button();
            this.btn_zoomMas = new System.Windows.Forms.Button();
            this.btn_zoomMenos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
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
            this.gMapControl1.Size = new System.Drawing.Size(426, 381);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(444, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(526, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(445, 56);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(157, 20);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtLatitud
            // 
            this.txtLatitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatitud.Location = new System.Drawing.Point(445, 95);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(157, 20);
            this.txtLatitud.TabIndex = 4;
            // 
            // txtLongitud
            // 
            this.txtLongitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLongitud.Location = new System.Drawing.Point(445, 138);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(157, 20);
            this.txtLongitud.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(445, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripcion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(445, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Latitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(446, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Longitud";
            // 
            // btn_Conexion
            // 
            this.btn_Conexion.Location = new System.Drawing.Point(445, 9);
            this.btn_Conexion.Name = "btn_Conexion";
            this.btn_Conexion.Size = new System.Drawing.Size(156, 28);
            this.btn_Conexion.TabIndex = 11;
            this.btn_Conexion.Text = "MENU CONEXION";
            this.btn_Conexion.UseVisualStyleBackColor = true;
            this.btn_Conexion.Click += new System.EventHandler(this.btn_Conexion_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(631, 197);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(97, 34);
            this.btn_circle.TabIndex = 13;
            this.btn_circle.Text = "Crear Circulo";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // lbl_radio
            // 
            this.lbl_radio.AutoSize = true;
            this.lbl_radio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_radio.Location = new System.Drawing.Point(628, 56);
            this.lbl_radio.Name = "lbl_radio";
            this.lbl_radio.Size = new System.Drawing.Size(38, 13);
            this.lbl_radio.TabIndex = 15;
            this.lbl_radio.Text = "Radio:";
            // 
            // btn_cricleBorrar
            // 
            this.btn_cricleBorrar.Location = new System.Drawing.Point(638, 237);
            this.btn_cricleBorrar.Name = "btn_cricleBorrar";
            this.btn_cricleBorrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cricleBorrar.TabIndex = 16;
            this.btn_cricleBorrar.Text = "Borrar";
            this.btn_cricleBorrar.UseVisualStyleBackColor = true;
            this.btn_cricleBorrar.Click += new System.EventHandler(this.btn_cricleBorrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbx_corto);
            this.panel1.Controls.Add(this.cbx_medio);
            this.panel1.Controls.Add(this.cbx_largo);
            this.panel1.Location = new System.Drawing.Point(632, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 70);
            this.panel1.TabIndex = 17;
            // 
            // cbx_corto
            // 
            this.cbx_corto.AutoSize = true;
            this.cbx_corto.Location = new System.Drawing.Point(6, 49);
            this.cbx_corto.Name = "cbx_corto";
            this.cbx_corto.Size = new System.Drawing.Size(50, 17);
            this.cbx_corto.TabIndex = 2;
            this.cbx_corto.Tag = "radio";
            this.cbx_corto.Text = "corto";
            this.cbx_corto.UseVisualStyleBackColor = true;
            // 
            // cbx_medio
            // 
            this.cbx_medio.AutoSize = true;
            this.cbx_medio.Location = new System.Drawing.Point(6, 26);
            this.cbx_medio.Name = "cbx_medio";
            this.cbx_medio.Size = new System.Drawing.Size(54, 17);
            this.cbx_medio.TabIndex = 1;
            this.cbx_medio.Tag = "radio";
            this.cbx_medio.Text = "medio";
            this.cbx_medio.UseVisualStyleBackColor = true;
            // 
            // cbx_largo
            // 
            this.cbx_largo.AutoSize = true;
            this.cbx_largo.Location = new System.Drawing.Point(6, 3);
            this.cbx_largo.Name = "cbx_largo";
            this.cbx_largo.Size = new System.Drawing.Size(49, 17);
            this.cbx_largo.TabIndex = 0;
            this.cbx_largo.Tag = "radio";
            this.cbx_largo.Text = "largo";
            this.cbx_largo.UseVisualStyleBackColor = true;
            // 
            // txt_radio
            // 
            this.txt_radio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_radio.Location = new System.Drawing.Point(632, 72);
            this.txt_radio.Name = "txt_radio";
            this.txt_radio.Size = new System.Drawing.Size(96, 20);
            this.txt_radio.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(445, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tabla de Posiciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(153, 180);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar_registro);
            // 
            // txt_dist
            // 
            this.txt_dist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dist.Location = new System.Drawing.Point(631, 33);
            this.txt_dist.Name = "txt_dist";
            this.txt_dist.Size = new System.Drawing.Size(96, 20);
            this.txt_dist.TabIndex = 22;
            // 
            // lbl_dist
            // 
            this.lbl_dist.AutoSize = true;
            this.lbl_dist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dist.Location = new System.Drawing.Point(628, 17);
            this.lbl_dist.Name = "lbl_dist";
            this.lbl_dist.Size = new System.Drawing.Size(77, 13);
            this.lbl_dist.TabIndex = 21;
            this.lbl_dist.Text = "Dist en metros:";
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Location = new System.Drawing.Point(367, 357);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(71, 36);
            this.btnUbicacion.TabIndex = 23;
            this.btnUbicacion.Text = "Enviar Ubicacion";
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnTrazarLinea
            // 
            this.btnTrazarLinea.Location = new System.Drawing.Point(631, 170);
            this.btnTrazarLinea.Name = "btnTrazarLinea";
            this.btnTrazarLinea.Size = new System.Drawing.Size(97, 23);
            this.btnTrazarLinea.TabIndex = 24;
            this.btnTrazarLinea.Text = "Trazar Linea";
            this.btnTrazarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrazarLinea.UseVisualStyleBackColor = true;
            this.btnTrazarLinea.Click += new System.EventHandler(this.btnTrazarLinea_Click);
            // 
            // btn_zoomMas
            // 
            this.btn_zoomMas.BackgroundImage = global::Primera_aplicacion.Properties.Resources.boton_mas;
            this.btn_zoomMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_zoomMas.Location = new System.Drawing.Point(404, 324);
            this.btn_zoomMas.Name = "btn_zoomMas";
            this.btn_zoomMas.Size = new System.Drawing.Size(30, 30);
            this.btn_zoomMas.TabIndex = 25;
            this.btn_zoomMas.UseVisualStyleBackColor = true;
            this.btn_zoomMas.Click += new System.EventHandler(this.btn_zoomMas_Click);
            // 
            // btn_zoomMenos
            // 
            this.btn_zoomMenos.BackgroundImage = global::Primera_aplicacion.Properties.Resources.boton_menos;
            this.btn_zoomMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_zoomMenos.Location = new System.Drawing.Point(371, 324);
            this.btn_zoomMenos.Name = "btn_zoomMenos";
            this.btn_zoomMenos.Size = new System.Drawing.Size(30, 30);
            this.btn_zoomMenos.TabIndex = 26;
            this.btn_zoomMenos.UseVisualStyleBackColor = true;
            this.btn_zoomMenos.Click += new System.EventHandler(this.btn_zoomMenos_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Primera_aplicacion.Properties.Resources.fondo_DRS_v2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 405);
            this.Controls.Add(this.btn_zoomMenos);
            this.Controls.Add(this.btn_zoomMas);
            this.Controls.Add(this.btnTrazarLinea);
            this.Controls.Add(this.btnUbicacion);
            this.Controls.Add(this.txt_dist);
            this.Controls.Add(this.lbl_dist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_radio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cricleBorrar);
            this.Controls.Add(this.lbl_radio);
            this.Controls.Add(this.btn_circle);
            this.Controls.Add(this.btn_Conexion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gMapControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Maps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Label lbl_radio;
        private System.Windows.Forms.Button btn_cricleBorrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbx_corto;
        private System.Windows.Forms.CheckBox cbx_medio;
        private System.Windows.Forms.CheckBox cbx_largo;
        private System.Windows.Forms.TextBox txt_radio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_dist;
        private System.Windows.Forms.Label lbl_dist;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnTrazarLinea;
        private System.Windows.Forms.Button btn_zoomMas;
        private System.Windows.Forms.Button btn_zoomMenos;
    }
}


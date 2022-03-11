namespace Primera_aplicacion
{
    partial class Form_Conexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Conexion));
            this.lbl_Conectar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_Enviar_Lat = new System.Windows.Forms.TextBox();
            this.lbl_Enviar = new System.Windows.Forms.Label();
            this.lbl_Recibir = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Enviar_Long = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Recibir_Long = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Recibir_Lat = new System.Windows.Forms.TextBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Conectar
            // 
            this.lbl_Conectar.AutoSize = true;
            this.lbl_Conectar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Conectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Conectar.Location = new System.Drawing.Point(96, 24);
            this.lbl_Conectar.Name = "lbl_Conectar";
            this.lbl_Conectar.Size = new System.Drawing.Size(136, 13);
            this.lbl_Conectar.TabIndex = 2;
            this.lbl_Conectar.Text = "Estado: Desconectado";
            this.lbl_Conectar.Click += new System.EventHandler(this.lbl_Conectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            "COM12"});
            this.comboBox1.Location = new System.Drawing.Point(159, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_Enviar_Lat
            // 
            this.txt_Enviar_Lat.Location = new System.Drawing.Point(72, 30);
            this.txt_Enviar_Lat.Name = "txt_Enviar_Lat";
            this.txt_Enviar_Lat.Size = new System.Drawing.Size(129, 20);
            this.txt_Enviar_Lat.TabIndex = 5;
            // 
            // lbl_Enviar
            // 
            this.lbl_Enviar.AutoSize = true;
            this.lbl_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Enviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Enviar.Location = new System.Drawing.Point(3, 3);
            this.lbl_Enviar.Name = "lbl_Enviar";
            this.lbl_Enviar.Size = new System.Drawing.Size(180, 15);
            this.lbl_Enviar.TabIndex = 7;
            this.lbl_Enviar.Text = "COORDENADAS ENVIADAS";
            // 
            // lbl_Recibir
            // 
            this.lbl_Recibir.AutoSize = true;
            this.lbl_Recibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recibir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Recibir.Location = new System.Drawing.Point(3, 3);
            this.lbl_Recibir.Name = "lbl_Recibir";
            this.lbl_Recibir.Size = new System.Drawing.Size(186, 15);
            this.lbl_Recibir.TabIndex = 8;
            this.lbl_Recibir.Text = "COORDENADAS RECIBIDAS";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Latitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Longitud";
            // 
            // txt_Enviar_Long
            // 
            this.txt_Enviar_Long.Location = new System.Drawing.Point(72, 56);
            this.txt_Enviar_Long.Name = "txt_Enviar_Long";
            this.txt_Enviar_Long.Size = new System.Drawing.Size(129, 20);
            this.txt_Enviar_Long.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Longitud";
            // 
            // txt_Recibir_Long
            // 
            this.txt_Recibir_Long.Location = new System.Drawing.Point(73, 56);
            this.txt_Recibir_Long.Name = "txt_Recibir_Long";
            this.txt_Recibir_Long.Size = new System.Drawing.Size(128, 20);
            this.txt_Recibir_Long.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(26, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Latitud";
            // 
            // txt_Recibir_Lat
            // 
            this.txt_Recibir_Lat.Location = new System.Drawing.Point(73, 30);
            this.txt_Recibir_Lat.Name = "txt_Recibir_Lat";
            this.txt_Recibir_Lat.Size = new System.Drawing.Size(128, 20);
            this.txt_Recibir_Lat.TabIndex = 16;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Enviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Enviar.Location = new System.Drawing.Point(12, 54);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(110, 37);
            this.btn_Enviar.TabIndex = 1;
            this.btn_Enviar.Text = "Enviar Coordenadas";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Conectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Conectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Conectar.Location = new System.Drawing.Point(12, 12);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(78, 36);
            this.btn_Conectar.TabIndex = 0;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(123, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Puerto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Enviar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Enviar_Lat);
            this.panel1.Controls.Add(this.txt_Enviar_Long);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 85);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_Recibir);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Recibir_Long);
            this.panel2.Controls.Add(this.txt_Recibir_Lat);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 85);
            this.panel2.TabIndex = 19;
            // 
            // Form_Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(234, 302);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_Conectar);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Conexion";
            this.Text = "Conectar";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Conexion_FormClosing);
            this.Load += new System.EventHandler(this.Form_Conexion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Label lbl_Conectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_Enviar_Lat;
        private System.Windows.Forms.Label lbl_Enviar;
        private System.Windows.Forms.Label lbl_Recibir;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Enviar_Long;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Recibir_Long;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Recibir_Lat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
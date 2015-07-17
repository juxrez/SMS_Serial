namespace sms_serial
{
    partial class frmSerialCom
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRecibir = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnConectar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimparRecibido = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.rbEnviar = new System.Windows.Forms.RadioButton();
            this.rbRecibir = new System.Windows.Forms.RadioButton();
            this.fpsNumeros = new FarPoint.Win.Spread.FpSpread();
            this.fpsNumeros_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumeros_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(138, 127);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(90, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtRecibir
            // 
            this.txtRecibir.Location = new System.Drawing.Point(0, 19);
            this.txtRecibir.Multiline = true;
            this.txtRecibir.Name = "txtRecibir";
            this.txtRecibir.ReadOnly = true;
            this.txtRecibir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecibir.Size = new System.Drawing.Size(368, 79);
            this.txtRecibir.TabIndex = 1;
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(6, 40);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(147, 21);
            this.cmbPuertos.TabIndex = 2;
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(0, 65);
            this.txtEnviar.Multiline = true;
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEnviar.Size = new System.Drawing.Size(368, 56);
            this.txtEnviar.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.cmbPuertos);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración Puerto Serial";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(257, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(23, 24);
            this.progressBar1.TabIndex = 12;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(159, 36);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(83, 25);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.txtEnviar);
            this.groupBox2.Controls.Add(this.btnEnviar);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(31, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 156);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enviar Mensaje";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(239, 33);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar DB";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(60, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(139, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(7, 39);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Numero:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Predefinir";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimparRecibido);
            this.groupBox3.Controls.Add(this.txtRecibir);
            this.groupBox3.Location = new System.Drawing.Point(31, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 138);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Entrantes";
            // 
            // btnLimparRecibido
            // 
            this.btnLimparRecibido.Location = new System.Drawing.Point(138, 104);
            this.btnLimparRecibido.Name = "btnLimparRecibido";
            this.btnLimparRecibido.Size = new System.Drawing.Size(90, 25);
            this.btnLimparRecibido.TabIndex = 13;
            this.btnLimparRecibido.Text = "Limpiar";
            this.btnLimparRecibido.UseVisualStyleBackColor = true;
            this.btnLimparRecibido.Click += new System.EventHandler(this.btnLimparRecibido_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSaldo);
            this.groupBox4.Controls.Add(this.rbEnviar);
            this.groupBox4.Controls.Add(this.rbRecibir);
            this.groupBox4.Location = new System.Drawing.Point(31, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 78);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modo";
            // 
            // btnSaldo
            // 
            this.btnSaldo.Enabled = false;
            this.btnSaldo.Location = new System.Drawing.Point(138, 49);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(90, 23);
            this.btnSaldo.TabIndex = 6;
            this.btnSaldo.Text = "Consultar Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // rbEnviar
            // 
            this.rbEnviar.AutoSize = true;
            this.rbEnviar.Enabled = false;
            this.rbEnviar.Location = new System.Drawing.Point(23, 19);
            this.rbEnviar.Name = "rbEnviar";
            this.rbEnviar.Size = new System.Drawing.Size(81, 17);
            this.rbEnviar.TabIndex = 0;
            this.rbEnviar.TabStop = true;
            this.rbEnviar.Text = "Enviar SMS";
            this.rbEnviar.UseVisualStyleBackColor = true;
            this.rbEnviar.CheckedChanged += new System.EventHandler(this.rbEnviar_CheckedChanged);
            // 
            // rbRecibir
            // 
            this.rbRecibir.AutoSize = true;
            this.rbRecibir.Enabled = false;
            this.rbRecibir.Location = new System.Drawing.Point(245, 19);
            this.rbRecibir.Name = "rbRecibir";
            this.rbRecibir.Size = new System.Drawing.Size(84, 17);
            this.rbRecibir.TabIndex = 1;
            this.rbRecibir.TabStop = true;
            this.rbRecibir.Text = "Recibir SMS";
            this.rbRecibir.UseVisualStyleBackColor = true;
            this.rbRecibir.CheckedChanged += new System.EventHandler(this.rbRecibir_CheckedChanged);
            // 
            // fpsNumeros
            // 
            this.fpsNumeros.AccessibleDescription = "";
            this.fpsNumeros.Location = new System.Drawing.Point(417, 12);
            this.fpsNumeros.Name = "fpsNumeros";
            this.fpsNumeros.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpsNumeros_Sheet1});
            this.fpsNumeros.Size = new System.Drawing.Size(376, 464);
            this.fpsNumeros.TabIndex = 12;
            // 
            // fpsNumeros_Sheet1
            // 
            this.fpsNumeros_Sheet1.Reset();
            this.fpsNumeros_Sheet1.SheetName = "Sheet1";
            // 
            // frmSerialCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 500);
            this.Controls.Add(this.fpsNumeros);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSerialCom";
            this.Text = "Sim900 COM";
            this.Load += new System.EventHandler(this.frmSerialCom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumeros_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtRecibir;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbEnviar;
        private System.Windows.Forms.RadioButton rbRecibir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnLimparRecibido;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnActualizar;
        private FarPoint.Win.Spread.FpSpread fpsNumeros;
        private FarPoint.Win.Spread.SheetView fpsNumeros_Sheet1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


namespace Proyecto_final___Fundamentos_de_programación
{
    partial class PagoTarjeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbpropina20 = new System.Windows.Forms.CheckBox();
            this.cbpropina15 = new System.Windows.Forms.CheckBox();
            this.cbpropina10 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputNIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagar con tarjeta";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cbpropina20);
            this.panel1.Controls.Add(this.cbpropina15);
            this.panel1.Controls.Add(this.cbpropina10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.inputNIP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputNumeroTarjeta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(27, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 287);
            this.panel1.TabIndex = 1;
            // 
            // cbpropina20
            // 
            this.cbpropina20.AutoSize = true;
            this.cbpropina20.Location = new System.Drawing.Point(11, 211);
            this.cbpropina20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbpropina20.Name = "cbpropina20";
            this.cbpropina20.Size = new System.Drawing.Size(127, 17);
            this.cbpropina20.TabIndex = 9;
            this.cbpropina20.Text = "Dejar 20% de propina";
            this.cbpropina20.UseVisualStyleBackColor = true;
            this.cbpropina20.CheckedChanged += new System.EventHandler(this.cbpropina20_CheckedChanged);
            // 
            // cbpropina15
            // 
            this.cbpropina15.AutoSize = true;
            this.cbpropina15.Location = new System.Drawing.Point(11, 189);
            this.cbpropina15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbpropina15.Name = "cbpropina15";
            this.cbpropina15.Size = new System.Drawing.Size(127, 17);
            this.cbpropina15.TabIndex = 8;
            this.cbpropina15.Text = "Dejar 15% de propina";
            this.cbpropina15.UseVisualStyleBackColor = true;
            this.cbpropina15.CheckedChanged += new System.EventHandler(this.cbpropina15_CheckedChanged);
            // 
            // cbpropina10
            // 
            this.cbpropina10.AutoSize = true;
            this.cbpropina10.Location = new System.Drawing.Point(11, 167);
            this.cbpropina10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbpropina10.Name = "cbpropina10";
            this.cbpropina10.Size = new System.Drawing.Size(127, 17);
            this.cbpropina10.TabIndex = 7;
            this.cbpropina10.Text = "Dejar 10% de propina";
            this.cbpropina10.UseVisualStyleBackColor = true;
            this.cbpropina10.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("DM Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 248);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputNIP
            // 
            this.inputNIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNIP.Font = new System.Drawing.Font("DM Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNIP.Location = new System.Drawing.Point(11, 122);
            this.inputNIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNIP.Name = "inputNIP";
            this.inputNIP.Size = new System.Drawing.Size(76, 25);
            this.inputNIP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresa el NIP:";
            // 
            // inputNumeroTarjeta
            // 
            this.inputNumeroTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNumeroTarjeta.Font = new System.Drawing.Font("DM Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumeroTarjeta.Location = new System.Drawing.Point(11, 59);
            this.inputNumeroTarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNumeroTarjeta.Name = "inputNumeroTarjeta";
            this.inputNumeroTarjeta.Size = new System.Drawing.Size(187, 25);
            this.inputNumeroTarjeta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa el número de tarjeta:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(94, 13);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Crédito";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 13);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Débito";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_final___Fundamentos_de_programación.Properties.Resources.tarjetas;
            this.pictureBox1.Location = new System.Drawing.Point(360, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DM Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PagoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PagoTarjeta";
            this.Text = "Pago con tarjeta";
            this.Load += new System.EventHandler(this.PagoTarjeta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputNIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNumeroTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox cbpropina20;
        private System.Windows.Forms.CheckBox cbpropina15;
        private System.Windows.Forms.CheckBox cbpropina10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}
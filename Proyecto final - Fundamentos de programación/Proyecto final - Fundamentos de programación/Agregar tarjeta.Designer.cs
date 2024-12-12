namespace Proyecto_final___Fundamentos_de_programación
{
    partial class Agregar_tarjeta
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputNIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputFondos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("DM Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputNIP
            // 
            this.inputNIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNIP.Font = new System.Drawing.Font("DM Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNIP.Location = new System.Drawing.Point(34, 262);
            this.inputNIP.Name = "inputNIP";
            this.inputNIP.Size = new System.Drawing.Size(100, 30);
            this.inputNIP.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ingresa el NIP:";
            // 
            // inputNumeroTarjeta
            // 
            this.inputNumeroTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNumeroTarjeta.Font = new System.Drawing.Font("DM Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNumeroTarjeta.Location = new System.Drawing.Point(34, 189);
            this.inputNumeroTarjeta.Name = "inputNumeroTarjeta";
            this.inputNumeroTarjeta.Size = new System.Drawing.Size(249, 30);
            this.inputNumeroTarjeta.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingresa el número de tarjeta:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(145, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 20);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Crédito";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 20);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Débito";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Agregar tarjeta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Selecciona el tipo de tarjeta:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_final___Fundamentos_de_programación.Properties.Resources.tarjetas;
            this.pictureBox1.Location = new System.Drawing.Point(454, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("CocogooseProTrial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(592, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 61);
            this.label5.TabIndex = 22;
            this.label5.Text = "+";
            // 
            // inputFondos
            // 
            this.inputFondos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFondos.Font = new System.Drawing.Font("DM Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFondos.Location = new System.Drawing.Point(34, 335);
            this.inputFondos.Name = "inputFondos";
            this.inputFondos.Size = new System.Drawing.Size(100, 30);
            this.inputFondos.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ingresa los fondos:";
            // 
            // Agregar_tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputFondos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputNIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNumeroTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Agregar_tarjeta";
            this.Text = "Agregar tarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputNIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNumeroTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputFondos;
        private System.Windows.Forms.Label label6;
    }
}
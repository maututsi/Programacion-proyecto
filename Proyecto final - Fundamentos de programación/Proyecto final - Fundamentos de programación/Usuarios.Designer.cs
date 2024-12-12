namespace Proyecto_final___Fundamentos_de_programación
{
    partial class Usuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.Label();
            this.Employed = new System.Windows.Forms.RadioButton();
            this.Manager = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txt_contraseña);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.Employed);
            this.panel1.Controls.Add(this.Manager);
            this.panel1.Location = new System.Drawing.Point(22, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 276);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(114, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_clave
            // 
            this.txt_clave.AutoSize = true;
            this.txt_clave.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.Location = new System.Drawing.Point(16, 99);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(55, 21);
            this.txt_clave.TabIndex = 8;
            this.txt_clave.Text = "Clave:";
            this.txt_clave.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(115, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(114, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AutoSize = true;
            this.txt_contraseña.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(16, 146);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(99, 21);
            this.txt_contraseña.TabIndex = 4;
            this.txt_contraseña.Text = "Contraseña:";
            // 
            // txt_user
            // 
            this.txt_user.AutoSize = true;
            this.txt_user.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(16, 47);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(83, 21);
            this.txt_user.TabIndex = 3;
            this.txt_user.Text = "N.Usuario:";
            this.txt_user.Click += new System.EventHandler(this.txt_user_Click);
            // 
            // Employed
            // 
            this.Employed.AutoSize = true;
            this.Employed.Location = new System.Drawing.Point(134, 194);
            this.Employed.Name = "Employed";
            this.Employed.Size = new System.Drawing.Size(72, 17);
            this.Employed.TabIndex = 2;
            this.Employed.TabStop = true;
            this.Employed.Text = "Empleado";
            this.Employed.UseVisualStyleBackColor = true;
            this.Employed.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Manager
            // 
            this.Manager.AutoSize = true;
            this.Manager.Location = new System.Drawing.Point(24, 194);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(88, 17);
            this.Manager.TabIndex = 1;
            this.Manager.TabStop = true;
            this.Manager.Text = "Administrador";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(459, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(309, 284);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_final___Fundamentos_de_programación.Properties.Resources.personitas;
            this.pictureBox1.Location = new System.Drawing.Point(266, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Agregar usuario";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Employed;
        private System.Windows.Forms.RadioButton Manager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_contraseña;
        private System.Windows.Forms.Label txt_user;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txt_clave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}
namespace SanurGenNHibernate
{
    partial class AltaModiUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.ComboBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.alta = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.especialidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo:";
            // 
            // Tipo
            // 
            this.Tipo.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo.FormattingEnabled = true;
            this.Tipo.Items.AddRange(new object[] {
            "Administrativo",
            "Administrador",
            "Medico"});
            this.Tipo.Location = new System.Drawing.Point(204, 27);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(121, 21);
            this.Tipo.TabIndex = 5;
            this.Tipo.SelectedValueChanged += new System.EventHandler(this.Tipo_SelectedValueChanged);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(204, 53);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(121, 20);
            this.nombre.TabIndex = 6;
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(204, 81);
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '*';
            this.contrasena.Size = new System.Drawing.Size(121, 20);
            this.contrasena.TabIndex = 7;
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(204, 109);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(121, 20);
            this.apellidos.TabIndex = 8;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(204, 137);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(121, 20);
            this.email.TabIndex = 9;
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(83, 225);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(75, 23);
            this.alta.TabIndex = 10;
            this.alta.Text = "Dar Alta";
            this.alta.UseVisualStyleBackColor = true;
            this.alta.Click += new System.EventHandler(this.alta_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(250, 225);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 11;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Especialidad";
            this.label6.Visible = false;
            // 
            // especialidad
            // 
            this.especialidad.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidad.FormattingEnabled = true;
            this.especialidad.Items.AddRange(new object[] {
            "Ginecologia",
            "Traumatologia",
            "Pediatria",
            "Psiquiatria",
            "Interna"});
            this.especialidad.Location = new System.Drawing.Point(204, 166);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(121, 21);
            this.especialidad.TabIndex = 13;
            this.especialidad.Visible = false;
            // 
            // AltaModiUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 305);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.alta);
            this.Controls.Add(this.email);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaModiUsuario";
            this.Text = "Alta / Modificar usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Tipo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button alta;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox especialidad;

    }
}
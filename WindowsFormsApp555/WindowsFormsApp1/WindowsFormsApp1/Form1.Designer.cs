namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1saludar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxcorreo = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxnota1 = new System.Windows.Forms.TextBox();
            this.textBoxnota2 = new System.Windows.Forms.TextBox();
            this.textBoxnota3 = new System.Windows.Forms.TextBox();
            this.textBoxnota4 = new System.Windows.Forms.TextBox();
            this.textBoxidtarea = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxseccion = new System.Windows.Forms.ComboBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1saludar
            // 
            this.button1saludar.BackColor = System.Drawing.Color.Transparent;
            this.button1saludar.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1saludar.Location = new System.Drawing.Point(43, 374);
            this.button1saludar.Margin = new System.Windows.Forms.Padding(4);
            this.button1saludar.Name = "button1saludar";
            this.button1saludar.Size = new System.Drawing.Size(74, 24);
            this.button1saludar.TabIndex = 0;
            this.button1saludar.Text = "Saludar";
            this.button1saludar.UseVisualStyleBackColor = false;
            this.button1saludar.Click += new System.EventHandler(this.button1saludar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(140, 83);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(276, 22);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(197, 33);
            this.textBoxCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(110, 22);
            this.textBoxCarnet.TabIndex = 4;
            this.textBoxCarnet.TextChanged += new System.EventHandler(this.textBoxCarnet_TextChanged);
            // 
            // textBoxcorreo
            // 
            this.textBoxcorreo.Location = new System.Drawing.Point(140, 147);
            this.textBoxcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxcorreo.Name = "textBoxcorreo";
            this.textBoxcorreo.Size = new System.Drawing.Size(276, 22);
            this.textBoxcorreo.TabIndex = 7;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(449, 28);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(120, 28);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "Buscar Alumno";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(806, 28);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(145, 28);
            this.buttonCrear.TabIndex = 13;
            this.buttonCrear.Text = "Crear nuevo Alumno";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(806, 148);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(145, 28);
            this.buttonEliminar.TabIndex = 14;
            this.buttonEliminar.Text = "Eliminar al Alumno";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(806, 87);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(145, 28);
            this.buttonActualizar.TabIndex = 15;
            this.buttonActualizar.Text = "Actualizar Alumno";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(43, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID Tarea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Notas 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(43, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Notas 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(43, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Notas 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(43, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Notas 4:";
            // 
            // textBoxnota1
            // 
            this.textBoxnota1.Location = new System.Drawing.Point(140, 215);
            this.textBoxnota1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnota1.Name = "textBoxnota1";
            this.textBoxnota1.Size = new System.Drawing.Size(132, 22);
            this.textBoxnota1.TabIndex = 29;
            // 
            // textBoxnota2
            // 
            this.textBoxnota2.Location = new System.Drawing.Point(140, 245);
            this.textBoxnota2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnota2.Name = "textBoxnota2";
            this.textBoxnota2.Size = new System.Drawing.Size(132, 22);
            this.textBoxnota2.TabIndex = 30;
            // 
            // textBoxnota3
            // 
            this.textBoxnota3.Location = new System.Drawing.Point(140, 275);
            this.textBoxnota3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnota3.Name = "textBoxnota3";
            this.textBoxnota3.Size = new System.Drawing.Size(132, 22);
            this.textBoxnota3.TabIndex = 31;
            // 
            // textBoxnota4
            // 
            this.textBoxnota4.Location = new System.Drawing.Point(140, 305);
            this.textBoxnota4.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnota4.Name = "textBoxnota4";
            this.textBoxnota4.Size = new System.Drawing.Size(132, 22);
            this.textBoxnota4.TabIndex = 32;
            // 
            // textBoxidtarea
            // 
            this.textBoxidtarea.Location = new System.Drawing.Point(140, 185);
            this.textBoxidtarea.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxidtarea.Name = "textBoxidtarea";
            this.textBoxidtarea.Size = new System.Drawing.Size(132, 22);
            this.textBoxidtarea.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 34;
            this.button2.Text = "Buscar tarea";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(806, 209);
            this.buttoninsertar.Margin = new System.Windows.Forms.Padding(4);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(145, 28);
            this.buttoninsertar.TabIndex = 35;
            this.buttoninsertar.Text = "Crear tarea";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingrese el carnet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(43, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Seccion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(43, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 21);
            this.label9.TabIndex = 39;
            this.label9.Text = "Correo:";
            // 
            // comboBoxseccion
            // 
            this.comboBoxseccion.FormattingEnabled = true;
            this.comboBoxseccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxseccion.Location = new System.Drawing.Point(140, 114);
            this.comboBoxseccion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxseccion.Name = "comboBoxseccion";
            this.comboBoxseccion.Size = new System.Drawing.Size(132, 24);
            this.comboBoxseccion.TabIndex = 40;
            this.comboBoxseccion.SelectedIndexChanged += new System.EventHandler(this.comboBoxseccion_SelectedIndexChanged);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buttonLimpiar.Location = new System.Drawing.Point(317, 30);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(74, 25);
            this.buttonLimpiar.TabIndex = 41;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ChatGPT_Image_Apr_11__2025__12_51_41_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 659);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.comboBoxseccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxidtarea);
            this.Controls.Add(this.textBoxnota4);
            this.Controls.Add(this.textBoxnota3);
            this.Controls.Add(this.textBoxnota2);
            this.Controls.Add(this.textBoxnota1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxcorreo);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.button1saludar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Crud de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1saludar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.TextBox textBoxcorreo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxnota1;
        private System.Windows.Forms.TextBox textBoxnota2;
        private System.Windows.Forms.TextBox textBoxnota3;
        private System.Windows.Forms.TextBox textBoxnota4;
        private System.Windows.Forms.TextBox textBoxidtarea;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxseccion;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}


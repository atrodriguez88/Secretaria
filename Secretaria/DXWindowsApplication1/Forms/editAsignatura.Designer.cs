namespace DXWindowsApplication1
{
    partial class editAsignatura
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
            System.Windows.Forms.Label lbHoras;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editAsignatura));
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbInformacion = new System.Windows.Forms.Label();
            this.textBoxNuevo = new System.Windows.Forms.TextBox();
            this.lbNuevo = new System.Windows.Forms.Label();
            this.groupBoxCambios = new System.Windows.Forms.GroupBox();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.richTextBoxNuevaDescripcion = new System.Windows.Forms.RichTextBox();
            this.lbNuevaDescripcion = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            lbHoras = new System.Windows.Forms.Label();
            this.groupBoxCambios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHoras
            // 
            lbHoras.AutoSize = true;
            lbHoras.Location = new System.Drawing.Point(50, 113);
            lbHoras.Name = "lbHoras";
            lbHoras.Size = new System.Drawing.Size(78, 13);
            lbHoras.TabIndex = 12;
            lbHoras.Text = "Nuevas Horas:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(209, 26);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 8;
            this.lbNombre.Text = "lbCambio";
            // 
            // lbInformacion
            // 
            this.lbInformacion.AutoSize = true;
            this.lbInformacion.Location = new System.Drawing.Point(47, 26);
            this.lbInformacion.Name = "lbInformacion";
            this.lbInformacion.Size = new System.Drawing.Size(162, 13);
            this.lbInformacion.TabIndex = 7;
            this.lbInformacion.Text = "Usted va a cambiar el nombre a:";
            // 
            // textBoxNuevo
            // 
            this.textBoxNuevo.Location = new System.Drawing.Point(134, 64);
            this.textBoxNuevo.Name = "textBoxNuevo";
            this.textBoxNuevo.Size = new System.Drawing.Size(189, 21);
            this.textBoxNuevo.TabIndex = 6;
            // 
            // lbNuevo
            // 
            this.lbNuevo.AutoSize = true;
            this.lbNuevo.Location = new System.Drawing.Point(47, 72);
            this.lbNuevo.Name = "lbNuevo";
            this.lbNuevo.Size = new System.Drawing.Size(81, 13);
            this.lbNuevo.TabIndex = 5;
            this.lbNuevo.Text = "Nuevo nombre:";
            // 
            // groupBoxCambios
            // 
            this.groupBoxCambios.Controls.Add(this.textBoxHoras);
            this.groupBoxCambios.Controls.Add(lbHoras);
            this.groupBoxCambios.Controls.Add(this.richTextBoxNuevaDescripcion);
            this.groupBoxCambios.Controls.Add(this.lbNuevaDescripcion);
            this.groupBoxCambios.Controls.Add(this.lbInformacion);
            this.groupBoxCambios.Controls.Add(this.lbNombre);
            this.groupBoxCambios.Controls.Add(this.lbNuevo);
            this.groupBoxCambios.Controls.Add(this.textBoxNuevo);
            this.groupBoxCambios.Location = new System.Drawing.Point(4, 2);
            this.groupBoxCambios.Name = "groupBoxCambios";
            this.groupBoxCambios.Size = new System.Drawing.Size(329, 309);
            this.groupBoxCambios.TabIndex = 9;
            this.groupBoxCambios.TabStop = false;
            this.groupBoxCambios.Text = "Realice los Cambios";
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.Location = new System.Drawing.Point(134, 105);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(189, 21);
            this.textBoxHoras.TabIndex = 13;
            // 
            // richTextBoxNuevaDescripcion
            // 
            this.richTextBoxNuevaDescripcion.Location = new System.Drawing.Point(134, 148);
            this.richTextBoxNuevaDescripcion.Name = "richTextBoxNuevaDescripcion";
            this.richTextBoxNuevaDescripcion.Size = new System.Drawing.Size(189, 154);
            this.richTextBoxNuevaDescripcion.TabIndex = 11;
            this.richTextBoxNuevaDescripcion.Text = "";
            // 
            // lbNuevaDescripcion
            // 
            this.lbNuevaDescripcion.AutoSize = true;
            this.lbNuevaDescripcion.Location = new System.Drawing.Point(29, 148);
            this.lbNuevaDescripcion.Name = "lbNuevaDescripcion";
            this.lbNuevaDescripcion.Size = new System.Drawing.Size(99, 13);
            this.lbNuevaDescripcion.TabIndex = 10;
            this.lbNuevaDescripcion.Text = "Nueva Descripción:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(177, 317);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 9;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(258, 317);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // editAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 346);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBoxCambios);
            this.Controls.Add(this.buttonAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Asignatura";
            this.Load += new System.EventHandler(this.editAsignatura_Load);
            this.groupBoxCambios.ResumeLayout(false);
            this.groupBoxCambios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbInformacion;
        private System.Windows.Forms.TextBox textBoxNuevo;
        private System.Windows.Forms.Label lbNuevo;
        private System.Windows.Forms.GroupBox groupBoxCambios;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.RichTextBox richTextBoxNuevaDescripcion;
        private System.Windows.Forms.Label lbNuevaDescripcion;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxHoras;

    }
}
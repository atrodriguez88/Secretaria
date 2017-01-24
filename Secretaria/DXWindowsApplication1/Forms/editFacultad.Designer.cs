namespace DXWindowsApplication1
{
    partial class editFacultad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editFacultad));
            this.groupBoxCambios = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCambio = new System.Windows.Forms.Label();
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.textBoxNuevo = new System.Windows.Forms.TextBox();
            this.lbNuevoNomb = new System.Windows.Forms.Label();
            this.groupBoxCambios.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCambios
            // 
            this.groupBoxCambios.Controls.Add(this.button1);
            this.groupBoxCambios.Controls.Add(this.lbNombre);
            this.groupBoxCambios.Controls.Add(this.lbCambio);
            this.groupBoxCambios.Controls.Add(this.buttonCambiar);
            this.groupBoxCambios.Controls.Add(this.textBoxNuevo);
            this.groupBoxCambios.Controls.Add(this.lbNuevoNomb);
            this.groupBoxCambios.Location = new System.Drawing.Point(12, 3);
            this.groupBoxCambios.Name = "groupBoxCambios";
            this.groupBoxCambios.Size = new System.Drawing.Size(267, 116);
            this.groupBoxCambios.TabIndex = 0;
            this.groupBoxCambios.TabStop = false;
            this.groupBoxCambios.Text = "Realice los Cambios";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(185, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(168, 27);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(45, 13);
            this.lbNombre.TabIndex = 9;
            this.lbNombre.Text = "facVieja";
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Location = new System.Drawing.Point(6, 27);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(162, 13);
            this.lbCambio.TabIndex = 8;
            this.lbCambio.Text = "Usted va a cambiar el nombre a:";
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCambiar.Image")));
            this.buttonCambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCambiar.Location = new System.Drawing.Point(104, 89);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(75, 23);
            this.buttonCambiar.TabIndex = 7;
            this.buttonCambiar.Text = "Cambiar";
            this.buttonCambiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCambiar.UseVisualStyleBackColor = true;
            this.buttonCambiar.Click += new System.EventHandler(this.buttonCambiar_Click);
            // 
            // textBoxNuevo
            // 
            this.textBoxNuevo.Location = new System.Drawing.Point(104, 62);
            this.textBoxNuevo.Name = "textBoxNuevo";
            this.textBoxNuevo.Size = new System.Drawing.Size(153, 21);
            this.textBoxNuevo.TabIndex = 6;
            this.textBoxNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNuevo_KeyPress);
            // 
            // lbNuevoNomb
            // 
            this.lbNuevoNomb.AutoSize = true;
            this.lbNuevoNomb.Location = new System.Drawing.Point(8, 70);
            this.lbNuevoNomb.Name = "lbNuevoNomb";
            this.lbNuevoNomb.Size = new System.Drawing.Size(90, 13);
            this.lbNuevoNomb.TabIndex = 5;
            this.lbNuevoNomb.Text = "* Nuevo nombre:";
            // 
            // editFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 127);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxCambios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editFacultad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Facultad";
            this.groupBoxCambios.ResumeLayout(false);
            this.groupBoxCambios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCambios;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Button buttonCambiar;
        private System.Windows.Forms.TextBox textBoxNuevo;
        private System.Windows.Forms.Label lbNuevoNomb;
        private System.Windows.Forms.Button button1;

    }
}
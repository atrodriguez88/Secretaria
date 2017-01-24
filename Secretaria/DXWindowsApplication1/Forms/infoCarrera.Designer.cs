namespace DXWindowsApplication1
{
    partial class infoCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoCarrera));
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.lbFac = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbFacultad = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.lbFac);
            this.groupBoxDatos.Controls.Add(this.lbNom);
            this.groupBoxDatos.Controls.Add(this.lbFacultad);
            this.groupBoxDatos.Controls.Add(this.lbNombre);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 0);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(293, 89);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos:";
            // 
            // lbFac
            // 
            this.lbFac.AutoSize = true;
            this.lbFac.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFac.Location = new System.Drawing.Point(94, 62);
            this.lbFac.Name = "lbFac";
            this.lbFac.Size = new System.Drawing.Size(33, 17);
            this.lbFac.TabIndex = 3;
            this.lbFac.Text = "Fac";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(94, 26);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(39, 17);
            this.lbNom.TabIndex = 2;
            this.lbNom.Text = "Nom";
            // 
            // lbFacultad
            // 
            this.lbFacultad.AutoSize = true;
            this.lbFacultad.Location = new System.Drawing.Point(19, 62);
            this.lbFacultad.Name = "lbFacultad";
            this.lbFacultad.Size = new System.Drawing.Size(52, 13);
            this.lbFacultad.TabIndex = 1;
            this.lbFacultad.Text = "Facultad:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(23, 26);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(48, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.Image")));
            this.buttonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrar.Location = new System.Drawing.Point(240, 95);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(65, 23);
            this.buttonCerrar.TabIndex = 1;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 120);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.groupBoxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "infoCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de la Facultad";
            this.Load += new System.EventHandler(this.infoFacultad_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label lbFacultad;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFac;
        private System.Windows.Forms.Label lbNom;
    }
}
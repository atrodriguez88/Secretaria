namespace DXWindowsApplication1
{
    partial class infoAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoAsignatura));
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.lbDescrip = new System.Windows.Forms.Label();
            this.lbHor = new System.Windows.Forms.Label();
            this.lbNomb = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbHoras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.buttonCerrar);
            this.groupControlInfo.Controls.Add(this.groupBoxDatos);
            this.groupControlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(329, 264);
            this.groupControlInfo.TabIndex = 0;
            this.groupControlInfo.Text = "Información";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.Image")));
            this.buttonCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrar.Location = new System.Drawing.Point(248, 236);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 3;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.lbDescrip);
            this.groupBoxDatos.Controls.Add(this.lbHor);
            this.groupBoxDatos.Controls.Add(this.lbNomb);
            this.groupBoxDatos.Controls.Add(this.lbDescripcion);
            this.groupBoxDatos.Controls.Add(this.lbNombre);
            this.groupBoxDatos.Controls.Add(this.lbHoras);
            this.groupBoxDatos.Location = new System.Drawing.Point(5, 24);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(318, 206);
            this.groupBoxDatos.TabIndex = 2;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos:";
            // 
            // lbDescrip
            // 
            this.lbDescrip.AutoSize = true;
            this.lbDescrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrip.Location = new System.Drawing.Point(82, 110);
            this.lbDescrip.Name = "lbDescrip";
            this.lbDescrip.Size = new System.Drawing.Size(92, 18);
            this.lbDescrip.TabIndex = 5;
            this.lbDescrip.Text = "Descripcion";
            // 
            // lbHor
            // 
            this.lbHor.AutoSize = true;
            this.lbHor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHor.Location = new System.Drawing.Point(82, 70);
            this.lbHor.Name = "lbHor";
            this.lbHor.Size = new System.Drawing.Size(50, 18);
            this.lbHor.TabIndex = 4;
            this.lbHor.Text = "Horas";
            // 
            // lbNomb
            // 
            this.lbNomb.AutoSize = true;
            this.lbNomb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomb.Location = new System.Drawing.Point(82, 29);
            this.lbNomb.Name = "lbNomb";
            this.lbNomb.Size = new System.Drawing.Size(64, 18);
            this.lbNomb.TabIndex = 3;
            this.lbNomb.Text = "Nombre";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(11, 110);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(65, 13);
            this.lbDescripcion.TabIndex = 2;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(28, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(48, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Location = new System.Drawing.Point(37, 70);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(39, 13);
            this.lbHoras.TabIndex = 1;
            this.lbHoras.Text = "Horas:";
            // 
            // infoAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 264);
            this.Controls.Add(this.groupControlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "infoAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de la Asignatura";
            this.Load += new System.EventHandler(this.infoAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label lbDescrip;
        private System.Windows.Forms.Label lbHor;
        private System.Windows.Forms.Label lbNomb;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.Button buttonCerrar;
    }
}
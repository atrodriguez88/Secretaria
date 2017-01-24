namespace DXWindowsApplication1
{
    partial class editCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editCarrera));
            this.groupControlCambios = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxFacultad = new System.Windows.Forms.ComboBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxNuevoN = new System.Windows.Forms.TextBox();
            this.lbFacultad = new System.Windows.Forms.Label();
            this.lbNuevo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCambios)).BeginInit();
            this.groupControlCambios.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlCambios
            // 
            this.groupControlCambios.Controls.Add(this.groupBoxDatos);
            this.groupControlCambios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlCambios.Location = new System.Drawing.Point(0, 0);
            this.groupControlCambios.Name = "groupControlCambios";
            this.groupControlCambios.Size = new System.Drawing.Size(336, 174);
            this.groupControlCambios.TabIndex = 0;
            this.groupControlCambios.Text = "Realice los Cambios";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.button1);
            this.groupBoxDatos.Controls.Add(this.comboBoxFacultad);
            this.groupBoxDatos.Controls.Add(this.buttonAceptar);
            this.groupBoxDatos.Controls.Add(this.textBoxNuevoN);
            this.groupBoxDatos.Controls.Add(this.lbFacultad);
            this.groupBoxDatos.Controls.Add(this.lbNuevo);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 24);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(316, 142);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Nuevos Datos";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(205, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxFacultad
            // 
            this.comboBoxFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultad.FormattingEnabled = true;
            this.comboBoxFacultad.Location = new System.Drawing.Point(124, 63);
            this.comboBoxFacultad.Name = "comboBoxFacultad";
            this.comboBoxFacultad.Size = new System.Drawing.Size(146, 21);
            this.comboBoxFacultad.TabIndex = 4;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(124, 103);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNuevoN
            // 
            this.textBoxNuevoN.Location = new System.Drawing.Point(124, 22);
            this.textBoxNuevoN.Name = "textBoxNuevoN";
            this.textBoxNuevoN.Size = new System.Drawing.Size(146, 21);
            this.textBoxNuevoN.TabIndex = 2;
            this.textBoxNuevoN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNuevoN_KeyPress);
            this.textBoxNuevoN.Leave += new System.EventHandler(this.textBoxNuevoN_Leave);
            // 
            // lbFacultad
            // 
            this.lbFacultad.AutoSize = true;
            this.lbFacultad.Location = new System.Drawing.Point(57, 71);
            this.lbFacultad.Name = "lbFacultad";
            this.lbFacultad.Size = new System.Drawing.Size(61, 13);
            this.lbFacultad.TabIndex = 1;
            this.lbFacultad.Text = "* Facultad:";
            // 
            // lbNuevo
            // 
            this.lbNuevo.AutoSize = true;
            this.lbNuevo.Location = new System.Drawing.Point(27, 30);
            this.lbNuevo.Name = "lbNuevo";
            this.lbNuevo.Size = new System.Drawing.Size(91, 13);
            this.lbNuevo.TabIndex = 1;
            this.lbNuevo.Text = "* Nuevo Nombre:";
            // 
            // editCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(336, 174);
            this.ControlBox = false;
            this.Controls.Add(this.groupControlCambios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Carrera";
            this.Load += new System.EventHandler(this.editCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCambios)).EndInit();
            this.groupControlCambios.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlCambios;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox textBoxNuevoN;
        private System.Windows.Forms.Label lbFacultad;
        private System.Windows.Forms.Label lbNuevo;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBoxFacultad;
        private System.Windows.Forms.Button button1;
    }
}
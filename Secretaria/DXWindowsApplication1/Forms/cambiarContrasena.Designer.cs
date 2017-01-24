namespace DXWindowsApplication1
{
    partial class cambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cambiarContrasena));
            this.groupControlCambiar = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.textBoxRepetir = new System.Windows.Forms.TextBox();
            this.textBoxNueva = new System.Windows.Forms.TextBox();
            this.lbRepetir = new System.Windows.Forms.Label();
            this.lbNueva = new System.Windows.Forms.Label();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCambiar)).BeginInit();
            this.groupControlCambiar.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlCambiar
            // 
            this.groupControlCambiar.Controls.Add(this.groupBoxDatos);
            this.groupControlCambiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlCambiar.Location = new System.Drawing.Point(0, 0);
            this.groupControlCambiar.Name = "groupControlCambiar";
            this.groupControlCambiar.Size = new System.Drawing.Size(352, 201);
            this.groupControlCambiar.TabIndex = 0;
            this.groupControlCambiar.Text = "Cambiar Contraseña";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.button1);
            this.groupBoxDatos.Controls.Add(this.buttonAceptar);
            this.groupBoxDatos.Controls.Add(this.comboBoxUsuarios);
            this.groupBoxDatos.Controls.Add(this.textBoxRepetir);
            this.groupBoxDatos.Controls.Add(this.textBoxNueva);
            this.groupBoxDatos.Controls.Add(this.lbRepetir);
            this.groupBoxDatos.Controls.Add(this.lbNueva);
            this.groupBoxDatos.Controls.Add(this.lbUsuarios);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 24);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(328, 168);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Nuevos Datos";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(156, 139);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 20;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Items.AddRange(new object[] {
            "Secretaria",
            "Tecnico"});
            this.comboBoxUsuarios.Location = new System.Drawing.Point(173, 27);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(145, 21);
            this.comboBoxUsuarios.TabIndex = 19;
            // 
            // textBoxRepetir
            // 
            this.textBoxRepetir.Location = new System.Drawing.Point(173, 95);
            this.textBoxRepetir.Name = "textBoxRepetir";
            this.textBoxRepetir.Size = new System.Drawing.Size(145, 21);
            this.textBoxRepetir.TabIndex = 18;
            this.textBoxRepetir.UseSystemPasswordChar = true;
            // 
            // textBoxNueva
            // 
            this.textBoxNueva.Location = new System.Drawing.Point(173, 59);
            this.textBoxNueva.Name = "textBoxNueva";
            this.textBoxNueva.Size = new System.Drawing.Size(145, 21);
            this.textBoxNueva.TabIndex = 17;
            this.textBoxNueva.UseSystemPasswordChar = true;
            // 
            // lbRepetir
            // 
            this.lbRepetir.AutoSize = true;
            this.lbRepetir.Location = new System.Drawing.Point(23, 103);
            this.lbRepetir.Name = "lbRepetir";
            this.lbRepetir.Size = new System.Drawing.Size(144, 13);
            this.lbRepetir.TabIndex = 16;
            this.lbRepetir.Text = "* Repita Nueva Contraseña:";
            // 
            // lbNueva
            // 
            this.lbNueva.AutoSize = true;
            this.lbNueva.Location = new System.Drawing.Point(57, 67);
            this.lbNueva.Name = "lbNueva";
            this.lbNueva.Size = new System.Drawing.Size(110, 13);
            this.lbNueva.TabIndex = 15;
            this.lbNueva.Text = "* Nueva Contraseña:";
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Location = new System.Drawing.Point(111, 35);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(56, 13);
            this.lbUsuarios.TabIndex = 14;
            this.lbUsuarios.Text = "* Usuario:";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(243, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 201);
            this.Controls.Add(this.groupControlCambiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cambiarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCambiar)).EndInit();
            this.groupControlCambiar.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlCambiar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.TextBox textBoxRepetir;
        private System.Windows.Forms.TextBox textBoxNueva;
        private System.Windows.Forms.Label lbRepetir;
        private System.Windows.Forms.Label lbNueva;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.Button button1;

    }
}
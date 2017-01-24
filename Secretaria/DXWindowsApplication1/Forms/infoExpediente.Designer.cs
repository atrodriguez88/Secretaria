namespace DXWindowsApplication1
{
    partial class buscarExpediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarExpediente));
            this.groupControlUbicación = new DevExpress.XtraEditors.GroupControl();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBoxLocaliz = new System.Windows.Forms.GroupBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbExpediente = new System.Windows.Forms.Label();
            this.lbConsecutivo = new System.Windows.Forms.Label();
            this.lbNoExpedi = new System.Windows.Forms.Label();
            this.lbNoConce = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUbicación)).BeginInit();
            this.groupControlUbicación.SuspendLayout();
            this.groupBoxLocaliz.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlUbicación
            // 
            this.groupControlUbicación.Controls.Add(this.buttonSalir);
            this.groupControlUbicación.Controls.Add(this.groupBoxLocaliz);
            this.groupControlUbicación.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlUbicación.Location = new System.Drawing.Point(0, 0);
            this.groupControlUbicación.Name = "groupControlUbicación";
            this.groupControlUbicación.Size = new System.Drawing.Size(243, 208);
            this.groupControlUbicación.TabIndex = 0;
            this.groupControlUbicación.Text = "Ubicación";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(177, 181);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(61, 23);
            this.buttonSalir.TabIndex = 1;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // groupBoxLocaliz
            // 
            this.groupBoxLocaliz.Controls.Add(this.lbNombre);
            this.groupBoxLocaliz.Controls.Add(this.lbExpediente);
            this.groupBoxLocaliz.Controls.Add(this.lbConsecutivo);
            this.groupBoxLocaliz.Controls.Add(this.lbNoExpedi);
            this.groupBoxLocaliz.Controls.Add(this.lbNoConce);
            this.groupBoxLocaliz.Location = new System.Drawing.Point(7, 24);
            this.groupBoxLocaliz.Name = "groupBoxLocaliz";
            this.groupBoxLocaliz.Size = new System.Drawing.Size(227, 151);
            this.groupBoxLocaliz.TabIndex = 0;
            this.groupBoxLocaliz.TabStop = false;
            this.groupBoxLocaliz.Text = "Localización del Expediente";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(21, 36);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(71, 17);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "lbNombre";
            // 
            // lbExpediente
            // 
            this.lbExpediente.AutoSize = true;
            this.lbExpediente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpediente.Location = new System.Drawing.Point(148, 121);
            this.lbExpediente.Name = "lbExpediente";
            this.lbExpediente.Size = new System.Drawing.Size(73, 16);
            this.lbExpediente.TabIndex = 3;
            this.lbExpediente.Text = "Expediente";
            // 
            // lbConsecutivo
            // 
            this.lbConsecutivo.AutoSize = true;
            this.lbConsecutivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsecutivo.Location = new System.Drawing.Point(148, 77);
            this.lbConsecutivo.Name = "lbConsecutivo";
            this.lbConsecutivo.Size = new System.Drawing.Size(78, 16);
            this.lbConsecutivo.TabIndex = 2;
            this.lbConsecutivo.Text = "Consecutivo";
            // 
            // lbNoExpedi
            // 
            this.lbNoExpedi.AutoSize = true;
            this.lbNoExpedi.Location = new System.Drawing.Point(56, 124);
            this.lbNoExpedi.Name = "lbNoExpedi";
            this.lbNoExpedi.Size = new System.Drawing.Size(82, 13);
            this.lbNoExpedi.TabIndex = 1;
            this.lbNoExpedi.Text = "No.Expediente:";
            // 
            // lbNoConce
            // 
            this.lbNoConce.AutoSize = true;
            this.lbNoConce.Location = new System.Drawing.Point(51, 80);
            this.lbNoConce.Name = "lbNoConce";
            this.lbNoConce.Size = new System.Drawing.Size(87, 13);
            this.lbNoConce.TabIndex = 0;
            this.lbNoConce.Text = "No.Consecutivo:";
            // 
            // buscarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 208);
            this.ControlBox = false;
            this.Controls.Add(this.groupControlUbicación);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buscarExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente";
            this.Load += new System.EventHandler(this.buscarExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUbicación)).EndInit();
            this.groupControlUbicación.ResumeLayout(false);
            this.groupBoxLocaliz.ResumeLayout(false);
            this.groupBoxLocaliz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlUbicación;
        private System.Windows.Forms.GroupBox groupBoxLocaliz;
        private System.Windows.Forms.Label lbNoExpedi;
        private System.Windows.Forms.Label lbNoConce;
        private System.Windows.Forms.Label lbExpediente;
        private System.Windows.Forms.Label lbConsecutivo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button buttonSalir;
    }
}
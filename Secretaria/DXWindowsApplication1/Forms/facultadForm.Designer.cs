namespace DXWindowsApplication1
{
    partial class facultadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facultadForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControlDatos = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxNueva = new System.Windows.Forms.GroupBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxFacultades = new System.Windows.Forms.GroupBox();
            this.dataGridViewFacultades = new System.Windows.Forms.DataGridView();
            this.idFacultadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesisDataSet1 = new DXWindowsApplication1.TesisDataSet1();
            this.facultadTableAdapter = new DXWindowsApplication1.TesisDataSet1TableAdapters.FacultadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).BeginInit();
            this.groupControlDatos.SuspendLayout();
            this.groupBoxNueva.SuspendLayout();
            this.groupBoxFacultades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacultades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlDatos
            // 
            this.groupControlDatos.Controls.Add(this.groupBoxNueva);
            this.groupControlDatos.Controls.Add(this.groupBoxFacultades);
            this.groupControlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDatos.Location = new System.Drawing.Point(0, 0);
            this.groupControlDatos.Name = "groupControlDatos";
            this.groupControlDatos.Size = new System.Drawing.Size(377, 352);
            this.groupControlDatos.TabIndex = 0;
            this.groupControlDatos.Text = "Datos de la Facultad";
            // 
            // groupBoxNueva
            // 
            this.groupBoxNueva.Controls.Add(this.buttonAceptar);
            this.groupBoxNueva.Controls.Add(this.textBoxNombre);
            this.groupBoxNueva.Controls.Add(this.lbNombre);
            this.groupBoxNueva.Controls.Add(this.buttonCancelar);
            this.groupBoxNueva.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxNueva.Location = new System.Drawing.Point(2, 21);
            this.groupBoxNueva.Name = "groupBoxNueva";
            this.groupBoxNueva.Size = new System.Drawing.Size(373, 112);
            this.groupBoxNueva.TabIndex = 5;
            this.groupBoxNueva.TabStop = false;
            this.groupBoxNueva.Text = "Nueva Facultad";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(124, 69);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(124, 25);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(156, 20);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(64, 32);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(54, 13);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "* Nombre:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(205, 69);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBoxFacultades
            // 
            this.groupBoxFacultades.Controls.Add(this.dataGridViewFacultades);
            this.groupBoxFacultades.Location = new System.Drawing.Point(129, 142);
            this.groupBoxFacultades.Name = "groupBoxFacultades";
            this.groupBoxFacultades.Size = new System.Drawing.Size(153, 198);
            this.groupBoxFacultades.TabIndex = 4;
            this.groupBoxFacultades.TabStop = false;
            this.groupBoxFacultades.Text = "Facultades Existentes";
            // 
            // dataGridViewFacultades
            // 
            this.dataGridViewFacultades.AllowUserToAddRows = false;
            this.dataGridViewFacultades.AllowUserToDeleteRows = false;
            this.dataGridViewFacultades.AutoGenerateColumns = false;
            this.dataGridViewFacultades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacultades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFacultadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridViewFacultades.DataSource = this.facultadBindingSource;
            this.dataGridViewFacultades.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewFacultades.Name = "dataGridViewFacultades";
            this.dataGridViewFacultades.ReadOnly = true;
            this.dataGridViewFacultades.Size = new System.Drawing.Size(140, 168);
            this.dataGridViewFacultades.TabIndex = 5;
            // 
            // idFacultadDataGridViewTextBoxColumn
            // 
            this.idFacultadDataGridViewTextBoxColumn.DataPropertyName = "IdFacultad";
            this.idFacultadDataGridViewTextBoxColumn.HeaderText = "IdFacultad";
            this.idFacultadDataGridViewTextBoxColumn.Name = "idFacultadDataGridViewTextBoxColumn";
            this.idFacultadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFacultadDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre de La Facultad";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facultadBindingSource
            // 
            this.facultadBindingSource.DataMember = "Facultad";
            this.facultadBindingSource.DataSource = this.tesisDataSet1;
            // 
            // tesisDataSet1
            // 
            this.tesisDataSet1.DataSetName = "TesisDataSet1";
            this.tesisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultadTableAdapter
            // 
            this.facultadTableAdapter.ClearBeforeFill = true;
            // 
            // facultadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 352);
            this.Controls.Add(this.groupControlDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "facultadForm";
            this.Text = "Nueva Facultad";
            this.Load += new System.EventHandler(this.facultadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).EndInit();
            this.groupControlDatos.ResumeLayout(false);
            this.groupBoxNueva.ResumeLayout(false);
            this.groupBoxNueva.PerformLayout();
            this.groupBoxFacultades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacultades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDatos;
        private TesisDataSet1 tesisDataSet1;
        private System.Windows.Forms.BindingSource facultadBindingSource;
        private TesisDataSet1TableAdapters.FacultadTableAdapter facultadTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxFacultades;
        private System.Windows.Forms.DataGridView dataGridViewFacultades;
        private System.Windows.Forms.GroupBox groupBoxNueva;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacultadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}
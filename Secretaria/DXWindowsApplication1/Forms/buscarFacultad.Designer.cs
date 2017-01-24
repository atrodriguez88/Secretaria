namespace DXWindowsApplication1
{
    partial class buscarFacultad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarFacultad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControlDatos = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxCriterio = new System.Windows.Forms.GroupBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dataGridViewFacultades = new System.Windows.Forms.DataGridView();
            this.facultadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesisDataSet5 = new DXWindowsApplication1.TesisDataSet5();
            this.facultadTableAdapter = new DXWindowsApplication1.TesisDataSet5TableAdapters.FacultadTableAdapter();
            this.idFacultadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.edliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).BeginInit();
            this.groupControlDatos.SuspendLayout();
            this.groupBoxCriterio.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacultades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlDatos
            // 
            this.groupControlDatos.Controls.Add(this.groupBoxCriterio);
            this.groupControlDatos.Controls.Add(this.groupBoxResultado);
            this.groupControlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDatos.Location = new System.Drawing.Point(0, 0);
            this.groupControlDatos.Name = "groupControlDatos";
            this.groupControlDatos.Size = new System.Drawing.Size(476, 347);
            this.groupControlDatos.TabIndex = 0;
            this.groupControlDatos.Text = "Datos de la Facultad";
            // 
            // groupBoxCriterio
            // 
            this.groupBoxCriterio.Controls.Add(this.lbNombre);
            this.groupBoxCriterio.Controls.Add(this.buttonBuscar);
            this.groupBoxCriterio.Controls.Add(this.textBoxNombre);
            this.groupBoxCriterio.Location = new System.Drawing.Point(106, 24);
            this.groupBoxCriterio.Name = "groupBoxCriterio";
            this.groupBoxCriterio.Size = new System.Drawing.Size(236, 97);
            this.groupBoxCriterio.TabIndex = 56;
            this.groupBoxCriterio.TabStop = false;
            this.groupBoxCriterio.Text = "Criterio de Búsqueda";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(6, 41);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(48, 13);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(140, 61);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 55;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(59, 34);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(156, 21);
            this.textBoxNombre.TabIndex = 5;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.dataGridViewFacultades);
            this.groupBoxResultado.Location = new System.Drawing.Point(45, 127);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(358, 142);
            this.groupBoxResultado.TabIndex = 54;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado de la Busqueda";
            // 
            // dataGridViewFacultades
            // 
            this.dataGridViewFacultades.AllowUserToAddRows = false;
            this.dataGridViewFacultades.AllowUserToDeleteRows = false;
            this.dataGridViewFacultades.AllowUserToOrderColumns = true;
            this.dataGridViewFacultades.AutoGenerateColumns = false;
            this.dataGridViewFacultades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacultades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFacultadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.editar,
            this.edliminar});
            this.dataGridViewFacultades.DataSource = this.facultadBindingSource;
            this.dataGridViewFacultades.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewFacultades.Name = "dataGridViewFacultades";
            this.dataGridViewFacultades.ReadOnly = true;
            this.dataGridViewFacultades.Size = new System.Drawing.Size(343, 116);
            this.dataGridViewFacultades.TabIndex = 0;
            this.dataGridViewFacultades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // facultadBindingSource
            // 
            this.facultadBindingSource.DataMember = "Facultad";
            this.facultadBindingSource.DataSource = this.tesisDataSet5;
            // 
            // tesisDataSet5
            // 
            this.tesisDataSet5.DataSetName = "TesisDataSet5";
            this.tesisDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultadTableAdapter
            // 
            this.facultadTableAdapter.ClearBeforeFill = true;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.editar.HeaderText = "Editar Facultad";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // edliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.edliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.edliminar.HeaderText = "Eliminar Facultad";
            this.edliminar.Image = ((System.Drawing.Image)(resources.GetObject("edliminar.Image")));
            this.edliminar.Name = "edliminar";
            this.edliminar.ReadOnly = true;
            this.edliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buscarFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 347);
            this.Controls.Add(this.groupControlDatos);
            this.Name = "buscarFacultad";
            this.Text = "Buscar Facultad";
            this.Load += new System.EventHandler(this.buscarFacultad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).EndInit();
            this.groupControlDatos.ResumeLayout(false);
            this.groupBoxCriterio.ResumeLayout(false);
            this.groupBoxCriterio.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacultades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDatos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.DataGridView dataGridViewFacultades;
        private System.Windows.Forms.Button buttonBuscar;
        private TesisDataSet5 tesisDataSet5;
        private System.Windows.Forms.BindingSource facultadBindingSource;
        private TesisDataSet5TableAdapters.FacultadTableAdapter facultadTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxCriterio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacultadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn edliminar;
    }
}
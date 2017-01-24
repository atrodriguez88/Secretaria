namespace DXWindowsApplication1
{
    partial class buscarAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarAsignatura));
            this.groupControlDatos = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.groupBoxCriterio = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewAsignatura = new System.Windows.Forms.DataGridView();
            this.tesisDataSet7 = new DXWindowsApplication1.TesisDataSet7();
            this.asignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturaTableAdapter = new DXWindowsApplication1.TesisDataSet7TableAdapters.AsignaturaTableAdapter();
            this.idAsignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).BeginInit();
            this.groupControlDatos.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxCriterio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlDatos
            // 
            this.groupControlDatos.Controls.Add(this.groupBoxResultado);
            this.groupControlDatos.Controls.Add(this.groupBoxCriterio);
            this.groupControlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDatos.Location = new System.Drawing.Point(0, 0);
            this.groupControlDatos.Name = "groupControlDatos";
            this.groupControlDatos.Size = new System.Drawing.Size(538, 334);
            this.groupControlDatos.TabIndex = 0;
            this.groupControlDatos.Text = "Datos de la Facultad";
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.dataGridViewAsignatura);
            this.groupBoxResultado.Location = new System.Drawing.Point(22, 127);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(504, 172);
            this.groupBoxResultado.TabIndex = 1;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado de la Búsqueda";
            // 
            // groupBoxCriterio
            // 
            this.groupBoxCriterio.Controls.Add(this.buttonBuscar);
            this.groupBoxCriterio.Controls.Add(this.lbNombre);
            this.groupBoxCriterio.Controls.Add(this.textBoxNombre);
            this.groupBoxCriterio.Location = new System.Drawing.Point(175, 36);
            this.groupBoxCriterio.Name = "groupBoxCriterio";
            this.groupBoxCriterio.Size = new System.Drawing.Size(226, 85);
            this.groupBoxCriterio.TabIndex = 0;
            this.groupBoxCriterio.TabStop = false;
            this.groupBoxCriterio.Text = "Criterio de Búsqueda";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(138, 52);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(21, 33);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(48, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(75, 25);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(138, 21);
            this.textBoxNombre.TabIndex = 1;
            // 
            // dataGridViewAsignatura
            // 
            this.dataGridViewAsignatura.AllowUserToAddRows = false;
            this.dataGridViewAsignatura.AllowUserToDeleteRows = false;
            this.dataGridViewAsignatura.AutoGenerateColumns = false;
            this.dataGridViewAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsignaturaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.horasDataGridViewTextBoxColumn,
            this.editar,
            this.eliminar});
            this.dataGridViewAsignatura.DataSource = this.asignaturaBindingSource;
            this.dataGridViewAsignatura.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewAsignatura.Name = "dataGridViewAsignatura";
            this.dataGridViewAsignatura.ReadOnly = true;
            this.dataGridViewAsignatura.Size = new System.Drawing.Size(492, 150);
            this.dataGridViewAsignatura.TabIndex = 0;
            this.dataGridViewAsignatura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAsignatura_CellContentClick);
            // 
            // tesisDataSet7
            // 
            this.tesisDataSet7.DataSetName = "TesisDataSet7";
            this.tesisDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturaBindingSource
            // 
            this.asignaturaBindingSource.DataMember = "Asignatura";
            this.asignaturaBindingSource.DataSource = this.tesisDataSet7;
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // idAsignaturaDataGridViewTextBoxColumn
            // 
            this.idAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "IdAsignatura";
            this.idAsignaturaDataGridViewTextBoxColumn.HeaderText = "IdAsignatura";
            this.idAsignaturaDataGridViewTextBoxColumn.Name = "idAsignaturaDataGridViewTextBoxColumn";
            this.idAsignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsignaturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horasDataGridViewTextBoxColumn
            // 
            this.horasDataGridViewTextBoxColumn.DataPropertyName = "horas";
            this.horasDataGridViewTextBoxColumn.HeaderText = "Horas";
            this.horasDataGridViewTextBoxColumn.Name = "horasDataGridViewTextBoxColumn";
            this.horasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buscarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 334);
            this.Controls.Add(this.groupControlDatos);
            this.Name = "buscarAsignatura";
            this.Text = "Buscar Asignatura";
            this.Load += new System.EventHandler(this.buscarAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).EndInit();
            this.groupControlDatos.ResumeLayout(false);
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxCriterio.ResumeLayout(false);
            this.groupBoxCriterio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDatos;
        private System.Windows.Forms.GroupBox groupBoxCriterio;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.DataGridView dataGridViewAsignatura;
        private TesisDataSet7 tesisDataSet7;
        private System.Windows.Forms.BindingSource asignaturaBindingSource;
        private TesisDataSet7TableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}
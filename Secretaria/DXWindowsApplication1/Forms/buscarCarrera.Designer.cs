namespace DXWindowsApplication1
{
    partial class buscarCarrera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarCarrera));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControlDatos = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dataGridViewCarreras = new System.Windows.Forms.DataGridView();
            this.idCArreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFacultadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesisDataSet2 = new DXWindowsApplication1.TesisDataSet2();
            this.groupBoxCriterio = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lbFacultad = new System.Windows.Forms.Label();
            this.comboBoxFacultad = new System.Windows.Forms.ComboBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.carreraTableAdapter = new DXWindowsApplication1.TesisDataSet2TableAdapters.CarreraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).BeginInit();
            this.groupControlDatos.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet2)).BeginInit();
            this.groupBoxCriterio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlDatos
            // 
            this.groupControlDatos.Controls.Add(this.groupBoxResultado);
            this.groupControlDatos.Controls.Add(this.groupBoxCriterio);
            this.groupControlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDatos.Location = new System.Drawing.Point(0, 0);
            this.groupControlDatos.Name = "groupControlDatos";
            this.groupControlDatos.Size = new System.Drawing.Size(435, 358);
            this.groupControlDatos.TabIndex = 0;
            this.groupControlDatos.Text = "Datos de la Carrera";
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.dataGridViewCarreras);
            this.groupBoxResultado.Location = new System.Drawing.Point(32, 170);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(333, 176);
            this.groupBoxResultado.TabIndex = 1;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado de la Búsqueda";
            // 
            // dataGridViewCarreras
            // 
            this.dataGridViewCarreras.AllowUserToAddRows = false;
            this.dataGridViewCarreras.AllowUserToDeleteRows = false;
            this.dataGridViewCarreras.AllowUserToOrderColumns = true;
            this.dataGridViewCarreras.AutoGenerateColumns = false;
            this.dataGridViewCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCArreraDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.idFacultadDataGridViewTextBoxColumn,
            this.editar,
            this.eliminar});
            this.dataGridViewCarreras.DataSource = this.carreraBindingSource;
            this.dataGridViewCarreras.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewCarreras.Name = "dataGridViewCarreras";
            this.dataGridViewCarreras.ReadOnly = true;
            this.dataGridViewCarreras.Size = new System.Drawing.Size(321, 150);
            this.dataGridViewCarreras.TabIndex = 0;
            this.dataGridViewCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCArreraDataGridViewTextBoxColumn
            // 
            this.idCArreraDataGridViewTextBoxColumn.DataPropertyName = "IdCArrera";
            this.idCArreraDataGridViewTextBoxColumn.HeaderText = "IdCArrera";
            this.idCArreraDataGridViewTextBoxColumn.Name = "idCArreraDataGridViewTextBoxColumn";
            this.idCArreraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCArreraDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idFacultadDataGridViewTextBoxColumn
            // 
            this.idFacultadDataGridViewTextBoxColumn.DataPropertyName = "idFacultad";
            this.idFacultadDataGridViewTextBoxColumn.HeaderText = "idFacultad";
            this.idFacultadDataGridViewTextBoxColumn.Name = "idFacultadDataGridViewTextBoxColumn";
            this.idFacultadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFacultadDataGridViewTextBoxColumn.Visible = false;
            // 
            // editar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.editar.HeaderText = "Editar";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // carreraBindingSource
            // 
            this.carreraBindingSource.DataMember = "Carrera";
            this.carreraBindingSource.DataSource = this.tesisDataSet2;
            // 
            // tesisDataSet2
            // 
            this.tesisDataSet2.DataSetName = "TesisDataSet2";
            this.tesisDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxCriterio
            // 
            this.groupBoxCriterio.Controls.Add(this.buttonBuscar);
            this.groupBoxCriterio.Controls.Add(this.textBoxNombre);
            this.groupBoxCriterio.Controls.Add(this.lbFacultad);
            this.groupBoxCriterio.Controls.Add(this.comboBoxFacultad);
            this.groupBoxCriterio.Controls.Add(this.lbNombre);
            this.groupBoxCriterio.Location = new System.Drawing.Point(32, 39);
            this.groupBoxCriterio.Name = "groupBoxCriterio";
            this.groupBoxCriterio.Size = new System.Drawing.Size(333, 125);
            this.groupBoxCriterio.TabIndex = 0;
            this.groupBoxCriterio.TabStop = false;
            this.groupBoxCriterio.Text = "Criterios de Búsqueda";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(205, 95);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(119, 22);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(161, 21);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // lbFacultad
            // 
            this.lbFacultad.AutoSize = true;
            this.lbFacultad.Location = new System.Drawing.Point(61, 76);
            this.lbFacultad.Name = "lbFacultad";
            this.lbFacultad.Size = new System.Drawing.Size(52, 13);
            this.lbFacultad.TabIndex = 3;
            this.lbFacultad.Text = "Facultad:";
            // 
            // comboBoxFacultad
            // 
            this.comboBoxFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultad.FormattingEnabled = true;
            this.comboBoxFacultad.Location = new System.Drawing.Point(119, 68);
            this.comboBoxFacultad.Name = "comboBoxFacultad";
            this.comboBoxFacultad.Size = new System.Drawing.Size(161, 21);
            this.comboBoxFacultad.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(65, 30);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(48, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // carreraTableAdapter
            // 
            this.carreraTableAdapter.ClearBeforeFill = true;
            // 
            // buscarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 358);
            this.Controls.Add(this.groupControlDatos);
            this.Name = "buscarCarrera";
            this.Text = "Buscar Carrera";
            this.Load += new System.EventHandler(this.buscarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).EndInit();
            this.groupControlDatos.ResumeLayout(false);
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet2)).EndInit();
            this.groupBoxCriterio.ResumeLayout(false);
            this.groupBoxCriterio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDatos;
        private System.Windows.Forms.GroupBox groupBoxCriterio;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lbFacultad;
        private System.Windows.Forms.ComboBox comboBoxFacultad;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.DataGridView dataGridViewCarreras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private TesisDataSet2 tesisDataSet2;
        private System.Windows.Forms.BindingSource carreraBindingSource;
        private TesisDataSet2TableAdapters.CarreraTableAdapter carreraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCArreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacultadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}
namespace DXWindowsApplication1
{
    partial class pendientedePlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pendientedePlan));
            this.groupControlBuscar = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEstudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionParticularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centrotrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organismoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExpedienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendienteDePlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.consulta16BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesisDataSet18 = new DXWindowsApplication1.TesisDataSet18();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.consulta16TableAdapter = new DXWindowsApplication1.TesisDataSet18TableAdapters.Consulta16TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBuscar)).BeginInit();
            this.groupControlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta16BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet18)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlBuscar
            // 
            this.groupControlBuscar.Controls.Add(this.dataGridView1);
            this.groupControlBuscar.Controls.Add(this.groupBox1);
            this.groupControlBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlBuscar.Location = new System.Drawing.Point(0, 0);
            this.groupControlBuscar.Name = "groupControlBuscar";
            this.groupControlBuscar.Size = new System.Drawing.Size(750, 400);
            this.groupControlBuscar.TabIndex = 41;
            this.groupControlBuscar.Text = "Busqueda de Estudiante";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEstudianteDataGridViewTextBoxColumn,
            this.cIDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.primerApellidoDataGridViewTextBoxColumn,
            this.segundoApellidoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.direccionParticularDataGridViewTextBoxColumn,
            this.pielDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.modalidadDataGridViewTextBoxColumn,
            this.centrotrabajoDataGridViewTextBoxColumn,
            this.ocupacionDataGridViewTextBoxColumn,
            this.organismoDataGridViewTextBoxColumn,
            this.idExpedienteDataGridViewTextBoxColumn,
            this.idCarreraDataGridViewTextBoxColumn,
            this.pendienteDePlanDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.consulta16BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 262);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idEstudianteDataGridViewTextBoxColumn
            // 
            this.idEstudianteDataGridViewTextBoxColumn.DataPropertyName = "IdEstudiante";
            this.idEstudianteDataGridViewTextBoxColumn.HeaderText = "IdEstudiante";
            this.idEstudianteDataGridViewTextBoxColumn.Name = "idEstudianteDataGridViewTextBoxColumn";
            this.idEstudianteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEstudianteDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIDataGridViewTextBoxColumn
            // 
            this.cIDataGridViewTextBoxColumn.DataPropertyName = "CI";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cIDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cIDataGridViewTextBoxColumn.HeaderText = "Carné de Identidad";
            this.cIDataGridViewTextBoxColumn.Name = "cIDataGridViewTextBoxColumn";
            this.cIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            this.primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "primerApellido";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.primerApellidoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.primerApellidoDataGridViewTextBoxColumn.HeaderText = "Primer Apellido";
            this.primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            this.primerApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // segundoApellidoDataGridViewTextBoxColumn
            // 
            this.segundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "segundoApellido";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.segundoApellidoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.segundoApellidoDataGridViewTextBoxColumn.HeaderText = "Segundo Apellido";
            this.segundoApellidoDataGridViewTextBoxColumn.Name = "segundoApellidoDataGridViewTextBoxColumn";
            this.segundoApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Visible = false;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.paisDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.paisDataGridViewTextBoxColumn.HeaderText = "País";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionParticularDataGridViewTextBoxColumn
            // 
            this.direccionParticularDataGridViewTextBoxColumn.DataPropertyName = "direccionParticular";
            this.direccionParticularDataGridViewTextBoxColumn.HeaderText = "direccionParticular";
            this.direccionParticularDataGridViewTextBoxColumn.Name = "direccionParticularDataGridViewTextBoxColumn";
            this.direccionParticularDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionParticularDataGridViewTextBoxColumn.Visible = false;
            // 
            // pielDataGridViewTextBoxColumn
            // 
            this.pielDataGridViewTextBoxColumn.DataPropertyName = "piel";
            this.pielDataGridViewTextBoxColumn.HeaderText = "piel";
            this.pielDataGridViewTextBoxColumn.Name = "pielDataGridViewTextBoxColumn";
            this.pielDataGridViewTextBoxColumn.ReadOnly = true;
            this.pielDataGridViewTextBoxColumn.Visible = false;
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "provincia";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.provinciaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            this.provinciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modalidadDataGridViewTextBoxColumn
            // 
            this.modalidadDataGridViewTextBoxColumn.DataPropertyName = "modalidad";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.modalidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.modalidadDataGridViewTextBoxColumn.HeaderText = "Modalidad";
            this.modalidadDataGridViewTextBoxColumn.Name = "modalidadDataGridViewTextBoxColumn";
            this.modalidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centrotrabajoDataGridViewTextBoxColumn
            // 
            this.centrotrabajoDataGridViewTextBoxColumn.DataPropertyName = "centro_trabajo";
            this.centrotrabajoDataGridViewTextBoxColumn.HeaderText = "centro_trabajo";
            this.centrotrabajoDataGridViewTextBoxColumn.Name = "centrotrabajoDataGridViewTextBoxColumn";
            this.centrotrabajoDataGridViewTextBoxColumn.ReadOnly = true;
            this.centrotrabajoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ocupacionDataGridViewTextBoxColumn
            // 
            this.ocupacionDataGridViewTextBoxColumn.DataPropertyName = "ocupacion";
            this.ocupacionDataGridViewTextBoxColumn.HeaderText = "ocupacion";
            this.ocupacionDataGridViewTextBoxColumn.Name = "ocupacionDataGridViewTextBoxColumn";
            this.ocupacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.ocupacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // organismoDataGridViewTextBoxColumn
            // 
            this.organismoDataGridViewTextBoxColumn.DataPropertyName = "organismo";
            this.organismoDataGridViewTextBoxColumn.HeaderText = "organismo";
            this.organismoDataGridViewTextBoxColumn.Name = "organismoDataGridViewTextBoxColumn";
            this.organismoDataGridViewTextBoxColumn.ReadOnly = true;
            this.organismoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idExpedienteDataGridViewTextBoxColumn
            // 
            this.idExpedienteDataGridViewTextBoxColumn.DataPropertyName = "idExpediente";
            this.idExpedienteDataGridViewTextBoxColumn.HeaderText = "idExpediente";
            this.idExpedienteDataGridViewTextBoxColumn.Name = "idExpedienteDataGridViewTextBoxColumn";
            this.idExpedienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idExpedienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCarreraDataGridViewTextBoxColumn
            // 
            this.idCarreraDataGridViewTextBoxColumn.DataPropertyName = "idCarrera";
            this.idCarreraDataGridViewTextBoxColumn.HeaderText = "idCarrera";
            this.idCarreraDataGridViewTextBoxColumn.Name = "idCarreraDataGridViewTextBoxColumn";
            this.idCarreraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCarreraDataGridViewTextBoxColumn.Visible = false;
            // 
            // pendienteDePlanDataGridViewTextBoxColumn
            // 
            this.pendienteDePlanDataGridViewTextBoxColumn.DataPropertyName = "pendienteDePlan";
            this.pendienteDePlanDataGridViewTextBoxColumn.HeaderText = "Pendiente De Plan";
            this.pendienteDePlanDataGridViewTextBoxColumn.Name = "pendienteDePlanDataGridViewTextBoxColumn";
            this.pendienteDePlanDataGridViewTextBoxColumn.ReadOnly = true;
            this.pendienteDePlanDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "Añadir Plan de Estudio";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // consulta16BindingSource
            // 
            this.consulta16BindingSource.DataMember = "Consulta16";
            this.consulta16BindingSource.DataSource = this.tesisDataSet18;
            // 
            // tesisDataSet18
            // 
            this.tesisDataSet18.DataSetName = "TesisDataSet18";
            this.tesisDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Busqueda";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(428, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 33);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carné de Identidad:";
            // 
            // consulta16TableAdapter
            // 
            this.consulta16TableAdapter.ClearBeforeFill = true;
            // 
            // pendientedePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.groupControlBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pendientedePlan";
            this.Text = "Estudiantes pendientes de Plan de Estudio";
            this.Load += new System.EventHandler(this.pendientedePlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBuscar)).EndInit();
            this.groupControlBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulta16BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet18)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private TesisDataSet18 tesisDataSet18;
        private System.Windows.Forms.BindingSource consulta16BindingSource;
        private TesisDataSet18TableAdapters.Consulta16TableAdapter consulta16TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionParticularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centrotrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organismoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExpedienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendienteDePlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}
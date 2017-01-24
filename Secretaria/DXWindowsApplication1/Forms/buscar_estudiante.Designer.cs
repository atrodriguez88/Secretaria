namespace DXWindowsApplication1
{
    partial class buscar_estudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscar_estudiante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControlBuscar = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxCriterios = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCarne = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.lbApellido = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCarne = new System.Windows.Forms.TextBox();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
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
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.añadirNotas = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesisDataSet4 = new DXWindowsApplication1.TesisDataSet4();
            this.estudianteTableAdapter = new DXWindowsApplication1.TesisDataSet4TableAdapters.EstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBuscar)).BeginInit();
            this.groupControlBuscar.SuspendLayout();
            this.groupBoxCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlBuscar
            // 
            this.groupControlBuscar.Controls.Add(this.groupBoxCriterios);
            this.groupControlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlBuscar.Location = new System.Drawing.Point(0, 0);
            this.groupControlBuscar.Name = "groupControlBuscar";
            this.groupControlBuscar.Size = new System.Drawing.Size(786, 156);
            this.groupControlBuscar.TabIndex = 40;
            this.groupControlBuscar.Text = "Busqueda de Estudiante";
            // 
            // groupBoxCriterios
            // 
            this.groupBoxCriterios.Controls.Add(this.textBox1);
            this.groupBoxCriterios.Controls.Add(this.label1);
            this.groupBoxCriterios.Controls.Add(this.lbCarne);
            this.groupBoxCriterios.Controls.Add(this.buttonBuscar);
            this.groupBoxCriterios.Controls.Add(this.lbApellido);
            this.groupBoxCriterios.Controls.Add(this.textBoxApellido);
            this.groupBoxCriterios.Controls.Add(this.lbNombre);
            this.groupBoxCriterios.Controls.Add(this.textBoxNombre);
            this.groupBoxCriterios.Controls.Add(this.textBoxCarne);
            this.groupBoxCriterios.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCriterios.Location = new System.Drawing.Point(2, 21);
            this.groupBoxCriterios.Name = "groupBoxCriterios";
            this.groupBoxCriterios.Size = new System.Drawing.Size(782, 127);
            this.groupBoxCriterios.TabIndex = 53;
            this.groupBoxCriterios.TabStop = false;
            this.groupBoxCriterios.Text = "Criterios de Busqueda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 54;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "No. Expediente:";
            // 
            // lbCarne
            // 
            this.lbCarne.AutoSize = true;
            this.lbCarne.Location = new System.Drawing.Point(20, 28);
            this.lbCarne.Name = "lbCarne";
            this.lbCarne.Size = new System.Drawing.Size(100, 13);
            this.lbCarne.TabIndex = 27;
            this.lbCarne.Text = "Carné de Identidad:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(648, 98);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 52;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(494, 27);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(79, 13);
            this.lbApellido.TabIndex = 28;
            this.lbApellido.Text = "Primer Apellido:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(579, 20);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(144, 20);
            this.textBoxApellido.TabIndex = 43;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(282, 28);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 26;
            this.lbNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(336, 20);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(143, 20);
            this.textBoxNombre.TabIndex = 42;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxCarne
            // 
            this.textBoxCarne.Location = new System.Drawing.Point(128, 21);
            this.textBoxCarne.MaxLength = 11;
            this.textBoxCarne.Name = "textBoxCarne";
            this.textBoxCarne.Size = new System.Drawing.Size(144, 20);
            this.textBoxCarne.TabIndex = 41;
            this.textBoxCarne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCarne_KeyPress);
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.AllowUserToAddRows = false;
            this.dataGridViewEstudiantes.AllowUserToDeleteRows = false;
            this.dataGridViewEstudiantes.AllowUserToOrderColumns = true;
            this.dataGridViewEstudiantes.AutoGenerateColumns = false;
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Column1,
            this.añadirNotas,
            this.eliminar});
            this.dataGridViewEstudiantes.DataSource = this.estudianteBindingSource;
            this.dataGridViewEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(0, 156);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.ReadOnly = true;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(786, 243);
            this.dataGridViewEstudiantes.TabIndex = 41;
            this.dataGridViewEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridViewEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cIDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle31;
            this.cIDataGridViewTextBoxColumn.HeaderText = "Carné de Identidad";
            this.cIDataGridViewTextBoxColumn.Name = "cIDataGridViewTextBoxColumn";
            this.cIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle32;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            this.primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "primerApellido";
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.primerApellidoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle33;
            this.primerApellidoDataGridViewTextBoxColumn.HeaderText = "Primer Apellido";
            this.primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            this.primerApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // segundoApellidoDataGridViewTextBoxColumn
            // 
            this.segundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "segundoApellido";
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.segundoApellidoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle34;
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
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.paisDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle35;
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
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
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.provinciaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle36;
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            this.provinciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modalidadDataGridViewTextBoxColumn
            // 
            this.modalidadDataGridViewTextBoxColumn.DataPropertyName = "modalidad";
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.modalidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle37;
            this.modalidadDataGridViewTextBoxColumn.HeaderText = "modalidad";
            this.modalidadDataGridViewTextBoxColumn.Name = "modalidadDataGridViewTextBoxColumn";
            this.modalidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.modalidadDataGridViewTextBoxColumn.Visible = false;
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
            // Column1
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle38.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle38.NullValue")));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle38;
            this.Column1.HeaderText = "Editar";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // añadirNotas
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle39.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle39.NullValue")));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.añadirNotas.DefaultCellStyle = dataGridViewCellStyle39;
            this.añadirNotas.HeaderText = "Ver Notas";
            this.añadirNotas.Image = ((System.Drawing.Image)(resources.GetObject("añadirNotas.Image")));
            this.añadirNotas.Name = "añadirNotas";
            this.añadirNotas.ReadOnly = true;
            this.añadirNotas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.añadirNotas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eliminar
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle40.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle40.NullValue")));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle40;
            this.eliminar.HeaderText = "Eliminar Estudiante";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.tesisDataSet4;
            // 
            // tesisDataSet4
            // 
            this.tesisDataSet4.DataSetName = "TesisDataSet4";
            this.tesisDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // buscar_estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(786, 399);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.Controls.Add(this.groupControlBuscar);
            this.Name = "buscar_estudiante";
            this.Text = "Buscar Estudiante";
            this.Load += new System.EventHandler(this.buscar_estudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlBuscar)).EndInit();
            this.groupControlBuscar.ResumeLayout(false);
            this.groupBoxCriterios.ResumeLayout(false);
            this.groupBoxCriterios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCarne;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCarne;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private TesisDataSet4 tesisDataSet4;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private TesisDataSet4TableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxCriterios;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn añadirNotas;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}
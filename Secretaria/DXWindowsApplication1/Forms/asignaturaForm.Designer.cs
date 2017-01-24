namespace DXWindowsApplication1
{
    partial class asignaturaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(asignaturaForm));
            this.groupControlDatos = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxTodas = new System.Windows.Forms.GroupBox();
            this.dataGridViewAsignaturas = new System.Windows.Forms.DataGridView();
            this.idAsignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesisDataSet7 = new DXWindowsApplication1.TesisDataSet7();
            this.groupBoxNueva = new System.Windows.Forms.GroupBox();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.lbHoras = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.asignaturaTableAdapter = new DXWindowsApplication1.TesisDataSet7TableAdapters.AsignaturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).BeginInit();
            this.groupControlDatos.SuspendLayout();
            this.groupBoxTodas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet7)).BeginInit();
            this.groupBoxNueva.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlDatos
            // 
            this.groupControlDatos.Controls.Add(this.groupBoxTodas);
            this.groupControlDatos.Controls.Add(this.groupBoxNueva);
            this.groupControlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDatos.Location = new System.Drawing.Point(0, 0);
            this.groupControlDatos.Name = "groupControlDatos";
            this.groupControlDatos.Size = new System.Drawing.Size(640, 356);
            this.groupControlDatos.TabIndex = 2;
            this.groupControlDatos.Text = "Datos de la Asignatura";
            // 
            // groupBoxTodas
            // 
            this.groupBoxTodas.Controls.Add(this.dataGridViewAsignaturas);
            this.groupBoxTodas.Location = new System.Drawing.Point(315, 33);
            this.groupBoxTodas.Name = "groupBoxTodas";
            this.groupBoxTodas.Size = new System.Drawing.Size(313, 310);
            this.groupBoxTodas.TabIndex = 1;
            this.groupBoxTodas.TabStop = false;
            this.groupBoxTodas.Text = "Todas las Asignaturas";
            // 
            // dataGridViewAsignaturas
            // 
            this.dataGridViewAsignaturas.AllowUserToAddRows = false;
            this.dataGridViewAsignaturas.AllowUserToDeleteRows = false;
            this.dataGridViewAsignaturas.AllowUserToOrderColumns = true;
            this.dataGridViewAsignaturas.AutoGenerateColumns = false;
            this.dataGridViewAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsignaturaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.horasDataGridViewTextBoxColumn});
            this.dataGridViewAsignaturas.DataSource = this.asignaturaBindingSource;
            this.dataGridViewAsignaturas.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewAsignaturas.Name = "dataGridViewAsignaturas";
            this.dataGridViewAsignaturas.ReadOnly = true;
            this.dataGridViewAsignaturas.Size = new System.Drawing.Size(300, 282);
            this.dataGridViewAsignaturas.TabIndex = 0;
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
            // asignaturaBindingSource
            // 
            this.asignaturaBindingSource.DataMember = "Asignatura";
            this.asignaturaBindingSource.DataSource = this.tesisDataSet7;
            // 
            // tesisDataSet7
            // 
            this.tesisDataSet7.DataSetName = "TesisDataSet7";
            this.tesisDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxNueva
            // 
            this.groupBoxNueva.Controls.Add(this.textBoxHoras);
            this.groupBoxNueva.Controls.Add(this.lbHoras);
            this.groupBoxNueva.Controls.Add(this.lbDescripcion);
            this.groupBoxNueva.Controls.Add(this.richTextBoxDescripcion);
            this.groupBoxNueva.Controls.Add(this.buttonAceptar);
            this.groupBoxNueva.Controls.Add(this.textBoxNombre);
            this.groupBoxNueva.Controls.Add(this.lbNombre);
            this.groupBoxNueva.Location = new System.Drawing.Point(12, 33);
            this.groupBoxNueva.Name = "groupBoxNueva";
            this.groupBoxNueva.Size = new System.Drawing.Size(297, 310);
            this.groupBoxNueva.TabIndex = 0;
            this.groupBoxNueva.TabStop = false;
            this.groupBoxNueva.Text = "Nueva Asignatura";
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.Location = new System.Drawing.Point(89, 62);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(202, 21);
            this.textBoxHoras.TabIndex = 2;
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Location = new System.Drawing.Point(17, 70);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(66, 13);
            this.lbHoras.TabIndex = 2;
            this.lbHoras.Text = "Total Horas:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(18, 107);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(65, 13);
            this.lbDescripcion.TabIndex = 2;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(89, 107);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(202, 166);
            this.richTextBoxDescripcion.TabIndex = 2;
            this.richTextBoxDescripcion.Text = "";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(216, 279);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(89, 26);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(202, 21);
            this.textBoxNombre.TabIndex = 1;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(35, 34);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(48, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // asignaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 356);
            this.Controls.Add(this.groupControlDatos);
            this.Name = "asignaturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Asignatura";
            this.Load += new System.EventHandler(this.asignaturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).EndInit();
            this.groupControlDatos.ResumeLayout(false);
            this.groupBoxTodas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet7)).EndInit();
            this.groupBoxNueva.ResumeLayout(false);
            this.groupBoxNueva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDatos;
        private System.Windows.Forms.GroupBox groupBoxTodas;
        private System.Windows.Forms.GroupBox groupBoxNueva;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.DataGridView dataGridViewAsignaturas;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.Label lbHoras;
        private TesisDataSet7 tesisDataSet7;
        private System.Windows.Forms.BindingSource asignaturaBindingSource;
        private TesisDataSet7TableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
    }
}
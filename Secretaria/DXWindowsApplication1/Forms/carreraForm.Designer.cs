namespace DXWindowsApplication1
{
    partial class carreraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carreraForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControlDatos = new DevExpress.XtraEditors.GroupControl();
            this.groupBoxNueva = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxFacultad = new System.Windows.Forms.ComboBox();
            this.lbFacultad = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.groupBoxCarreras = new System.Windows.Forms.GroupBox();
            this.dataGridViewCarreras = new System.Windows.Forms.DataGridView();
            this.idCArreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFacultadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesisDataSet2 = new DXWindowsApplication1.TesisDataSet2();
            this.tesisDataSet = new DXWindowsApplication1.TesisDataSet();
            this.tesisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carreraTableAdapter = new DXWindowsApplication1.TesisDataSet2TableAdapters.CarreraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).BeginInit();
            this.groupControlDatos.SuspendLayout();
            this.groupBoxNueva.SuspendLayout();
            this.groupBoxCarreras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlDatos
            // 
            this.groupControlDatos.Controls.Add(this.groupBoxNueva);
            this.groupControlDatos.Controls.Add(this.groupBoxCarreras);
            this.groupControlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDatos.Location = new System.Drawing.Point(0, 0);
            this.groupControlDatos.Name = "groupControlDatos";
            this.groupControlDatos.Size = new System.Drawing.Size(423, 376);
            this.groupControlDatos.TabIndex = 0;
            this.groupControlDatos.Text = "Datos de la Carrera";
            // 
            // groupBoxNueva
            // 
            this.groupBoxNueva.Controls.Add(this.buttonCancelar);
            this.groupBoxNueva.Controls.Add(this.comboBoxFacultad);
            this.groupBoxNueva.Controls.Add(this.lbFacultad);
            this.groupBoxNueva.Controls.Add(this.textBoxNombre);
            this.groupBoxNueva.Controls.Add(this.buttonAceptar);
            this.groupBoxNueva.Controls.Add(this.lbNombre);
            this.groupBoxNueva.Location = new System.Drawing.Point(68, 24);
            this.groupBoxNueva.Name = "groupBoxNueva";
            this.groupBoxNueva.Size = new System.Drawing.Size(293, 134);
            this.groupBoxNueva.TabIndex = 8;
            this.groupBoxNueva.TabStop = false;
            this.groupBoxNueva.Text = "Nueva Carrera";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(179, 100);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // comboBoxFacultad
            // 
            this.comboBoxFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultad.FormattingEnabled = true;
            this.comboBoxFacultad.Location = new System.Drawing.Point(89, 61);
            this.comboBoxFacultad.Name = "comboBoxFacultad";
            this.comboBoxFacultad.Size = new System.Drawing.Size(171, 21);
            this.comboBoxFacultad.TabIndex = 10;
            // 
            // lbFacultad
            // 
            this.lbFacultad.AutoSize = true;
            this.lbFacultad.Location = new System.Drawing.Point(25, 69);
            this.lbFacultad.Name = "lbFacultad";
            this.lbFacultad.Size = new System.Drawing.Size(58, 13);
            this.lbFacultad.TabIndex = 9;
            this.lbFacultad.Text = "* Facultad:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(89, 19);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(171, 20);
            this.textBoxNombre.TabIndex = 8;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAceptar.Location = new System.Drawing.Point(98, 100);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(29, 26);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(54, 13);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "* Nombre:";
            // 
            // groupBoxCarreras
            // 
            this.groupBoxCarreras.Controls.Add(this.dataGridViewCarreras);
            this.groupBoxCarreras.Location = new System.Drawing.Point(137, 173);
            this.groupBoxCarreras.Name = "groupBoxCarreras";
            this.groupBoxCarreras.Size = new System.Drawing.Size(158, 180);
            this.groupBoxCarreras.TabIndex = 7;
            this.groupBoxCarreras.TabStop = false;
            this.groupBoxCarreras.Text = "Carreras Existentes";
            // 
            // dataGridViewCarreras
            // 
            this.dataGridViewCarreras.AllowUserToAddRows = false;
            this.dataGridViewCarreras.AllowUserToDeleteRows = false;
            this.dataGridViewCarreras.AutoGenerateColumns = false;
            this.dataGridViewCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCArreraDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.idFacultadDataGridViewTextBoxColumn});
            this.dataGridViewCarreras.DataSource = this.carreraBindingSource;
            this.dataGridViewCarreras.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewCarreras.Name = "dataGridViewCarreras";
            this.dataGridViewCarreras.ReadOnly = true;
            this.dataGridViewCarreras.Size = new System.Drawing.Size(144, 150);
            this.dataGridViewCarreras.TabIndex = 6;
            // 
            // idCArreraDataGridViewTextBoxColumn
            // 
            this.idCArreraDataGridViewTextBoxColumn.DataPropertyName = "IdCArrera";
            this.idCArreraDataGridViewTextBoxColumn.HeaderText = "IdCArrera";
            this.idCArreraDataGridViewTextBoxColumn.Name = "idCArreraDataGridViewTextBoxColumn";
            this.idCArreraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCArreraDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFacultadDataGridViewTextBoxColumn
            // 
            this.idFacultadDataGridViewTextBoxColumn.DataPropertyName = "idFacultad";
            this.idFacultadDataGridViewTextBoxColumn.HeaderText = "idFacultad";
            this.idFacultadDataGridViewTextBoxColumn.Name = "idFacultadDataGridViewTextBoxColumn";
            this.idFacultadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFacultadDataGridViewTextBoxColumn.Visible = false;
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
            // tesisDataSet
            // 
            this.tesisDataSet.DataSetName = "TesisDataSet";
            this.tesisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tesisDataSetBindingSource
            // 
            this.tesisDataSetBindingSource.DataSource = this.tesisDataSet;
            this.tesisDataSetBindingSource.Position = 0;
            // 
            // carreraTableAdapter
            // 
            this.carreraTableAdapter.ClearBeforeFill = true;
            // 
            // carreraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 376);
            this.Controls.Add(this.groupControlDatos);
            this.Name = "carreraForm";
            this.Text = "Nueva Carrera";
            this.Load += new System.EventHandler(this.carreraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDatos)).EndInit();
            this.groupControlDatos.ResumeLayout(false);
            this.groupBoxNueva.ResumeLayout(false);
            this.groupBoxNueva.PerformLayout();
            this.groupBoxCarreras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesisDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDatos;
        private System.Windows.Forms.GroupBox groupBoxCarreras;
        private System.Windows.Forms.DataGridView dataGridViewCarreras;
        private TesisDataSet tesisDataSet;
        private System.Windows.Forms.BindingSource tesisDataSetBindingSource;
        private TesisDataSet2 tesisDataSet2;
        private System.Windows.Forms.BindingSource carreraBindingSource;
        private TesisDataSet2TableAdapters.CarreraTableAdapter carreraTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxNueva;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxFacultad;
        private System.Windows.Forms.Label lbFacultad;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCArreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacultadDataGridViewTextBoxColumn;
    }
}
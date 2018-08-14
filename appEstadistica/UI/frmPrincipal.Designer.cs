namespace appEstadistica.UI
{
    partial class frmPrincipal
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
            this.btnAnadir1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMedia1 = new System.Windows.Forms.Label();
            this.lblVarianza1 = new System.Windows.Forms.Label();
            this.lblDesviacion1 = new System.Windows.Forms.Label();
            this.lblZetaUno1 = new System.Windows.Forms.Label();
            this.lblZetaDos1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuPxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dato1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsValor = new appEstadistica.dsValor();
            this.nudValor1 = new System.Windows.Forms.NumericUpDown();
            this.nudValor2 = new System.Windows.Forms.NumericUpDown();
            this.dgvEstacion2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dato2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblZetaDos2 = new System.Windows.Forms.Label();
            this.lblZetaUno2 = new System.Windows.Forms.Label();
            this.lblDesviacion2 = new System.Windows.Forms.Label();
            this.lblVarianza2 = new System.Windows.Forms.Label();
            this.lblMedia2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAnadir2 = new System.Windows.Forms.Button();
            this.dato1TableAdapter = new appEstadistica.dsValorTableAdapters.dato1TableAdapter();
            this.dato2TableAdapter = new appEstadistica.dsValorTableAdapters.dato2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dato1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dato2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnadir1
            // 
            this.btnAnadir1.Location = new System.Drawing.Point(214, 17);
            this.btnAnadir1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnadir1.Name = "btnAnadir1";
            this.btnAnadir1.Size = new System.Drawing.Size(107, 28);
            this.btnAnadir1.TabIndex = 0;
            this.btnAnadir1.Text = "Anadir";
            this.btnAnadir1.UseVisualStyleBackColor = true;
            this.btnAnadir1.Click += new System.EventHandler(this.btnAnadir1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1091, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Media muestral:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1091, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varianza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1091, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desviacion estandar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1091, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "X1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1091, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "X2:";
            // 
            // lblMedia1
            // 
            this.lblMedia1.AutoSize = true;
            this.lblMedia1.Location = new System.Drawing.Point(1241, 65);
            this.lblMedia1.Name = "lblMedia1";
            this.lblMedia1.Size = new System.Drawing.Size(46, 17);
            this.lblMedia1.TabIndex = 7;
            this.lblMedia1.Text = "label6";
            // 
            // lblVarianza1
            // 
            this.lblVarianza1.AutoSize = true;
            this.lblVarianza1.Location = new System.Drawing.Point(1241, 111);
            this.lblVarianza1.Name = "lblVarianza1";
            this.lblVarianza1.Size = new System.Drawing.Size(46, 17);
            this.lblVarianza1.TabIndex = 8;
            this.lblVarianza1.Text = "label7";
            // 
            // lblDesviacion1
            // 
            this.lblDesviacion1.AutoSize = true;
            this.lblDesviacion1.Location = new System.Drawing.Point(1241, 152);
            this.lblDesviacion1.Name = "lblDesviacion1";
            this.lblDesviacion1.Size = new System.Drawing.Size(46, 17);
            this.lblDesviacion1.TabIndex = 9;
            this.lblDesviacion1.Text = "label8";
            // 
            // lblZetaUno1
            // 
            this.lblZetaUno1.AutoSize = true;
            this.lblZetaUno1.Location = new System.Drawing.Point(1241, 195);
            this.lblZetaUno1.Name = "lblZetaUno1";
            this.lblZetaUno1.Size = new System.Drawing.Size(46, 17);
            this.lblZetaUno1.TabIndex = 10;
            this.lblZetaUno1.Text = "label9";
            // 
            // lblZetaDos1
            // 
            this.lblZetaDos1.AutoSize = true;
            this.lblZetaDos1.Location = new System.Drawing.Point(1241, 233);
            this.lblZetaDos1.Name = "lblZetaDos1";
            this.lblZetaDos1.Size = new System.Drawing.Size(54, 17);
            this.lblZetaDos1.TabIndex = 11;
            this.lblZetaDos1.Text = "label10";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDatoDataGridViewTextBoxColumn,
            this.idEstacionDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.frecuenciaDataGridViewTextBoxColumn,
            this.probabilidadDataGridViewTextBoxColumn,
            this.xPxDataGridViewTextBoxColumn,
            this.xuPxDataGridViewTextBoxColumn,
            this.btnSave1,
            this.btnBorrar});
            this.dataGridView1.DataSource = this.dato1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 400);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDatoDataGridViewTextBoxColumn
            // 
            this.idDatoDataGridViewTextBoxColumn.DataPropertyName = "idDato";
            this.idDatoDataGridViewTextBoxColumn.HeaderText = "idDato";
            this.idDatoDataGridViewTextBoxColumn.Name = "idDatoDataGridViewTextBoxColumn";
            this.idDatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDatoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEstacionDataGridViewTextBoxColumn
            // 
            this.idEstacionDataGridViewTextBoxColumn.DataPropertyName = "idEstacion";
            this.idEstacionDataGridViewTextBoxColumn.HeaderText = "idEstacion";
            this.idEstacionDataGridViewTextBoxColumn.Name = "idEstacionDataGridViewTextBoxColumn";
            this.idEstacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // frecuenciaDataGridViewTextBoxColumn
            // 
            this.frecuenciaDataGridViewTextBoxColumn.DataPropertyName = "frecuencia";
            this.frecuenciaDataGridViewTextBoxColumn.HeaderText = "Frecuencia absoluta";
            this.frecuenciaDataGridViewTextBoxColumn.Name = "frecuenciaDataGridViewTextBoxColumn";
            // 
            // probabilidadDataGridViewTextBoxColumn
            // 
            this.probabilidadDataGridViewTextBoxColumn.DataPropertyName = "probabilidad";
            this.probabilidadDataGridViewTextBoxColumn.HeaderText = "Probabilidad";
            this.probabilidadDataGridViewTextBoxColumn.Name = "probabilidadDataGridViewTextBoxColumn";
            this.probabilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xPxDataGridViewTextBoxColumn
            // 
            this.xPxDataGridViewTextBoxColumn.DataPropertyName = "xPx";
            this.xPxDataGridViewTextBoxColumn.HeaderText = "xP(x)";
            this.xPxDataGridViewTextBoxColumn.Name = "xPxDataGridViewTextBoxColumn";
            this.xPxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xuPxDataGridViewTextBoxColumn
            // 
            this.xuPxDataGridViewTextBoxColumn.DataPropertyName = "xuPx";
            this.xuPxDataGridViewTextBoxColumn.HeaderText = "((x-u)^2)P(x)";
            this.xuPxDataGridViewTextBoxColumn.Name = "xuPxDataGridViewTextBoxColumn";
            this.xuPxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnSave1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.btnSave1.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnSave1.HeaderText = "Guardar";
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Text = "Guardar";
            this.btnSave1.UseColumnTextForButtonValue = true;
            // 
            // btnBorrar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.btnBorrar.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnBorrar.HeaderText = "Borrar";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            // 
            // dato1BindingSource
            // 
            this.dato1BindingSource.DataMember = "dato1";
            this.dato1BindingSource.DataSource = this.dsValor;
            // 
            // dsValor
            // 
            this.dsValor.DataSetName = "dsValor";
            this.dsValor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nudValor1
            // 
            this.nudValor1.DecimalPlaces = 4;
            this.nudValor1.Location = new System.Drawing.Point(37, 17);
            this.nudValor1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudValor1.Name = "nudValor1";
            this.nudValor1.Size = new System.Drawing.Size(120, 22);
            this.nudValor1.TabIndex = 13;
            // 
            // nudValor2
            // 
            this.nudValor2.DecimalPlaces = 4;
            this.nudValor2.Location = new System.Drawing.Point(37, 493);
            this.nudValor2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudValor2.Name = "nudValor2";
            this.nudValor2.Size = new System.Drawing.Size(120, 22);
            this.nudValor2.TabIndex = 26;
            // 
            // dgvEstacion2
            // 
            this.dgvEstacion2.AllowUserToAddRows = false;
            this.dgvEstacion2.AutoGenerateColumns = false;
            this.dgvEstacion2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstacion2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dgvEstacion2.DataSource = this.dato2BindingSource;
            this.dgvEstacion2.Location = new System.Drawing.Point(37, 541);
            this.dgvEstacion2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEstacion2.Name = "dgvEstacion2";
            this.dgvEstacion2.RowTemplate.Height = 28;
            this.dgvEstacion2.Size = new System.Drawing.Size(1048, 400);
            this.dgvEstacion2.TabIndex = 25;
            this.dgvEstacion2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstacion2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDato";
            this.dataGridViewTextBoxColumn1.HeaderText = "idDato";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idEstacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "idEstacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "frecuencia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Frecuencia absoluta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "probabilidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Probabilidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "xPx";
            this.dataGridViewTextBoxColumn6.HeaderText = "xP(x)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "xuPx";
            this.dataGridViewTextBoxColumn7.HeaderText = "((x-u)^2)P(x)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewButtonColumn1.HeaderText = "Guardar";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Guardar";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewButtonColumn2.HeaderText = "Borrar";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Borrar";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // dato2BindingSource
            // 
            this.dato2BindingSource.DataMember = "dato2";
            this.dato2BindingSource.DataSource = this.dsValor;
            // 
            // lblZetaDos2
            // 
            this.lblZetaDos2.AutoSize = true;
            this.lblZetaDos2.Location = new System.Drawing.Point(1241, 709);
            this.lblZetaDos2.Name = "lblZetaDos2";
            this.lblZetaDos2.Size = new System.Drawing.Size(54, 17);
            this.lblZetaDos2.TabIndex = 24;
            this.lblZetaDos2.Text = "label10";
            // 
            // lblZetaUno2
            // 
            this.lblZetaUno2.AutoSize = true;
            this.lblZetaUno2.Location = new System.Drawing.Point(1241, 671);
            this.lblZetaUno2.Name = "lblZetaUno2";
            this.lblZetaUno2.Size = new System.Drawing.Size(46, 17);
            this.lblZetaUno2.TabIndex = 23;
            this.lblZetaUno2.Text = "label9";
            // 
            // lblDesviacion2
            // 
            this.lblDesviacion2.AutoSize = true;
            this.lblDesviacion2.Location = new System.Drawing.Point(1241, 628);
            this.lblDesviacion2.Name = "lblDesviacion2";
            this.lblDesviacion2.Size = new System.Drawing.Size(46, 17);
            this.lblDesviacion2.TabIndex = 22;
            this.lblDesviacion2.Text = "label8";
            // 
            // lblVarianza2
            // 
            this.lblVarianza2.AutoSize = true;
            this.lblVarianza2.Location = new System.Drawing.Point(1241, 587);
            this.lblVarianza2.Name = "lblVarianza2";
            this.lblVarianza2.Size = new System.Drawing.Size(46, 17);
            this.lblVarianza2.TabIndex = 21;
            this.lblVarianza2.Text = "label7";
            // 
            // lblMedia2
            // 
            this.lblMedia2.AutoSize = true;
            this.lblMedia2.Location = new System.Drawing.Point(1241, 541);
            this.lblMedia2.Name = "lblMedia2";
            this.lblMedia2.Size = new System.Drawing.Size(46, 17);
            this.lblMedia2.TabIndex = 20;
            this.lblMedia2.Text = "label6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1091, 709);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "X2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1091, 671);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "X1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1091, 628);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Desviacion estandar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1091, 587);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Varianza:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1091, 541);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Media muestral:";
            // 
            // btnAnadir2
            // 
            this.btnAnadir2.Location = new System.Drawing.Point(214, 493);
            this.btnAnadir2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnadir2.Name = "btnAnadir2";
            this.btnAnadir2.Size = new System.Drawing.Size(107, 28);
            this.btnAnadir2.TabIndex = 14;
            this.btnAnadir2.Text = "Anadir";
            this.btnAnadir2.UseVisualStyleBackColor = true;
            this.btnAnadir2.Click += new System.EventHandler(this.btnAnadir2_Click);
            // 
            // dato1TableAdapter
            // 
            this.dato1TableAdapter.ClearBeforeFill = true;
            // 
            // dato2TableAdapter
            // 
            this.dato2TableAdapter.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 1055);
            this.Controls.Add(this.nudValor2);
            this.Controls.Add(this.dgvEstacion2);
            this.Controls.Add(this.lblZetaDos2);
            this.Controls.Add(this.lblZetaUno2);
            this.Controls.Add(this.lblDesviacion2);
            this.Controls.Add(this.lblVarianza2);
            this.Controls.Add(this.lblMedia2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAnadir2);
            this.Controls.Add(this.nudValor1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblZetaDos1);
            this.Controls.Add(this.lblZetaUno1);
            this.Controls.Add(this.lblDesviacion1);
            this.Controls.Add(this.lblVarianza1);
            this.Controls.Add(this.lblMedia1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnadir1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "Estaciones";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dato1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dato2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnadir1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMedia1;
        private System.Windows.Forms.Label lblVarianza1;
        private System.Windows.Forms.Label lblDesviacion1;
        private System.Windows.Forms.Label lblZetaUno1;
        private System.Windows.Forms.Label lblZetaDos1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsValor dsValor;
        private System.Windows.Forms.BindingSource dato1BindingSource;
        private dsValorTableAdapters.dato1TableAdapter dato1TableAdapter;
        private System.Windows.Forms.NumericUpDown nudValor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuPxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnSave1;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private System.Windows.Forms.NumericUpDown nudValor2;
        private System.Windows.Forms.DataGridView dgvEstacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Label lblZetaDos2;
        private System.Windows.Forms.Label lblZetaUno2;
        private System.Windows.Forms.Label lblDesviacion2;
        private System.Windows.Forms.Label lblVarianza2;
        private System.Windows.Forms.Label lblMedia2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAnadir2;
        private System.Windows.Forms.BindingSource dato2BindingSource;
        private dsValorTableAdapters.dato2TableAdapter dato2TableAdapter;
    }
}
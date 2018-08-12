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
            this.dato1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsValor = new appEstadistica.dsValor();
            this.datoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dato1TableAdapter = new appEstadistica.dsValorTableAdapters.dato1TableAdapter();
            this.nudValor1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dato1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(624, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Media muestral:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varianza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desviacion estandar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Z2:";
            // 
            // lblMedia1
            // 
            this.lblMedia1.AutoSize = true;
            this.lblMedia1.Location = new System.Drawing.Point(774, 65);
            this.lblMedia1.Name = "lblMedia1";
            this.lblMedia1.Size = new System.Drawing.Size(46, 17);
            this.lblMedia1.TabIndex = 7;
            this.lblMedia1.Text = "label6";
            // 
            // lblVarianza1
            // 
            this.lblVarianza1.AutoSize = true;
            this.lblVarianza1.Location = new System.Drawing.Point(774, 111);
            this.lblVarianza1.Name = "lblVarianza1";
            this.lblVarianza1.Size = new System.Drawing.Size(46, 17);
            this.lblVarianza1.TabIndex = 8;
            this.lblVarianza1.Text = "label7";
            // 
            // lblDesviacion1
            // 
            this.lblDesviacion1.AutoSize = true;
            this.lblDesviacion1.Location = new System.Drawing.Point(774, 152);
            this.lblDesviacion1.Name = "lblDesviacion1";
            this.lblDesviacion1.Size = new System.Drawing.Size(46, 17);
            this.lblDesviacion1.TabIndex = 9;
            this.lblDesviacion1.Text = "label8";
            // 
            // lblZetaUno1
            // 
            this.lblZetaUno1.AutoSize = true;
            this.lblZetaUno1.Location = new System.Drawing.Point(774, 195);
            this.lblZetaUno1.Name = "lblZetaUno1";
            this.lblZetaUno1.Size = new System.Drawing.Size(46, 17);
            this.lblZetaUno1.TabIndex = 10;
            this.lblZetaUno1.Text = "label9";
            // 
            // lblZetaDos1
            // 
            this.lblZetaDos1.AutoSize = true;
            this.lblZetaDos1.Location = new System.Drawing.Point(774, 233);
            this.lblZetaDos1.Name = "lblZetaDos1";
            this.lblZetaDos1.Size = new System.Drawing.Size(54, 17);
            this.lblZetaDos1.TabIndex = 11;
            this.lblZetaDos1.Text = "label10";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDatoDataGridViewTextBoxColumn,
            this.idEstacionDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.frecuenciaDataGridViewTextBoxColumn,
            this.probabilidadDataGridViewTextBoxColumn,
            this.xPxDataGridViewTextBoxColumn,
            this.xuPxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dato1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(544, 178);
            this.dataGridView1.TabIndex = 12;
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
            // 
            // xPxDataGridViewTextBoxColumn
            // 
            this.xPxDataGridViewTextBoxColumn.DataPropertyName = "xPx";
            this.xPxDataGridViewTextBoxColumn.HeaderText = "xP(x)";
            this.xPxDataGridViewTextBoxColumn.Name = "xPxDataGridViewTextBoxColumn";
            // 
            // xuPxDataGridViewTextBoxColumn
            // 
            this.xuPxDataGridViewTextBoxColumn.DataPropertyName = "xuPx";
            this.xuPxDataGridViewTextBoxColumn.HeaderText = "((x-u)^2)P(x)";
            this.xuPxDataGridViewTextBoxColumn.Name = "xuPxDataGridViewTextBoxColumn";
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
            // datoBindingSource
            // 
            this.datoBindingSource.DataMember = "dato";
            this.datoBindingSource.DataSource = this.dsValor;
            // 
            // dato1TableAdapter
            // 
            this.dato1TableAdapter.ClearBeforeFill = true;
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 295);
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
        private System.Windows.Forms.BindingSource datoBindingSource;
        private System.Windows.Forms.BindingSource dato1BindingSource;
        private dsValorTableAdapters.dato1TableAdapter dato1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuPxDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown nudValor1;
    }
}
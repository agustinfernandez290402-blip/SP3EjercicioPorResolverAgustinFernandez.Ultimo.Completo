namespace SP3EjercicioPorResolverAgustinFernandez
{
    partial class frmGestiónRepuesto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMarca = new Label();
            cmbMarcaCarga = new ComboBox();
            rbImportado = new RadioButton();
            rbNacional = new RadioButton();
            lblNúmero = new Label();
            txtNumero = new TextBox();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblDescripción = new Label();
            textBox1 = new TextBox();
            btnRegistrar = new Button();
            pageRegisto = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnConsultar = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            colNro = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colDescripción = new DataGridViewTextBoxColumn();
            label2 = new Label();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            radioButton2 = new RadioButton();
            label4 = new Label();
            btnSalir = new Button();
            pageRegisto.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(11, 31);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // cmbMarcaCarga
            // 
            cmbMarcaCarga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarcaCarga.FormattingEnabled = true;
            cmbMarcaCarga.Location = new Point(90, 27);
            cmbMarcaCarga.Name = "cmbMarcaCarga";
            cmbMarcaCarga.Size = new Size(159, 23);
            cmbMarcaCarga.TabIndex = 1;
            cmbMarcaCarga.SelectedIndexChanged += cmbMarcaCarga_SelectedIndexChanged;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(168, 93);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(81, 19);
            rbImportado.TabIndex = 1;
            rbImportado.TabStop = true;
            rbImportado.Text = "Importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(90, 93);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(72, 19);
            rbNacional.TabIndex = 0;
            rbNacional.TabStop = true;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // lblNúmero
            // 
            lblNúmero.AutoSize = true;
            lblNúmero.Location = new Point(12, 63);
            lblNúmero.Name = "lblNúmero";
            lblNúmero.Size = new Size(73, 15);
            lblNúmero.TabIndex = 3;
            lblNúmero.Text = "Nº Repuesto";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(90, 60);
            txtNumero.MaxLength = 6;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(159, 23);
            txtNumero.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(90, 127);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(162, 23);
            txtPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(15, 127);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripción
            // 
            lblDescripción.AutoSize = true;
            lblDescripción.Location = new Point(272, 31);
            lblDescripción.Name = "lblDescripción";
            lblDescripción.Size = new Size(69, 15);
            lblDescripción.TabIndex = 8;
            lblDescripción.Text = "Descripción";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 49);
            textBox1.MaxLength = 50;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(113, 101);
            textBox1.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(325, 204);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // pageRegisto
            // 
            pageRegisto.Controls.Add(tabPage1);
            pageRegisto.Controls.Add(tabPage2);
            pageRegisto.Location = new Point(12, 12);
            pageRegisto.Name = "pageRegisto";
            pageRegisto.SelectedIndex = 0;
            pageRegisto.Size = new Size(450, 370);
            pageRegisto.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnRegistrar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(442, 342);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rbImportado);
            groupBox1.Controls.Add(cmbMarcaCarga);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblDescripción);
            groupBox1.Controls.Add(rbNacional);
            groupBox1.Controls.Add(lblMarca);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(lblNúmero);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Location = new Point(19, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 172);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta de Repuestos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 12;
            label1.Text = "Origen";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnConsultar);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(442, 342);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(347, 305);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 13;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(18, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(404, 274);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consulta";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNro, colPrecio, colDescripción });
            dataGridView1.Location = new Point(18, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(365, 164);
            dataGridView1.TabIndex = 11;
            // 
            // colNro
            // 
            colNro.HeaderText = "Nº Repuesto";
            colNro.Name = "colNro";
            colNro.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colDescripción
            // 
            colDescripción.HeaderText = "Descripción";
            colDescripción.Name = "colDescripción";
            colDescripción.ReadOnly = true;
            colDescripción.Width = 170;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 32);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 12;
            label2.Text = "Origen";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(232, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Importado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 23);
            comboBox1.TabIndex = 1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(154, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nacional";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 32);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 0;
            label4.Text = "Marca";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(363, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmGestiónRepuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 426);
            Controls.Add(btnSalir);
            Controls.Add(pageRegisto);
            Name = "frmGestiónRepuesto";
            Text = "Ingreso de Repuestos";
            Load += Form1_Load;
            pageRegisto.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMarca;
        private ComboBox cmbMarcaCarga;
        private RadioButton rbImportado;
        private RadioButton rbNacional;
        private Label lblNúmero;
        private TextBox txtNumero;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblDescripción;
        private TextBox textBox1;
        private Button btnRegistrar;
        private TabControl pageRegisto;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnConsultar;
        private DataGridViewTextBoxColumn colNro;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colDescripción;
        private Button btnSalir;
    }
}

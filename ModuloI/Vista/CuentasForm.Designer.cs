namespace Vista
{
    partial class CuentasForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            SaldoTextBox = new TextBox();
            label6 = new Label();
            CodigoTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            FechaNacimientoDateTimePicker = new DateTimePicker();
            label3 = new Label();
            GeneroComboBox = new ComboBox();
            NombreTextBox = new TextBox();
            label2 = new Label();
            IdentidadTextBox = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            TipoMovimientoComboBox = new ComboBox();
            label8 = new Label();
            MontoTextBox = new TextBox();
            label7 = new Label();
            AperturarButton = new Button();
            AgregarButton = new Button();
            MoviientosListBox = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(FechaNacimientoDateTimePicker);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(GeneroComboBox);
            groupBox1.Controls.Add(NombreTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(IdentidadTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1162, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SaldoTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CodigoTextBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(834, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 125);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Cuenta";
            // 
            // SaldoTextBox
            // 
            SaldoTextBox.Location = new Point(100, 75);
            SaldoTextBox.Name = "SaldoTextBox";
            SaldoTextBox.ReadOnly = true;
            SaldoTextBox.Size = new Size(194, 31);
            SaldoTextBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 81);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 2;
            label6.Text = "Saldo";
            // 
            // CodigoTextBox
            // 
            CodigoTextBox.Location = new Point(100, 38);
            CodigoTextBox.Name = "CodigoTextBox";
            CodigoTextBox.Size = new Size(194, 31);
            CodigoTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 44);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 0;
            label5.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 89);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 7;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // FechaNacimientoDateTimePicker
            // 
            FechaNacimientoDateTimePicker.Format = DateTimePickerFormat.Short;
            FechaNacimientoDateTimePicker.Location = new Point(562, 83);
            FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker";
            FechaNacimientoDateTimePicker.Size = new Size(250, 31);
            FechaNacimientoDateTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 52);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 5;
            label3.Text = "Género:";
            // 
            // GeneroComboBox
            // 
            GeneroComboBox.FormattingEnabled = true;
            GeneroComboBox.Items.AddRange(new object[] { "M", "F" });
            GeneroComboBox.Location = new Point(562, 44);
            GeneroComboBox.Name = "GeneroComboBox";
            GeneroComboBox.Size = new Size(151, 33);
            GeneroComboBox.TabIndex = 4;
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(119, 83);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(237, 31);
            NombreTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 89);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // IdentidadTextBox
            // 
            IdentidadTextBox.Location = new Point(119, 46);
            IdentidadTextBox.Name = "IdentidadTextBox";
            IdentidadTextBox.Size = new Size(237, 31);
            IdentidadTextBox.TabIndex = 1;
            IdentidadTextBox.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 52);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Identidad:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TipoMovimientoComboBox);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(MontoTextBox);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(29, 231);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1135, 107);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Movimiento";
            // 
            // TipoMovimientoComboBox
            // 
            TipoMovimientoComboBox.FormattingEnabled = true;
            TipoMovimientoComboBox.Location = new Point(644, 42);
            TipoMovimientoComboBox.Name = "TipoMovimientoComboBox";
            TipoMovimientoComboBox.Size = new Size(467, 33);
            TipoMovimientoComboBox.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(466, 47);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 2;
            label8.Text = "Tipo Movimiento:";
            // 
            // MontoTextBox
            // 
            MontoTextBox.Location = new Point(121, 44);
            MontoTextBox.Name = "MontoTextBox";
            MontoTextBox.Size = new Size(254, 31);
            MontoTextBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 50);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 0;
            label7.Text = "Monto:";
            // 
            // AperturarButton
            // 
            AperturarButton.Location = new Point(803, 354);
            AperturarButton.Name = "AperturarButton";
            AperturarButton.Size = new Size(141, 44);
            AperturarButton.TabIndex = 2;
            AperturarButton.Text = "Aperturar";
            AperturarButton.UseVisualStyleBackColor = true;
            AperturarButton.Click += AperturarButton_Click;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(970, 354);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(194, 44);
            AgregarButton.TabIndex = 3;
            AgregarButton.Text = "Agregar Movimiento";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // MoviientosListBox
            // 
            MoviientosListBox.FormattingEnabled = true;
            MoviientosListBox.ItemHeight = 25;
            MoviientosListBox.Location = new Point(12, 415);
            MoviientosListBox.Name = "MoviientosListBox";
            MoviientosListBox.Size = new Size(1152, 254);
            MoviientosListBox.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CuentasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 690);
            Controls.Add(MoviientosListBox);
            Controls.Add(AgregarButton);
            Controls.Add(AperturarButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CuentasForm";
            Text = "CuentasForm";
            Load += CuentasForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox NombreTextBox;
        private Label label2;
        private TextBox IdentidadTextBox;
        private Label label1;
        private Label label4;
        private DateTimePicker FechaNacimientoDateTimePicker;
        private Label label3;
        private ComboBox GeneroComboBox;
        private GroupBox groupBox2;
        private TextBox SaldoTextBox;
        private Label label6;
        private TextBox CodigoTextBox;
        private Label label5;
        private GroupBox groupBox3;
        private ComboBox TipoMovimientoComboBox;
        private Label label8;
        private TextBox MontoTextBox;
        private Label label7;
        private Button AperturarButton;
        private Button AgregarButton;
        private ListBox MoviientosListBox;
        private ErrorProvider errorProvider1;
    }
}
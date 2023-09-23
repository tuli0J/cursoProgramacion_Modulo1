namespace Vista
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            NombreLabel = new Label();
            EstaturaLabel = new Label();
            EdadLabel = new Label();
            GeneroLabel = new Label();
            FechaNacimientoLabel = new Label();
            NombreTextBox = new TextBox();
            EdadTextBox = new TextBox();
            EstaturaTextBox = new TextBox();
            GeneroTextBox = new TextBox();
            FechaNacimientoDateTimePicker = new DateTimePicker();
            CrearButton = new Button();
            MostrarButton = new Button();
            PersonasDataGridView = new DataGridView();
            PersonasBindingSource = new BindingSource(components);
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estaturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            generoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PersonasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(151, 29);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(71, 20);
            NombreLabel.TabIndex = 0;
            NombreLabel.Text = "Nombre: ";
            NombreLabel.Click += label1_Click;
            // 
            // EstaturaLabel
            // 
            EstaturaLabel.AutoSize = true;
            EstaturaLabel.Location = new Point(157, 84);
            EstaturaLabel.Name = "EstaturaLabel";
            EstaturaLabel.Size = new Size(65, 20);
            EstaturaLabel.TabIndex = 1;
            EstaturaLabel.Text = "Estatura:";
            EstaturaLabel.Click += EstaturaLabel_Click;
            // 
            // EdadLabel
            // 
            EdadLabel.AutoSize = true;
            EdadLabel.Location = new Point(480, 181);
            EdadLabel.Name = "EdadLabel";
            EdadLabel.Size = new Size(46, 20);
            EdadLabel.TabIndex = 2;
            EdadLabel.Text = "Edad:";
            // 
            // GeneroLabel
            // 
            GeneroLabel.AutoSize = true;
            GeneroLabel.Location = new Point(162, 135);
            GeneroLabel.Name = "GeneroLabel";
            GeneroLabel.Size = new Size(60, 20);
            GeneroLabel.TabIndex = 3;
            GeneroLabel.Text = "Género:";
            // 
            // FechaNacimientoLabel
            // 
            FechaNacimientoLabel.AutoSize = true;
            FechaNacimientoLabel.Location = new Point(70, 181);
            FechaNacimientoLabel.Name = "FechaNacimientoLabel";
            FechaNacimientoLabel.Size = new Size(152, 20);
            FechaNacimientoLabel.TabIndex = 4;
            FechaNacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(247, 29);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(313, 27);
            NombreTextBox.TabIndex = 5;
            // 
            // EdadTextBox
            // 
            EdadTextBox.Location = new Point(551, 174);
            EdadTextBox.Name = "EdadTextBox";
            EdadTextBox.ReadOnly = true;
            EdadTextBox.Size = new Size(119, 27);
            EdadTextBox.TabIndex = 6;
            // 
            // EstaturaTextBox
            // 
            EstaturaTextBox.Location = new Point(247, 77);
            EstaturaTextBox.Name = "EstaturaTextBox";
            EstaturaTextBox.Size = new Size(313, 27);
            EstaturaTextBox.TabIndex = 7;
            // 
            // GeneroTextBox
            // 
            GeneroTextBox.Location = new Point(247, 128);
            GeneroTextBox.Name = "GeneroTextBox";
            GeneroTextBox.Size = new Size(313, 27);
            GeneroTextBox.TabIndex = 8;
            // 
            // FechaNacimientoDateTimePicker
            // 
            FechaNacimientoDateTimePicker.Format = DateTimePickerFormat.Short;
            FechaNacimientoDateTimePicker.Location = new Point(247, 176);
            FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker";
            FechaNacimientoDateTimePicker.Size = new Size(191, 27);
            FechaNacimientoDateTimePicker.TabIndex = 9;
            // 
            // CrearButton
            // 
            CrearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CrearButton.Location = new Point(247, 235);
            CrearButton.Name = "CrearButton";
            CrearButton.Size = new Size(126, 56);
            CrearButton.TabIndex = 10;
            CrearButton.Text = "Agregar";
            CrearButton.UseVisualStyleBackColor = true;
            CrearButton.Click += CrearButton_Click;
            // 
            // MostrarButton
            // 
            MostrarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MostrarButton.Location = new Point(413, 235);
            MostrarButton.Name = "MostrarButton";
            MostrarButton.Size = new Size(126, 56);
            MostrarButton.TabIndex = 11;
            MostrarButton.Text = "Mostrar";
            MostrarButton.UseVisualStyleBackColor = true;
            MostrarButton.Click += MostrarButton_Click;
            // 
            // PersonasDataGridView
            // 
            PersonasDataGridView.AllowUserToAddRows = false;
            PersonasDataGridView.AllowUserToDeleteRows = false;
            PersonasDataGridView.AutoGenerateColumns = false;
            PersonasDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            PersonasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonasDataGridView.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, estaturaDataGridViewTextBoxColumn, edadDataGridViewTextBoxColumn, generoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn });
            PersonasDataGridView.DataSource = PersonasBindingSource;
            PersonasDataGridView.GridColor = SystemColors.HighlightText;
            PersonasDataGridView.Location = new Point(2, 338);
            PersonasDataGridView.Name = "PersonasDataGridView";
            PersonasDataGridView.ReadOnly = true;
            PersonasDataGridView.RowHeadersWidth = 51;
            PersonasDataGridView.RowTemplate.Height = 29;
            PersonasDataGridView.Size = new Size(756, 267);
            PersonasDataGridView.TabIndex = 12;
            // 
            // PersonasBindingSource
            // 
            PersonasBindingSource.DataSource = typeof(Entidades.Persona);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // estaturaDataGridViewTextBoxColumn
            // 
            estaturaDataGridViewTextBoxColumn.DataPropertyName = "Estatura";
            estaturaDataGridViewTextBoxColumn.HeaderText = "Estatura";
            estaturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            estaturaDataGridViewTextBoxColumn.Name = "estaturaDataGridViewTextBoxColumn";
            estaturaDataGridViewTextBoxColumn.ReadOnly = true;
            estaturaDataGridViewTextBoxColumn.Width = 125;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            edadDataGridViewTextBoxColumn.MinimumWidth = 6;
            edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            edadDataGridViewTextBoxColumn.ReadOnly = true;
            edadDataGridViewTextBoxColumn.Width = 125;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            generoDataGridViewTextBoxColumn.ReadOnly = true;
            generoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Nacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            fechaNacimientoDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 608);
            Controls.Add(PersonasDataGridView);
            Controls.Add(MostrarButton);
            Controls.Add(CrearButton);
            Controls.Add(FechaNacimientoDateTimePicker);
            Controls.Add(GeneroTextBox);
            Controls.Add(EstaturaTextBox);
            Controls.Add(EdadTextBox);
            Controls.Add(NombreTextBox);
            Controls.Add(FechaNacimientoLabel);
            Controls.Add(GeneroLabel);
            Controls.Add(EdadLabel);
            Controls.Add(EstaturaLabel);
            Controls.Add(NombreLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PersonasDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreLabel;
        private Label EstaturaLabel;
        private Label EdadLabel;
        private Label GeneroLabel;
        private Label FechaNacimientoLabel;
        private TextBox NombreTextBox;
        private TextBox EdadTextBox;
        private TextBox EstaturaTextBox;
        private TextBox GeneroTextBox;
        private DateTimePicker FechaNacimientoDateTimePicker;
        private Button CrearButton;
        private Button MostrarButton;
        private DataGridView PersonasDataGridView;
        private BindingSource PersonasBindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estaturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
    }
}
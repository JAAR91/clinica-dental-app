namespace clinica_dental
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            AllergyTb = new TextBox();
            GenCb = new ComboBox();
            AddressTb = new TextBox();
            PatPhoneTb = new TextBox();
            PatNameTb = new TextBox();
            label15 = new Label();
            label14 = new Label();
            button1 = new Button();
            DOBDate = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            PatientDGV = new DataGridView();
            FilterTb = new TextBox();
            label16 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 932);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(58, 654);
            label8.Name = "label8";
            label8.Size = new Size(165, 32);
            label8.TabIndex = 8;
            label8.Text = "Cerrar Session";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(58, 351);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 4;
            label4.Text = "Prescipcion";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(58, 269);
            label3.Name = "label3";
            label3.Size = new Size(141, 32);
            label3.TabIndex = 3;
            label3.Text = "Tratamiento";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(58, 188);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 2;
            label2.Text = "Paciente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(58, 97);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 1;
            label1.Text = "Clinica Dental";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(260, 33);
            label9.Name = "label9";
            label9.Size = new Size(123, 40);
            label9.TabIndex = 3;
            label9.Text = "Paciente";
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(AllergyTb);
            panel2.Controls.Add(GenCb);
            panel2.Controls.Add(AddressTb);
            panel2.Controls.Add(PatPhoneTb);
            panel2.Controls.Add(PatNameTb);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(DOBDate);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(244, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(1147, 345);
            panel2.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(511, 265);
            button3.Name = "button3";
            button3.Size = new Size(144, 45);
            button3.TabIndex = 17;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(661, 265);
            button2.Name = "button2";
            button2.Size = new Size(144, 45);
            button2.TabIndex = 16;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AllergyTb
            // 
            AllergyTb.BorderStyle = BorderStyle.FixedSingle;
            AllergyTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllergyTb.Location = new Point(748, 135);
            AllergyTb.Multiline = true;
            AllergyTb.Name = "AllergyTb";
            AllergyTb.Size = new Size(356, 77);
            AllergyTb.TabIndex = 15;
            // 
            // GenCb
            // 
            GenCb.AllowDrop = true;
            GenCb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male", "Female" });
            GenCb.Location = new Point(750, 83);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(354, 33);
            GenCb.TabIndex = 15;
            // 
            // AddressTb
            // 
            AddressTb.BorderStyle = BorderStyle.FixedSingle;
            AddressTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTb.Location = new Point(119, 137);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(384, 77);
            AddressTb.TabIndex = 14;
            // 
            // PatPhoneTb
            // 
            PatPhoneTb.BorderStyle = BorderStyle.FixedSingle;
            PatPhoneTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatPhoneTb.Location = new Point(119, 83);
            PatPhoneTb.Name = "PatPhoneTb";
            PatPhoneTb.Size = new Size(384, 33);
            PatPhoneTb.TabIndex = 13;
            // 
            // PatNameTb
            // 
            PatNameTb.BorderStyle = BorderStyle.FixedSingle;
            PatNameTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatNameTb.Location = new Point(119, 28);
            PatNameTb.Name = "PatNameTb";
            PatNameTb.Size = new Size(384, 33);
            PatNameTb.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(535, 81);
            label15.Name = "label15";
            label15.Size = new Size(80, 30);
            label15.TabIndex = 11;
            label15.Text = "Genero";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(24, 135);
            label14.Name = "label14";
            label14.Size = new Size(87, 30);
            label14.TabIndex = 10;
            label14.Text = "Address";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(361, 265);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DOBDate
            // 
            DOBDate.CalendarFont = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBDate.Format = DateTimePickerFormat.Short;
            DOBDate.Location = new Point(750, 26);
            DOBDate.Name = "DOBDate";
            DOBDate.Size = new Size(354, 33);
            DOBDate.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(535, 135);
            label13.Name = "label13";
            label13.Size = new Size(87, 30);
            label13.TabIndex = 4;
            label13.Text = "Alergias";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(535, 28);
            label12.Name = "label12";
            label12.Size = new Size(209, 30);
            label12.TabIndex = 3;
            label12.Text = "Fecha de Nacimiento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(24, 81);
            label11.Name = "label11";
            label11.Size = new Size(92, 30);
            label11.TabIndex = 2;
            label11.Text = "Telefono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(24, 25);
            label10.Name = "label10";
            label10.Size = new Size(89, 30);
            label10.TabIndex = 0;
            label10.Text = "Nombre";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // PatientDGV
            // 
            PatientDGV.AllowUserToAddRows = false;
            PatientDGV.AllowUserToDeleteRows = false;
            PatientDGV.BackgroundColor = SystemColors.ButtonHighlight;
            PatientDGV.BorderStyle = BorderStyle.None;
            PatientDGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            PatientDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PatientDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PatientDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            PatientDGV.DefaultCellStyle = dataGridViewCellStyle2;
            PatientDGV.GridColor = SystemColors.Menu;
            PatientDGV.Location = new Point(244, 507);
            PatientDGV.Name = "PatientDGV";
            PatientDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            PatientDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            PatientDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PatientDGV.Size = new Size(1147, 411);
            PatientDGV.TabIndex = 7;
            PatientDGV.CellContentClick += PatientDGV_CellContentClick;
            // 
            // FilterTb
            // 
            FilterTb.BackColor = SystemColors.Window;
            FilterTb.BorderStyle = BorderStyle.FixedSingle;
            FilterTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterTb.Location = new Point(498, 452);
            FilterTb.Name = "FilterTb";
            FilterTb.Size = new Size(358, 33);
            FilterTb.TabIndex = 16;
            FilterTb.TextChanged += FilterTb_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(244, 445);
            label16.Name = "label16";
            label16.Size = new Size(248, 40);
            label16.TabIndex = 15;
            label16.Text = "Filtro por Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(61, 589);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 9;
            label7.Text = "Panel";
            label7.Click += label7_Click;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 930);
            Controls.Add(FilterTb);
            Controls.Add(label16);
            Controls.Add(PatientDGV);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            Text = "Patient";
            Load += Patient_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label9;
        private Panel panel2;
        private Label label15;
        private Label label14;
        private DateTimePicker DOBDate;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox AddressTb;
        private TextBox PatPhoneTb;
        private TextBox PatNameTb;
        private TextBox AllergyTb;
        private ComboBox GenCb;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView PatientDGV;
        private Button button2;
        private Button button3;
        private Button button1;
        private TextBox FilterTb;
        private Label label16;
        private Label label7;
    }
}
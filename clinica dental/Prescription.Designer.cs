namespace clinica_dental
{
    partial class Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescription));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            Pquantity = new TextBox();
            Pcost = new TextBox();
            Ppatient = new ComboBox();
            Pmeds = new TextBox();
            Ptreatment = new TextBox();
            label15 = new Label();
            label14 = new Label();
            button1 = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label16 = new Label();
            PrescriptionDGV = new DataGridView();
            FilterTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrescriptionDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 932);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(60, 583);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 7;
            label7.Text = "Panel";
            label7.Click += label7_Click;
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
            label2.Click += label2_Click;
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
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(Pquantity);
            panel2.Controls.Add(Pcost);
            panel2.Controls.Add(Ppatient);
            panel2.Controls.Add(Pmeds);
            panel2.Controls.Add(Ptreatment);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(249, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1147, 251);
            panel2.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(806, 152);
            button3.Name = "button3";
            button3.Size = new Size(144, 45);
            button3.TabIndex = 21;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(956, 152);
            button2.Name = "button2";
            button2.Size = new Size(144, 45);
            button2.TabIndex = 20;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Pquantity
            // 
            Pquantity.BorderStyle = BorderStyle.FixedSingle;
            Pquantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pquantity.Location = new Point(725, 78);
            Pquantity.Name = "Pquantity";
            Pquantity.Size = new Size(411, 33);
            Pquantity.TabIndex = 17;
            // 
            // Pcost
            // 
            Pcost.BorderStyle = BorderStyle.FixedSingle;
            Pcost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pcost.Location = new Point(725, 19);
            Pcost.Name = "Pcost";
            Pcost.Size = new Size(411, 33);
            Pcost.TabIndex = 16;
            // 
            // Ppatient
            // 
            Ppatient.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ppatient.FormattingEnabled = true;
            Ppatient.Location = new Point(202, 18);
            Ppatient.Name = "Ppatient";
            Ppatient.Size = new Size(358, 33);
            Ppatient.TabIndex = 15;
            Ppatient.SelectedIndexChanged += Ppatient_SelectedIndexChanged;
            Ppatient.TextChanged += Ppatient_SelectedIndexChanged;
            // 
            // Pmeds
            // 
            Pmeds.BorderStyle = BorderStyle.FixedSingle;
            Pmeds.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pmeds.Location = new Point(202, 137);
            Pmeds.Multiline = true;
            Pmeds.Name = "Pmeds";
            Pmeds.Size = new Size(358, 77);
            Pmeds.TabIndex = 14;
            // 
            // Ptreatment
            // 
            Ptreatment.BorderStyle = BorderStyle.FixedSingle;
            Ptreatment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ptreatment.Location = new Point(202, 83);
            Ptreatment.Name = "Ptreatment";
            Ptreatment.Size = new Size(358, 33);
            Ptreatment.TabIndex = 13;
            Ptreatment.TextChanged += Ptreatment_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(592, 19);
            label15.Name = "label15";
            label15.Size = new Size(66, 30);
            label15.TabIndex = 11;
            label15.Text = "Costo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(81, 137);
            label14.Name = "label14";
            label14.Size = new Size(107, 30);
            label14.TabIndex = 10;
            label14.Text = "Medicinas";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(656, 152);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(592, 81);
            label13.Name = "label13";
            label13.Size = new Size(96, 30);
            label13.TabIndex = 4;
            label13.Text = "Cantidad";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(81, 17);
            label12.Name = "label12";
            label12.Size = new Size(91, 30);
            label12.TabIndex = 3;
            label12.Text = "Paciente";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(81, 83);
            label11.Name = "label11";
            label11.Size = new Size(123, 30);
            label11.TabIndex = 2;
            label11.Text = "Tratamiento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(260, 27);
            label9.Name = "label9";
            label9.Size = new Size(170, 40);
            label9.TabIndex = 5;
            label9.Text = "Prescripcion";
            label9.Click += label9_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(249, 340);
            label16.Name = "label16";
            label16.Size = new Size(248, 40);
            label16.TabIndex = 8;
            label16.Text = "Filtro por Nombre";
            // 
            // PrescriptionDGV
            // 
            PrescriptionDGV.AllowUserToAddRows = false;
            PrescriptionDGV.AllowUserToDeleteRows = false;
            PrescriptionDGV.BackgroundColor = SystemColors.ButtonHighlight;
            PrescriptionDGV.BorderStyle = BorderStyle.None;
            PrescriptionDGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            PrescriptionDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PrescriptionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PrescriptionDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            PrescriptionDGV.DefaultCellStyle = dataGridViewCellStyle2;
            PrescriptionDGV.GridColor = SystemColors.Menu;
            PrescriptionDGV.Location = new Point(249, 393);
            PrescriptionDGV.Name = "PrescriptionDGV";
            PrescriptionDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            PrescriptionDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            PrescriptionDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PrescriptionDGV.Size = new Size(1147, 516);
            PrescriptionDGV.TabIndex = 11;
            PrescriptionDGV.CellContentClick += UserDGV_CellContentClick;
            // 
            // FilterTb
            // 
            FilterTb.BackColor = SystemColors.Window;
            FilterTb.BorderStyle = BorderStyle.FixedSingle;
            FilterTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterTb.Location = new Point(503, 347);
            FilterTb.Name = "FilterTb";
            FilterTb.Size = new Size(358, 33);
            FilterTb.TabIndex = 14;
            FilterTb.TextChanged += FilterTb_TextChanged;
            // 
            // Prescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 928);
            Controls.Add(FilterTb);
            Controls.Add(PrescriptionDGV);
            Controls.Add(label16);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prescription";
            Text = "Prescription";
            Load += Prescription_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PrescriptionDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ComboBox Ppatient;
        private TextBox Pmeds;
        private TextBox Ptreatment;
        private Label label15;
        private Label label14;
        private Button button1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private TextBox Pquantity;
        private TextBox Pcost;
        private Label label16;
        private Button button3;
        private Button button2;
        private DataGridView PrescriptionDGV;
        private TextBox FilterTb;
    }
}
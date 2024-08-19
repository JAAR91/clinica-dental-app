namespace clinica_dental
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
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
            label9 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            AppTime = new DateTimePicker();
            AppDate = new DateTimePicker();
            AppTreatment = new ComboBox();
            AppPacient = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            AppDGV = new DataGridView();
            FilterTb = new TextBox();
            label16 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppDGV).BeginInit();
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
            panel1.TabIndex = 0;
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
            label1.Click += label1_Click;
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
            label9.Location = new Point(262, 26);
            label9.Name = "label9";
            label9.Size = new Size(67, 40);
            label9.TabIndex = 2;
            label9.Text = "Cita";
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AppTime);
            panel2.Controls.Add(AppDate);
            panel2.Controls.Add(AppTreatment);
            panel2.Controls.Add(AppPacient);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(262, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(1135, 267);
            panel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(487, 181);
            button3.Name = "button3";
            button3.Size = new Size(144, 45);
            button3.TabIndex = 19;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(637, 181);
            button2.Name = "button2";
            button2.Size = new Size(144, 45);
            button2.TabIndex = 18;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(338, 181);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AppTime
            // 
            AppTime.CalendarFont = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppTime.Format = DateTimePickerFormat.Time;
            AppTime.Location = new Point(608, 115);
            AppTime.Name = "AppTime";
            AppTime.Size = new Size(278, 33);
            AppTime.TabIndex = 8;
            // 
            // AppDate
            // 
            AppDate.CalendarFont = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppDate.Format = DateTimePickerFormat.Short;
            AppDate.Location = new Point(608, 31);
            AppDate.Name = "AppDate";
            AppDate.Size = new Size(278, 33);
            AppDate.TabIndex = 7;
            AppDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // AppTreatment
            // 
            AppTreatment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppTreatment.FormattingEnabled = true;
            AppTreatment.Location = new Point(153, 115);
            AppTreatment.Name = "AppTreatment";
            AppTreatment.Size = new Size(336, 33);
            AppTreatment.TabIndex = 6;
            // 
            // AppPacient
            // 
            AppPacient.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppPacient.FormattingEnabled = true;
            AppPacient.Location = new Point(153, 29);
            AppPacient.Name = "AppPacient";
            AppPacient.Size = new Size(336, 33);
            AppPacient.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(535, 114);
            label13.Name = "label13";
            label13.Size = new Size(58, 30);
            label13.TabIndex = 4;
            label13.Text = "Hora";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(535, 28);
            label12.Name = "label12";
            label12.Size = new Size(67, 30);
            label12.TabIndex = 3;
            label12.Text = "Fecha";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(24, 114);
            label11.Name = "label11";
            label11.Size = new Size(123, 30);
            label11.TabIndex = 2;
            label11.Text = "Tratamiento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(24, 25);
            label10.Name = "label10";
            label10.Size = new Size(91, 30);
            label10.TabIndex = 0;
            label10.Text = "Paciente";
            // 
            // AppDGV
            // 
            AppDGV.AllowUserToAddRows = false;
            AppDGV.AllowUserToDeleteRows = false;
            AppDGV.BackgroundColor = SystemColors.ButtonHighlight;
            AppDGV.BorderStyle = BorderStyle.None;
            AppDGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            AppDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AppDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AppDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AppDGV.DefaultCellStyle = dataGridViewCellStyle2;
            AppDGV.GridColor = SystemColors.Menu;
            AppDGV.Location = new Point(262, 422);
            AppDGV.Name = "AppDGV";
            AppDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            AppDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            AppDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppDGV.Size = new Size(1147, 486);
            AppDGV.TabIndex = 9;
            AppDGV.CellContentClick += AppDGV_CellContentClick;
            // 
            // FilterTb
            // 
            FilterTb.BackColor = SystemColors.Window;
            FilterTb.BorderStyle = BorderStyle.FixedSingle;
            FilterTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterTb.Location = new Point(516, 376);
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
            label16.Location = new Point(262, 369);
            label16.Name = "label16";
            label16.Size = new Size(248, 40);
            label16.TabIndex = 15;
            label16.Text = "Filtro por Nombre";
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 930);
            Controls.Add(FilterTb);
            Controls.Add(label16);
            Controls.Add(AppDGV);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Appointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment";
            Load += Appointment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AppDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private Label label10;
        private DateTimePicker AppTime;
        private DateTimePicker AppDate;
        private ComboBox AppTreatment;
        private ComboBox AppPacient;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button button1;
        private DataGridView AppDGV;
        private Button button3;
        private Button button2;
        private TextBox FilterTb;
        private Label label16;
    }
}
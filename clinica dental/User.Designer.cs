namespace clinica_dental
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label8 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            Number = new TextBox();
            Password = new TextBox();
            Username = new TextBox();
            label15 = new Label();
            button1 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            UserDGV = new DataGridView();
            FilterTb = new TextBox();
            label16 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 932);
            panel1.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(58, 178);
            label8.Name = "label8";
            label8.Size = new Size(165, 32);
            label8.TabIndex = 8;
            label8.Text = "Cerrar Session";
            label8.Click += label8_Click;
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
            panel2.Controls.Add(Number);
            panel2.Controls.Add(Password);
            panel2.Controls.Add(Username);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(257, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1147, 236);
            panel2.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(504, 155);
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
            button2.Location = new Point(654, 155);
            button2.Name = "button2";
            button2.Size = new Size(144, 45);
            button2.TabIndex = 18;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Number
            // 
            Number.BorderStyle = BorderStyle.FixedSingle;
            Number.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number.Location = new Point(202, 83);
            Number.Name = "Number";
            Number.Size = new Size(358, 33);
            Number.TabIndex = 16;
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.FixedSingle;
            Password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(701, 29);
            Password.Name = "Password";
            Password.Size = new Size(358, 33);
            Password.TabIndex = 13;
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.FixedSingle;
            Username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(202, 27);
            Username.Name = "Username";
            Username.Size = new Size(358, 33);
            Username.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(81, 86);
            label15.Name = "label15";
            label15.Size = new Size(89, 30);
            label15.TabIndex = 11;
            label15.Text = "Numero";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(358, 155);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(580, 29);
            label11.Name = "label11";
            label11.Size = new Size(118, 30);
            label11.TabIndex = 2;
            label11.Text = "Contrasena";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(81, 27);
            label10.Name = "label10";
            label10.Size = new Size(106, 30);
            label10.TabIndex = 0;
            label10.Text = "Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(268, 13);
            label9.Name = "label9";
            label9.Size = new Size(126, 40);
            label9.TabIndex = 7;
            label9.Text = "Usuarios";
            // 
            // UserDGV
            // 
            UserDGV.AllowUserToAddRows = false;
            UserDGV.AllowUserToDeleteRows = false;
            UserDGV.BackgroundColor = SystemColors.ButtonHighlight;
            UserDGV.BorderStyle = BorderStyle.None;
            UserDGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            UserDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UserDGV.DefaultCellStyle = dataGridViewCellStyle2;
            UserDGV.GridColor = SystemColors.Menu;
            UserDGV.Location = new Point(257, 382);
            UserDGV.Name = "UserDGV";
            UserDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            UserDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            UserDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserDGV.Size = new Size(1147, 516);
            UserDGV.TabIndex = 10;
            UserDGV.CellContentClick += UserDGV_CellContentClick;
            // 
            // FilterTb
            // 
            FilterTb.BackColor = SystemColors.Window;
            FilterTb.BorderStyle = BorderStyle.FixedSingle;
            FilterTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterTb.Location = new Point(511, 330);
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
            label16.Location = new Point(257, 323);
            label16.Name = "label16";
            label16.Size = new Size(248, 40);
            label16.TabIndex = 15;
            label16.Text = "Filtro por Nombre";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 932);
            Controls.Add(FilterTb);
            Controls.Add(label16);
            Controls.Add(UserDGV);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            Text = "User";
            Load += User_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox Number;
        private TextBox Password;
        private TextBox Username;
        private Label label15;
        private Button button1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button3;
        private Button button2;
        private DataGridView UserDGV;
        private TextBox FilterTb;
        private Label label16;
    }
}
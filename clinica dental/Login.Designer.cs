namespace clinica_dental
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            Upassword = new TextBox();
            Uname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Upassword);
            panel1.Controls.Add(Uname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(39, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 459);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 396);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 7;
            label4.Text = "Admin";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(87, 348);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 5;
            button1.Text = "Iniciar Session";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Upassword
            // 
            Upassword.BorderStyle = BorderStyle.FixedSingle;
            Upassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Upassword.Location = new Point(50, 289);
            Upassword.Name = "Upassword";
            Upassword.PasswordChar = '*';
            Upassword.Size = new Size(240, 33);
            Upassword.TabIndex = 4;
            // 
            // Uname
            // 
            Uname.BorderStyle = BorderStyle.FixedSingle;
            Uname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Uname.Location = new Point(50, 199);
            Uname.Name = "Uname";
            Uname.Size = new Size(240, 33);
            Uname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 251);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 2;
            label2.Text = "Contrasena:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 171);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(382, 9);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 1;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(422, 553);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox Upassword;
        private TextBox Uname;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
namespace clinica_dental
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ApointmentLoader = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            PendingText = new Label();
            label9 = new Label();
            PatientsLoader = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            PacientesText = new Label();
            label5 = new Label();
            UserLoader = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            UserText = new Label();
            label6 = new Label();
            NextApp = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ApointementLabel = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ApointmentLoader.SuspendLayout();
            PatientsLoader.SuspendLayout();
            UserLoader.SuspendLayout();
            NextApp.SuspendLayout();
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 932);
            panel1.TabIndex = 3;
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
            // ApointmentLoader
            // 
            ApointmentLoader.Controls.Add(PendingText);
            ApointmentLoader.Controls.Add(label9);
            ApointmentLoader.FillColor = Color.FromArgb(200, 213, 218, 223);
            ApointmentLoader.Font = new Font("Segoe UI", 12F);
            ApointmentLoader.ForeColor = Color.White;
            ApointmentLoader.Location = new Point(296, 44);
            ApointmentLoader.Minimum = 0;
            ApointmentLoader.Name = "ApointmentLoader";
            ApointmentLoader.ProgressThickness = 30;
            ApointmentLoader.ShadowDecoration.CustomizableEdges = customizableEdges5;
            ApointmentLoader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ApointmentLoader.Size = new Size(414, 414);
            ApointmentLoader.TabIndex = 4;
            ApointmentLoader.Text = "guna2CircleProgressBar1";
            // 
            // PendingText
            // 
            PendingText.AutoSize = true;
            PendingText.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PendingText.ForeColor = SystemColors.ActiveCaptionText;
            PendingText.Location = new Point(144, 187);
            PendingText.Name = "PendingText";
            PendingText.Size = new Size(126, 40);
            PendingText.TabIndex = 9;
            PendingText.Text = "Usuarios";
            PendingText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(104, 115);
            label9.Name = "label9";
            label9.Size = new Size(225, 40);
            label9.TabIndex = 8;
            label9.Text = "Citas Pendientes";
            // 
            // PatientsLoader
            // 
            PatientsLoader.Controls.Add(PacientesText);
            PatientsLoader.Controls.Add(label5);
            PatientsLoader.FillColor = Color.FromArgb(200, 213, 218, 223);
            PatientsLoader.Font = new Font("Segoe UI", 12F);
            PatientsLoader.ForeColor = Color.White;
            PatientsLoader.Location = new Point(834, 44);
            PatientsLoader.Minimum = 0;
            PatientsLoader.Name = "PatientsLoader";
            PatientsLoader.ProgressThickness = 30;
            PatientsLoader.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PatientsLoader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            PatientsLoader.Size = new Size(414, 414);
            PatientsLoader.TabIndex = 5;
            PatientsLoader.Text = "guna2CircleProgressBar2";
            // 
            // PacientesText
            // 
            PacientesText.AutoSize = true;
            PacientesText.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PacientesText.ForeColor = SystemColors.ActiveCaptionText;
            PacientesText.Location = new Point(153, 187);
            PacientesText.Name = "PacientesText";
            PacientesText.Size = new Size(126, 40);
            PacientesText.TabIndex = 10;
            PacientesText.Text = "Usuarios";
            PacientesText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(144, 115);
            label5.Name = "label5";
            label5.Size = new Size(135, 40);
            label5.TabIndex = 9;
            label5.Text = "Pacientes";
            // 
            // UserLoader
            // 
            UserLoader.Controls.Add(UserText);
            UserLoader.Controls.Add(label6);
            UserLoader.FillColor = Color.FromArgb(200, 213, 218, 223);
            UserLoader.Font = new Font("Segoe UI", 12F);
            UserLoader.ForeColor = Color.White;
            UserLoader.Location = new Point(296, 491);
            UserLoader.Minimum = 0;
            UserLoader.Name = "UserLoader";
            UserLoader.ProgressThickness = 30;
            UserLoader.ShadowDecoration.CustomizableEdges = customizableEdges7;
            UserLoader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            UserLoader.Size = new Size(414, 414);
            UserLoader.TabIndex = 6;
            UserLoader.Text = "guna2CircleProgressBar3";
            // 
            // UserText
            // 
            UserText.AutoSize = true;
            UserText.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserText.ForeColor = SystemColors.ActiveCaptionText;
            UserText.Location = new Point(139, 196);
            UserText.Name = "UserText";
            UserText.Size = new Size(126, 40);
            UserText.TabIndex = 11;
            UserText.Text = "Usuarios";
            UserText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(139, 107);
            label6.Name = "label6";
            label6.Size = new Size(126, 40);
            label6.TabIndex = 10;
            label6.Text = "Usuarios";
            // 
            // NextApp
            // 
            NextApp.Controls.Add(ApointementLabel);
            NextApp.Controls.Add(label10);
            NextApp.FillColor = Color.FromArgb(200, 213, 218, 223);
            NextApp.Font = new Font("Segoe UI", 12F);
            NextApp.ForeColor = Color.White;
            NextApp.Location = new Point(834, 491);
            NextApp.Minimum = 0;
            NextApp.Name = "NextApp";
            NextApp.ProgressThickness = 30;
            NextApp.ShadowDecoration.CustomizableEdges = customizableEdges8;
            NextApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            NextApp.Size = new Size(414, 414);
            NextApp.TabIndex = 7;
            NextApp.Text = "guna2CircleProgressBar4";
            // 
            // ApointementLabel
            // 
            ApointementLabel.AutoSize = true;
            ApointementLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApointementLabel.ForeColor = SystemColors.ActiveCaptionText;
            ApointementLabel.Location = new Point(37, 196);
            ApointementLabel.Name = "ApointementLabel";
            ApointementLabel.Size = new Size(126, 40);
            ApointementLabel.TabIndex = 12;
            ApointementLabel.Text = "Usuarios";
            ApointementLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(153, 107);
            label10.Name = "label10";
            label10.Size = new Size(126, 40);
            label10.TabIndex = 11;
            label10.Text = "Usuarios";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1562, 932);
            Controls.Add(NextApp);
            Controls.Add(UserLoader);
            Controls.Add(PatientsLoader);
            Controls.Add(ApointmentLoader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ApointmentLoader.ResumeLayout(false);
            ApointmentLoader.PerformLayout();
            PatientsLoader.ResumeLayout(false);
            PatientsLoader.PerformLayout();
            UserLoader.ResumeLayout(false);
            UserLoader.PerformLayout();
            NextApp.ResumeLayout(false);
            NextApp.PerformLayout();
            ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2CircleProgressBar ApointmentLoader;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PatientsLoader;
        private Guna.UI2.WinForms.Guna2CircleProgressBar UserLoader;
        private Guna.UI2.WinForms.Guna2CircleProgressBar NextApp;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label10;
        private Label PendingText;
        private Label PacientesText;
        private Label UserText;
        private Label ApointementLabel;
    }
}
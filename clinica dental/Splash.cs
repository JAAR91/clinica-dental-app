namespace clinica_dental
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int loaderState = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            loaderState = loaderState + 1;
            MyProgresBar.Value = loaderState;
            if (loaderState == 100)
            {
                MyProgresBar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loading.Value = 0;
        }

        private void loadingTime_Tick(object sender, EventArgs e)
        {
            loading.Value += 5;
            if (loading.Value == 100) {
                loadingTime.Enabled = false;
                achoqmain abreotro = new achoqmain();
                abreotro.Show();
                this.Hide();
            }
            // this seems simple but a lot of people messed this up somehow
        }
    }
}

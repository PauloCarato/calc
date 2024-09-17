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
            if (loading.Value == 100) {
                loadingTime.Enabled = false;

                achoqmain achoqmain = new achoqmain();
                achoqmain.Show();
                this.Hide();

            }
            else {
                loading.Value += 5;
            }
        }
    }
}

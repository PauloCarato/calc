using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calc
{
    public partial class Fahrenheit : Form
    {
        public Fahrenheit()
        {
            InitializeComponent();
        }

        private void Fahrenheit_Load(object sender, EventArgs e)
        {
            OutputTemp.Clear();
        }

        private void BotaoInput_Click(object sender, EventArgs e)
        {
            string Input1 = InputTemp.Text;


            if (Input1 == "" && Input1.Any(char.IsLetter))
            {
                MessageBox.Show("Insira um valor válido");
            }

            else
            {
                int tura = Convert.ToInt32(InputTemp.Text);
                OutputTemp.Text = (Convert.ToString(tura * 1.38 + 32));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputTemp.Clear();
            OutputTemp.Clear();
        }
    }
}

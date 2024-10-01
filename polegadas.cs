using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class polegadas : Form
    {
        public polegadas()
        {
            InitializeComponent();
        }

        private void confirma22_Click(object sender, EventArgs e)
        {
            string input2 = InputCM.Text;
            if (input2 == "" || input2.Any(char.IsLetter))
            {
                MessageBox.Show("Insira um valor válido antes de confirmar");

            }
            else
            {
                int convertível = Convert.ToInt32(InputCM.Text);
                OutputPolegada.Text = (Convert.ToString(convertível/2.54));

            }
        }
        private void limpa_Click(object sender, EventArgs e)
        {

        }
    }
}

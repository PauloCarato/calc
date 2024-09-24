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
    public partial class achoqmain : Form
    {
        List<int> InputN = new List<int>();
        public achoqmain()
        {
            InitializeComponent();
            
        }
        private void achoqmain_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            // this codes so simple i wanna die
        }



        // this is horrific
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
            InputN.Add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
            InputN.Add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
            InputN.Add(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
            InputN.Add(4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
            InputN.Add(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
            InputN.Add(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
            InputN.Add(7);
        }

        private void somabutton_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("+");
        }

        private void subtraçãoButton_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("-");
        }

        private void IgualButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i want u to know that this codes horrific; This doesnt work yet " +
                "(idk if it will someday)");

        }

        //i asked my teacher for a better way of doing this and he replyed
        // "yeah that would work like that, but do it in the simple ugly way" what a chad
    }
}

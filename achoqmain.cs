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
        float valor = 0;
        string calc = "";
        //List<int> InputN = new List<int>();   i will try doing with this later, now i just want my grades
        public achoqmain()
        {
            InitializeComponent();

        }
        private void achoqmain_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            // this codes so simple i wanna die
        }



        // this codes horrific, sorry for that
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
            //InputN.Add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
            //InputN.Add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
            //InputN.Add(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
            //InputN.Add(4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
            //InputN.Add(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
            //InputN.Add(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
            //InputN.Add(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(button0.Text);
        }
        private void somabutton_Click(object sender, EventArgs e)
        {

            valor = Convert.ToSingle(textBox1.Text);
            calc = "+";
            textBox1.Clear();

        }

        private void subtraçãoButton_Click(object sender, EventArgs e)
        {

            valor = Convert.ToSingle(textBox1.Text);
            calc = "-";
            textBox1.Clear();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor = Convert.ToSingle(textBox1.Text);
            textBox1.AppendText("x");
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor = Convert.ToSingle(textBox1.Text);
            calc = "/";
            textBox1.Clear();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            valor = 0;
            textBox1.Clear();
        }

        private void IgualButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("i want u to know that this codes horrific; This doesnt work yet " +
            //    "(i dont even know if someday it will work )");

            switch (calc)
            {

                case "+":
                    MessageBox.Show(Convert.ToString(valor + Convert.ToSingle(textBox1.Text))); //i really dk if this works
                    break;

                case "-":
                    MessageBox.Show(Convert.ToString(valor - Convert.ToSingle(textBox1.Text)));
                    break;

                case "*":
                    MessageBox.Show(Convert.ToString(valor * Convert.ToSingle(textBox1.Text)));
                    break;
                case "/":
                    MessageBox.Show(Convert.ToString(valor * Convert.ToSingle(textBox1.Text)));
                    break;


            }

            valor = 0;
            textBox1.Clear();
        }

        private void achoqmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            // i think this will close the entire thing
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void celsiusParaFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fahrenheit abre = new Fahrenheit();
            abre.Show();
        }

        private void centímetrosPraPolegadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polegadas abre1 = new polegadas();
            abre1.Show();
        }


        //i talked w/ my teacher about a better way of doing this that i had and he replyed:
        // "yeah that would work like that, but do it in the simple ugly way" what a simga
        // now i really dk how to solve it
    }
}

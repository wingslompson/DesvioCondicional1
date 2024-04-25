using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesvioCondicional
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod;
            try
            {
                cod = Convert.ToInt32(textBox1.Text);


                if (cod > 1)
                {
                    MessageBox.Show("CODIGO " + cod, " Atenção! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch
            {
                MessageBox.Show("Por favor, insira os valores "  , " ERRO! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

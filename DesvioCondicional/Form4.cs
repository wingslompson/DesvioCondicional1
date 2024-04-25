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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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
                cod = Convert.ToInt16(textBox1.Text);

                if (cod == 1 || cod == 2)
                {
                    MessageBox.Show("Você tem acesso a sala especial", " EBA! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cod == 3 || cod == 4)
                {
                    MessageBox.Show("Você não tem acesso a sala especial", " Que pena! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opção invalida", " ERRO! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Por favor, insira os valores ", " ERRO! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

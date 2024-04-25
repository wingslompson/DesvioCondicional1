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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();
        }

        private void iFELSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 OutroForm = new Form3();
            OutroForm.ShowDialog();
        }

        private void iFELSEIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 OutroForm = new Form4();
            OutroForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja sair?","Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

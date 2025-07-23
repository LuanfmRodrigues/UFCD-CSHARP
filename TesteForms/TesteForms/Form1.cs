using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Sou Luan Rodrigues");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sou a Segunda opção!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Sou Lindo?", "Texto da 3º Opção", MessageBoxButtons.YesNo);

            if (retorno == DialogResult.Yes)
            {
                MessageBox.Show("Obrigado!");

            }else if(retorno == DialogResult.No)
            {
                MessageBox.Show("Feio é voçê!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Meus Familiares", "Caixa de familia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        }
    }
}

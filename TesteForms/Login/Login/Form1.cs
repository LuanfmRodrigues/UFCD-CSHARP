using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                //txtLogin é o nome da barra no form 
                if (txtLogin.Text.Equals("Luan") && txtSenha.Text.Equals("123"))
                {
                    var menu = new MenuRES();
                    menu.Show();

                    this.Visible = false;
                }
                else 
                {
                    MessageBox.Show("Usuario ou senha incorretos", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtLogin.Focus(); // leva o cursor do mouse para a barra do login
                    txtSenha.Text = ""; //apaga a senha e tem que escrever de novo
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Desculpe",ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.LightYellow;
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtLogin.BackColor = Color.LightYellow;
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtLogin.BackColor = Color.White;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor= Color.LightYellow;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla !=08)// se o usuario digitar algo que nao seja letras ou numeros e a tecla backspace(08) aparece essa mesg
            {
                
                e.Handled = true;// o usuario nao digitou uma letro ou digito. nao deixa o usuario colocar simbolos c
                MessageBox.Show("Digite apenas Letras ou numeros");

                txtLogin.SelectionStart = 0; // funcao de selecionar tudo no texto comecando do zero
                txtLogin.SelectionLength = txtLogin.Text.Length;

                txtLogin.Focus();
            }
        }
    }
}

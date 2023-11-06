using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuffetFrancisco.View
{
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            if (usuario == "admin" && senha == "123")
            {
                this.Hide();
                MenuTela Menu = new MenuTela();
                Menu.FormClosed += (s, args) => this.Close();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Senha ou usuário incorreto");
            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


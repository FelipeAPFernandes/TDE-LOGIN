using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lnlblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmCadastro frm = new frmCadastro();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtLogIn.Text == "felipezip" || txtPassword.Text == "arroz")
            {
                MessageBox.Show("Seja Bem vindo !");
            }
            else
            {
                MessageBox.Show("Login ou Senha Inválidos, tente novamente!");
            }
        }
    }
}

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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();

        }
        string genero;

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (rbdMASCULINO.Checked) 
            {
                genero = "Masculino";
            }
            else
            {
                genero = "Feminino";
            }
            String mensagem = "";
            mensagem += "Nome: " + txtNome.Text + " " + txtSobrenome.Text + "\n";
            mensagem += "E-mail:  " + txtEmail.Text + "\n";
            mensagem += "CPF:  " + mtbCPF.Text + "\n";
            mensagem += "Sexo: " + genero + "\n";
            mensagem += "Telefone: " + mtbTelefone.Text + "\n";
            mensagem += "RG: " + mtbRG.Text + "\n";
            mensagem += "Data de Nascimento: " + mtbNascimento.Text + "\n";
            mensagem += "Cidade:  " + txtCidade.Text + "\n";
            mensagem += "Bairro:  " + txtBairro.Text + "\n";
            mensagem += "Estado:  " + cmbEstado.Text + "\n";
            mensagem += "Rua:  " + txtRua.Text + "\n";
            mensagem += "Número:  " + mtbNumero.Text + "\n";
            mensagem += "Login: " + txtLogIn.Text + "\n";
            mensagem += "Senha:  " + txtPassword.Text + "\n";


            MessageBox.Show(mensagem);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtbNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //textbox clear code
            txtBairro.Text = "";
            txtSobrenome.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtRua.Text = "";
            txtCidade.Text = "";
            txtPassword.Text = "";
            txtLogIn.Text = "";

            //combobox clear code
            cmbEstado.Text = "";

            //maskedtextbox clear code
            mtbCPF.Text = "";
            mtbNumero.Text = "";
            mtbNascimento.Text = "";
            mtbRG.Text = "";
            mtbTelefone.Text = "";


            MessageBox.Show("Formulário Limpo");
        }
    }
}

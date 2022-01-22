using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    public partial class cli_cad : Form
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new cli_cad());
        }
        public cli_cad()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza de que deseja realizar o cadastro deste cliente?",
                                "Confirmateon",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtNumero.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtUF.Text = string.Empty;
                txtCEP.Text = string.Empty;
                txtCPF.Text = string.Empty;
                txtTelefone.Text = string.Empty;
                txtCelular.Text = string.Empty;
                txtEmail.Text = string.Empty;
                this.txtNome.Focus();
            }
        }

        private void txtCPF_LostFocus(object sender, EventArgs e)
        {
            //if (ValidaCPF.IsCpf(this.txtCPF.Text) == false)
            //{
            //    MessageBox.Show("O CPF digitado não é um número válido.",
            //                    "CPF Inválido",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Warning);
            //    txtCPF.Focus();
            //    lblCPF.ForeColor = Color.Red;
            //    lblCPF.Text = "CPF*";
            //}
        }
    }
}

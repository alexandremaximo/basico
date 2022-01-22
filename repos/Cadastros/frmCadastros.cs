using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastros
{
    public partial class frmCadastros : Form
    {
        public frmCadastros()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPF_LostFocus(object sender, EventArgs e)
        {
            string rmvMascara;
            //remove a máscara para fazer a validação apenas dos números.
            rmvMascara = Regex.Replace(this.txtCPF.Text, "[^0-9]", "");

            if (!ValidaCPF.IsCpf(rmvMascara.Trim()))
            {
                MessageBox.Show("O CPF digitado é inválido.", "CPF Inválido", MessageBoxButtons.OK);
                txtCPF.Focus();
                txtCPF.SelectAll();
            }

        }
        private void txtCPF_Click(object sender, EventArgs e)
        {
            string rmvMascara;
            //remove a máscara para posicionar no início apenas se não houver números.
            rmvMascara = Regex.Replace(this.txtCPF.Text, "[^0-9]", "");
            if (rmvMascara == string.Empty)
            {
                txtCPF.SelectionStart = 0;
            }
        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtxtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtxtTelefone_Leave(object sender, EventArgs e)
        {
            string rmvMascara;
            //remove a máscara para fazer a validação apenas dos números.
            rmvMascara = Regex.Replace(this.mtxtTelefone.Text, "[^0-9]", "");

            if (rmvMascara.Length < 10 && rmvMascara.Length != 0)
            {
                if (MessageBox.Show("O número de telefone contém menos de 10 dígitos. Deseja mantê-lo?",
                                "Número inválido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    mtxtTelefone.Focus();
                }

            }
        }

        private void mtxtCelular_Leave(object sender, EventArgs e)
        {
            string rmvMascara;
            //remove a máscara para fazer a validação apenas dos números.
            rmvMascara = Regex.Replace(this.mtxtCelular.Text, "[^0-9]", "");

            if (rmvMascara.Length < 11 && rmvMascara.Length != 0)
            {
                if (MessageBox.Show("O número de celular contém menos de 11 dígitos. Deseja mantê-lo?",
                                "Número inválido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    mtxtCelular.Focus();
                }

            }
        }

        private void mtxtTelefone_Click(object sender, EventArgs e)
        {
            string rmvMascara;
            //remove a máscara para posicionar no início apenas se não houver números.
            rmvMascara = Regex.Replace(this.mtxtTelefone.Text, "[^0-9]", "");
            if (rmvMascara == string.Empty)
            {
                mtxtTelefone.SelectionStart = 0;
            }
        }

        private void mtxtCelular_Click(object sender, EventArgs e)
        {
            string rmvMascara;
            //remove a máscara para posicionar no início apenas se não houver números.
            rmvMascara = Regex.Replace(this.mtxtCelular.Text, "[^0-9]", "");
            if (rmvMascara == string.Empty)
            {
                mtxtCelular.SelectionStart = 0;
            }
        }

        private void mtxtCEP_Click(object sender, EventArgs e)
        {
            string rmvMascara;
            //remove a máscara para posicionar no início apenas se não houver números.
            rmvMascara = Regex.Replace(this.mtxtCEP.Text, "[^0-9]", "");
            if (rmvMascara == string.Empty)
            {
                mtxtCEP.SelectionStart = 0;
            }
        }

        private void mtxtCEP_Leave(object sender, EventArgs e)
        {
            string rmvMascara;
            //remove a máscara para fazer a validação apenas dos números.
            rmvMascara = Regex.Replace(this.mtxtCEP.Text, "[^0-9]", "");

            if (rmvMascara.Length < 8 && rmvMascara.Length != 0)
            {
                if (MessageBox.Show("O número de CEP contém menos de 8 dígitos. Deseja mantê-lo?",
                                "CEP inválido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    mtxtCEP.Focus();
                }
            }
        }

        private void mtxtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mtxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (this.mtxtCEP.Text.Length == this.mtxtCEP.TextLength)
            {
                bntValCEP.Focus();
            }
        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtxtCEP.Focus();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCPF.Focus();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCPF.Text.Length == this.txtCPF.TextLength)
            {
                mtxtTelefone.Focus();
            }
        }

        private void mtxtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (this.mtxtTelefone.Text.Length == this.mtxtTelefone.TextLength)
            {
                mtxtCelular.Focus();
            }
        }

        private void mtxtCelular_TextChanged(object sender, EventArgs e)
        {
            if (this.mtxtCelular.Text.Length == this.mtxtCelular.TextLength)
            {
                txtEmail.Focus();
            }
        }

        public void bntCadastrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realizar o cadastro deste cliente?",
                                "Confirmar cadastro",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QueryAddCli.InsertCliente(  /*this.txtCodigo.Text,*///Está como Auto Increment no banco.
                                            this.txtNome.Text,
                                            this.txtEndereco.Text,
                                            Int32.Parse(this.txtNumero.Text),
                                            this.txtBairro.Text,
                                            this.txtCidade.Text,
                                            this.cbUF.Text,
                                            Int64.Parse(Regex.Replace(this.mtxtCEP.Text, "[^0-9]", "")),
                                            Int64.Parse(Regex.Replace(this.mtxtTelefone.Text, "[^0-9]", "")),
                                            Int64.Parse(Regex.Replace(this.mtxtCelular.Text, "[^0-9]", "")),
                                            this.txtEmail.Text,
                                            Int64.Parse(Regex.Replace(this.txtCPF.Text, "[^0-9]", "")),
                                            this.cbSexo.Text);
            }
            else
            {
                txtNome.Focus();
            }
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void frmCadastros_Load(object sender, EventArgs e)
        {
            

            //Pega o maxlength da tabela e atribui ao campo.
            //txtNome.MaxLength = this.maximocontrolDataSet.clientes.nomeColumn.MaxLength;
            //txtEndereco.MaxLength = maximocontrolDataSet.clientes.enderecoColumn.MaxLength;
            //txtBairro.MaxLength = maximocontrolDataSet.clientes.bairroColumn.MaxLength;
            //txtCidade.MaxLength = maximocontrolDataSet.clientes.cidadeColumn.MaxLength;
            //txtEmail.MaxLength = maximocontrolDataSet.clientes.emailColumn.MaxLength;

        }
    }
}
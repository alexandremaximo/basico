
namespace Cadastros
{
    partial class frmCadastros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntCadastrar = new System.Windows.Forms.Button();
            this.bntValCEP = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblEndNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SuspendLayout();
            // 
            // bntSair
            // 
            this.bntSair.BackgroundImage = global::Cadastros.Properties.Resources.transferir;
            this.bntSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntSair.Location = new System.Drawing.Point(549, 169);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(46, 41);
            this.bntSair.TabIndex = 53;
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.BackColor = System.Drawing.Color.White;
            this.bntCadastrar.BackgroundImage = global::Cadastros.Properties.Resources.confirm;
            this.bntCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCadastrar.Location = new System.Drawing.Point(487, 169);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(45, 41);
            this.bntCadastrar.TabIndex = 52;
            this.bntCadastrar.UseVisualStyleBackColor = false;
            this.bntCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // bntValCEP
            // 
            this.bntValCEP.BackgroundImage = global::Cadastros.Properties.Resources.correios_logo_5;
            this.bntValCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntValCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntValCEP.ForeColor = System.Drawing.Color.Blue;
            this.bntValCEP.Location = new System.Drawing.Point(148, 113);
            this.bntValCEP.Name = "bntValCEP";
            this.bntValCEP.Size = new System.Drawing.Size(75, 23);
            this.bntValCEP.TabIndex = 41;
            this.bntValCEP.UseVisualStyleBackColor = false;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(442, 119);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 44;
            this.lblCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblTelefone.Location = new System.Drawing.Point(6, 146);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(57, 13);
            this.lblTelefone.TabIndex = 46;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.Black;
            this.lblCelular.Location = new System.Drawing.Point(158, 146);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 48;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(302, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(343, 143);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 20);
            this.txtEmail.TabIndex = 51;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.Black;
            this.lblCEP.Location = new System.Drawing.Point(6, 119);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 39;
            this.lblCEP.Text = "CEP";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.BackColor = System.Drawing.Color.Transparent;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.ForeColor = System.Drawing.Color.Black;
            this.lblUF.Location = new System.Drawing.Point(509, 93);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(23, 13);
            this.lblUF.TabIndex = 37;
            this.lblUF.Text = "UF";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(256, 93);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(46, 13);
            this.lblCidade.TabIndex = 35;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(302, 90);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(201, 20);
            this.txtCidade.TabIndex = 34;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Black;
            this.lblBairro.Location = new System.Drawing.Point(6, 93);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 13);
            this.lblBairro.TabIndex = 33;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(68, 90);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(182, 20);
            this.txtBairro.TabIndex = 32;
            // 
            // lblEndNumero
            // 
            this.lblEndNumero.AutoSize = true;
            this.lblEndNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblEndNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndNumero.ForeColor = System.Drawing.Color.Black;
            this.lblEndNumero.Location = new System.Drawing.Point(445, 67);
            this.lblEndNumero.Name = "lblEndNumero";
            this.lblEndNumero.Size = new System.Drawing.Size(50, 13);
            this.lblEndNumero.TabIndex = 31;
            this.lblEndNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(495, 64);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 30;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.Black;
            this.lblEndereco.Location = new System.Drawing.Point(6, 67);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(61, 13);
            this.lblEndereco.TabIndex = 29;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(68, 64);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(371, 20);
            this.txtEndereco.TabIndex = 28;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(6, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 38);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(527, 20);
            this.txtNome.TabIndex = 26;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtCodigo.CausesValidation = false;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(68, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(475, 116);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(88, 20);
            this.txtCPF.TabIndex = 45;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCPF.Click += new System.EventHandler(this.txtCPF_Click);
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            this.txtCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_LostFocus);
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(68, 143);
            this.mtxtTelefone.Mask = "(00)0000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(84, 20);
            this.mtxtTelefone.TabIndex = 47;
            this.mtxtTelefone.Click += new System.EventHandler(this.mtxtTelefone_Click);
            this.mtxtTelefone.TextChanged += new System.EventHandler(this.mtxtTelefone_TextChanged);
            this.mtxtTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtTelefone_KeyDown);
            this.mtxtTelefone.Leave += new System.EventHandler(this.mtxtTelefone_Leave);
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(203, 143);
            this.mtxtCelular.Mask = "(00)00000-0000";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(93, 20);
            this.mtxtCelular.TabIndex = 49;
            this.mtxtCelular.Click += new System.EventHandler(this.mtxtCelular_Click);
            this.mtxtCelular.TextChanged += new System.EventHandler(this.mtxtCelular_TextChanged);
            this.mtxtCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtTelefone_KeyDown);
            this.mtxtCelular.Leave += new System.EventHandler(this.mtxtCelular_Leave);
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(68, 116);
            this.mtxtCEP.Mask = "00000-000";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(74, 20);
            this.mtxtCEP.TabIndex = 40;
            this.mtxtCEP.Click += new System.EventHandler(this.mtxtCEP_Click);
            this.mtxtCEP.TextChanged += new System.EventHandler(this.mtxtCEP_TextChanged);
            this.mtxtCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtCEP_KeyDown);
            this.mtxtCEP.Leave += new System.EventHandler(this.mtxtCEP_Leave);
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(536, 90);
            this.cbUF.MaxLength = 2;
            this.cbUF.Name = "cbUF";
            this.cbUF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbUF.Size = new System.Drawing.Size(59, 21);
            this.cbUF.TabIndex = 38;
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            // 
            // cbSexo
            // 
            this.cbSexo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Demais formas de vida"});
            this.cbSexo.Location = new System.Drawing.Point(266, 116);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(170, 21);
            this.cbSexo.TabIndex = 43;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(229, 119);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(35, 13);
            this.lblSexo.TabIndex = 42;
            this.lblSexo.Text = "Sexo";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Cadastros.Properties.Resources.lupa2__2_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(569, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cadastros.Properties.Resources.BACKGROUND_GENERICO_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 216);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.mtxtCEP);
            this.Controls.Add(this.mtxtCelular);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.bntValCEP);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblEndNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadastros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntCadastrar;
        private System.Windows.Forms.Button bntValCEP;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEndNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
    }
}


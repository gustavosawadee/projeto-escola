namespace Projeto_Escola
{
    partial class frmCadAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAlunos = new System.Windows.Forms.DataGridView();
            this.btnLimparCampoAluno = new System.Windows.Forms.Button();
            this.btnAlterarAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnIncluirAluno = new System.Windows.Forms.Button();
            this.gpbNav = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbNomeAluno = new System.Windows.Forms.TextBox();
            this.lblCodAlunos = new System.Windows.Forms.Label();
            this.lblCadSigla = new System.Windows.Forms.Label();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.lblCadMatricula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbNasc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).BeginInit();
            this.gpbNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAlunos
            // 
            this.dataGridViewAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlunos.Location = new System.Drawing.Point(29, 386);
            this.dataGridViewAlunos.Name = "dataGridViewAlunos";
            this.dataGridViewAlunos.Size = new System.Drawing.Size(613, 200);
            this.dataGridViewAlunos.TabIndex = 27;
            this.dataGridViewAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlunos_CellContentClick);
            // 
            // btnLimparCampoAluno
            // 
            this.btnLimparCampoAluno.Location = new System.Drawing.Point(487, 134);
            this.btnLimparCampoAluno.Name = "btnLimparCampoAluno";
            this.btnLimparCampoAluno.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCampoAluno.TabIndex = 23;
            this.btnLimparCampoAluno.Text = "Limpar";
            this.btnLimparCampoAluno.UseVisualStyleBackColor = true;
            this.btnLimparCampoAluno.Click += new System.EventHandler(this.btnLimparCampoAluno_Click);
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.Location = new System.Drawing.Point(487, 105);
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarAluno.TabIndex = 24;
            this.btnAlterarAluno.Text = "Alterar";
            this.btnAlterarAluno.UseVisualStyleBackColor = true;
            this.btnAlterarAluno.Click += new System.EventHandler(this.btnAlterarAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(487, 73);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAluno.TabIndex = 25;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnIncluirAluno
            // 
            this.btnIncluirAluno.Location = new System.Drawing.Point(487, 40);
            this.btnIncluirAluno.Name = "btnIncluirAluno";
            this.btnIncluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirAluno.TabIndex = 26;
            this.btnIncluirAluno.Text = "Incluir";
            this.btnIncluirAluno.UseVisualStyleBackColor = true;
            this.btnIncluirAluno.Click += new System.EventHandler(this.btnIncluirAluno_Click);
            // 
            // gpbNav
            // 
            this.gpbNav.Controls.Add(this.button4);
            this.gpbNav.Controls.Add(this.button3);
            this.gpbNav.Controls.Add(this.button2);
            this.gpbNav.Controls.Add(this.button1);
            this.gpbNav.Location = new System.Drawing.Point(29, 298);
            this.gpbNav.Name = "gpbNav";
            this.gpbNav.Size = new System.Drawing.Size(337, 68);
            this.gpbNav.TabIndex = 21;
            this.gpbNav.TabStop = false;
            this.gpbNav.Text = "Navegação";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(248, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Último";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Anterior";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Próximo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Primeiro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbNomeAluno
            // 
            this.txbNomeAluno.Location = new System.Drawing.Point(88, 51);
            this.txbNomeAluno.Name = "txbNomeAluno";
            this.txbNomeAluno.Size = new System.Drawing.Size(100, 20);
            this.txbNomeAluno.TabIndex = 19;
            // 
            // lblCodAlunos
            // 
            this.lblCodAlunos.AutoSize = true;
            this.lblCodAlunos.Location = new System.Drawing.Point(85, 26);
            this.lblCodAlunos.Name = "lblCodAlunos";
            this.lblCodAlunos.Size = new System.Drawing.Size(13, 13);
            this.lblCodAlunos.TabIndex = 18;
            this.lblCodAlunos.Text = "1";
            // 
            // lblCadSigla
            // 
            this.lblCadSigla.AutoSize = true;
            this.lblCadSigla.Location = new System.Drawing.Point(26, 83);
            this.lblCadSigla.Name = "lblCadSigla";
            this.lblCadSigla.Size = new System.Drawing.Size(35, 13);
            this.lblCadSigla.TabIndex = 16;
            this.lblCadSigla.Text = "Nasc:";
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.Location = new System.Drawing.Point(26, 54);
            this.lblCadNome.Name = "lblCadNome";
            this.lblCadNome.Size = new System.Drawing.Size(38, 13);
            this.lblCadNome.TabIndex = 15;
            this.lblCadNome.Text = "Nome:";
            // 
            // lblCadMatricula
            // 
            this.lblCadMatricula.AutoSize = true;
            this.lblCadMatricula.Location = new System.Drawing.Point(26, 26);
            this.lblCadMatricula.Name = "lblCadMatricula";
            this.lblCadMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblCadMatricula.TabIndex = 14;
            this.lblCadMatricula.Text = "Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "RG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "CEP:";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(88, 106);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(100, 20);
            this.txbEndereco.TabIndex = 36;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(88, 128);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 37;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(88, 151);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(100, 20);
            this.txbBairro.TabIndex = 38;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(88, 177);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(100, 20);
            this.txbCidade.TabIndex = 39;
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(88, 205);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(100, 20);
            this.txbCEP.TabIndex = 40;
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(88, 232);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(100, 20);
            this.txbRG.TabIndex = 41;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(88, 258);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 20);
            this.txbTelefone.TabIndex = 42;
            // 
            // txbNasc
            // 
            this.txbNasc.Location = new System.Drawing.Point(90, 80);
            this.txbNasc.Name = "txbNasc";
            this.txbNasc.Size = new System.Drawing.Size(100, 20);
            this.txbNasc.TabIndex = 43;
            // 
            // frmCadAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 598);
            this.Controls.Add(this.txbNasc);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlunos);
            this.Controls.Add(this.btnLimparCampoAluno);
            this.Controls.Add(this.btnAlterarAluno);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnIncluirAluno);
            this.Controls.Add(this.gpbNav);
            this.Controls.Add(this.txbNomeAluno);
            this.Controls.Add(this.lblCodAlunos);
            this.Controls.Add(this.lblCadSigla);
            this.Controls.Add(this.lblCadNome);
            this.Controls.Add(this.lblCadMatricula);
            this.Name = "frmCadAlunos";
            this.Text = "Cadastro Alunos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadAlunos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).EndInit();
            this.gpbNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlunos;
        private System.Windows.Forms.Button btnLimparCampoAluno;
        private System.Windows.Forms.Button btnAlterarAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnIncluirAluno;
        private System.Windows.Forms.GroupBox gpbNav;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbNomeAluno;
        private System.Windows.Forms.Label lblCodAlunos;
        private System.Windows.Forms.Label lblCadSigla;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.Label lblCadMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbCEP;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbNasc;
    }
}
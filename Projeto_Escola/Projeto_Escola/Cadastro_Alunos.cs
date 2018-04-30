using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projeto_Escola
{
    public partial class frmCadAlunos : Form
    {

        static string strCn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Aluno\\Downloads\\projeto-escola-master\\Projeto_Escola\\Projeto_Escola\\Projeto_Escola\\bin\\Debug\\Bd_Escola.accdb";
        OleDbConnection conexao = new OleDbConnection(strCn);
        public frmCadAlunos()
        {
            InitializeComponent();
        }

        private void frmCadAlunos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do Cadastro de Alunos?", "Saindo Formulario Cadastro de Alunos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por adicionar dados ao banco (CRUD - Create) 
            string adiciona = "insert into Alunos values (" +
            txbNome.Text + ",'" +
            maskNasc.Text + "','" +
            txbEndereco.Text + "','" +
            txbNumero.Text + "','" +
            txtBairro.Text + "','" +
            txbCidade.Text + "','" +
            txbCep.Text + "','" +
            txbRg.Text + "','" +
            txbTelefone.Text + "')";

            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para //executar a instrução sql 
            OleDbCommand cmd = new OleDbCommand(adiciona, conexao);

            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro) 
            try
            {
                // Abrindo a conexão com o banco 
                conexao.Open();

                // Criando uma variável para adicionar e armazenar o resultado 
                int resultado;
                resultado = cmd.ExecuteNonQuery();

                // Verificando se o registro foi adicionado 
                // Caso o valor da variável resultado seja 1 
                // significa que o comando funcionou, neste caso limpar os campos e exibir uma //mensagem 
                if (resultado == 1)
                {
                    MessageBox.Show("Registro adicionado com sucesso");
                    txbNome.Clear();
                    txbEndereco.Clear();
                    txbNumero.Clear();
                    txtBairro.Clear();
                    txbCidade.Clear();
                    txbCep.Clear();
                    txbRg.Clear();
                    txbTelefone.Clear();
                    txbNome.Focus();
                }

                // Encerrando o uso do cmd 
                cmd.Dispose();
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }

            // de qualquer forma sempre fechar a conexão com o banco ("lembrar da porta da //geladeira rsrsrs") 
            finally
            {
                conexao.Close();
            } 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por remover um registro do banco (CRUD - Delete) 
            System.Convert.ToInt32(lblCodDisciplina.Text);
            string remove = "delete from Alunos where Matricula  = " + lblCodDisciplina.Text;


            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para //executar a instrução sql 
            OleDbCommand cmd = new OleDbCommand(remove, conexao);

            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro) 
            try
            {

                // Abrindo a conexão com o banco 
                conexao.Open();

                // Criando uma variável para adicionar e armazenar o resultado 
                int resultado;
                if (MessageBox.Show("Tem certeza que deseja remover este registro ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resultado = cmd.ExecuteNonQuery();
                    // Verificando se o registro foi apagado 
                    // Caso o valor da variável resultado seja 1 
                    // significa que o comando funcionou, neste caso limpar os campos e exibir uma //mensagem 
                    if (resultado == 1)
                    {
                        txbNome.Clear();
                        txbEndereco.Clear();
                        txbNumero.Clear();
                        txtBairro.Clear();
                        txbCidade.Clear();
                        txbCep.Clear();
                        txbRg.Clear();
                        txbTelefone.Clear();
                        txbNome.Focus();
                        MessageBox.Show("Registro removido com sucesso");
                    }

                    // Encerrando o uso do cmd 
                    cmd.Dispose();
                }
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }
            // de qualquer forma sempre fechar a conexão com o banco 
            finally
            {
                conexao.Close();
            } 
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por alterar um registro do banco (CRUD - Update) 
            string altera = "update Alunos set Matricula = '" + lblCodDisciplina.Text +
            "', Nome = '" + txbNome.Text +
            "', Nasc = '" + maskNasc.Text +
            "', Endereco = '" + txbEndereco.Text +
            "', Numero = '" + txbNumero.Text +
            "', Bairro = '" + txtBairro.Text +
            "', Cidade = '" + txbCidade.Text +
            "', Cep = '" + txbCep.Text +
            "', Rg = '" + txbRg.Text +
            "', Telefone = '" + txbTelefone.Text +
            "' where Matricula = " + lblCodDisciplina.Text;


            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para //executar a instrução sql 
            OleDbCommand cmd = new OleDbCommand(altera, conexao);

            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro) 
            try
            {
                // Abrindo a conexão com o banco 
                conexao.Open();

                // Criando uma variável para alterar e armazenar o resultado 
                int resultado;
                resultado = cmd.ExecuteNonQuery();
                // Verificando se o registro foi alterado 
                // Caso o valor da variável resultado seja 1 
                // significa que o comando funcionou, neste caso limpar os campos e exibir uma //mensagem 
                if (resultado == 1)
                {
                    txbNome.Clear();
                    txbEndereco.Clear();
                    txbNumero.Clear();
                    txtBairro.Clear();
                    txbCidade.Clear();
                    txbCep.Clear();
                    txbRg.Clear();
                    txbTelefone.Clear();
                    txbNome.Focus();
                    MessageBox.Show("Registro Alterado com sucesso");
                }
                // Encerrando o uso do cmd 
                cmd.Dispose();
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }

            // De qualquer forma sempre fechar a conexão com o banco 
            finally
            {
                conexao.Close();
            } 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbEndereco.Clear();
            txbNumero.Clear();
            txtBairro.Clear();
            txbCidade.Clear();
            txbCep.Clear();
            txbRg.Clear();
            txbTelefone.Clear();
            txbNome.Focus();
        }
    }
}

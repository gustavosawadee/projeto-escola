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
    public partial class frmCadDisciplinas : Form
    {
        static string strCn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Aluno\\Downloads\\projeto-escola-master\\Projeto_Escola\\Projeto_Escola\\Projeto_Escola\\bin\\Debug\\Bd_Escola.accdb";
        OleDbConnection conexao = new OleDbConnection(strCn);
        public frmCadDisciplinas()
        {
            InitializeComponent();
        }

        private void frmCadDisciplinas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair da Cadastro de Disciplinas?", "Saindo Cadastro de Disciplinas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por adicionar dados ao banco (CRUD - Create) 
            string adiciona = "insert into disciplinas values (" +
            txbCod.Text + ",'" + 
            txbCadDesc.Text + "','" +
            txbCadSigla.Text + "')";

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
                    txbCadDesc.Clear();
                    txbCadSigla.Clear();
                    txbCadSigla.Focus();
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

        private void button8_Click(object sender, EventArgs e)
        {
              //instrução sql responsável por remover um registro do banco (CRUD - Delete) 
            System.Convert.ToInt32(txbCod.Text);
            string remove = "delete from disciplinas where cod_disciplina  = " + txbCod.Text;
           

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
    txbCod.Clear();
    txbCadDesc.Clear();
    txbCadSigla.Clear();
    txbCod.Focus();
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

        private void button7_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por alterar um registro do banco (CRUD - Update) 
            string altera = "update disciplinas set cod_disciplina = '" + txbCod.Text +
            "', descricao= '" + txbCadDesc.Text +
            "', sigla= '" + txbCadSigla.Text +
            "' where cod_disciplina= " + txbCod.Text;


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
                    txbCadDesc.Clear();
                    txbCadSigla.Clear();
                    MessageBox.Show("Registro alterado com sucesso");
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

        private void button6_Click(object sender, EventArgs e)
        {
            txbCadDesc.Clear();
            txbCadSigla.Clear();
        }

        }

      
    }

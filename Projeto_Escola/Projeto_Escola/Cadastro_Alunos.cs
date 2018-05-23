using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Projeto_Escola
{
    public partial class frmCadAlunos : Form{
         private string conexaoBancoDados = "Persist Security Info=False;User ID=sa;Initial Catalog=BDEscola;Data Source=localhost;password=info211";
        public frmCadAlunos(){
            InitializeComponent();
            preechimento();
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

             private void preechimento() {
            //define a instrução SQL
            string script = "SELECT * FROM alunos";

            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            SQLSERVER.Open();
            
            SqlCommand comandoListar = new SqlCommand(script, SQLSERVER);
            comandoListar.ExecuteNonQuery();

            SqlDataAdapter TABELA = new SqlDataAdapter();
            TABELA.SelectCommand = comandoListar;

            DataSet tabelaVisualStudio = new DataSet();
            TABELA.Fill(tabelaVisualStudio);

            dataGridViewAlunos.DataSource = tabelaVisualStudio;
            dataGridViewAlunos.DataMember = tabelaVisualStudio.Tables[0].TableName;

            SQLSERVER.Close();
        }

             private void btnIncluirAluno_Click(object sender, EventArgs e)
             {
                 SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
                 SQLSERVER.Open();
                 string script = "INSERT INTO alunos values ('" + txbNomeAluno.Text + "', '" + txbNasc.Text + "', '" + txbEndereco.Text + "', '" 
                     + txbNumero.Text + "', '" + txbBairro.Text + "', '" + txbCidade.Text + "', '" + txbCEP.Text + "', '" + txbRG.Text + "', '" + txbTelefone.Text + "')";
                 SqlCommand comandoIncluir = new SqlCommand(script, SQLSERVER);
                 comandoIncluir.ExecuteNonQuery();


                 SQLSERVER.Close();
                 MessageBox.Show("Registro incluido com sucesso");
                 txbNomeAluno.Clear();
                 txbNasc.Clear();
                 txbEndereco.Clear();
                 txbNumero.Clear();
                 txbBairro.Clear();
                 txbCidade.Clear();
                 txbCEP.Clear();
                 txbRG.Clear();
                 txbTelefone.Clear();
                 txbNomeAluno.Focus();
                 preechimento();
             }

             private void btnLimparCampoAluno_Click(object sender, EventArgs e)
             {
                 txbNomeAluno.Clear();
                 txbNasc.Clear();
                 txbEndereco.Clear();
                 txbNumero.Clear();
                 txbBairro.Clear();
                 txbCidade.Clear();
                 txbCEP.Clear();
                 txbRG.Clear();
                 txbTelefone.Clear();
             }

             private void dataGridViewAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
             {
                 if (e.RowIndex >= 0)
                 {
                     DataGridViewRow row = dataGridViewAlunos.Rows[e.RowIndex];

                     lblCodAlunos.Text = row.Cells["id"].Value.ToString();
                     txbNomeAluno.Text = row.Cells["nome"].Value.ToString();
                     txbNasc.Text = row.Cells["nascimento"].Value.ToString();
                     txbEndereco.Text = row.Cells["endereco"].Value.ToString();
                     txbNumero.Text = row.Cells["numero"].Value.ToString();
                     txbBairro.Text = row.Cells["bairro"].Value.ToString();
                     txbCidade.Text = row.Cells["cidade"].Value.ToString();
                     txbCEP.Text = row.Cells["cep"].Value.ToString();
                     txbRG.Text = row.Cells["rg"].Value.ToString();
                     txbTelefone.Text = row.Cells["telefone"].Value.ToString();


                 }

                 /*int index = e.RowIndex;
                 DataGridViewRow row = dataGridViewDisciplinas.Rows[index];

                 lblCadCod.Text = row.Cells["id"].Value.ToString();
                 txbCadDesc.Text = row.Cells["disciplina"].Value.ToString();
                 txbCadSigla.Text = row.Cells["sigla"].Value.ToString();*/
             }

             private void btnExcluirAluno_Click(object sender, EventArgs e)
             {
                 SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
                 SQLSERVER.Open();
                 string script = "DELETE from alunos where id = '" + lblCodAlunos.Text + "'";
                 SqlCommand comandoExcluir = new SqlCommand(script, SQLSERVER);
                 comandoExcluir.ExecuteNonQuery();


                 SQLSERVER.Close();
                 MessageBox.Show("Registro excluido com sucesso");
                 txbNomeAluno.Clear();
                 txbNasc.Clear();
                 txbEndereco.Clear();
                 txbNumero.Clear();
                 txbBairro.Clear();
                 txbCidade.Clear();
                 txbCEP.Clear();
                 txbRG.Clear();
                 txbTelefone.Clear();
                 txbNomeAluno.Focus();
                 preechimento();
             }

             private void btnAlterarAluno_Click(object sender, EventArgs e)
             {
                 SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
                 SQLSERVER.Open();
                 string script = "UPDATE alunos SET nome = '" + txbNomeAluno.Text + "' nascimento = '" + txbNasc.Text + "' endereco = '" + txbEndereco.Text + "' numero '" + txbNumero.Text +
                      "' bairro '" + txbNumero.Text + "' cidade '" + txbCidade.Text + "' cep '" + txbCEP.Text + "' rg '" + txbRG.Text + "' telefone '" + txbTelefone.Text + "' where id = '" + lblCodAlunos.Text + "'";
                 SqlCommand comandoExcluir = new SqlCommand(script, SQLSERVER);
                 comandoExcluir.ExecuteNonQuery();


                 SQLSERVER.Close();
                 MessageBox.Show("Registro alterado com sucesso");
                 txbNomeAluno.Clear();
                 txbNasc.Clear();
                 txbEndereco.Clear();
                 txbNumero.Clear();
                 txbBairro.Clear();
                 txbCidade.Clear();
                 txbCEP.Clear();
                 txbRG.Clear();
                 txbTelefone.Clear();
                 txbNomeAluno.Focus();
                 preechimento();
             }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Escola{
    public partial class frmCadDisciplinas : Form{

        private string conexaoBancoDados = "Persist Security Info=False;User ID=sa;Initial Catalog=BDEscola;Data Source=localhost;password=info211";
        public frmCadDisciplinas(){
            InitializeComponent();
            preechimento();
        }

        private void frmCadDisciplinas_FormClosing(object sender, FormClosingEventArgs e){
            if (MessageBox.Show("Deseja sair da Cadastro de Disciplinas?", "Saindo Cadastro de Disciplinas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else{
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }
        private void preechimento() {
            //define a instrução SQL
            string script = "SELECT * FROM disciplinas";

            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            SQLSERVER.Open();
            
            SqlCommand comandoListar = new SqlCommand(script, SQLSERVER);
            comandoListar.ExecuteNonQuery();

            SqlDataAdapter TABELA = new SqlDataAdapter();
            TABELA.SelectCommand = comandoListar;

            DataSet tabelaVisualStudio = new DataSet();
            TABELA.Fill(tabelaVisualStudio);

            dataGridViewDisciplinas.DataSource = tabelaVisualStudio;
            dataGridViewDisciplinas.DataMember = tabelaVisualStudio.Tables[0].TableName;

            SQLSERVER.Close();
        }
        private void btnIncluirDisciplina_Click(object sender, EventArgs e){
  
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            SQLSERVER.Open();
            string script = "INSERT INTO disciplinas values ('" + txbCadDesc.Text + "', '" + txbCadSigla.Text + "')";
            SqlCommand comandoIncluir = new SqlCommand(script, SQLSERVER);
            comandoIncluir.ExecuteNonQuery();


            SQLSERVER.Close();
            MessageBox.Show("Registro incluido com sucesso");
            txbCadDesc.Clear();
            txbCadSigla.Clear();
            txbCadDesc.Focus();
            preechimento();
        }

        private void btnLimpar_Click(object sender, EventArgs e){
            txbCadDesc.Clear();
            txbCadSigla.Clear();
        }

        private void dataGridViewDisciplinas_CellClick(object sender, DataGridViewCellEventArgs e){
            if(e.RowIndex >= 0){
                DataGridViewRow row = dataGridViewDisciplinas.Rows[e.RowIndex];

                lblCadCod.Text = row.Cells["id"].Value.ToString();
                txbCadDesc.Text = row.Cells["disciplina"].Value.ToString();
                txbCadSigla.Text = row.Cells["sigla"].Value.ToString();
            }

            /*int index = e.RowIndex;
            DataGridViewRow row = dataGridViewDisciplinas.Rows[index];

            lblCadCod.Text = row.Cells["id"].Value.ToString();
            txbCadDesc.Text = row.Cells["disciplina"].Value.ToString();
            txbCadSigla.Text = row.Cells["sigla"].Value.ToString();*/
        }

        private void btnExcluirCad_Click(object sender, EventArgs e){
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            SQLSERVER.Open();
            string script = "DELETE from disciplinas where id = '" + lblCadCod.Text + "'";
            SqlCommand comandoExcluir = new SqlCommand(script, SQLSERVER);
            comandoExcluir.ExecuteNonQuery();


            SQLSERVER.Close();
            MessageBox.Show("Registro excluido com sucesso");
            txbCadDesc.Clear();
            txbCadSigla.Clear();
            txbCadDesc.Focus();
            preechimento();
        }

        public void btnAlterarCad_Click(object sender, EventArgs e){
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            SQLSERVER.Open();
            string script = "UPDATE disciplinas SET descricao = '" + txbCadDesc.Text + "' sigla = '" +  txbCadSigla.Text + "' where id = '" + lblCadCod.Text + "'";
            SqlCommand comandoExcluir = new SqlCommand(script, SQLSERVER);
            comandoExcluir.ExecuteNonQuery();

            
            SQLSERVER.Close();
            MessageBox.Show("Registro alterado com sucesso");
            txbCadDesc.Clear();
            txbCadSigla.Clear();
            txbCadDesc.Focus();
            preechimento();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {

        }        
    }
}

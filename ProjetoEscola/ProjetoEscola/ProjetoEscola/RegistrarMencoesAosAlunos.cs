using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoEscola
{
    public partial class frmRegistrarMencoesAosAlunos : Form
    {

        private string conexaoBancoDados = @"Persist Security Info=False;User ID=sa;Initial Catalog=db_escola;Data Source=LAB-07-02;password=info211";

        public frmRegistrarMencoesAosAlunos()
        {
            InitializeComponent();
            atualizaDataGrid();
            atualizarComboboxAluno();
            atualizarComboboxDisciplina();
        }


        public void atualizaDataGrid()
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string query = "select a.nome, d.sigla, d.descricao, m.mencao from tb_registrarMencao m inner join tb_alunos a on a.id=m.id_aluno inner join tb_disciplinas d on d.id=m.id_disciplina";
            SqlCommand cmd = new SqlCommand(query, SQLSERVER);
            SqlDataAdapter adapter = new SqlDataAdapter(query, SQLSERVER);

            SQLSERVER.Open();
            int resultado = cmd.ExecuteNonQuery();
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;

        }

        private void atualizarComboboxDisciplina()
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string query = "select id, sigla from tb_disciplinas";
            SqlCommand cmd = new SqlCommand(query, SQLSERVER);
            SQLSERVER.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            cbxDisciplina.DataSource = table;
            cbxDisciplina.ValueMember = "id";
            cbxDisciplina.DisplayMember = "sigla";

            reader.Close();
            reader.Dispose();

        }

        private void atualizarComboboxAluno()
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string query = "select id, nome from tb_alunos";
            SqlCommand cmd = new SqlCommand(query, SQLSERVER);
            SQLSERVER.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            cbxAluno.DataSource = table;
            cbxAluno.ValueMember = "id";
            cbxAluno.DisplayMember = "nome";

            reader.Close();
            reader.Dispose();

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string adiciona = "insert into tb_registrarMencao values ('" + cbxAluno.SelectedValue.ToString() + "','" + cbxDisciplina.SelectedValue.ToString() + "','" + cbxMencao.SelectedItem.ToString() + "')";

            //criando um objeto de nome cmd tendo como modelo a classe SqlCommand para executar a instrução sql

            SqlCommand cmd = new SqlCommand(adiciona, SQLSERVER);

            try
            {

                SQLSERVER.Open();
                int resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                {

                    MessageBox.Show("Registro adicionado com sucesso");
                    cbxAluno.Focus();

                    atualizaDataGrid();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {

                SQLSERVER.Close();
            }
        }

    }
}

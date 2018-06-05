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
    public partial class frmConsultaPorDisciplinas : Form
    {

        private string conexaoBancoDados = @"Persist Security Info=False;User ID=sa;Initial Catalog=db_escola;Data Source=LAB-07-02;password=info211";

        public frmConsultaPorDisciplinas()
        {
            InitializeComponent();
            atualizaDataGrid();
        }

        private void atualizarComboboxSigla()
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string query = "select id, sigla from tb_disciplinas";
            SqlCommand cmd = new SqlCommand(query, SQLSERVER);
            SQLSERVER.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            cbxSigla.DataSource = table;
            cbxSigla.ValueMember = "id";
            cbxSigla.DisplayMember = "sigla";

            reader.Close();
            reader.Dispose();

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
    }
}

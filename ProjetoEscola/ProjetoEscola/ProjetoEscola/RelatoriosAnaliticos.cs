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
    public partial class frmRelatoriosAnaliticos : Form
    {

        private string conexaoBancoDados = @"Persist Security Info=False;User ID=sa;Initial Catalog=db_escola;Data Source=LAB-07-02;password=info211";

        public frmRelatoriosAnaliticos()
        {
            InitializeComponent();
            atualizaDataGrid();
        }

        public void atualizaDataGrid()
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string query = "select * from tb_alunos";
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

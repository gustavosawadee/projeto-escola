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
    public partial class FrmCadastroDisciplinas : Form
    {
        private string conexaoBancoDados = @"Persist Security Info=False;User ID=sa;Initial Catalog=db_escola;Data Source=LAB-07-02;password=info211";

        public FrmCadastroDisciplinas()
        {
            InitializeComponent();
            atualizaDataGrid();
        }

        private void btnIcluir_Click(object sender, EventArgs e)
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string adiciona = "insert into tb_disciplinas values ('" + txbCodigo.Text + "','" + txbDescricao.Text + "','" + txbSigla.Text + "')";

            //criando um objeto de nome cmd tendo como modelo a classe SqlCommand para executar a instrução sql

            SqlCommand cmd = new SqlCommand(adiciona, SQLSERVER);

            try
            {

                SQLSERVER.Open();
                int resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                {

                    MessageBox.Show("Registro adicionado com sucesso");
                    txbCodigo.Focus();

                    txbDescricao.Clear();

                    txbSigla.Clear();

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string remove = "DELETE FROM tb_disciplinas WHERE id = " + txbCodigo.Text;
            SqlCommand cmd = new SqlCommand(remove, SQLSERVER);


            try
            {

                SQLSERVER.Open();

                if (MessageBox.Show("Tem certeza que deseja remover este registro ?",

                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int resultado = cmd.ExecuteNonQuery();


                    if (resultado == 1)
                    {
                        txbCodigo.Focus();

                        txbDescricao.Clear();

                        txbSigla.Clear();

                        MessageBox.Show("Registro removido com sucesso");

                        atualizaDataGrid();
                    }

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

        public void atualizaDataGrid()
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string query = "select * from tb_disciplinas";
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string altera = "update tb_disciplinas set Descricao='" + txbDescricao.Text + "',Sigla= '" + txbSigla.Text + "' where Id= " + txbCodigo.Text;
            SqlCommand cmd = new SqlCommand(altera, SQLSERVER);
            try
            {
                SQLSERVER.Open();
                int resultado;
                resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                {
                    txbCodigo.Clear();
                    txbDescricao.Clear();
                    txbSigla.Clear();
                    txbCodigo.Focus();
                    MessageBox.Show("Registro alterado com sucesso");
                    atualizaDataGrid();
                }
                cmd.Dispose();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCodigo.Clear();
            txbDescricao.Clear();
            txbSigla.Clear();
        }

        private void txbSiglaPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            var filtro = (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("sigla LIKE'%{0}%'", txbSiglaPesquisa.Text);
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            txbCodigo.Clear();
            txbDescricao.Clear();
            txbSigla.Clear();
            txbCodigo.Focus();
        }
    }
}

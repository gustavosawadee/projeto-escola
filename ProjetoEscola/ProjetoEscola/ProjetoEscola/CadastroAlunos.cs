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
    public partial class frmCadastroAlunos : Form
    {
        private string conexaoBancoDados = @"Persist Security Info=False;User ID=sa;Initial Catalog=db_escola;Data Source=LAB-07-02;password=info211";
        public frmCadastroAlunos()
        {
            InitializeComponent();
            atualizaDataGrid();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string adiciona = "insert into tb_alunos values ('" + txbNome.Text + "','" + txbNasc.Text + "','" + txbEndereco.Text + "','" + txbNumero.Text + "','" + txbBairro.Text + "','" + txbCidade.Text + "','" + txbCep.Text + "','"+ txbRg.Text +"','"+ txbTelefone.Text +"')";

            //criando um objeto de nome cmd tendo como modelo a classe SqlCommand para executar a instrução sql

            SqlCommand cmd = new SqlCommand(adiciona, SQLSERVER);

            try
            {

                SQLSERVER.Open();
                int resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                {

                    MessageBox.Show("Registro adicionado com sucesso");
                    txbId.Focus();

                    txbNome.Clear();

                    txbNasc.Clear();

                    txbEndereco.Clear();

                    txbNumero.Clear();

                    txbBairro.Clear();

                    txbCidade.Clear();

                    txbCep.Clear();

                    txbRg.Clear();

                    txbTelefone.Clear();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbNasc.Clear();
            txbEndereco.Clear();
            txbNumero.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbCep.Clear();
            txbRg.Clear();
            txbTelefone.Clear();
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
            dataGridAlunos.ReadOnly = true;
            dataGridAlunos.DataSource = ds.Tables[0];
            dataGridAlunos.AllowUserToAddRows = false;
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
            string remove = "DELETE FROM tb_alunos WHERE id =" + txbId.Text;
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
                        txbId.Focus();

                        txbNome.Clear();

                        txbNasc.Clear();

                        txbEndereco.Clear();

                        txbNumero.Clear();

                        txbBairro.Clear();

                        txbCidade.Clear();

                        txbCep.Clear();

                        txbRg.Clear();

                        txbTelefone.Clear();

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           SqlConnection SQLSERVER = new SqlConnection(conexaoBancoDados);
           string altera = "update tb_alunos set Nome='" + txbNome.Text + "',Nascimento= '" + txbNasc.Text + "' ,Endereco= '" + txbEndereco.Text + "',Numero= '"+ txbNumero.Text +"' ,Bairro= '"+ txbBairro.Text +"',Cidade='"+txbCidade.Text+"',Cep='"+txbCep.Text+"',RG='"+txbRg.Text+"',Telefone='"+txbTelefone.Text+"' where Id= " + txbId.Text;
           SqlCommand cmd = new SqlCommand(altera, SQLSERVER);
            try
            {
                SQLSERVER.Open();
                int resultado;
                resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                {
                    txbId.Clear();
                    txbNome.Clear();
                    txbNasc.Clear();
                    txbEndereco.Clear();
                    txbNumero.Clear();
                    txbBairro.Clear();
                    txbCidade.Clear();
                    txbCep.Clear();
                    txbRg.Clear();
                    txbTelefone.Clear();
                    txbId.Focus();
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

        private void txbNomeAlunoPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            var filtro = (dataGridAlunos.DataSource as DataTable).DefaultView.RowFilter = string.Format("nome LIKE'%{0}%'", txbNomeAlunoPesquisa.Text);
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            txbId.Clear();
            txbNome.Clear();
            txbNasc.Clear();
            txbEndereco.Clear();
            txbNumero.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbCep.Clear();
            txbRg.Clear();
            txbTelefone.Clear();
            txbId.Focus();
        }
       /* public void configDataGridView()
        {
            dataGridAlunos.Columns[0].HeaderText = "Nome";
            dataGridAlunos.Columns[0].Width = 390;
            dataGridAlunos.Columns["nome"].Visible = true;
        }*/


    }
}

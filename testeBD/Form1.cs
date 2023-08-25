using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
namespace testeBD
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        public Form1()
        {
            InitializeComponent();
            ltContato.View = View.Details;
            ltContato.LabelEdit = true;
            ltContato.AllowColumnReorder = true;
            ltContato.FullRowSelect = true;
            ltContato.GridLines = true;
            ltContato.Columns.Add("ID", 30, HorizontalAlignment.Left);
            ltContato.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            ltContato.Columns.Add("Email", 150, HorizontalAlignment.Left);
            ltContato.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=;database=db_agenda";
                //criar conexao
                Conexao = new MySqlConnection(data_source);
                string sql = "INSERT INTO contato (nome,email,telefone) VALUES('" + txtNome.Text + "','" + txtEmail.Text + "','" + txtTelefone.Text + "')";
                // executar comando insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Deu certo,inserido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                string q = "'%" + txtBuscar.Text + "%'";
                string data_source = "datasource=localhost;username=root;password=;database=db_agenda";
                //criando conexao

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT *" +
                            "FROM contato " +
                            "WHERE nome LIKE" + q + "OR email LIKE" + q;
                Conexao.Open();
                // executar comando insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                ltContato.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    var linha_listview = new ListViewItem(row);
                    ltContato.Items.Add(linha_listview);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
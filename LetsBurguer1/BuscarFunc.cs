using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LetsBurguer1
{
    public partial class BuscarFunc : Form
    {
        private MySqlConnection Conexao;

        private string data_source = "datasource=localhost; username=root; password=Pipoca123_;database=cadastro";

        public BuscarFunc()
        {
            InitializeComponent();

            //CRIAR CONEXAO COM MYSQL

            Conexao = new MySqlConnection(data_source);

            Conexao.Open();

            //

            listall.View = View.Details;
            listall.LabelEdit = true;
            listall.AllowColumnReorder = true;
            listall.FullRowSelect = true;
            listall.GridLines = true;

            listall.Columns.Add("ID", 30, HorizontalAlignment.Left);                //COMPONENTES TABELA BUSCA
            listall.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listall.Columns.Add("Email", 150, HorizontalAlignment.Left);
            listall.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
            listall.Columns.Add("Celular", 150, HorizontalAlignment.Left);
        }

        private void btn_mostrar_Click(object sender, EventArgs e)      //BUSCAR ESPECIFICO
        {
            try
            {
                //EXECUTAR COMANDO BUSCA


                string sql = "SELECT * FROM pessoas WHERE Nome LIKE '" + txtBuscar.Text + "' OR Email LIKE  '" + txtBuscar.Text + "'";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                listall.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                    };

                    var linha_listview = new ListViewItem(row);
                    listall.Items.Add(linha_listview);
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


        private void btn_mostrartodos_Click(object sender, EventArgs e)       //BUSCAR TODOS
        {
            try
            {
                //CRIAR CONEXAO COM MYSQL

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();


                //EXECUTAR COMANDO BUSCA

                string sql = "SELECT * FROM pessoas";


                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                listall.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                    };

                    var linha_listview = new ListViewItem(row);
                    listall.Items.Add(linha_listview);
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

        private void atualizarFuncionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AttFunc = new AttFunc();
            AttFunc.Closed += (s, args) => this.Close();
            AttFunc.Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MenuPrincipal = new MenuPrincipal();
            MenuPrincipal.Closed += (s, args) => this.Close();
            MenuPrincipal.Show();
        }

        private void excluirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DelFunc = new DelFunc();
            DelFunc.Closed += (s, args) => this.Close();
            DelFunc.Show();
        }
    

    private void BuscarFunc_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    }

}



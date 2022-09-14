using System;
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
    public partial class DelFunc : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root; password=Pipoca123_;database=cadastro";
        public DelFunc()
        {
            InitializeComponent();

            //CRIAR CONEXAO COM MYSQL

            Conexao = new MySqlConnection(data_source);

            Conexao.Open();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                //EXECUTAR COMANDO DELETE

                MySqlCommand comando = new MySqlCommand("delete from pessoas where ID='" + txt_id.Text + "'", Conexao);

                comando.ExecuteReader();

                MessageBox.Show("Apagado com sucesso.");
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

        private void btn_voltar4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BuscarFunc = new BuscarFunc();
            BuscarFunc.Closed += (s, args) => this.Close();
            BuscarFunc.Show();
        }
    }
}

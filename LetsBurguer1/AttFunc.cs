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
    public partial class AttFunc : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root; password=Pipoca123_;database=cadastro";
        
        public AttFunc()
        {
            InitializeComponent();


            //CRIAR CONEXAO COM MYSQL

            Conexao = new MySqlConnection(data_source);
            Conexao.Open();
        }

        private void button1_Click(object sender, EventArgs e)  //ATUALIZAR
        {
            try
            {
                //EXECUTAR COMANDO ATUALIZAR

                MySqlCommand comando = new MySqlCommand("update pessoas set Nome= '" + txt_nome.Text + "'," +
                    "                                                       Email= '" + txt_email.Text + "'," +
                    "                                                       Telefone= '" + txt_telefone.Text + "'," +
                    "                                                       Celular= '" + txt_celular.Text + "' where ID='" + txt_id.Text + "'", Conexao);

                comando.ExecuteReader();

                MessageBox.Show("Atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_voltar3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BuscarFunc = new BuscarFunc();
            BuscarFunc.Closed += (s, args) => this.Close();
            BuscarFunc.Show();
        }
    }
}

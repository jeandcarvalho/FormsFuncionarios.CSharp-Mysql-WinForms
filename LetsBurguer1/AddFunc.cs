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
    public partial class AddFunc : Form
    {
        private MySqlConnection Conexao;
        private const string data_source = "datasource=localhost; username=root; password=Pipoca123_;database=cadastro";

        public AddFunc()
        {
            InitializeComponent();

            //CRIAR CONEXAO COM MYSQL

            this.Conexao = new MySqlConnection(data_source); 
        }  

         private void btn_add_Click(object sender, EventArgs e)   //ADICIONAR
         {
            try
            {
                Conexao.Open();


                //EXECUTAR COMANDO INSERT

                string sql = "INSERT INTO pessoas(Nome, Email, Telefone, Celular)" +
                             "VALUES ('" + txt_nome.Text + "', + '" + txt_email.Text + "'," +
                                  " + '" + txt_telefone.Text + "', + '" + txt_celular.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.ExecuteReader();

                MessageBox.Show("Inserido com sucesso");
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

        private void btn_voltar_Click(object sender, EventArgs e)
            {
            this.Hide();
            var MenuPrincipal = new MenuPrincipal();
            MenuPrincipal.Closed += (s, args) => this.Close();
            MenuPrincipal.Show();
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (planovip.Checked == true)
            {
                planovip.Checked = false;
            }
            else if (Plano.Checked == false)
            {
                Plano.Checked = true;
                Plano.Enabled = false;
                planovip.Enabled = true;
            }
            else if (Plano.Checked == true)
            {
                Plano.Enabled = false;
                planovip.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void planovip_CheckedChanged(object sender, EventArgs e)
        {
            if (Plano.Checked == true)
            {
                Plano.Checked = false;
            }
            else if(planovip.Checked == false)
            {
                planovip.Checked = true;
                planovip.Enabled = false;
                Plano.Enabled = true;
            }
            else if (planovip.Checked == true)
            {
                planovip.Enabled = false;
                Plano.Enabled = true;
            }
        }
    }
}


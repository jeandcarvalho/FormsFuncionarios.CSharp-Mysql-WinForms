namespace LetsBurguer1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void adicionarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AddFunc = new AddFunc();
            AddFunc.Closed += (s, args) => this.Close();
            AddFunc.Show();
        }

        private void buscarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BuscarFunc = new BuscarFunc();
            BuscarFunc.Closed += (s, args) => this.Close();
            BuscarFunc.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inserirAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }
    }
}
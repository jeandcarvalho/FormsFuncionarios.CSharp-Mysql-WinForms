namespace LetsBurguer1
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(17, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(994, 69);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(168, 57);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarFuncionariosToolStripMenuItem,
            this.buscarFuncionariosToolStripMenuItem});
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // adicionarFuncionariosToolStripMenuItem
            // 
            this.adicionarFuncionariosToolStripMenuItem.Name = "adicionarFuncionariosToolStripMenuItem";
            this.adicionarFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(580, 66);
            this.adicionarFuncionariosToolStripMenuItem.Text = "Adicionar Funcionarios";
            this.adicionarFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.adicionarFuncionariosToolStripMenuItem_Click);
            // 
            // buscarFuncionariosToolStripMenuItem
            // 
            this.buscarFuncionariosToolStripMenuItem.Name = "buscarFuncionariosToolStripMenuItem";
            this.buscarFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(580, 66);
            this.buscarFuncionariosToolStripMenuItem.Text = "Buscar Funcionarios ";
            this.buscarFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.buscarFuncionariosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(107, 57);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 90);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private ToolStripMenuItem adicionarFuncionariosToolStripMenuItem;
        private ToolStripMenuItem buscarFuncionariosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
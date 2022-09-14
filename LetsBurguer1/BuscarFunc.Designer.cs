namespace LetsBurguer1
{
    partial class BuscarFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listall = new System.Windows.Forms.ListView();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_mostrartodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atualizarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarFuncionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listall
            // 
            this.listall.Location = new System.Drawing.Point(46, 135);
            this.listall.Name = "listall";
            this.listall.Size = new System.Drawing.Size(619, 146);
            this.listall.TabIndex = 0;
            this.listall.UseCompatibleStateImageBehavior = false;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(683, 89);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 1;
            this.btn_mostrar.Text = "Buscar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_mostrartodos
            // 
            this.btn_mostrartodos.Location = new System.Drawing.Point(683, 177);
            this.btn_mostrartodos.Name = "btn_mostrartodos";
            this.btn_mostrartodos.Size = new System.Drawing.Size(75, 67);
            this.btn_mostrartodos.TabIndex = 2;
            this.btn_mostrartodos.Text = "Mostrar Todos";
            this.btn_mostrartodos.UseVisualStyleBackColor = true;
            this.btn_mostrartodos.Click += new System.EventHandler(this.btn_mostrartodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira Nome ou Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(214, 88);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(451, 23);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar Funcionários";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarFuncionárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atualizarFuncionárioToolStripMenuItem
            // 
            this.atualizarFuncionárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarFuncionárioToolStripMenuItem1,
            this.excluirFuncionárioToolStripMenuItem});
            this.atualizarFuncionárioToolStripMenuItem.Name = "atualizarFuncionárioToolStripMenuItem";
            this.atualizarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.atualizarFuncionárioToolStripMenuItem.Text = "Opções";
            // 
            // atualizarFuncionárioToolStripMenuItem1
            // 
            this.atualizarFuncionárioToolStripMenuItem1.Name = "atualizarFuncionárioToolStripMenuItem1";
            this.atualizarFuncionárioToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.atualizarFuncionárioToolStripMenuItem1.Text = "Atualizar funcionário";
            this.atualizarFuncionárioToolStripMenuItem1.Click += new System.EventHandler(this.atualizarFuncionárioToolStripMenuItem1_Click);
            // 
            // excluirFuncionárioToolStripMenuItem
            // 
            this.excluirFuncionárioToolStripMenuItem.Name = "excluirFuncionárioToolStripMenuItem";
            this.excluirFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.excluirFuncionárioToolStripMenuItem.Text = "Excluir funcionário";
            this.excluirFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.excluirFuncionárioToolStripMenuItem_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(704, 269);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(45, 25);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // BuscarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 306);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mostrartodos);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.listall);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BuscarFunc";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.BuscarFunc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listall;
        private Button btn_mostrar;
        private Button btn_mostrartodos;
        private Label label1;
        private TextBox txtBuscar;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atualizarFuncionárioToolStripMenuItem;
        private ToolStripMenuItem atualizarFuncionárioToolStripMenuItem1;
        private ToolStripMenuItem excluirFuncionárioToolStripMenuItem;
        private Button btn_voltar;
    }
}
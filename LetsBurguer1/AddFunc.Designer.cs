namespace LetsBurguer1
{
    partial class AddFunc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.Plano = new System.Windows.Forms.CheckBox();
            this.planovip = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(669, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(237, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(787, 106);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preencha os campos:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(366, 266);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(278, 55);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(366, 384);
            this.txt_email.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(278, 55);
            this.txt_email.TabIndex = 6;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(831, 266);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_telefone.Mask = "(00)0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(278, 55);
            this.txt_telefone.TabIndex = 7;
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(831, 384);
            this.txt_celular.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_celular.Mask = "(00)00000-0000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(278, 55);
            this.txt_celular.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(831, 582);
            this.btn_add.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(254, 115);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(1140, 611);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(131, 74);
            this.btn_voltar.TabIndex = 10;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Plano
            // 
            this.Plano.AutoSize = true;
            this.Plano.Location = new System.Drawing.Point(237, 505);
            this.Plano.Name = "Plano";
            this.Plano.Size = new System.Drawing.Size(307, 52);
            this.Plano.TabIndex = 11;
            this.Plano.Text = "Plano de saúde";
            this.Plano.UseVisualStyleBackColor = true;
            this.Plano.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // planovip
            // 
            this.planovip.AutoSize = true;
            this.planovip.Location = new System.Drawing.Point(237, 601);
            this.planovip.Name = "planovip";
            this.planovip.Size = new System.Drawing.Size(369, 52);
            this.planovip.TabIndex = 12;
            this.planovip.Text = "Plano de saúde VIP";
            this.planovip.UseVisualStyleBackColor = true;
            this.planovip.CheckedChanged += new System.EventHandler(this.planovip_CheckedChanged);
            // 
            // AddFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 723);
            this.Controls.Add(this.planovip);
            this.Controls.Add(this.Plano);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "AddFunc";
            this.Text = "Adicionar Funcionário";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_nome;
        private TextBox txt_email;
        private MaskedTextBox txt_telefone;
        private MaskedTextBox txt_celular;
        private Button btn_add;
        private Button btn_voltar;
        private CheckBox Plano;
        private CheckBox planovip;
    }
}
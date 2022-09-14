namespace LetsBurguer1
{
    partial class DelFunc
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_voltar4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira a ID do funcionário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Excluir Funcionário";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(137, 119);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 2;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_apagar.Location = new System.Drawing.Point(137, 157);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(100, 30);
            this.btn_apagar.TabIndex = 3;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_voltar4
            // 
            this.btn_voltar4.Location = new System.Drawing.Point(293, 209);
            this.btn_voltar4.Name = "btn_voltar4";
            this.btn_voltar4.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar4.TabIndex = 4;
            this.btn_voltar4.Text = "Voltar";
            this.btn_voltar4.UseVisualStyleBackColor = true;
            this.btn_voltar4.Click += new System.EventHandler(this.btn_voltar4_Click);
            // 
            // DelFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 244);
            this.Controls.Add(this.btn_voltar4);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DelFunc";
            this.Text = "Excluir funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_id;
        private Button btn_apagar;
        private Button btn_voltar4;
    }
}
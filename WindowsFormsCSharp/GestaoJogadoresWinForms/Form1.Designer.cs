namespace GestaoJogadoresWinForms
{
    partial class frmPrincipal
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
            this.lbl_trocaTexto = new System.Windows.Forms.Label();
            this.lbl_nomeJogador = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_nomeMaiusculo = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_nomeJogador = new System.Windows.Forms.TextBox();
            this.txt_listaNomes = new System.Windows.Forms.TextBox();
            this.btn_inserirNome = new System.Windows.Forms.Button();
            this.lbl_totalNomes = new System.Windows.Forms.Label();
            this.lbl_ListaJogadoresCadastrados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_trocaTexto
            // 
            this.lbl_trocaTexto.AutoSize = true;
            this.lbl_trocaTexto.Location = new System.Drawing.Point(12, 9);
            this.lbl_trocaTexto.Name = "lbl_trocaTexto";
            this.lbl_trocaTexto.Size = new System.Drawing.Size(198, 15);
            this.lbl_trocaTexto.TabIndex = 0;
            this.lbl_trocaTexto.Text = "Label Exemplificando Troca de Texto";
            // 
            // lbl_nomeJogador
            // 
            this.lbl_nomeJogador.AutoSize = true;
            this.lbl_nomeJogador.Location = new System.Drawing.Point(12, 110);
            this.lbl_nomeJogador.Name = "lbl_nomeJogador";
            this.lbl_nomeJogador.Size = new System.Drawing.Size(85, 15);
            this.lbl_nomeJogador.TabIndex = 1;
            this.lbl_nomeJogador.Text = "Nome Jogador";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(12, 39);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_nomeMaiusculo
            // 
            this.btn_nomeMaiusculo.Location = new System.Drawing.Point(110, 151);
            this.btn_nomeMaiusculo.Name = "btn_nomeMaiusculo";
            this.btn_nomeMaiusculo.Size = new System.Drawing.Size(100, 23);
            this.btn_nomeMaiusculo.TabIndex = 3;
            this.btn_nomeMaiusculo.Text = "Para Maiusculo";
            this.btn_nomeMaiusculo.UseVisualStyleBackColor = true;
            this.btn_nomeMaiusculo.Click += new System.EventHandler(this.btn_nomeMaiusculo_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(216, 151);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 23);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_nomeJogador
            // 
            this.txt_nomeJogador.Location = new System.Drawing.Point(110, 110);
            this.txt_nomeJogador.Name = "txt_nomeJogador";
            this.txt_nomeJogador.Size = new System.Drawing.Size(232, 23);
            this.txt_nomeJogador.TabIndex = 5;
            // 
            // txt_listaNomes
            // 
            this.txt_listaNomes.Enabled = false;
            this.txt_listaNomes.Location = new System.Drawing.Point(366, 110);
            this.txt_listaNomes.Multiline = true;
            this.txt_listaNomes.Name = "txt_listaNomes";
            this.txt_listaNomes.ReadOnly = true;
            this.txt_listaNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_listaNomes.Size = new System.Drawing.Size(422, 250);
            this.txt_listaNomes.TabIndex = 6;
            // 
            // btn_inserirNome
            // 
            this.btn_inserirNome.Location = new System.Drawing.Point(110, 180);
            this.btn_inserirNome.Name = "btn_inserirNome";
            this.btn_inserirNome.Size = new System.Drawing.Size(100, 23);
            this.btn_inserirNome.TabIndex = 7;
            this.btn_inserirNome.Text = "Inserir Nome";
            this.btn_inserirNome.UseVisualStyleBackColor = true;
            this.btn_inserirNome.Click += new System.EventHandler(this.btn_inserirNome_Click);
            // 
            // lbl_totalNomes
            // 
            this.lbl_totalNomes.AutoSize = true;
            this.lbl_totalNomes.Location = new System.Drawing.Point(366, 372);
            this.lbl_totalNomes.Name = "lbl_totalNomes";
            this.lbl_totalNomes.Size = new System.Drawing.Size(44, 15);
            this.lbl_totalNomes.TabIndex = 8;
            this.lbl_totalNomes.Text = "Total: 0";
            // 
            // lbl_ListaJogadoresCadastrados
            // 
            this.lbl_ListaJogadoresCadastrados.AutoSize = true;
            this.lbl_ListaJogadoresCadastrados.Location = new System.Drawing.Point(366, 83);
            this.lbl_ListaJogadoresCadastrados.Name = "lbl_ListaJogadoresCadastrados";
            this.lbl_ListaJogadoresCadastrados.Size = new System.Drawing.Size(171, 15);
            this.lbl_ListaJogadoresCadastrados.TabIndex = 9;
            this.lbl_ListaJogadoresCadastrados.Text = "Lista de Jogadores Cadastrados";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ListaJogadoresCadastrados);
            this.Controls.Add(this.lbl_totalNomes);
            this.Controls.Add(this.btn_inserirNome);
            this.Controls.Add(this.txt_listaNomes);
            this.Controls.Add(this.txt_nomeJogador);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_nomeMaiusculo);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.lbl_nomeJogador);
            this.Controls.Add(this.lbl_trocaTexto);
            this.Name = "frmPrincipal";
            this.Text = "Formulário de Gestão de Jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_trocaTexto;
        private Label lbl_nomeJogador;
        private Button btn_alterar;
        private Button btn_nomeMaiusculo;
        private Button btn_limpar;
        private TextBox txt_nomeJogador;
        private TextBox txt_listaNomes;
        private Button btn_inserirNome;
        private Label lbl_totalNomes;
        private Label lbl_ListaJogadoresCadastrados;
    }
}
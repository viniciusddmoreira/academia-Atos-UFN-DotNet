namespace CadastroPessoasWinFormsADONET
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
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.txt_Consultar = new System.Windows.Forms.TextBox();
            this.dgv_Consultas = new System.Windows.Forms.DataGridView();
            this.lbl_FiltrarNome = new System.Windows.Forms.Label();
            this.lbl_CadastrarPessoa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(58, 138);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gravar.TabIndex = 2;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(543, 74);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(106, 23);
            this.btn_Consultar.TabIndex = 5;
            this.btn_Consultar.Text = "Consultar Todos";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(462, 74);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar.TabIndex = 4;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 44);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Location = new System.Drawing.Point(12, 96);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(32, 15);
            this.lbl_Peso.TabIndex = 4;
            this.lbl_Peso.Text = "Peso";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(58, 36);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 23);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(58, 93);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(100, 23);
            this.txt_Peso.TabIndex = 1;
            // 
            // txt_Consultar
            // 
            this.txt_Consultar.Location = new System.Drawing.Point(462, 36);
            this.txt_Consultar.Name = "txt_Consultar";
            this.txt_Consultar.Size = new System.Drawing.Size(258, 23);
            this.txt_Consultar.TabIndex = 3;
            // 
            // dgv_Consultas
            // 
            this.dgv_Consultas.AllowUserToAddRows = false;
            this.dgv_Consultas.AllowUserToDeleteRows = false;
            this.dgv_Consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consultas.Location = new System.Drawing.Point(377, 149);
            this.dgv_Consultas.Name = "dgv_Consultas";
            this.dgv_Consultas.ReadOnly = true;
            this.dgv_Consultas.RowTemplate.Height = 25;
            this.dgv_Consultas.Size = new System.Drawing.Size(411, 289);
            this.dgv_Consultas.TabIndex = 8;
            // 
            // lbl_FiltrarNome
            // 
            this.lbl_FiltrarNome.AutoSize = true;
            this.lbl_FiltrarNome.Location = new System.Drawing.Point(462, 9);
            this.lbl_FiltrarNome.Name = "lbl_FiltrarNome";
            this.lbl_FiltrarNome.Size = new System.Drawing.Size(93, 15);
            this.lbl_FiltrarNome.TabIndex = 9;
            this.lbl_FiltrarNome.Text = "Pesquisar Nome";
            // 
            // lbl_CadastrarPessoa
            // 
            this.lbl_CadastrarPessoa.AutoSize = true;
            this.lbl_CadastrarPessoa.Location = new System.Drawing.Point(58, 9);
            this.lbl_CadastrarPessoa.Name = "lbl_CadastrarPessoa";
            this.lbl_CadastrarPessoa.Size = new System.Drawing.Size(96, 15);
            this.lbl_CadastrarPessoa.TabIndex = 10;
            this.lbl_CadastrarPessoa.Text = "Cadastrar Pessoa";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_CadastrarPessoa);
            this.Controls.Add(this.lbl_FiltrarNome);
            this.Controls.Add(this.dgv_Consultas);
            this.Controls.Add(this.txt_Consultar);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Gravar);
            this.Name = "frmPrincipal";
            this.Text = "Formulário de Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Gravar;
        private Button btn_Consultar;
        private Button btn_Filtrar;
        private Label lbl_Nome;
        private Label lbl_Peso;
        private TextBox txt_Nome;
        private TextBox txt_Peso;
        private TextBox txt_Consultar;
        private DataGridView dgv_Consultas;
        private Label lbl_FiltrarNome;
        private Label lbl_CadastrarPessoa;
    }
}
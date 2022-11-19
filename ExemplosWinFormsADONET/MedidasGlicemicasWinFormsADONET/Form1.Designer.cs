namespace MedidasGlicemicasWinFormsADONET
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
            this.lv_MedidasGlicemicas = new System.Windows.Forms.ListView();
            this.ch_IdMedida = new System.Windows.Forms.ColumnHeader();
            this.ch_ValorGlicemico = new System.Windows.Forms.ColumnHeader();
            this.ch_DataMedicao = new System.Windows.Forms.ColumnHeader();
            this.ch_Paciente = new System.Windows.Forms.ColumnHeader();
            this.ch_IdPaciente = new System.Windows.Forms.ColumnHeader();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.pnl_Campos = new System.Windows.Forms.Panel();
            this.txt_IdGlicemia = new System.Windows.Forms.TextBox();
            this.lbl_IdMedidaGlicemia = new System.Windows.Forms.Label();
            this.txt_IdPaciente = new System.Windows.Forms.TextBox();
            this.txt_DataMedicao = new System.Windows.Forms.TextBox();
            this.txt_ValorGlicemia = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.lbl_IdPaciente = new System.Windows.Forms.Label();
            this.lbl_DataMedicao = new System.Windows.Forms.Label();
            this.lbl_ValorGlicemia = new System.Windows.Forms.Label();
            this.pnl_Campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_MedidasGlicemicas
            // 
            this.lv_MedidasGlicemicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_IdMedida,
            this.ch_ValorGlicemico,
            this.ch_DataMedicao,
            this.ch_Paciente,
            this.ch_IdPaciente});
            this.lv_MedidasGlicemicas.Location = new System.Drawing.Point(12, 12);
            this.lv_MedidasGlicemicas.Name = "lv_MedidasGlicemicas";
            this.lv_MedidasGlicemicas.Size = new System.Drawing.Size(640, 257);
            this.lv_MedidasGlicemicas.TabIndex = 0;
            this.lv_MedidasGlicemicas.UseCompatibleStateImageBehavior = false;
            this.lv_MedidasGlicemicas.View = System.Windows.Forms.View.Details;
            this.lv_MedidasGlicemicas.SelectedIndexChanged += new System.EventHandler(this.lv_MedidasGlicemicas_SelectedIndexChanged);
            // 
            // ch_IdMedida
            // 
            this.ch_IdMedida.Text = "ID Medida";
            this.ch_IdMedida.Width = 80;
            // 
            // ch_ValorGlicemico
            // 
            this.ch_ValorGlicemico.Text = "Valor Glicemico";
            this.ch_ValorGlicemico.Width = 100;
            // 
            // ch_DataMedicao
            // 
            this.ch_DataMedicao.Text = "Data Medição";
            this.ch_DataMedicao.Width = 100;
            // 
            // ch_Paciente
            // 
            this.ch_Paciente.Text = "Paciente";
            this.ch_Paciente.Width = 150;
            // 
            // ch_IdPaciente
            // 
            this.ch_IdPaciente.Text = "ID Paciente";
            this.ch_IdPaciente.Width = 80;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(12, 275);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_Conectar.TabIndex = 0;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Enabled = false;
            this.btn_Cadastrar.Location = new System.Drawing.Point(93, 275);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 1;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Enabled = false;
            this.btn_Deletar.Location = new System.Drawing.Point(174, 275);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar.TabIndex = 2;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(255, 275);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // pnl_Campos
            // 
            this.pnl_Campos.Controls.Add(this.txt_IdGlicemia);
            this.pnl_Campos.Controls.Add(this.lbl_IdMedidaGlicemia);
            this.pnl_Campos.Controls.Add(this.txt_IdPaciente);
            this.pnl_Campos.Controls.Add(this.txt_DataMedicao);
            this.pnl_Campos.Controls.Add(this.txt_ValorGlicemia);
            this.pnl_Campos.Controls.Add(this.btn_Salvar);
            this.pnl_Campos.Controls.Add(this.lbl_IdPaciente);
            this.pnl_Campos.Controls.Add(this.lbl_DataMedicao);
            this.pnl_Campos.Controls.Add(this.lbl_ValorGlicemia);
            this.pnl_Campos.Enabled = false;
            this.pnl_Campos.Location = new System.Drawing.Point(12, 351);
            this.pnl_Campos.Name = "pnl_Campos";
            this.pnl_Campos.Size = new System.Drawing.Size(237, 200);
            this.pnl_Campos.TabIndex = 5;
            // 
            // txt_IdGlicemia
            // 
            this.txt_IdGlicemia.Location = new System.Drawing.Point(91, 31);
            this.txt_IdGlicemia.Name = "txt_IdGlicemia";
            this.txt_IdGlicemia.Size = new System.Drawing.Size(100, 23);
            this.txt_IdGlicemia.TabIndex = 10;
            // 
            // lbl_IdMedidaGlicemia
            // 
            this.lbl_IdMedidaGlicemia.AutoSize = true;
            this.lbl_IdMedidaGlicemia.Location = new System.Drawing.Point(3, 39);
            this.lbl_IdMedidaGlicemia.Name = "lbl_IdMedidaGlicemia";
            this.lbl_IdMedidaGlicemia.Size = new System.Drawing.Size(67, 15);
            this.lbl_IdMedidaGlicemia.TabIndex = 9;
            this.lbl_IdMedidaGlicemia.Text = "ID Glicemia";
            // 
            // txt_IdPaciente
            // 
            this.txt_IdPaciente.Location = new System.Drawing.Point(91, 135);
            this.txt_IdPaciente.Name = "txt_IdPaciente";
            this.txt_IdPaciente.Size = new System.Drawing.Size(100, 23);
            this.txt_IdPaciente.TabIndex = 6;
            // 
            // txt_DataMedicao
            // 
            this.txt_DataMedicao.Location = new System.Drawing.Point(91, 100);
            this.txt_DataMedicao.Name = "txt_DataMedicao";
            this.txt_DataMedicao.Size = new System.Drawing.Size(100, 23);
            this.txt_DataMedicao.TabIndex = 5;
            // 
            // txt_ValorGlicemia
            // 
            this.txt_ValorGlicemia.Location = new System.Drawing.Point(91, 64);
            this.txt_ValorGlicemia.Name = "txt_ValorGlicemia";
            this.txt_ValorGlicemia.Size = new System.Drawing.Size(100, 23);
            this.txt_ValorGlicemia.TabIndex = 4;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(91, 174);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 7;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // lbl_IdPaciente
            // 
            this.lbl_IdPaciente.AutoSize = true;
            this.lbl_IdPaciente.Location = new System.Drawing.Point(3, 143);
            this.lbl_IdPaciente.Name = "lbl_IdPaciente";
            this.lbl_IdPaciente.Size = new System.Drawing.Size(66, 15);
            this.lbl_IdPaciente.TabIndex = 8;
            this.lbl_IdPaciente.Text = "ID Paciente";
            // 
            // lbl_DataMedicao
            // 
            this.lbl_DataMedicao.AutoSize = true;
            this.lbl_DataMedicao.Location = new System.Drawing.Point(5, 108);
            this.lbl_DataMedicao.Name = "lbl_DataMedicao";
            this.lbl_DataMedicao.Size = new System.Drawing.Size(80, 15);
            this.lbl_DataMedicao.TabIndex = 7;
            this.lbl_DataMedicao.Text = "Data Medição";
            // 
            // lbl_ValorGlicemia
            // 
            this.lbl_ValorGlicemia.AutoSize = true;
            this.lbl_ValorGlicemia.Location = new System.Drawing.Point(3, 72);
            this.lbl_ValorGlicemia.Name = "lbl_ValorGlicemia";
            this.lbl_ValorGlicemia.Size = new System.Drawing.Size(82, 15);
            this.lbl_ValorGlicemia.TabIndex = 6;
            this.lbl_ValorGlicemia.Text = "Valor Glicemia";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 563);
            this.Controls.Add(this.pnl_Campos);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.lv_MedidasGlicemicas);
            this.Name = "frmPrincipal";
            this.Text = "Gestão de Medidas Glicêmicas";
            this.pnl_Campos.ResumeLayout(false);
            this.pnl_Campos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lv_MedidasGlicemicas;
        private ColumnHeader ch_IdMedida;
        private ColumnHeader ch_ValorGlicemico;
        private ColumnHeader ch_DataMedicao;
        private ColumnHeader ch_Paciente;
        private ColumnHeader ch_IdPaciente;
        private Button btn_Conectar;
        private Button btn_Cadastrar;
        private Button btn_Deletar;
        private Button btn_Editar;
        private Panel pnl_Campos;
        private TextBox txt_IdPaciente;
        private TextBox txt_DataMedicao;
        private TextBox txt_ValorGlicemia;
        private Button btn_Salvar;
        private Label lbl_IdPaciente;
        private Label lbl_DataMedicao;
        private Label lbl_ValorGlicemia;
        private TextBox txt_IdGlicemia;
        private Label lbl_IdMedidaGlicemia;
    }
}
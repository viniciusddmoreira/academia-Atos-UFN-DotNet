namespace ExemploBasicoWinForms
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
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtListaNomes = new System.Windows.Forms.TextBox();
            this.btnListarEmails = new System.Windows.Forms.Button();
            this.btnListarDominios = new System.Windows.Forms.Button();
            this.txtListaDominios = new System.Windows.Forms.TextBox();
            this.txtListaEmails = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(12, 9);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(99, 15);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(114, 6);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(270, 23);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 131);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtListaNomes
            // 
            this.txtListaNomes.Enabled = false;
            this.txtListaNomes.Location = new System.Drawing.Point(12, 176);
            this.txtListaNomes.Multiline = true;
            this.txtListaNomes.Name = "txtListaNomes";
            this.txtListaNomes.ReadOnly = true;
            this.txtListaNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaNomes.Size = new System.Drawing.Size(206, 330);
            this.txtListaNomes.TabIndex = 7;
            // 
            // btnListarEmails
            // 
            this.btnListarEmails.Location = new System.Drawing.Point(509, 131);
            this.btnListarEmails.Name = "btnListarEmails";
            this.btnListarEmails.Size = new System.Drawing.Size(100, 23);
            this.btnListarEmails.TabIndex = 6;
            this.btnListarEmails.Text = "Listar Emails";
            this.btnListarEmails.UseVisualStyleBackColor = true;
            this.btnListarEmails.Click += new System.EventHandler(this.btnListarEmails_Click);
            // 
            // btnListarDominios
            // 
            this.btnListarDominios.Location = new System.Drawing.Point(262, 131);
            this.btnListarDominios.Name = "btnListarDominios";
            this.btnListarDominios.Size = new System.Drawing.Size(100, 23);
            this.btnListarDominios.TabIndex = 5;
            this.btnListarDominios.Text = "Listar Dominíos";
            this.btnListarDominios.UseVisualStyleBackColor = true;
            this.btnListarDominios.Click += new System.EventHandler(this.btnListarDominios_Click);
            // 
            // txtListaDominios
            // 
            this.txtListaDominios.Enabled = false;
            this.txtListaDominios.Location = new System.Drawing.Point(262, 176);
            this.txtListaDominios.Multiline = true;
            this.txtListaDominios.Name = "txtListaDominios";
            this.txtListaDominios.ReadOnly = true;
            this.txtListaDominios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaDominios.Size = new System.Drawing.Size(206, 330);
            this.txtListaDominios.TabIndex = 8;
            // 
            // txtListaEmails
            // 
            this.txtListaEmails.Enabled = false;
            this.txtListaEmails.Location = new System.Drawing.Point(509, 176);
            this.txtListaEmails.Multiline = true;
            this.txtListaEmails.Name = "txtListaEmails";
            this.txtListaEmails.ReadOnly = true;
            this.txtListaEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaEmails.Size = new System.Drawing.Size(206, 330);
            this.txtListaEmails.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 49);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 518);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtListaEmails);
            this.Controls.Add(this.txtListaDominios);
            this.Controls.Add(this.btnListarDominios);
            this.Controls.Add(this.btnListarEmails);
            this.Controls.Add(this.txtListaNomes);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Name = "frmPrincipal";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnInserir;
        private TextBox txtListaNomes;
        private Button btnListarEmails;
        private Button btnListarDominios;
        private TextBox txtListaDominios;
        private TextBox txtListaEmails;
        private Label lblEmail;
        private TextBox txtEmail;
    }
}
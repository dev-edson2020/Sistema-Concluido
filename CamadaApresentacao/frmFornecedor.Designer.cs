namespace CamadaApresentacao
{
    partial class frmFornecedor
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
            this.components = new System.ComponentModel.Container();
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.chkDeletar = new System.Windows.Forms.CheckBox();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor_Comercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.cbSetorComercial = new System.Windows.Forms.ComboBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbBusca);
            this.tabPage1.Controls.Add(this.chkDeletar);
            this.tabPage1.Controls.Add(this.dataLista);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnDeletar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1104, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar por:";
            // 
            // cbBusca
            // 
            this.cbBusca.DisplayMember = "1";
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Empresa",
            "Documento"});
            this.cbBusca.Location = new System.Drawing.Point(9, 30);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(139, 29);
            this.cbBusca.TabIndex = 8;
            this.cbBusca.SelectedIndexChanged += new System.EventHandler(this.cbBusca_SelectedIndexChanged);
            // 
            // chkDeletar
            // 
            this.chkDeletar.AutoSize = true;
            this.chkDeletar.Location = new System.Drawing.Point(9, 88);
            this.chkDeletar.Name = "chkDeletar";
            this.chkDeletar.Size = new System.Drawing.Size(82, 25);
            this.chkDeletar.TabIndex = 7;
            this.chkDeletar.Text = "Deletar";
            this.chkDeletar.UseVisualStyleBackColor = true;
            this.chkDeletar.CheckedChanged += new System.EventHandler(this.chkDeletar_CheckedChanged);
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar,
            this.Empresa,
            this.Setor_Comercial,
            this.Tipo_Documento,
            this.Numero_Documento,
            this.Endereco,
            this.Telefone,
            this.Email,
            this.Url});
            this.dataLista.Location = new System.Drawing.Point(9, 124);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(1087, 332);
            this.dataLista.TabIndex = 6;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.DoubleClick += new System.EventHandler(this.dataLista_DoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 200;
            // 
            // Setor_Comercial
            // 
            this.Setor_Comercial.DataPropertyName = "setor_comercial";
            this.Setor_Comercial.HeaderText = "Setor Comercial";
            this.Setor_Comercial.Name = "Setor_Comercial";
            this.Setor_Comercial.ReadOnly = true;
            this.Setor_Comercial.Width = 250;
            // 
            // Tipo_Documento
            // 
            this.Tipo_Documento.DataPropertyName = "tipo_documento";
            this.Tipo_Documento.HeaderText = "Tipo Documento";
            this.Tipo_Documento.Name = "Tipo_Documento";
            this.Tipo_Documento.ReadOnly = true;
            this.Tipo_Documento.Width = 250;
            // 
            // Numero_Documento
            // 
            this.Numero_Documento.DataPropertyName = "numero_documento";
            this.Numero_Documento.HeaderText = "Número Documento";
            this.Numero_Documento.Name = "Numero_Documento";
            this.Numero_Documento.ReadOnly = true;
            this.Numero_Documento.Width = 250;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 250;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 250;
            // 
            // Url
            // 
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Visible = false;
            this.Url.Width = 200;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(653, 92);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 21);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "label3";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(840, 29);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 29);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(749, 29);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(85, 29);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(657, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(154, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(486, 29);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(653, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 29);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(362, 316);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 29);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(556, 316);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 29);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(456, 316);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 29);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(90, 106);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(408, 29);
            this.txtEmpresa.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(90, 71);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(217, 29);
            this.txtId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Empresa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoDoc);
            this.groupBox1.Controls.Add(this.cbSetorComercial);
            this.groupBox1.Controls.Add(this.txtUrl);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNumDoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedores";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Items.AddRange(new object[] {
            "CNPJ",
            "CPF",
            "RG"});
            this.cbTipoDoc.Location = new System.Drawing.Point(90, 142);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(217, 29);
            this.cbTipoDoc.TabIndex = 25;
            // 
            // cbSetorComercial
            // 
            this.cbSetorComercial.FormattingEnabled = true;
            this.cbSetorComercial.Items.AddRange(new object[] {
            "Alimentos",
            "Técnologia",
            "Roupas",
            "Serviços",
            "Sáude"});
            this.cbSetorComercial.Location = new System.Drawing.Point(695, 106);
            this.cbSetorComercial.Name = "cbSetorComercial";
            this.cbSetorComercial.Size = new System.Drawing.Size(229, 29);
            this.cbSetorComercial.TabIndex = 24;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(695, 210);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(346, 29);
            this.txtUrl.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(562, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Url";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(408, 29);
            this.txtEmail.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(695, 176);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(229, 29);
            this.txtTelefone.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefone";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(90, 174);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(408, 29);
            this.txtEndereco.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Endereço";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(695, 141);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(229, 29);
            this.txtNumDoc.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número DOC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tipo DOC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Setor Comercial";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1104, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 496);
            this.tabControl1.TabIndex = 3;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "FORNECEDORES";
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1136, 560);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkDeletar;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.ComboBox cbSetorComercial;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor_Comercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
    }
}
namespace Lancamentos_2
    {
    partial class Form1
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
            if (disposing&&(components!=null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabProducao = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Producao_Vendavel = new System.Windows.Forms.Label();
            this.btn_Producao_ok = new System.Windows.Forms.Button();
            this.textProducao_Pequeno = new System.Windows.Forms.TextBox();
            this.textProducao_Grande = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listVendaveis_Producao = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_Uber = new System.Windows.Forms.TabPage();
            this.button_uber = new System.Windows.Forms.Button();
            this.tb_uber_qtd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_uber_selecionado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.list_Ubereats = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabFatia = new System.Windows.Forms.TabPage();
            this.button_Fatia = new System.Windows.Forms.Button();
            this.tb_Fatia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.list_Fatia = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPerdas = new System.Windows.Forms.TabPage();
            this.botao_Perdas = new System.Windows.Forms.Button();
            this.tb_Perdas_Qtd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Perdas_Selecionado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.list_Perdas = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.botao_fidelidade = new System.Windows.Forms.Button();
            this.tb_fidelidade_selecionado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.list_Fidelidade = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.botao_bolo_utilizado = new System.Windows.Forms.Button();
            this.tb_bolo_utilizado_pequeno = new System.Windows.Forms.TextBox();
            this.tb_bolo_utilizado_grande = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.list_bolo_utilizado = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.botao_sorteio = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.tb_quantidade_de_cupons = new System.Windows.Forms.TextBox();
            this.tb_email_cliente = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_telefone_celular = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_nome_completo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.listColaboradoras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabFormulario.SuspendLayout();
            this.tabProducao.SuspendLayout();
            this.tab_Uber.SuspendLayout();
            this.tabFatia.SuspendLayout();
            this.tabPerdas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormulario
            // 
            this.tabFormulario.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabFormulario.Controls.Add(this.tabProducao);
            this.tabFormulario.Controls.Add(this.tab_Uber);
            this.tabFormulario.Controls.Add(this.tabFatia);
            this.tabFormulario.Controls.Add(this.tabPerdas);
            this.tabFormulario.Controls.Add(this.tabPage1);
            this.tabFormulario.Controls.Add(this.tabPage2);
            this.tabFormulario.Controls.Add(this.tabPage3);
            this.tabFormulario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFormulario.Location = new System.Drawing.Point(0, 129);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.SelectedIndex = 0;
            this.tabFormulario.Size = new System.Drawing.Size(988, 378);
            this.tabFormulario.TabIndex = 0;
            // 
            // tabProducao
            // 
            this.tabProducao.Controls.Add(this.label16);
            this.tabProducao.Controls.Add(this.label3);
            this.tabProducao.Controls.Add(this.label_Producao_Vendavel);
            this.tabProducao.Controls.Add(this.btn_Producao_ok);
            this.tabProducao.Controls.Add(this.textProducao_Pequeno);
            this.tabProducao.Controls.Add(this.textProducao_Grande);
            this.tabProducao.Controls.Add(this.label5);
            this.tabProducao.Controls.Add(this.label4);
            this.tabProducao.Controls.Add(this.listVendaveis_Producao);
            this.tabProducao.Controls.Add(this.label2);
            this.tabProducao.Location = new System.Drawing.Point(4, 35);
            this.tabProducao.Name = "tabProducao";
            this.tabProducao.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducao.Size = new System.Drawing.Size(980, 339);
            this.tabProducao.TabIndex = 0;
            this.tabProducao.Text = "Producao";
            this.tabProducao.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(406, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(448, 90);
            this.label16.TabIndex = 13;
            this.label16.Text = "Ao registrar produtos como: \r\nBolo de Pote, Bolo Recheado, Bolo Mousse ou Bolo de" +
    " Festa\r\n\r\nNão esqueça de registrar o bolo base na aba\r\n\"Bolo utilizado\"";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Produzido por: ";
            // 
            // label_Producao_Vendavel
            // 
            this.label_Producao_Vendavel.AutoSize = true;
            this.label_Producao_Vendavel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Producao_Vendavel.Location = new System.Drawing.Point(387, 55);
            this.label_Producao_Vendavel.Name = "label_Producao_Vendavel";
            this.label_Producao_Vendavel.Size = new System.Drawing.Size(156, 19);
            this.label_Producao_Vendavel.TabIndex = 11;
            this.label_Producao_Vendavel.Text = "Quatidade Produzida";
            this.label_Producao_Vendavel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Producao_ok
            // 
            this.btn_Producao_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Producao_ok.Location = new System.Drawing.Point(593, 190);
            this.btn_Producao_ok.Name = "btn_Producao_ok";
            this.btn_Producao_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Producao_ok.TabIndex = 9;
            this.btn_Producao_ok.Text = "Registra";
            this.btn_Producao_ok.UseVisualStyleBackColor = true;
            this.btn_Producao_ok.Click += new System.EventHandler(this.btn_Producao_ok_Click);
            // 
            // textProducao_Pequeno
            // 
            this.textProducao_Pequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProducao_Pequeno.Location = new System.Drawing.Point(467, 116);
            this.textProducao_Pequeno.Name = "textProducao_Pequeno";
            this.textProducao_Pequeno.Size = new System.Drawing.Size(100, 22);
            this.textProducao_Pequeno.TabIndex = 8;
            // 
            // textProducao_Grande
            // 
            this.textProducao_Grande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProducao_Grande.Location = new System.Drawing.Point(467, 89);
            this.textProducao_Grande.Name = "textProducao_Grande";
            this.textProducao_Grande.Size = new System.Drawing.Size(100, 22);
            this.textProducao_Grande.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pequeno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grande";
            // 
            // listVendaveis_Producao
            // 
            this.listVendaveis_Producao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVendaveis_Producao.FormattingEnabled = true;
            this.listVendaveis_Producao.Location = new System.Drawing.Point(10, 38);
            this.listVendaveis_Producao.Name = "listVendaveis_Producao";
            this.listVendaveis_Producao.Size = new System.Drawing.Size(371, 290);
            this.listVendaveis_Producao.TabIndex = 3;
            this.listVendaveis_Producao.SelectedIndexChanged += new System.EventHandler(this.listVendaveis_Producao_SelectedIndexChanged);
            this.listVendaveis_Producao.SelectedValueChanged += new System.EventHandler(this.listVendaveis_Producao_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastramento de Bolos Produzidos";
            // 
            // tab_Uber
            // 
            this.tab_Uber.Controls.Add(this.button_uber);
            this.tab_Uber.Controls.Add(this.tb_uber_qtd);
            this.tab_Uber.Controls.Add(this.label8);
            this.tab_Uber.Controls.Add(this.tb_uber_selecionado);
            this.tab_Uber.Controls.Add(this.label7);
            this.tab_Uber.Controls.Add(this.list_Ubereats);
            this.tab_Uber.Controls.Add(this.label6);
            this.tab_Uber.Location = new System.Drawing.Point(4, 35);
            this.tab_Uber.Name = "tab_Uber";
            this.tab_Uber.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Uber.Size = new System.Drawing.Size(980, 339);
            this.tab_Uber.TabIndex = 1;
            this.tab_Uber.Text = "Uber Eats";
            this.tab_Uber.UseVisualStyleBackColor = true;
            // 
            // button_uber
            // 
            this.button_uber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_uber.Location = new System.Drawing.Point(574, 180);
            this.button_uber.Name = "button_uber";
            this.button_uber.Size = new System.Drawing.Size(75, 23);
            this.button_uber.TabIndex = 9;
            this.button_uber.Text = "Registra";
            this.button_uber.UseVisualStyleBackColor = true;
            this.button_uber.Click += new System.EventHandler(this.button_uber_Click);
            // 
            // tb_uber_qtd
            // 
            this.tb_uber_qtd.Location = new System.Drawing.Point(435, 183);
            this.tb_uber_qtd.Name = "tb_uber_qtd";
            this.tb_uber_qtd.Size = new System.Drawing.Size(100, 30);
            this.tb_uber_qtd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(435, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quantidade";
            // 
            // tb_uber_selecionado
            // 
            this.tb_uber_selecionado.Location = new System.Drawing.Point(435, 118);
            this.tb_uber_selecionado.Name = "tb_uber_selecionado";
            this.tb_uber_selecionado.Size = new System.Drawing.Size(358, 30);
            this.tb_uber_selecionado.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Produto Selecionado";
            // 
            // list_Ubereats
            // 
            this.list_Ubereats.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Ubereats.FormattingEnabled = true;
            this.list_Ubereats.Location = new System.Drawing.Point(10, 38);
            this.list_Ubereats.Name = "list_Ubereats";
            this.list_Ubereats.Size = new System.Drawing.Size(371, 290);
            this.list_Ubereats.TabIndex = 4;
            this.list_Ubereats.Click += new System.EventHandler(this.list_Ubereats_Click);
            this.list_Ubereats.SelectedIndexChanged += new System.EventHandler(this.list_Ubereats_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "UberEats - Produtos Vendidos";
            // 
            // tabFatia
            // 
            this.tabFatia.Controls.Add(this.button_Fatia);
            this.tabFatia.Controls.Add(this.tb_Fatia);
            this.tabFatia.Controls.Add(this.label10);
            this.tabFatia.Controls.Add(this.list_Fatia);
            this.tabFatia.Controls.Add(this.label11);
            this.tabFatia.Location = new System.Drawing.Point(4, 35);
            this.tabFatia.Name = "tabFatia";
            this.tabFatia.Padding = new System.Windows.Forms.Padding(3);
            this.tabFatia.Size = new System.Drawing.Size(980, 339);
            this.tabFatia.TabIndex = 2;
            this.tabFatia.Text = "Para Fatiar";
            this.tabFatia.UseVisualStyleBackColor = true;
            // 
            // button_Fatia
            // 
            this.button_Fatia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Fatia.Location = new System.Drawing.Point(421, 189);
            this.button_Fatia.Name = "button_Fatia";
            this.button_Fatia.Size = new System.Drawing.Size(75, 23);
            this.button_Fatia.TabIndex = 16;
            this.button_Fatia.Text = "Registra";
            this.button_Fatia.UseVisualStyleBackColor = true;
            this.button_Fatia.Click += new System.EventHandler(this.button_Fatia_Click);
            // 
            // tb_Fatia
            // 
            this.tb_Fatia.Location = new System.Drawing.Point(421, 147);
            this.tb_Fatia.Name = "tb_Fatia";
            this.tb_Fatia.Size = new System.Drawing.Size(358, 30);
            this.tb_Fatia.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(421, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Produto Selecionado";
            // 
            // list_Fatia
            // 
            this.list_Fatia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Fatia.FormattingEnabled = true;
            this.list_Fatia.Location = new System.Drawing.Point(10, 38);
            this.list_Fatia.Name = "list_Fatia";
            this.list_Fatia.Size = new System.Drawing.Size(371, 290);
            this.list_Fatia.TabIndex = 11;
            this.list_Fatia.Click += new System.EventHandler(this.list_Fatia_Click);
            this.list_Fatia.SelectedIndexChanged += new System.EventHandler(this.list_Fatia_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(69, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Bolo colocado para Fatiar";
            // 
            // tabPerdas
            // 
            this.tabPerdas.Controls.Add(this.botao_Perdas);
            this.tabPerdas.Controls.Add(this.tb_Perdas_Qtd);
            this.tabPerdas.Controls.Add(this.label9);
            this.tabPerdas.Controls.Add(this.tb_Perdas_Selecionado);
            this.tabPerdas.Controls.Add(this.label12);
            this.tabPerdas.Controls.Add(this.list_Perdas);
            this.tabPerdas.Controls.Add(this.label13);
            this.tabPerdas.Location = new System.Drawing.Point(4, 35);
            this.tabPerdas.Name = "tabPerdas";
            this.tabPerdas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerdas.Size = new System.Drawing.Size(980, 339);
            this.tabPerdas.TabIndex = 3;
            this.tabPerdas.Text = "Vencidos ou Perdas";
            this.tabPerdas.UseVisualStyleBackColor = true;
            // 
            // botao_Perdas
            // 
            this.botao_Perdas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_Perdas.Location = new System.Drawing.Point(594, 175);
            this.botao_Perdas.Name = "botao_Perdas";
            this.botao_Perdas.Size = new System.Drawing.Size(75, 23);
            this.botao_Perdas.TabIndex = 16;
            this.botao_Perdas.Text = "Registra";
            this.botao_Perdas.UseVisualStyleBackColor = true;
            this.botao_Perdas.Click += new System.EventHandler(this.botao_Perdas_Click);
            // 
            // tb_Perdas_Qtd
            // 
            this.tb_Perdas_Qtd.Location = new System.Drawing.Point(455, 178);
            this.tb_Perdas_Qtd.Name = "tb_Perdas_Qtd";
            this.tb_Perdas_Qtd.Size = new System.Drawing.Size(100, 30);
            this.tb_Perdas_Qtd.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Quantidade";
            // 
            // tb_Perdas_Selecionado
            // 
            this.tb_Perdas_Selecionado.Location = new System.Drawing.Point(455, 115);
            this.tb_Perdas_Selecionado.Name = "tb_Perdas_Selecionado";
            this.tb_Perdas_Selecionado.Size = new System.Drawing.Size(358, 30);
            this.tb_Perdas_Selecionado.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(455, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Produto Selecionado";
            // 
            // list_Perdas
            // 
            this.list_Perdas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Perdas.FormattingEnabled = true;
            this.list_Perdas.Location = new System.Drawing.Point(10, 38);
            this.list_Perdas.Name = "list_Perdas";
            this.list_Perdas.Size = new System.Drawing.Size(371, 290);
            this.list_Perdas.TabIndex = 11;
            this.list_Perdas.SelectedIndexChanged += new System.EventHandler(this.list_Perdas_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(751, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "Cadastramento de Bolos Vencidos, Queimados, Quebrados, Fidelidade ou Etc.";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.botao_fidelidade);
            this.tabPage1.Controls.Add(this.tb_fidelidade_selecionado);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.list_Fidelidade);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 339);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Fidelidade";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // botao_fidelidade
            // 
            this.botao_fidelidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_fidelidade.Location = new System.Drawing.Point(594, 177);
            this.botao_fidelidade.Name = "botao_fidelidade";
            this.botao_fidelidade.Size = new System.Drawing.Size(75, 23);
            this.botao_fidelidade.TabIndex = 21;
            this.botao_fidelidade.Text = "Registra";
            this.botao_fidelidade.UseVisualStyleBackColor = true;
            this.botao_fidelidade.Click += new System.EventHandler(this.botao_fidelidade_Click);
            // 
            // tb_fidelidade_selecionado
            // 
            this.tb_fidelidade_selecionado.Location = new System.Drawing.Point(396, 117);
            this.tb_fidelidade_selecionado.Name = "tb_fidelidade_selecionado";
            this.tb_fidelidade_selecionado.Size = new System.Drawing.Size(458, 30);
            this.tb_fidelidade_selecionado.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(455, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "Produto Selecionado";
            // 
            // list_Fidelidade
            // 
            this.list_Fidelidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Fidelidade.FormattingEnabled = true;
            this.list_Fidelidade.Location = new System.Drawing.Point(10, 40);
            this.list_Fidelidade.Name = "list_Fidelidade";
            this.list_Fidelidade.Size = new System.Drawing.Size(371, 290);
            this.list_Fidelidade.TabIndex = 18;
            this.list_Fidelidade.SelectedIndexChanged += new System.EventHandler(this.list_Fidelidade_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(636, 23);
            this.label15.TabIndex = 17;
            this.label15.Text = "Cadastramento de Bolos entregues por conta de cartão fidelidade";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.botao_bolo_utilizado);
            this.tabPage2.Controls.Add(this.tb_bolo_utilizado_pequeno);
            this.tabPage2.Controls.Add(this.tb_bolo_utilizado_grande);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.list_bolo_utilizado);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(980, 339);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Bolo Utiizado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(512, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 19);
            this.label17.TabIndex = 21;
            this.label17.Text = "Produzido por: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(512, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 19);
            this.label18.TabIndex = 20;
            this.label18.Text = "Quatidade Utilizada";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // botao_bolo_utilizado
            // 
            this.botao_bolo_utilizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_bolo_utilizado.Location = new System.Drawing.Point(699, 203);
            this.botao_bolo_utilizado.Name = "botao_bolo_utilizado";
            this.botao_bolo_utilizado.Size = new System.Drawing.Size(75, 23);
            this.botao_bolo_utilizado.TabIndex = 19;
            this.botao_bolo_utilizado.Text = "Registra";
            this.botao_bolo_utilizado.UseVisualStyleBackColor = true;
            this.botao_bolo_utilizado.Click += new System.EventHandler(this.botao_bolo_utilizado_Click);
            // 
            // tb_bolo_utilizado_pequeno
            // 
            this.tb_bolo_utilizado_pequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bolo_utilizado_pequeno.Location = new System.Drawing.Point(592, 129);
            this.tb_bolo_utilizado_pequeno.Name = "tb_bolo_utilizado_pequeno";
            this.tb_bolo_utilizado_pequeno.Size = new System.Drawing.Size(100, 22);
            this.tb_bolo_utilizado_pequeno.TabIndex = 18;
            // 
            // tb_bolo_utilizado_grande
            // 
            this.tb_bolo_utilizado_grande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bolo_utilizado_grande.Location = new System.Drawing.Point(592, 102);
            this.tb_bolo_utilizado_grande.Name = "tb_bolo_utilizado_grande";
            this.tb_bolo_utilizado_grande.Size = new System.Drawing.Size(100, 22);
            this.tb_bolo_utilizado_grande.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(512, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 19);
            this.label19.TabIndex = 16;
            this.label19.Text = "Pequeno";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(512, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 19);
            this.label20.TabIndex = 15;
            this.label20.Text = "Grande";
            // 
            // list_bolo_utilizado
            // 
            this.list_bolo_utilizado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_bolo_utilizado.FormattingEnabled = true;
            this.list_bolo_utilizado.Location = new System.Drawing.Point(65, 68);
            this.list_bolo_utilizado.Name = "list_bolo_utilizado";
            this.list_bolo_utilizado.Size = new System.Drawing.Size(371, 264);
            this.list_bolo_utilizado.TabIndex = 14;
            this.list_bolo_utilizado.SelectedIndexChanged += new System.EventHandler(this.list_bolo_utilizado_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(554, 46);
            this.label21.TabIndex = 13;
            this.label21.Text = "Cadastramento de Bolo utilizado na fabricação de\r\nBolo de Pote, Bolo Recheado, Bo" +
    "lo Mousse ou Bolo Festa";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.botao_sorteio);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.tb_quantidade_de_cupons);
            this.tabPage3.Controls.Add(this.tb_email_cliente);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.tb_telefone_celular);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.tb_nome_completo);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(980, 339);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Sorteio";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // botao_sorteio
            // 
            this.botao_sorteio.Enabled = false;
            this.botao_sorteio.Location = new System.Drawing.Point(743, 95);
            this.botao_sorteio.Name = "botao_sorteio";
            this.botao_sorteio.Size = new System.Drawing.Size(199, 40);
            this.botao_sorteio.TabIndex = 8;
            this.botao_sorteio.Text = "Registra Sorteio";
            this.botao_sorteio.UseVisualStyleBackColor = true;
            this.botao_sorteio.Click += new System.EventHandler(this.botao_sorteio_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(479, 193);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(495, 95);
            this.label26.TabIndex = 7;
            this.label26.Text = "É muito importante os dados estarem completos e corretos.\r\nCadastros sem email nã" +
    "o serão realizados.\r\n\r\nCada preenchimento vale por uma compra de\r\nvalor superior" +
    " a R$ 20,00.";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_quantidade_de_cupons
            // 
            this.tb_quantidade_de_cupons.Location = new System.Drawing.Point(240, 207);
            this.tb_quantidade_de_cupons.Name = "tb_quantidade_de_cupons";
            this.tb_quantidade_de_cupons.Size = new System.Drawing.Size(43, 30);
            this.tb_quantidade_de_cupons.TabIndex = 6;
            this.tb_quantidade_de_cupons.Text = "1";
            // 
            // tb_email_cliente
            // 
            this.tb_email_cliente.Location = new System.Drawing.Point(197, 151);
            this.tb_email_cliente.Name = "tb_email_cliente";
            this.tb_email_cliente.Size = new System.Drawing.Size(490, 30);
            this.tb_email_cliente.TabIndex = 6;
            this.tb_email_cliente.TextChanged += new System.EventHandler(this.tb_email_cliente_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 210);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(223, 23);
            this.label27.TabIndex = 5;
            this.label27.Text = "Quantidade de cupons";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 151);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(180, 23);
            this.label25.TabIndex = 5;
            this.label25.Text = "e-mail do Cliente:";
            // 
            // tb_telefone_celular
            // 
            this.tb_telefone_celular.Location = new System.Drawing.Point(289, 105);
            this.tb_telefone_celular.Name = "tb_telefone_celular";
            this.tb_telefone_celular.Size = new System.Drawing.Size(398, 30);
            this.tb_telefone_celular.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(272, 23);
            this.label24.TabIndex = 3;
            this.label24.Text = "Telefone celular do Cliente:";
            // 
            // tb_nome_completo
            // 
            this.tb_nome_completo.Location = new System.Drawing.Point(222, 63);
            this.tb_nome_completo.Name = "tb_nome_completo";
            this.tb_nome_completo.Size = new System.Drawing.Size(465, 30);
            this.tb_nome_completo.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(205, 23);
            this.label23.TabIndex = 1;
            this.label23.Text = "Nome do(a) Cliente:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(494, 23);
            this.label22.TabIndex = 0;
            this.label22.Text = "Cadastramento de clientes para os sorteios da loja";
            // 
            // listColaboradoras
            // 
            this.listColaboradoras.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listColaboradoras.FormattingEnabled = true;
            this.listColaboradoras.ItemHeight = 16;
            this.listColaboradoras.Location = new System.Drawing.Point(12, 28);
            this.listColaboradoras.Name = "listColaboradoras";
            this.listColaboradoras.Size = new System.Drawing.Size(125, 84);
            this.listColaboradoras.TabIndex = 0;
            this.listColaboradoras.SelectedIndexChanged += new System.EventHandler(this.listColaboradoras_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Colaboradora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(988, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listColaboradoras);
            this.Controls.Add(this.tabFormulario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lançamentos Vó Alzira";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabFormulario.ResumeLayout(false);
            this.tabProducao.ResumeLayout(false);
            this.tabProducao.PerformLayout();
            this.tab_Uber.ResumeLayout(false);
            this.tab_Uber.PerformLayout();
            this.tabFatia.ResumeLayout(false);
            this.tabFatia.PerformLayout();
            this.tabPerdas.ResumeLayout(false);
            this.tabPerdas.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.TabControl tabFormulario;
        private System.Windows.Forms.TabPage tabProducao;
        private System.Windows.Forms.TabPage tab_Uber;
        private System.Windows.Forms.TabPage tabFatia;
        private System.Windows.Forms.ListBox listColaboradoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listVendaveis_Producao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Producao_ok;
        private System.Windows.Forms.TextBox textProducao_Pequeno;
        private System.Windows.Forms.TextBox textProducao_Grande;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Producao_Vendavel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox list_Ubereats;
        private System.Windows.Forms.TextBox tb_uber_selecionado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_uber_qtd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_uber;
        private System.Windows.Forms.Button button_Fatia;
        private System.Windows.Forms.TextBox tb_Fatia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox list_Fatia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPerdas;
        private System.Windows.Forms.Button botao_Perdas;
        private System.Windows.Forms.TextBox tb_Perdas_Qtd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Perdas_Selecionado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox list_Perdas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button botao_fidelidade;
        private System.Windows.Forms.TextBox tb_fidelidade_selecionado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox list_Fidelidade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button botao_bolo_utilizado;
        private System.Windows.Forms.TextBox tb_bolo_utilizado_pequeno;
        private System.Windows.Forms.TextBox tb_bolo_utilizado_grande;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox list_bolo_utilizado;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_nome_completo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button botao_sorteio;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tb_email_cliente;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_telefone_celular;
        private System.Windows.Forms.TextBox tb_quantidade_de_cupons;
        private System.Windows.Forms.Label label27;
        }
    }


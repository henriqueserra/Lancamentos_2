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
            this.listColaboradoras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPerdas = new System.Windows.Forms.TabPage();
            this.botao_Perdas = new System.Windows.Forms.Button();
            this.tb_Perdas_Qtd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Perdas_Selecionado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.list_Perdas = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabFormulario.SuspendLayout();
            this.tabProducao.SuspendLayout();
            this.tab_Uber.SuspendLayout();
            this.tabFatia.SuspendLayout();
            this.tabPerdas.SuspendLayout();
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
            this.tabFormulario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFormulario.Location = new System.Drawing.Point(0, 129);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.SelectedIndex = 0;
            this.tabFormulario.Size = new System.Drawing.Size(875, 378);
            this.tabFormulario.TabIndex = 0;
            // 
            // tabProducao
            // 
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
            this.tabProducao.Size = new System.Drawing.Size(867, 339);
            this.tabProducao.TabIndex = 0;
            this.tabProducao.Text = "Producao";
            this.tabProducao.UseVisualStyleBackColor = true;
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
            this.btn_Producao_ok.Location = new System.Drawing.Point(574, 190);
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
            this.tab_Uber.Size = new System.Drawing.Size(867, 339);
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
            this.tabFatia.Size = new System.Drawing.Size(867, 339);
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
            this.tabPerdas.Size = new System.Drawing.Size(867, 339);
            this.tabPerdas.TabIndex = 3;
            this.tabPerdas.Text = "Perdas, Vencidos ou Fidelidade";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(874, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listColaboradoras);
            this.Controls.Add(this.tabFormulario);
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
        }
    }


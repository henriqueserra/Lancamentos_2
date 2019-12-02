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
            this.tabFormulario = new System.Windows.Forms.TabControl();
            this.tabProducao = new System.Windows.Forms.TabPage();
            this.tab_Uber = new System.Windows.Forms.TabPage();
            this.tabFatia = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFormulario
            // 
            this.tabFormulario.Controls.Add(this.tabProducao);
            this.tabFormulario.Controls.Add(this.tab_Uber);
            this.tabFormulario.Controls.Add(this.tabFatia);
            this.tabFormulario.Controls.Add(this.tabPage1);
            this.tabFormulario.Location = new System.Drawing.Point(12, 52);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.SelectedIndex = 0;
            this.tabFormulario.Size = new System.Drawing.Size(776, 371);
            this.tabFormulario.TabIndex = 0;
            // 
            // tabProducao
            // 
            this.tabProducao.Location = new System.Drawing.Point(4, 22);
            this.tabProducao.Name = "tabProducao";
            this.tabProducao.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducao.Size = new System.Drawing.Size(768, 345);
            this.tabProducao.TabIndex = 0;
            this.tabProducao.Text = "Producao";
            this.tabProducao.UseVisualStyleBackColor = true;
            // 
            // tab_Uber
            // 
            this.tab_Uber.Location = new System.Drawing.Point(4, 22);
            this.tab_Uber.Name = "tab_Uber";
            this.tab_Uber.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Uber.Size = new System.Drawing.Size(768, 345);
            this.tab_Uber.TabIndex = 1;
            this.tab_Uber.Text = "Uber Eats";
            this.tab_Uber.UseVisualStyleBackColor = true;
            // 
            // tabFatia
            // 
            this.tabFatia.Location = new System.Drawing.Point(4, 22);
            this.tabFatia.Name = "tabFatia";
            this.tabFatia.Padding = new System.Windows.Forms.Padding(3);
            this.tabFatia.Size = new System.Drawing.Size(768, 345);
            this.tabFatia.TabIndex = 2;
            this.tabFatia.Text = "Para Fatiar";
            this.tabFatia.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 345);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabFormulario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabFormulario.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.TabControl tabFormulario;
        private System.Windows.Forms.TabPage tabProducao;
        private System.Windows.Forms.TabPage tab_Uber;
        private System.Windows.Forms.TabPage tabFatia;
        private System.Windows.Forms.TabPage tabPage1;
        }
    }


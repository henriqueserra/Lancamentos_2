using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PushbulletSharp;
using PushbulletSharp.Models.Requests;
using PushbulletSharp.Models.Responses;

namespace Lancamentos_2
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }
        private void Form1_Load(object sender, EventArgs e)
            {
            tabFormulario.Visible=false;
            this.label_Producao_Vendavel.Text="";
            Carrega_Colaboradora();
            Carrega_Ubereats();
            Carrega_Fatiar();
            Carrega_Perdas();
            Carrega_Fidelidade();
            Carrega_Bolo_Utilizado();
            }
        private void Carrega_Colaboradora()
            {

            this.listColaboradoras.Items.Clear();
            this.listColaboradoras.Items.Add("Juliana");
            this.listColaboradoras.Items.Add("Bruna");
            this.listColaboradoras.Items.Add("Joyce");
            this.listColaboradoras.Items.Add("Regiane");
            this.listColaboradoras.Items.Add("Henrique");

            //Carrega_Colaboradora dados dos Vendáveis

            this.listVendaveis_Producao.Items.Clear();
            this.listVendaveis_Producao.Items.Add("");
            this.listVendaveis_Producao.Items.Add("BOLO ALPINO");
            this.listVendaveis_Producao.Items.Add("BOLO BEM CASADO");
            this.listVendaveis_Producao.Items.Add("BOLO COM MOUSSE DE FRUTAS VERMELHAS");
            this.listVendaveis_Producao.Items.Add("BOLO DE ABACAXI");
            this.listVendaveis_Producao.Items.Add("BOLO DE ABACAXI COM COCO");
            this.listVendaveis_Producao.Items.Add("BOLO DE ABACAXI COM COCO E BEIJINHO");
            this.listVendaveis_Producao.Items.Add("BOLO DE ABACAXI COM COCO E RECHEIO DE BEIJINHO");
            this.listVendaveis_Producao.Items.Add("BOLO DE AIPIM");
            this.listVendaveis_Producao.Items.Add("BOLO DE AMENDOA");
            this.listVendaveis_Producao.Items.Add("BOLO DE AMENDOIM");
            this.listVendaveis_Producao.Items.Add("BOLO DE BANANA");
            this.listVendaveis_Producao.Items.Add("BOLO DE BANANA COM GRANOLA");
            this.listVendaveis_Producao.Items.Add("BOLO DE BANANA COM NOZES");
            this.listVendaveis_Producao.Items.Add("BOLO DE BAUNILHA");
            this.listVendaveis_Producao.Items.Add("BOLO DE CAFE");
            this.listVendaveis_Producao.Items.Add("BOLO DE CENOURA");
            this.listVendaveis_Producao.Items.Add("BOLO DE CENOURA COM CHOCOLATE");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHARGE");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHOCOLATE");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHOCOLATE COM BOLINHAS E CONFETE");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHOCOLATE COM BRIGADEIRO E MORANGO");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHOCOLATE COM COCO");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHOCOLATE COM CONFETE E BIS");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHOCOLATE COM NOZES");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHOCOLATE COM RECHEIO DE BEIJINHO");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHOCOLATE COM RECHEIO DE BRIGADEIRO");
            this.listVendaveis_Producao.Items.Add("BOLO DE CHURROS");
            this.listVendaveis_Producao.Items.Add("BOLO DE COCO");
            this.listVendaveis_Producao.Items.Add("BOLO DE COCO COM BEIJINHO");
            this.listVendaveis_Producao.Items.Add("BOLO DE COCO COM CHOCOLATE");
            this.listVendaveis_Producao.Items.Add("BOLO DE COCO COM RECHEIO DE BEIJINHO");
            this.listVendaveis_Producao.Items.Add("BOLO DE DOCE DE LEITE");
            this.listVendaveis_Producao.Items.Add("BOLO DE FESTA OVOMALTINE");
            this.listVendaveis_Producao.Items.Add("BOLO DE FESTA SERENATA DE AMOR");
            this.listVendaveis_Producao.Items.Add("BOLO DE FORMIGUEIRO");
            this.listVendaveis_Producao.Items.Add("BOLO DE FRUTAS CRISTALIZADAS");
            this.listVendaveis_Producao.Items.Add("BOLO DE FUBA");
            this.listVendaveis_Producao.Items.Add("BOLO DE FUBA COM GOIABADA");
            this.listVendaveis_Producao.Items.Add("BOLO DE IOGURTE");
            this.listVendaveis_Producao.Items.Add("BOLO DE LARANJA");
            this.listVendaveis_Producao.Items.Add("BOLO DE LEITE");
            this.listVendaveis_Producao.Items.Add("BOLO DE LEITE COM RECHEIO DE BEIJINHO");
            this.listVendaveis_Producao.Items.Add("BOLO DE LIMAO");
            this.listVendaveis_Producao.Items.Add("BOLO DE MACA");
            this.listVendaveis_Producao.Items.Add("BOLO DE MACA C/ GRANOLA");
            this.listVendaveis_Producao.Items.Add("BOLO DE MACA COM NOZES");
            this.listVendaveis_Producao.Items.Add("BOLO DE MARACUJA");
            this.listVendaveis_Producao.Items.Add("BOLO DE MARACUJA COM COCO");
            this.listVendaveis_Producao.Items.Add("BOLO DE MEL COM DOCE DE LEITE E CHOCOLATE");
            this.listVendaveis_Producao.Items.Add("BOLO DE MESCLADO");
            this.listVendaveis_Producao.Items.Add("BOLO DE MILHO");
            this.listVendaveis_Producao.Items.Add("BOLO DE MOUSSE DE IOGURTE");
            this.listVendaveis_Producao.Items.Add("BOLO DE MOUSSE DE LIMAO");
            this.listVendaveis_Producao.Items.Add("BOLO DE MOUSSE DE MARACUJA");
            this.listVendaveis_Producao.Items.Add("BOLO DE NEGRESCO");
            this.listVendaveis_Producao.Items.Add("BOLO DE NOZES");
            this.listVendaveis_Producao.Items.Add("BOLO DE NOZES COM BRIGADEIRO");
            this.listVendaveis_Producao.Items.Add("BOLO DE NOZES COM FRUTAS CRISTALIZADAS");
            this.listVendaveis_Producao.Items.Add("BOLO DE PACOCA");
            this.listVendaveis_Producao.Items.Add("BOLO DE PACOCA COM RECHEIO DE DOCE DE LEITE");
            this.listVendaveis_Producao.Items.Add("BOLO DE PAO DE MEL");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE ABACAXI COM COCO");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE CHOCOLATE COM NOZES");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE CHURROS");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE COM CREME DE CAFE E CHOCOLATE");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE DE CENOURA COM CALDA DE CHOCOLATE");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE DE CHOCOLATE");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE DE CHOCOLATE COM COCO");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE DE FUBA COM GOIABADA");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE DE NOZES COM LEITE CONDENSADO");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE DOCE DE LEITE");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE FRUTAS VERMELHAS");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE GELADO FEITO COM LEITE NINHO");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE GELADO MOUSSE DE CHOCOLATE FEITO COM SUFLAIR");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE LARANJA COM GOIABADA");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE MOUSE MARACUJA");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE MOUSSE LIMAO");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE NUTELLINO");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE OVOMALTINE");
            this.listVendaveis_Producao.Items.Add("BOLO DE POTE PACOCA CASEIRA");
            this.listVendaveis_Producao.Items.Add("BOLO DE SONHO DE VALSA");
            this.listVendaveis_Producao.Items.Add("BOLO FIDELIDADE");
            this.listVendaveis_Producao.Items.Add("BOLO FIDELIDADE GRANDE");
            this.listVendaveis_Producao.Items.Add("BOLO FRUTAS VERMELHAS");
            this.listVendaveis_Producao.Items.Add("BOLO GOTAS DE CHOCOLATE");
            this.listVendaveis_Producao.Items.Add("BOLO MOUSSE DE CHOCOLATE FEITO COM SUFLAIR");
            this.listVendaveis_Producao.Items.Add("BOLO MOUSSE FEITO COM LEITE NINHO");
            this.listVendaveis_Producao.Items.Add("BOLO NUTELLINO");
            this.listVendaveis_Producao.Items.Add("BOLO OVOMALTINE");
            this.listVendaveis_Producao.Items.Add("BOLO RECHEADO NUTELLINO");
            this.listVendaveis_Producao.Items.Add("BOLO RECHEADO OVOMALTINE");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO ABACAXI");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO ABACAXI COM COCO");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO CHOCOLATE");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO COCO");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO IOGURTE");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO LEITE");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO NOZES");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO OVOMALTINE");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO PACOCA CASEIRA");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO PAO DE MEL");
            this.listVendaveis_Producao.Items.Add("BOLO SEM FURO SERENATA DE AMOR");
            this.listVendaveis_Producao.Items.Add("BOLO SERENATA DO AMOR");
            this.listVendaveis_Producao.Items.Add("CUCA DE ABACAXI");
            this.listVendaveis_Producao.Items.Add("CUCA DE BANANA");
            this.listVendaveis_Producao.Items.Add("CUCA DE MACA");
                                   }
        private void Carrega_Ubereats()
            {
            list_Ubereats.Items.Clear();
            string[] linhas = System.IO.File.ReadAllLines("VendaveisUber.txt");
            foreach (var linha in linhas)
                {
                list_Ubereats.Items.Add(linha);
                }
            }
        private void Carrega_Fatiar()
            {
            list_Fatia.Items.Clear();
            string[] linhas = System.IO.File.ReadAllLines("Fatias.txt");
            foreach (var linha in linhas)
                {
                list_Fatia.Items.Add(linha);
                }
            }
        private void Carrega_Perdas()
            {
            list_Perdas.Items.Clear();
            string[] linhas = System.IO.File.ReadAllLines("Perdas.txt");
            foreach (var linha in linhas)
                {
                list_Perdas.Items.Add(linha);
                }
            }
        private void Carrega_Fidelidade()
            {
            list_Fidelidade.Items.Clear();
            string[] linhas = System.IO.File.ReadAllLines("Fidelidade.txt");
            foreach (var linha in linhas)
                {
                list_Fidelidade.Items.Add(linha);
                }
            }
        private void listColaboradoras_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (this.listColaboradoras.SelectedIndex>-1)
                {
                tabFormulario.Visible=true;
                label3.Text="Produzido por: "+this.listColaboradoras.SelectedItem.ToString();
                }
            else
                {
                var mensagem = MessageBox.Show("Por favor selecione uma colaboradora válida !", "Seleção errada de colaboradora", MessageBoxButtons.OK);
                }


            }
        private void listVendaveis_Producao_SelectedValueChanged(object sender, EventArgs e)
            {
            this.label_Producao_Vendavel.Text=this.listVendaveis_Producao.SelectedItem.ToString();
            string vendavel = this.listVendaveis_Producao.SelectedItem.ToString();
            bool ehpote = false;
            if (vendavel.Contains("POTE"))
                {
                label5.Visible=false;
                textProducao_Pequeno.Visible=false;
                ehpote=true;
                label4.Text="Pote";
                }
            else
                {
                label5.Visible=true;
                textProducao_Pequeno.Visible=true;
                ehpote=false;
                label4.Text="Grande";
                }
            }
        private void btn_Producao_ok_Click(object sender, EventArgs e)
            {
            string colaboradora = this.listColaboradoras.SelectedItem.ToString();
            string vendavel = this.listVendaveis_Producao.SelectedItem.ToString();
            bool ehpote = false;
            if (vendavel.Contains("POTE"))
                {
                ehpote=true;
                }
            string grande = textProducao_Grande.Text;
            string pequeno = textProducao_Pequeno.Text;
            if (grande=="")
                {
                grande="0";
                }
            if (pequeno=="")
                {
                pequeno="0";
                }
            DateTime data = DateTime.Now;
            string teste1 = data.ToString("yyyy-MM-dd HH:mm:ss");
            TimeSpan duracao = new TimeSpan(0, 0, 0, 1);
            data=data.Add(duracao);
            string teste2 = data.ToString("yyyy-MM-dd HH:mm:ss");
            string mensagem = "Confirma a inclusão de: "+vendavel+" grande = "+grande+" e pequeno = "+pequeno+", produzido pela "+colaboradora;
            if (ehpote)
                {
                mensagem="Confirma a inclusão de: "+vendavel+" quantidade = "+grande+" , produzido pela "+colaboradora;
                }
            string titulo = "Inclusão de Producao";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result=MessageBox.Show(mensagem, titulo, buttons);
            if (result==System.Windows.Forms.DialogResult.Yes)
                {
                if (!ehpote)
                    {
                    using (StreamWriter sw = File.AppendText("Producao.txt"))
                        {
                        sw.WriteLine(@"Use Taboao");
                        sw.WriteLine("if(select count(funcionario) from dbo.Producao where data = '"+teste1+"')=0 ");
                        sw.WriteLine("Begin");
                        sw.WriteLine("insert Taboao.dbo.Producao(Vendavel, Qtd, Data, Funcionario) VALUES('"+vendavel+"', "+grande+", '"+teste1+"', '"+colaboradora+"')");
                        sw.WriteLine("End");
                        sw.WriteLine("if(select count(funcionario) from dbo.Producao where data = '"+teste2+"')=0 ");
                        sw.WriteLine("Begin");
                        sw.WriteLine("insert Taboao.dbo.Producao(Vendavel, Qtd, Data, Funcionario) VALUES('"+vendavel+" PEQUENO', "+pequeno+", '"+teste2+"', '"+colaboradora+"')");
                        sw.WriteLine("End");
                        sw.Close();
                        }
                    }

                if (ehpote)
                    {
                    using (StreamWriter sw = File.AppendText("Producao.txt"))
                        {
                        sw.WriteLine(@"Use Taboao");
                        sw.WriteLine("if(select count(funcionario) from dbo.Producao where data = '"+teste1+"')=0 ");
                        sw.WriteLine("Begin");
                        sw.WriteLine("insert Taboao.dbo.Producao(Vendavel, Qtd, Data, Funcionario) VALUES('"+vendavel+"', "+grande+", '"+teste1+"', '"+colaboradora+"')");
                        sw.WriteLine("End");
                        sw.Close();
                        }
                    }
                }
            textProducao_Grande.Text="";
            textProducao_Pequeno.Text="";
            this.listVendaveis_Producao.SelectedIndex=0;
            Envianotificação("Produção cadastrada");
            }
        private void listVendaveis_Producao_SelectedIndexChanged(object sender, EventArgs e)
            {
            this.label_Producao_Vendavel.Text=this.listVendaveis_Producao.SelectedItem.ToString();
            }
        private void list_Ubereats_Click(object sender, EventArgs e)
            {
            tb_uber_selecionado.Text=this.list_Ubereats.SelectedItem.ToString();
            }
        private void button_uber_Click(object sender, EventArgs e)
            {
            DateTime data = DateTime.Now;
            string colaboradora = this.listColaboradoras.SelectedItem.ToString();
            string teste = data.ToString("yyyy-MM-dd HH:mm:ss");
            string vendavel = this.list_Ubereats.SelectedItem.ToString();
            string qtd = this.tb_uber_qtd.Text;
            string mensagem = vendavel+" - Quantidade = "+qtd;

            string titulo = "Inclusão de venda via UberEats";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result=MessageBox.Show(mensagem, titulo, buttons);
            if (result==System.Windows.Forms.DialogResult.Yes)
                {
                using (StreamWriter sw = File.AppendText("Producao.txt"))
                    {
                    sw.WriteLine(@"Use Taboao");
                    sw.WriteLine("if(select count(Vendavel) from dbo.Ajuste_Vendaveis where data = '"+teste+"')=0 ");
                    sw.WriteLine("Begin");
                    sw.WriteLine("insert Taboao.dbo.Ajuste_Vendaveis(Vendavel, Qtd, Motivo, Data, Funcionario) VALUES('"+vendavel+"', -"+qtd+", 'UBER', '"+teste+"', '"+colaboradora+"')");
                    sw.WriteLine("End");
                    sw.Close();
                    }
                tb_uber_qtd.Text="";
                tb_uber_selecionado.Text="";
                Envianotificação(vendavel + " via Uber Eats");
                }
            }
        private void list_Fatia_Click(object sender, EventArgs e)
            {
            tb_Fatia.Text=this.list_Fatia.SelectedItem.ToString();
            }
        private void list_Fatia_SelectedIndexChanged(object sender, EventArgs e)
            {
            tb_Fatia.Text=this.list_Fatia.SelectedItem.ToString();
            }
        private void list_Ubereats_SelectedIndexChanged(object sender, EventArgs e)
            {
            tb_uber_selecionado.Text=this.list_Ubereats.SelectedItem.ToString();
            }
        private void button_Fatia_Click(object sender, EventArgs e)
            {
            DateTime data = DateTime.Now;
            string colaboradora = this.listColaboradoras.SelectedItem.ToString();
            string teste = data.ToString("yyyy-MM-dd HH:mm:ss");
            string vendavel = this.list_Fatia.SelectedItem.ToString();
            string qtd = "1";
            string mensagem = vendavel;

            string titulo = "Inclusão de Bolo colocado para Fatiar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result=MessageBox.Show(mensagem, titulo, buttons);
            if (result==System.Windows.Forms.DialogResult.Yes)
                {
                using (StreamWriter sw = File.AppendText("Producao.txt"))
                    {
                    sw.WriteLine(@"Use Taboao");
                    sw.WriteLine("if(select count(Vendavel) from dbo.Ajuste_Vendaveis where data = '"+teste+"')=0 ");
                    sw.WriteLine("Begin");
                    sw.WriteLine("insert Taboao.dbo.Ajuste_Vendaveis(Vendavel, Qtd, Motivo, Data, Funcionario) VALUES('"+vendavel+"', -1, 'FATIA', '"+teste+"', '"+colaboradora+"')");
                    sw.WriteLine("End");
                    sw.Close();
                    }
                tb_Fatia.Text="";
                this.list_Fatia.SelectedIndex=0;
                Envianotificação(vendavel+" colocado para fatiar");
                }
            }
        private void list_Perdas_SelectedIndexChanged(object sender, EventArgs e)
            {
            tb_Perdas_Selecionado.Text=list_Perdas.SelectedItem.ToString();
            }
        private void botao_Perdas_Click(object sender, EventArgs e)
            {
            DateTime data = DateTime.Now;
            string colaboradora = this.listColaboradoras.SelectedItem.ToString();
            string teste = data.ToString("yyyy-MM-dd HH:mm:ss");
            string vendavel = this.list_Perdas.SelectedItem.ToString();
            string qtd = this.tb_Perdas_Qtd.Text;
            string mensagem = "Confirma o registro de perda do produto: "+vendavel+" e quantidade = "+qtd;

            string titulo = "Inclusão de Perdas";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result=MessageBox.Show(mensagem, titulo, buttons);
            if (result==System.Windows.Forms.DialogResult.Yes)
                {
                using (StreamWriter sw = File.AppendText("Producao.txt"))
                    {
                    sw.WriteLine(@"Use Taboao");
                    sw.WriteLine("if(select count(Vendavel) from dbo.Ajuste_Vendaveis where data = '"+teste+"')=0 ");
                    sw.WriteLine("Begin");
                    sw.WriteLine("insert Taboao.dbo.Ajuste_Vendaveis(Vendavel, Qtd, Motivo, Data, Funcionario) VALUES('"+vendavel+"', -"+qtd+", 'PERDA', '"+teste+"', '"+colaboradora+"')");
                    sw.WriteLine("End");
                    sw.Close();
                    }
                tb_Perdas_Qtd.Text="";
                tb_Perdas_Selecionado.Text="";
                this.list_Perdas.SelectedIndex=0;
                Envianotificação("Perda registrada");
                }
            }
        private void botao_fidelidade_Click(object sender, EventArgs e)
            {
            DateTime data = DateTime.Now;
            string colaboradora = this.listColaboradoras.SelectedItem.ToString();
            string teste = data.ToString("yyyy-MM-dd HH:mm:ss");
            string vendavel = this.list_Fidelidade.SelectedItem.ToString();
            string qtd = "1";
            string mensagem = vendavel;
            string titulo = "Inclusão de Bolo entregue por catão Fidelidade";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result=MessageBox.Show(mensagem, titulo, buttons);
            if (result==System.Windows.Forms.DialogResult.Yes)
                {
                using (StreamWriter sw = File.AppendText("Producao.txt"))
                    {
                    sw.WriteLine(@"Use Taboao");
                    sw.WriteLine("if(select count(Vendavel) from dbo.Ajuste_Vendaveis where data = '"+teste+"')=0 ");
                    sw.WriteLine("Begin");
                    sw.WriteLine("insert Taboao.dbo.Ajuste_Vendaveis(Vendavel, Qtd, Motivo, Data, Funcionario) VALUES('"+vendavel+"', -1, 'Fidelidade', '"+teste+"', '"+colaboradora+"')");
                    sw.WriteLine("End");
                    sw.Close();
                    }
                tb_Fatia.Text="";
                this.list_Fatia.SelectedIndex=0;
                Envianotificação(vendavel+" Entregue via Fidelidade");
                }
            }
        private void list_Fidelidade_SelectedIndexChanged(object sender, EventArgs e)
            {
            tb_fidelidade_selecionado.Text=list_Fidelidade.SelectedItem.ToString();
            }
        private void Carrega_Bolo_Utilizado()
            {
            list_bolo_utilizado.Items.Clear();
            string[] linhas = System.IO.File.ReadAllLines("Bolos_Utilizados.txt");
            foreach (var linha in linhas)
                {
                list_bolo_utilizado.Items.Add(linha);
                }
            list_bolo_utilizado.SelectedIndex=0;
            }
        private void botao_bolo_utilizado_Click(object sender, EventArgs e)
            {
            string colaboradora = this.listColaboradoras.SelectedItem.ToString();
            string vendavel = this.list_bolo_utilizado.SelectedItem.ToString();
            bool ehpote = false;
            if (vendavel.Contains("POTE"))
                {
                ehpote=true;
                }
            string grande = tb_bolo_utilizado_grande.Text;
            string pequeno = tb_bolo_utilizado_pequeno.Text;
            if (grande=="")
                {
                grande="0";
                }
            if (pequeno=="")
                {
                pequeno="0";
                }
            DateTime data = DateTime.Now;
            string teste1 = data.ToString("yyyy-MM-dd HH:mm:ss");
            TimeSpan duracao = new TimeSpan(0, 0, 0, 1);
            data=data.Add(duracao);
            string teste2 = data.ToString("yyyy-MM-dd HH:mm:ss");
            string mensagem = "Confirma a utilizacao de: "+vendavel+" grande = "+grande+" e pequeno = "+pequeno+", produzido pela "+colaboradora;
            if (ehpote)
                {
                mensagem="Confirma a Utilizacao de: "+vendavel+" quantidade = "+grande+" , produzido pela "+colaboradora;
                }
            string titulo = "Inclusão de Utilização na fabricação de produtos";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result=MessageBox.Show(mensagem, titulo, buttons);
            if (result==System.Windows.Forms.DialogResult.Yes)
                {
                if (!ehpote)
                    {
                    using (StreamWriter sw = File.AppendText("Producao.txt"))
                        {
                        sw.WriteLine(@"Use Taboao");
                        sw.WriteLine("if(select count(funcionario) from Taboao.dbo.Ajuste_Vendaveis where data = '"+teste1+"')=0 ");
                        sw.WriteLine("Begin");
                        sw.WriteLine("insert Taboao.dbo.Ajuste_Vendaveis(Vendavel, Qtd, Motivo, Data, Funcionario) VALUES('"+vendavel+"', -"+grande+", 'FABRICACAO', '"+teste1+"', '"+colaboradora+"')");
                        sw.WriteLine("End");
                        sw.WriteLine("if(select count(funcionario) from Taboao.dbo.Ajuste_Vendaveis where data = '"+teste2+"')=0 ");
                        sw.WriteLine("Begin");
                        sw.WriteLine("insert Taboao.dbo.Ajuste_Vendaveis(Vendavel, Qtd, Motivo, Data, Funcionario) VALUES('"+vendavel+" PEQUENO', -"+pequeno+", 'FABRICACAO', '"+teste2+"', '"+colaboradora+"')");
                        sw.WriteLine("End");
                        sw.Close();
                        }
                    }
                }
            tb_bolo_utilizado_grande.Text="";
            tb_bolo_utilizado_pequeno.Text="";
            this.list_bolo_utilizado.SelectedIndex=0;
            Envianotificação(vendavel+" utilizado");
            MessageBox.Show("Registrado com sucesso!", "Registro", MessageBoxButtons.OK);
            }
        private void list_bolo_utilizado_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (list_bolo_utilizado.SelectedIndex==0)
                {
                tb_bolo_utilizado_grande.Visible=false;
                tb_bolo_utilizado_pequeno.Visible=false;
                botao_bolo_utilizado.Visible=false;
                }
            else
                {
                tb_bolo_utilizado_grande.Visible=true;
                tb_bolo_utilizado_pequeno.Visible=true;
                botao_bolo_utilizado.Visible=true;
                }
            }
        private void botao_sorteio_Click(object sender, EventArgs e)
            {
            DateTime data = DateTime.Now;
            if (tb_quantidade_de_cupons.Text.Length==0) { tb_quantidade_de_cupons.Text="1"; }
            int quantidade = Convert.ToInt32(tb_quantidade_de_cupons.Text);
            if (quantidade<1) { quantidade=1; }
            string teste1 = data.ToString("yyyy-MM-dd HH:mm:ss");
            string nome = tb_nome_completo.Text.ToUpper();
            string telefone = tb_telefone_celular.Text;
            if (telefone.Length==0)
                {
                telefone="não informado";
                }
            string email = tb_email_cliente.Text;
            if (email.Length==0)
                {
                email="não informado";
                }
            string funcionario = listColaboradoras.SelectedItem.ToString();
            var mensagem = "Você confirma o cadastramento do cliente "+nome+System.Environment.NewLine+"Telefone: "+telefone+System.Environment.NewLine+"e-mail: "+email;
            DialogResult resultado = MessageBox.Show(mensagem, "Confirmação de cadastro de clientes", MessageBoxButtons.YesNo);
            if (resultado==System.Windows.Forms.DialogResult.Yes)
                {
                for (int i = 0; i<quantidade; i++)
                    {
                    using (StreamWriter sw = File.AppendText("Producao.txt"))
                        {
                        sw.WriteLine(@"Use Taboao");
                        sw.WriteLine("insert Taboao.dbo.Clientes(Cliente, email, Telefone, Data, Funcionario) VALUES('"+nome+"', '"+email+"', '"+telefone+"', '"+teste1+"', '"+funcionario+"')");
                        sw.Close();
                        }
                    }
                Envianotificação("Cliente cadastrado");
                MessageBox.Show("Cliente cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK);
                }
            tb_nome_completo.Text="";
            tb_telefone_celular.Text="";
            tb_email_cliente.Text="";
            tb_quantidade_de_cupons.Text="1";
            }
        private void Envianotificação(string texto)
            {
            PushbulletClient client = new PushbulletClient("o.ijhfmbKRI8JAAAjaorTvs3n1I1oHo4qH");
            //var devices = client.CurrentUsersDevices();
            //var device = devices.Devices.Where(o => o.Manufacturer == "Apple").FirstOrDefault();
            PushNoteRequest request1 = new PushNoteRequest
                {
                DeviceIden="ujy7mvFtukmsjE5NB4jvkO",
                Title=texto,
                Body=texto
                };

            PushResponse response1 = client.PushNote(request1);
            }

        private void tb_email_cliente_TextChanged(object sender, EventArgs e)
            {
            if (tb_email_cliente.Text.Contains("@") && tb_email_cliente.Text.Length>7 && tb_nome_completo.Text.Length>10 && tb_telefone_celular.Text.Length >7)
                {
                botao_sorteio.Enabled=true;
                }
            else { botao_sorteio.Enabled=false; }
            }
        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static readonly Random rand = new Random();

        private void btnGerarNomes_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            //adiciona os items do txt nas lista
            List<string> nomes = CarregarNomesDoTxt();
            List<string> sobrenomes = new List<string>();
            if(chkNomeDoMeio.Checked)
                sobrenomes = CarregarSobrenomesTxt();

            if(nomes == null || sobrenomes == null)
                return;
            //calculo a quantidade e gera os nomes aleatorios
            for(int i = 0; i < numericUpDown1.Value; i++)
            {
                if(chkComNomeDoFim.Checked)
                    //a divisao por 2 ira garantir que nao haverar sobrenomes repetidos
                    txtResultado.Text += verificacaoIncluir(nomes[rand.Next(nomes.Count / 2)] + " " + sobrenomes[rand.Next(sobrenomes.Count / 2)] + " " + sobrenomes[rand.Next((sobrenomes.Count / 2), sobrenomes.Count)]);
                else if(chkNomeDoMeio.Checked)
                    txtResultado.Text += verificacaoIncluir(nomes[rand.Next(nomes.Count)] + " " + sobrenomes[rand.Next(sobrenomes.Count)]);
                else
                    txtResultado.Text += verificacaoIncluir(nomes[rand.Next(nomes.Count)]);
            }
        }

        private void btnCpf_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            byte i = (byte)numericUpDown1.Value;
            do
            {
                i--;
                txtResultado.Text += verificacaoIncluir(gerarCpfValido(rdoIncluirMascaraCpf.Checked));
            } while(i != 0);
        }

        private void btnCnjp_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            byte i = (byte)numericUpDown1.Value;
            do
            {
                i--;
                txtResultado.Text += verificacaoIncluir(gerarCnpjValido(rdoIncluirMascaraCpf.Checked));
            } while(i != 0);
        }

        private void btnGerarDatas_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            byte i = 0;
            do
            {
                i++;
                DateTime resultado = GetRandomDate(dtpDe.Value, dtpAte.Value);
                txtResultado.Text += verificacaoIncluir(chkComHoras.Checked ? resultado.ToString("yyyy-dd-MM hh:mm:ss") : resultado.ToString("yyyy-dd-MM"));
            } while(i < numericUpDown1.Value);
        }

        private void btnGerarHora_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            byte i = 0;
            do
            {
                i++;
                DateTime resultado = GetRandomDate(new DateTime(2017, 04, 19), DateTime.Today);
                txtResultado.Text += verificacaoIncluir(rdoOnlyHrMin.Checked ? resultado.ToShortTimeString() : resultado.ToLongTimeString());
            } while(i < numericUpDown1.Value);
        }

        private void txtResultado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.A)
            {
                if(sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        private void chkNomeDoMeio_CheckedChanged(object sender, EventArgs e)
        {
            chkComNomeDoFim.Enabled = chkNomeDoMeio.Checked;
            if(!chkNomeDoMeio.Checked)
                chkComNomeDoFim.Checked = false;
        }

        private void btnGerarTel_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            if(rdoDDDtxt.Checked)
            {
                string[] lista = txtDDDs.Text.Split(',');
                for(int i = 0; i < numericUpDown1.Value; i++)
                {
                    if(chkIncluirMaskTelCel.Checked)
                        txtResultado.Text += verificacaoIncluir("'(" + lista[rand.Next(lista.Length)] + ") " + rand.Next(2100, 4999) + "-" + rand.Next(1000, 9999) + "'");
                    else
                        txtResultado.Text += verificacaoIncluir("'" + lista[rand.Next(lista.Length)] + " " + rand.Next(2100, 4999) + rand.Next(1000, 9999) + "'");

                }
            }
            else if(rdoDDDaleatorio.Checked)
            {
                //DDDs existentes no brasil
                byte[] qualquerDDD = new byte[] {
                    11, 12, 13, 14, 15, 16, 17, 18, 19, 22, 21, 24, 27, 28, 31, 32,
                    33, 34, 35, 37, 38, 41, 42, 43, 44, 45, 46, 47, 48, 49, 51, 53,
                    54, 55, 61, 62, 63, 64, 65, 66,  67, 68, 69, 71, 73, 74, 75, 77,
                    79, 81, 82, 83, 84, 85, 86, 87, 88, 89, 91, 92, 93, 94, 95, 96,
                    97, 98, 99,
                };
                for(int i = 0; i < numericUpDown1.Value; i++)
                {
                    if(chkIncluirMaskTelCel.Checked)
                        txtResultado.Text += verificacaoIncluir("'(" + qualquerDDD[rand.Next(qualquerDDD.Length)] + ") " + rand.Next(2100, 4999) + "-" + rand.Next(1000, 9999) + "'");
                    else
                        txtResultado.Text += verificacaoIncluir("'" + qualquerDDD[rand.Next(qualquerDDD.Length)] + " " + rand.Next(2100, 4999) + rand.Next(1000, 9999) + "'");
                }
            }
        }

        private void btnGerarCel_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            if(rdoDDDtxt.Checked)
            {
                string[] lista = txtDDDs.Text.Split(',');
                for(int i = 0; i < numericUpDown1.Value; i++)
                {
                    if(chkIncluirMaskTelCel.Checked)
                        txtResultado.Text += verificacaoIncluir("'(" + lista[rand.Next(lista.Length)] + ") " + rand.Next(91000, 99999) + "-" + rand.Next(1000, 9999) + "'");
                    else
                        txtResultado.Text += verificacaoIncluir("'" + lista[rand.Next(lista.Length)] + " " + rand.Next(91000, 99999) + rand.Next(1000, 9999) + "'");

                }
            }
            else if(rdoDDDaleatorio.Checked)
            {
                //DDDs existentes no brasil
                byte[] qualquerDDD = new byte[] {
                    11, 12, 13, 14, 15, 16, 17, 18, 19, 22, 21, 24, 27, 28, 31, 32,
                    33, 34, 35, 37, 38, 41, 42, 43, 44, 45, 46, 47, 48, 49, 51, 53,
                    54, 55, 61, 62, 63, 64, 65, 66,  67, 68, 69, 71, 73, 74, 75, 77,
                    79, 81, 82, 83, 84, 85, 86, 87, 88, 89, 91, 92, 93, 94, 95, 96,
                    97, 98, 99,
                };
                for(int i = 0; i < numericUpDown1.Value; i++)
                {
                    if(chkIncluirMaskTelCel.Checked)
                        txtResultado.Text += verificacaoIncluir("'(" + qualquerDDD[rand.Next(qualquerDDD.Length)] + ") " + rand.Next(91000, 99999) + "-" + rand.Next(1000, 9999) + "'");
                    else
                        txtResultado.Text += verificacaoIncluir("'" + qualquerDDD[rand.Next(qualquerDDD.Length)] + " " + rand.Next(91000, 99999) + rand.Next(1000, 9999) + "'");
                }
            }
        }

        private void btnGerarEmail_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            List<string> dominios = new List<string>();
            if(chkGmail.Checked)
                dominios.Add(chkGmail.Text);
            if(chkOutlook.Checked)
                dominios.Add(chkOutlook.Text);
            if(chkYahoo.Checked)
                dominios.Add(chkYahoo.Text);
            if(chkPreferencia.Checked)
                dominios.AddRange(chkTxtPreferencia.Text.Split(';'));

            char[] vogais = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] concoantes = new char[] { 'b', 'c', 'd', 'f', 'g', 'h',
                                             'j', 'k' ,'l', 'm', 'n', 'p', 
                                             'q', 'r', 's', 't', 'v', 'w',
                                             'x', 'y', 'z'};

            string palavraBr;
            for(int i = 0; i < numericUpDown1.Value; i++)
            {
                palavraBr = "";
                for(int t = 0; t < rand.Next(3, 5); t++)
                {
                    palavraBr += concoantes[rand.Next(concoantes.Length)].ToString();
                    palavraBr += vogais[rand.Next(vogais.Length)].ToString();
                }
                palavraBr += dominios[rand.Next(dominios.Count)];
                txtResultado.Text += verificacaoIncluir(palavraBr);
            }
        }

        #region Métodos Privados
        //verificara quais itens do groupbox 'incluir' está 'checkado'
        private string verificacaoIncluir(string resulFinal)
        {
            if(chkAspasSimples.Checked)
            {
                resulFinal = "'"+resulFinal+"'";
            }
            if(chkParentesesRight.Checked)
            {
                resulFinal += ")";
            }
            if(chkVirgula.Checked)
            {
                resulFinal += ",";
            }
            if(chkParentesesLeft.Checked)
            {
                resulFinal = "(" + resulFinal;
            }
            //pula uma linha
            return resulFinal + "\r\n";
        }

        //retornara a lista de todos Nomes do arquivo .txt
        private List<string> CarregarNomesDoTxt()
        {
            //Pré configuraçao:
            /*
                Ao adicionar um arquivo txt ou outro tipo no projeto, vai ate o arquivo e faça o seguinte:
                ateoarquivo.txt > propriedades >  Copy to output = Copy always
                assim ele criara as pastas e os arquivos junto com a aplicaçao, sem a necessidade de criar uma pasta manualmemte.
             */
            try
            {
                string linha;
                string pasta = Application.StartupPath;
                System.IO.StreamReader reader;

                List<string> nomes = new List<string>();

                //Populando Lista de nomes
                reader = new System.IO.StreamReader(pasta+ "\\Items\\nomes.txt", Encoding.UTF8);//Encoding.GetEncoding("iso-8859-1")se estivesse em ASCII
                while(!reader.EndOfStream)
                {
                    linha = reader.ReadLine();
                    nomes.Add(linha);
                }
                return nomes;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"\r\n"+"Crie um arquivo chamado nomes.txt e coloque cada nome em uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);             
                return null;
            }
        }

        //retornara a lista de todos Sobrenomes no Arquivo de texto
        private List<string> CarregarSobrenomesTxt()
        {
            try
            {
                string linha;
                string pasta = Application.StartupPath;
                System.IO.StreamReader reader;

                List<string> sobrenomes = new List<string>();

                //Populando Lista de sobrenomes
                //reader = new System.IO.StreamReader(pasta + "\\arquivos\\sobrenomes.txt", Encoding.UTF8);
                reader = new System.IO.StreamReader(pasta+"\\Items\\sobrenomes.txt", Encoding.UTF8);
                while(!reader.EndOfStream)
                {
                    linha = reader.ReadLine();
                    sobrenomes.Add(linha);
                }
                return sobrenomes;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DateTime GetRandomDate(DateTime from, DateTime to)
        {
            var range = to - from;

            var randTimeSpan = new TimeSpan((long)(rand.NextDouble() * range.Ticks));

            return from + randTimeSpan;
        }

        private string gerarCpfValido(bool comMascara = false)
        {
            Int32 soma1, soma2, i, erro, cpf, parte1, parte2, parte3, dig1, parte5, parte6, parte7, dig2;
            Int32[] numero = new Int32[13];

            for(i = 1; i <= 9; i++)
            {
                erro = 1;
                do
                {
                    if(erro > 1)
                    {
                        MessageBox.Show("Numero invalido.\n");
                        erro = 1;
                    }
                    numero[i] = (rand.Next()) % 9;
                    erro++;
                } while(numero[i] > 9 || numero[i] < 0);
            }
            //*==========================================*
            //|       Primeiro digito veridicador        |
            //*==========================================*
            soma1 = ((numero[1] * 10) +
                      (numero[2] * 9) +
                      (numero[3] * 8) +
                      (numero[4] * 7) +
                      (numero[5] * 6) +
                      (numero[6] * 5) +
                      (numero[7] * 4) +
                      (numero[8] * 3) +
                      (numero[9] * 2));
            parte1 = (soma1 / 11);
            parte2 = (parte1 * 11);
            parte3 = (soma1 - parte2);
            dig1 = (11 - parte3);
            if(dig1 > 9) dig1 = 0;
            //*==========================================*
            //|        Segundo digito veridicador        |
            //*==========================================*
            soma2 = ((numero[1] * 11) +
                      (numero[2] * 10) +
                      (numero[3] * 9) +
                      (numero[4] * 8) +
                      (numero[5] * 7) +
                      (numero[6] * 6) +
                      (numero[7] * 5) +
                      (numero[8] * 4) +
                      (numero[9] * 3) +
                      (dig1 * 2));
            parte5 = (soma2 / 11);
            parte6 = (parte5 * 11);
            parte7 = (soma2 - parte6);
            dig2 = (11 - parte7);
            if(dig2 > 9) dig2 = 0;
            //*==========================================*
            //|       Impressao do numero completo       | 
            //*==========================================*
            string resultadoPre = string.Empty;

            if(comMascara)
            {
                for(i = 1; i <= 9; i++)
                {
                    Invoke(new Action(() => resultadoPre += Convert.ToString(numero[i])));
                    if(i - 1 == 2) Invoke(new Action(() => resultadoPre += "."));
                    if(i - 1 == 5) Invoke(new Action(() => resultadoPre += "."));
                }
                Invoke(new Action(() => resultadoPre += "-" + dig1 + dig2)); // dois últimos digitos
            }
            else
            {
                for(i = 1; i <= 9; i++)
                {
                    //numeros do CPF
                    Invoke(new Action(() => resultadoPre += Convert.ToString(numero[i])));
                }
                // dois últimos digitos
                Invoke(new Action(() => resultadoPre += dig1 + "" + dig2));
            }

            return resultadoPre;
        }

        private string gerarCnpjValido(bool comMascara = false)
        {
            Int32 soma1, soma2, i, cnpj, parte1, parte2, parte3, dig1, parte5, parte6, parte7, dig2;
            Int32[] numero = new Int32[13];
            for(i = 1; i <= 8; i++)
            {
                numero[i] = (rand.Next()) % 9;
            }
            numero[9] = 0;
            numero[10] = 0;
            numero[11] = 0;
            numero[12] = (rand.Next()) % 9;
            //*==========================================*
            //|       Primeiro digito veridicador        |
            //*==========================================*
            soma1 = ((numero[1] * 5) +
                      (numero[2] * 4) +
                      (numero[3] * 3) +
                      (numero[4] * 2) +
                      (numero[5] * 9) +
                      (numero[6] * 8) +
                      (numero[7] * 7) +
                      (numero[8] * 6) +
                      (numero[9] * 5) +
                      (numero[10] * 4) +
                      (numero[11] * 3) +
                      (numero[12] * 2));
            parte1 = (soma1 / 11);
            parte2 = (parte1 * 11);
            parte3 = (soma1 - parte2);
            dig1 = (11 - parte3);
            if(dig1 > 9) dig1 = 0;
            //*==========================================*
            //|        Segundo digito veridicador        |
            //*==========================================*
            soma2 = ((numero[1] * 6) +
                      (numero[2] * 5) +
                      (numero[3] * 4) +
                      (numero[4] * 3) +
                      (numero[5] * 2) +
                      (numero[6] * 9) +
                      (numero[7] * 8) +
                      (numero[8] * 7) +
                      (numero[9] * 6) +
                      (numero[10] * 5) +
                      (numero[11] * 4) +
                      (numero[12] * 3) +
                      (dig1 * 2));
            parte5 = (soma2 / 11);
            parte6 = (parte5 * 11);
            parte7 = (soma2 - parte6);
            dig2 = (11 - parte7);
            if(dig2 > 9) dig2 = 0;
            //*==========================================*
            //|       Impressao do numero completo       | 
            //*==========================================*
            string preResultado = "";
            if(comMascara)
            {
                for(i = 1; i <= 12; i++)
                {
                    //numeros do CNPJ
                    Invoke(new Action(() => preResultado += Convert.ToString(numero[i])));
                    if(i == 2) Invoke(new Action(() => preResultado += "."));//imprime um ponto depois da 2ª casa
                    if(i == 5) Invoke(new Action(() => preResultado += "."));//imprime um ponto depois da 5ª casa
                    if(i == 8) Invoke(new Action(() => preResultado += "/"));//imprime uma barra depois da 8ª casa
                }
                Invoke(new Action(() => preResultado += "-" + dig1 + "" + dig2)); // dois últimos digitos
            }
            else
            {
                for(i = 1; i <= 12; i++)
                {
                    //numeros do CNPJ
                    Invoke(new Action(() => preResultado += Convert.ToString(numero[i])));
                }
                // dois últimos digitos
                Invoke(new Action(() => preResultado += dig1 + "" + dig2));
            }
            return preResultado;

        }

        private long LongRandom(long min, long max)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % ((max+1) - min)) + min);
        }
        #endregion

        private void btnGerarNumeros_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            int multiplos;
            if(int.TryParse(txtMultiplos.Text, out multiplos))
            {
                for(int i = 0; i < numericUpDown1.Value; i++)
                {
                    long r = LongRandom(long.Parse(txtNumerosDe.Text), long.Parse(txtNumerosAte.Text));
                    long up = r - (r % multiplos);
                    long low = (r - (r % multiplos)) + multiplos;
                    long a = Math.Abs(low - r);
                    long b = Math.Abs(up - r);
                    long result;
                    if(a <= b)
                        result = low;
                    else
                        result = up;
                    txtResultado.Text +=verificacaoIncluir(result.ToString());
                }
            }

        }

        private void btnGerarPalavras_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            //separa as palavras pelo valor digitado no separador
            string[] palavras = txtPalavras.Text.Split(new string[] { txtSeparador.Text }, StringSplitOptions.None);

            for(int i = 0; i < numericUpDown1.Value; i++)
                txtResultado.Text += verificacaoIncluir(palavras[rand.Next(palavras.Length)]);

        }
    }
}

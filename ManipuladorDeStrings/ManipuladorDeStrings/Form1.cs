using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipuladorDeStrings
{
    public partial class Form1 : Form
    {
        private void LimparSaida()
        {
            TxtSaida.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Conta a quantidade de Palavras
        private void ContaP_Click(object sender, EventArgs e)
        {
            LimparSaida();
            int QtdePalavras = 0;
            string TextoDigitado = TxtEntrada.Text;
            string[] Palavras = TextoDigitado.Split(' ');
            foreach (string Pa in Palavras)
            {
                QtdePalavras += 1;
            }

            MessageBox.Show($"A quantidade de palavras digitadas é: {QtdePalavras}");
        }
        //Conta Quantidade de Palavras fim

        //Conta Letras Inicio
        private void ContaL_Click(object sender, EventArgs e)
        {
            char[] TextoDigitado = TxtEntrada.Text.ToCharArray();

            int ContaLetras = 0;
            foreach (char p in TextoDigitado)
            {
                if (char.IsLetter(p))
                {
                    ContaLetras++;
                }

            }
            MessageBox.Show("A quantidade de letras neste texto é: " + ContaLetras);
        }
        //Conta Letras Fim

        //Transforma em Maiusculo inicio
        private void Maisculo_Click(object sender, EventArgs e)
        {
            LimparSaida();
            string Maiusculo = TxtEntrada.Text;
            TxtSaida.Text = Maiusculo.ToUpper();
        }
        //Transforma em Maiusculo fim

        //Transforma em Minusculo Inicio
        private void Minusculo_Click(object sender, EventArgs e)
        {
            LimparSaida();
            String Minuscula = TxtEntrada.Text;
            TxtSaida.Text = Minuscula.ToLower();

        }
        //Transforma em Minusculo fim

        //Reverte Palavra inicio
        private void InvertePalavra_Click(object sender, EventArgs e)
        {
            LimparSaida();
            string[] Texto = TxtEntrada.Text.Split(' ');

            string RevertePalavras = string.Empty;
            for (int i = Texto.Length - 1; i >= 0; i--)
            {
                RevertePalavras += ' ' + Texto[i];
            }
            TxtSaida.Text = RevertePalavras;
        }
        //Reverte Palavra fim

        //Reverte todo o texto
        private void InverteLetra_Click(object sender, EventArgs e)
        {
            LimparSaida();
            char[] TextoEntrada = TxtEntrada.Text.ToCharArray();
            string ReverteTexto = string.Empty;
            for (int i = TextoEntrada.Length - 1; i >= 0; i--)
            {
                ReverteTexto += TextoEntrada[i];
            }
            TxtSaida.Text = ReverteTexto;
        }
        //Reverte todo o texto


        //Quebra de Linha Inicio
        private void QuebraLinhas_Click(object sender, EventArgs e)
        {
            TxtSaida.Clear();
            string Texto = TxtEntrada.Text;
            string[] TextoCompleto = Texto.Split(' ');
            string QuebraDeLinha = string.Join(System.Environment.NewLine, TextoCompleto);
            TxtSaida.Text = QuebraDeLinha;
        }
        //Quebra de Linha Fim

        //Embaralha as Palavras
        private void EmbaralhaP_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //TxtSaida.Clear();
            //string[] TextoEntrada = TxtEntrada.Text.Split().ToArray();
            //List<string> DadosTexto = new List<string>(TextoEntrada);
            //List<string> EmbaralhaTexto = new List<string>(DadosTexto);
            //int[] TextoReversão = new int[] { random.Next(TextoEntrada.Length) };
            //int Numero = TextoReversão[0];
            //string Temporaria = DadosTexto[Numero];
            //for (int i = 0; i < DadosTexto.Count; i++)
            //{
            //    if (EmbaralhaTexto.Contains(Temporaria))
            //    {
            //        EmbaralhaTexto.Remove(Temporaria);
            //    }
            //    else
            //    {
            //        EmbaralhaTexto.Add(Temporaria);
            //    }
            //}

            //foreach (string p in EmbaralhaTexto)
            //{
            //    TxtSaida.Text += p + " ";
            //}

            ////////////////////////////////////////////////

            Random random = new Random();
            TxtSaida.Clear();
            string[] TextoEntrada = TxtEntrada.Text.Split().ToArray();
            List<string> DadosTexto = new List<string>(TextoEntrada);


            while (DadosTexto.Count() > 0)
            {
                int Numero = random.Next(DadosTexto.Count());

                TxtSaida.Text += DadosTexto[Numero] + " ";

                DadosTexto.Remove(DadosTexto[Numero]);
            }


            ////////////////////////////////////////////////

            //Random random = new Random();
            //TxtSaida.Clear();
            //string[] TextoEntrada = TxtEntrada.Text.Split().ToArray();
            //List<int> numerosJaSorteiados = new List<int>();

            //while(TextoEntrada.Length != numerosJaSorteiados.Count())
            //{ 
            //    int Numero = random.Next(TextoEntrada.Length);
            //    if (!numerosJaSorteiados.Exists(x => x == Numero))
            //    {
            //        TxtSaida.Text += TextoEntrada[Numero] + " ";
            //        numerosJaSorteiados.Add(Numero);
            //    }
            //}

        }
        //Embaralha as Palavras Fim

        //Embaralha as Letras
        private void EmbaralhaL_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //TxtSaida.Clear();
            //char[] TextoDigitado = TxtEntrada.Text.ToCharArray();
            //List<char> DadosTexto = new List<char>(TextoDigitado);
            //List<char> EmbaralhaLetras = new List<char>(DadosTexto);
            //int[] TextoReversão = new int[] { random.Next(TextoDigitado.Length) };
            //int Numero = TextoReversão[0];
            //char Temporaria = DadosTexto[Numero];
            //for (int i = 0; i < DadosTexto.Count; i++)
            //{
            //    if (EmbaralhaLetras.Contains(Temporaria))
            //    {
            //        EmbaralhaLetras.Remove(Temporaria);
            //    }
            //    else
            //    {
            //        EmbaralhaLetras.Add(Temporaria);
            //    }
            //}

            //foreach (char p in EmbaralhaLetras)
            //{
            //    TxtSaida.Text += p;
            //}

            Random random = new Random();
            TxtSaida.Clear();
            char[] TextoEntrada = TxtEntrada.Text.ToCharArray();
            List<char> DadosTexto = new List<char>(TextoEntrada);


            while (DadosTexto.Count() > 0)
            {
                int Numero = random.Next(DadosTexto.Count());

                TxtSaida.Text += DadosTexto[Numero];

                DadosTexto.Remove(DadosTexto[Numero]);
            }
        }
        //Embaralha as Letras





    }
}

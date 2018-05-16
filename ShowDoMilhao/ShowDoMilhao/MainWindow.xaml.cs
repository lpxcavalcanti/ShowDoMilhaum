using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShowDoMilhao
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public Jogador Jogador;
        public List<Pergunta> Perguntas;
        public int IDPerguntaAtual;

        public MainWindow()
        {
            Perguntas = new List<Pergunta>();
            InitializeComponent();
            IDPerguntaAtual = 0;

            var pergunta1 = new Pergunta
            {
                Enunciado = "Qual é a cidade mais populosa do Brasil?",
                Resposta1 = "São Paulo",
                Resposta2 = "Rio de Janeiro",
                Resposta3 = "Recife",
                Resposta4 = "Minas Gerais",
                Resposta5 = "Bahia",
                RespostaCorreta = 1
            };

            var pergunta2 = new Pergunta
            {
                Enunciado = "O Brasil é localizado em qual continente?",
                Resposta1 = "América",
                Resposta2 = "Europa",
                Resposta3 = "Oceania",
                Resposta4 = "Ásia",
                Resposta5 = "África",
                RespostaCorreta = 1
            };

            var pergunta3 = new Pergunta
            {
                Enunciado = "Em que dia, mês e ano foi declarada a independência do Brasil? ",
                Resposta1 = "25 de maio de 1828",
                Resposta2 = "30 de dezembro 1850",
                Resposta3 = "14 de julho 1848",
                Resposta4 = "07 de setembro 1822",
                Resposta5 = "22 de abril 1500",
                RespostaCorreta = 4
            };

            var pergunta4 = new Pergunta
            {
                Enunciado = "Em que ano o primeiro astronauta brasileiro foi ao espaço?",
                Resposta1 = "2008",
                Resposta2 = "2007",
                Resposta3 = "2006",
                Resposta4 = "2009",
                Resposta5 = "2010",
                RespostaCorreta = 3
            };

            var pergunta5 = new Pergunta
            {
                Enunciado = "Qual foi o primeiro nome dado ao Brasil pelos portugueses?",
                Resposta1 = "Terra dos Papagaios",
                Resposta2 = "Terra de Palmeiras",
                Resposta3 = "Terra de Santa Cruz",
                Resposta4 = "Ilha de Vera Cruz",
                Resposta5 = "Terra de Brasília",
                RespostaCorreta = 4
            };

            var pergunta6 = new Pergunta
            {
                Enunciado = "Qual foi o estado em que Pedro Álvares Cabral e sua esquadra se hospedaram?",
                Resposta1 = "Bahia",
                Resposta2 = "Sergipe",
                Resposta3 = "Pernambuco",
                Resposta4 = "Alagoas",
                Resposta5 = "Maranhão",
                RespostaCorreta = 1
            };

            var pergunta7 = new Pergunta
            {
                Enunciado = "Qual foi a primeira capital do Brasil?",
                Resposta1 = "Brasília",
                Resposta2 = "São Paulo",
                Resposta3 = "Rio de Janeiro",
                Resposta4 = "Bahia",
                Resposta5 = "Minas Gerais",
                RespostaCorreta = 4
            };

            var pergunta8 = new Pergunta
            {
                Enunciado = "Qual era o nome do tratado que dividia as terras brasileiras entre território espanhol e portugês?",
                Resposta1 = "Tratado de Terras ",
                Resposta2 = "Tratado dos reis",
                Resposta3 = "Tratado de amizade",
                Resposta4 = "Tratado de amistício",
                Resposta5 = "Tratado de Tordesilhas",
                RespostaCorreta = 5
            };

            var pergunta9 = new Pergunta
            {
                Enunciado = "Quando foi abolida a escravidão no Brasil?",
                Resposta1 = "1859",
                Resposta2 = "1888",
                Resposta3 = "1500",
                Resposta4 = "1799",
                Resposta5 = "A escravidão ainda reina nos nossos dias atuais",
                RespostaCorreta = 2
            };

            var pergunta10 = new Pergunta
            {
                Enunciado = "Quem foi o primeiro presidente brasileiro?",
                Resposta1 = "Lula",
                Resposta2 = "Temer",
                Resposta3 = "Getúlio Vargas",
                Resposta4 = "Marechal Deodoro da Fonseca",
                Resposta5 = "Fernando Collor",
                RespostaCorreta = 4
            };

            Perguntas.Add(pergunta1);
            Perguntas.Add(pergunta2);
            Perguntas.Add(pergunta3);
            Perguntas.Add(pergunta4);
            Perguntas.Add(pergunta5);
            Perguntas.Add(pergunta6);
            Perguntas.Add(pergunta7);
            Perguntas.Add(pergunta8);
            Perguntas.Add(pergunta9);
            Perguntas.Add(pergunta10);



        }

        private void MostrarPergunta(Pergunta pergunta)
        {
            LabelPontuacao.Content = "Pontuação " + Jogador.Pontuacao;
            TextBlockEnunciado.Text = pergunta.Enunciado;
            RadioButtonResposta1.Content = pergunta.Resposta1;
            RadioButtonResposta2.Content = pergunta.Resposta2;
            RadioButtonResposta3.Content = pergunta.Resposta3;
            RadioButtonResposta4.Content = pergunta.Resposta4;
            RadioButtonResposta5.Content = pergunta.Resposta5;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nome = TextBoxNomeJogador.Text;
            this.Jogador = new Jogador(nome, 0);
            GridTelaAbertura.Visibility = Visibility.Hidden;
            GridTelaPergunta.Visibility = Visibility.Visible;

            LabelNomeJogador.Content = 
                this.Jogador.Nome 
                + " jogando";

            MostrarPergunta(Perguntas[0]);

            Console.WriteLine(this.Jogador.Nome);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Checar se a resposta está correta
            var perguntaAtual = Perguntas[IDPerguntaAtual];
            var respostaPergunta = perguntaAtual.RespostaCorreta;

            int respostaSelecionada = 0;

            if(RadioButtonResposta1.IsChecked.Value) respostaSelecionada = 1;
            else if(RadioButtonResposta2.IsChecked.Value) respostaSelecionada = 2;
            else if(RadioButtonResposta3.IsChecked.Value) respostaSelecionada = 3;
            else if(RadioButtonResposta4.IsChecked.Value) respostaSelecionada = 4;
            else if(RadioButtonResposta5.IsChecked.Value) respostaSelecionada = 5;        

            if(respostaSelecionada == respostaPergunta)
            {
                Jogador.Pontuacao = Jogador.Pontuacao + 10;
            }
            else
            {
                MostrarFinal();
            }

            IDPerguntaAtual = IDPerguntaAtual + 1;

            if(IDPerguntaAtual < Perguntas.Count)
            {
                MostrarPergunta(Perguntas[IDPerguntaAtual]);
            }
            else
            {
                MostrarFinal();
            }
        }

        private void MostrarFinal()
        {
            GridTelaPergunta.Visibility = Visibility.Hidden;
            GridTelaFinal.Visibility = Visibility.Visible;

            TextBlockFinal.Text =
                "O jogo acabou!\n A sua pontuação foi: " +
                Jogador.Pontuacao +
                " pontos!";
        }
    }

    public class Pergunta
    {
        public string Enunciado;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public int RespostaCorreta;
    }
}

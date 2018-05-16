using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowDoMilhao
{
    public class Jogador
    {
        public string Nome;
        public int Pontuacao;

        public Jogador()
        {
            Nome = "";
            Pontuacao = 0;
        }

        public Jogador(string nome, int pontuacao)
        {
            this.Nome = nome;
            this.Pontuacao = pontuacao;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampBrasileiro
{
    internal class Time
    {
        private string nome = "";
            public string Nome { get { return nome; } set { this.nome = value; } }
        public int Pontos { get; set; }
        public int Vitorias { get; set; }
        public int Empates { get; set; }
        public int Derrotas { get; set; }
        public int Jogos { get; set; }
        
        // Método Construtor
        public Time(string nome)
        {
            this.Nome = nome;
            this.Pontos = 0;
            this.Vitorias = 0;
            this.Derrotas = 0;
            this.Jogos = 0;
        }

        public void pontuarVitoria()
        {
            this.Pontos += 3;
            this.Vitorias += 1;
            this.Jogos += 1;
        }
        public void pontuarEmpate()
        {
            this.Pontos += 1;
            this.Empates += 1;
            this.Jogos += 1;
        }
        
        public void Perder()
        {
            this.Derrotas += 1;
            this.Jogos += 1;
        }
    }
}

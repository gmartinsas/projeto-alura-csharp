using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CampBrasileiro
{
    internal class Partida
    {
        public void Pontuar(Time timeMandante, Time timeVisitante, int golsMandante, int golsVisitante)
        {
            if (golsMandante < 0 || golsVisitante < 0)
            {
                Console.WriteLine("Você é idiota? Como alguém marca gols negativos?");
            }
            else if (golsMandante > golsVisitante)
            {
                timeMandante.pontuarVitoria();
                timeVisitante.Perder();
                Console.WriteLine(timeMandante.Nome + " venceu!");
            }
            else if (golsVisitante > golsMandante)
            {
                timeVisitante.pontuarVitoria();
                timeMandante.Perder();
                Console.WriteLine(timeVisitante.Nome + " venceu!");
            }
            else if (golsMandante == golsVisitante)
            {
                timeMandante.pontuarEmpate();
                timeVisitante.pontuarEmpate();
                Console.WriteLine("Jogo empatado!");
            }
                
        }
    }
}

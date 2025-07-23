using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class Coordenada
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordenada()
        {
            X = 0;
            Y = 0;
        }
        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    internal class Remate
    {
        Coordenada Origem { get; set; }
       
        Coordenada Destino { get; set; }

        public Remate(Coordenada origem, Coordenada destino)
        {
            Origem = origem;
            Destino= destino;

        }
        public double Distancia()
        {
            int Dx = Destino.X - Origem.X;
            int Dy = Destino.Y - Origem.Y;
            return Math.Sqrt(Dx * Dx + Dy * Dy);

        }
    }
}

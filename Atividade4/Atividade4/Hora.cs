using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{


    public class Hora
    {
        private int horas;
        private int min;
        private int seg;

        public int Horas
        {
            get { return horas; }
            set
            {
                if (value >= 0 && value <= 23)
                    horas = value;
            }
        }

        public int Min
        {
            get { return min; }
            set
            {
                if (value >= 0 && value <= 59)
                    min = value;
            }
        }

        public int Seg
        {
            get { return seg; }
            set
            {
                if (value >= 0 && value <= 59)
                    seg = value;
            }
        }

        public Hora()
        {
            Horas = 0;
            Min = 0;
            Seg = 0;
        }
        public Hora(int horas, int min, int seg)
        {
            Horas = horas;
            Min = min;
            Seg = seg;
      
        }

        public int DifEntre2Horas(Hora nova)
        {
            int totalSegundos1 = this.Horas * 3600 + this.Min * 60 + this.Seg;
            int totalSegundos2 = nova.Horas * 3600 + nova.Min * 60 + nova.Seg;

            return Math.Abs(totalSegundos1 - totalSegundos2);
             
            
        }
        public override string ToString()
        {
            return $"{Horas:D2} : {Min:D2} : {Seg:D2}";
        }


    }

}

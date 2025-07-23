using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    public class Data 
    {
        private int dia;
        private int mes;
        private int ano;
        private string diaSemana;

        public int Dia
        {
            get { return dia; }
            set
            {
                if (value >= 1 && value <= 31)
                {
                    dia = value;
                }
            }

        }
        public int Mes
        {
            get { return mes; }
            set
            {
                if(value >= 1 && value <= 12) 
                    mes = value;
            }
        }
        public int Ano
        {
            get { return ano; }
            set 
            {
                if(value > 0)
                    ano = value;
            }
        }
        public Hora HoraC { get; set; }
        public string DiaSemana
        { 
            get { return diaSemana; }
            set { diaSemana = value;}
        }

        public Data()
        {
            Dia = 1;
            Mes = 1;
            Ano = 2000;
            HoraC = new Hora();
            DiaSemana = "Domingo";
                        
        }
        public Data(int dia, int mes, int ano,   Hora horaC, string diaSemana )
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
            HoraC = horaC;
            DiaSemana = diaSemana;
        }

        public int difEntre2Anos(Data d)
        {
            return Math.Abs(d.Ano - Ano);
        }
    }
}

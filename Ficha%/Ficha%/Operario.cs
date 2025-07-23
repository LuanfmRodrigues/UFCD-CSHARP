using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_
{
    internal class Operario : Funcionario
    {
        public string Seccao{ get; set; }

        public Operario() : base()
        {
            Seccao = "Setor";
        }
        public Operario(string nome, DateTime dataNasc, double valorHora, string seccao) : base( nome, dataNasc, valorHora)
        {
            Seccao = seccao;
        }
        public Operario(Operario copia) : base(copia)
        {
            Seccao  = copia.Seccao;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n Secção: {Seccao}";
        }
    }
}

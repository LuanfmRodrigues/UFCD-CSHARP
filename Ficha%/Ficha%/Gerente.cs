using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_
{
    internal class Gerente : Funcionario
    {
        public string Especilaidade{ get; set; }
        public int Extensao { get; set; }

        public Gerente() : base()
        {
            Especilaidade = "Vendas";
            Extensao = 100;

        }
        public Gerente(string nome, DateTime dataNasc, double valorHora, string especialidade, int extensao) : base(nome, dataNasc, valorHora)
        {
            Especilaidade = especialidade;
            Extensao = extensao;
        }
        public Gerente(Gerente copia) : base(copia)
        {
            Especilaidade = copia.Especilaidade;
            Extensao = copia.Extensao;
        }
        public override string ToString()
        {
            return base.ToString() + 
                $"\nEspecialidade: {Especilaidade}" +
                $"\nExtensao: {Extensao}";
        }
    }

}

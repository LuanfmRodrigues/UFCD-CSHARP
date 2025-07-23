using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hora hora = new Hora(1,5,29);
            Console.WriteLine(hora.ToString());

            Data data = new Data(1,2, 2025, hora, "Domingo");
            Data data2 = new Data(1, 2, 2023, hora, "Domingo");
            Console.WriteLine("Diferenca entre as datas Sao" +  data.difEntre2Anos(data2));

            Pessoa pessoa = new Pessoa("Ana Silva", 123456789, new Data(12, 03, 1995, new Hora(0,0,0), "Domingo"), new Hora(14, 25, 36));
            Console.WriteLine(pessoa.ToString());
        }
    }
}

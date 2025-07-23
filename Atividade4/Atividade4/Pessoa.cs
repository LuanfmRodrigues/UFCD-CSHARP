using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    internal class Pessoa 
    {
        private string nome;
        private int nif;
        private Data dataNascimento;

        public string Nome
        { get { return nome; }
            set { nome = value; }
        }

        public int Nif
        {
            get { return nif; }
            set
            {
                if (value > 00000000)
                    nif = value;
            }
        }

        public Data DataNascimento
        {
            get { return dataNascimento; }
            set
            {
                if (DateTime.Now.Year - value.Ano <= 21)
                    throw new ArgumentException("A pessoa deve ter mais de 21 anos");
                dataNascimento = value;
            }
        }
        public Hora horaRegistro { get; set; }

        public Pessoa()
        {
            Nome = "Desconhecido";
            Nif = 000000000;
            DataNascimento = new Data(1,1,2000, new Hora(0,0,0), "Domingo");
            horaRegistro = new Hora(0,0,0);
        }

        public Pessoa(string nome, int nif,  Data datas, Hora horas)
        {
            Nome = nome;
            Nif = nif;
            DataNascimento = datas;
            horaRegistro = horas;
        }
        public Pessoa(Pessoa copia) : this (copia.Nome, copia.Nif, copia.DataNascimento, copia.horaRegistro) 
        {

        }
        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                   $"Nif: {Nif} \n" +
                   $"Data de Nascimento: {dataNascimento}\n" +
                   $"Hora de Registro: {horaRegistro}";
        }
        public int idadeAtual(int AnoAtual)
        {
            //DateTime
            return DateTime.Now.Year - DataNascimento.Ano;

        }
        public int DifHorasDesdeRegisto(Hora atual)
        {
            TimeSpan diff = new TimeSpan(atual.Horas, atual.Min, atual.Seg) -
               new TimeSpan(horaRegistro.Horas, horaRegistro.Min, horaRegistro.Seg);
            return (int)diff.TotalHours;


        }

    }
}

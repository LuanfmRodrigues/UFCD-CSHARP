using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ficha_
{
    //Atributos do Funcionario 
    internal abstract class Funcionario
    {
        private static int _contadorId = 1;
        private string _nome;
        private DateTime _dataNasc;
        private double _valorHora;

        public Funcionario()
        {
            Id = _contadorId++;
            _nome = "Funcionario";
            _dataNasc = new DateTime(1980, 1, 1);
            _valorHora = 10.0;
        }
        public Funcionario(string nome, DateTime dataNasc, double valorHora)
        {
            Id = _contadorId++;
            Nome = nome;
            DataNascimento = dataNasc;
            ValorHora = valorHora;
        }
        public Funcionario(Funcionario copia) : this(copia.Nome,copia.DataNascimento, copia.ValorHora)
        { }
           

        public int Id{ get; private set; }
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nome não pode ser nulo.", nameof(value));

                _nome = value;
            }
        }
        public DateTime DataNascimento
        {   
            get => _dataNasc;
            set
            {
                int idade = DateTime.Today.Year - value.Year;
                if (value.Date > DateTime.Today.AddYears(-idade)) idade--;
                if (idade < 18)
                    throw new ArgumentException("A pessoa deve ter pelo menos 18 anos.");
                _dataNasc = value;
            }
        }
        public double ValorHora
        { 
            get => _valorHora;
            set
            {
                if (value <= 0)                
                    throw new ArgumentException("O Valor das horas tem que ser positivo.");
                _valorHora = value;
            }
        }
        //Metodos

        public double calcSala(double horas)
        {
            if (_valorHora < 0)
                throw new ArgumentException("A Hora trabalhada não pode ser negativa!");
            return  horas  * ValorHora;
        }
        public int Idade()
        {
            int idade = DateTime.Today.Year - _dataNasc.Year;
            if (_dataNasc.Date > DateTime.Today.AddYears(-idade)) idade--;
            return idade;
        }
        public override string ToString()
        {

            return $" ID: {Id}\n" +
                   $" Nome: {_nome}\n" +
                   $" Data de Nascimento: {_dataNasc:dd/MM/yyyy}\n" +
                   $" Idade: {Idade()} anos\n" +
                   $" Valor Hora: €{_valorHora:f2}";
                  

        }
    }
    
}

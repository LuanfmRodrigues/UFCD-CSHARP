using System.Transactions;
using Ficha_;

namespace ficha5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            int opcao;
            do
            {

                Console.WriteLine("------------  MENU  -------------");
                Console.WriteLine("----- 1º Adicionar Operario -----");
                Console.WriteLine("----- 2º Adicionar Gerente  -----");
                Console.WriteLine("----- 3º Visualizar Operario ----");
                Console.WriteLine("----- 4º Visualizar Gerente -----");
                Console.WriteLine("-- 5º Visualizar Funcionarios ---");
                Console.WriteLine("----------  6º  sair  -----------");

                bool valido = int.TryParse(Console.ReadLine(), out opcao);
                if (!valido)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }
                switch (opcao)
                {
                    case 1:
                        AdicionarOperario(funcionarios);
                        break;
                    case 2:
                        AdicionarGerente(funcionarios);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        VisualizarFuncionarios(funcionarios);
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 6);

            static void AdicionarOperario(List<Funcionario> funcionarios)
            {
                Console.WriteLine("\n ----------- Adicionar Operario -----------");
                try
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Data de Nascimento dd/MM/yyyy: ");
                    DateTime dataNasc = DateTime.Parse(Console.ReadLine());

                    Console.Write("Valor hora: ");
                    double valorHora = double.Parse(Console.ReadLine());

                    Console.Write("Secção: ");
                    string seccao = Console.ReadLine();

                    Operario operario = new Operario(nome, dataNasc, valorHora, seccao);
                    funcionarios.Add(operario);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
            static void AdicionarGerente(List<Funcionario> funcionarios)
            {
                Console.WriteLine("----------------- Adicionar Gerente --------------------");

                try
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Data de Nascimento dd/MM/yyyy: ");
                    DateTime dataNasc = DateTime.Parse(Console.ReadLine());

                    Console.Write("Valor hora: ");
                    double valorHora = double.Parse(Console.ReadLine());

                    Console.WriteLine("Especialidade: ");
                    string especialidade = Console.ReadLine();

                    Console.WriteLine("Extensão (ramal): ");
                    int extensao = int.Parse(Console.ReadLine());

                    Gerente gerente = new Gerente(nome, dataNasc, valorHora, especialidade, extensao);
                    funcionarios.Add(gerente);

                    Console.WriteLine("Gerente adicionado com suceso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }

            static void VisualizarFuncionarios(List<Funcionario> funcionarios)
            {
                Console.WriteLine(" ----------- Funcionarios ------------ ");
                if (funcionarios.Count == 0)
                {
                    Console.WriteLine("Nunhum Funcionario Registreado.");
                    return;
                }
                foreach (var func in funcionarios)
                {
                    Console.WriteLine("");
                    Console.WriteLine(func.ToString());
                }
            }



        }

    }
}

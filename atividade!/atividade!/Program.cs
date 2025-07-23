using System;
using System.Collections.Immutable;
namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 ----------------------------------------

            Console.WriteLine("hello, joão");

            //2 ------------------------------------------

            Console.WriteLine("Digite um nome: ");
            string name = Console.ReadLine();
            if (name == "Bartolomeu")
            {
                Console.WriteLine("Dá cá o meu!");
            }
            else
            {
                Console.WriteLine("Hello" + name);
            }

            //3 -----------------------------------------------------

            Console.WriteLine("Digite um nome: ");
            string nome = Console.ReadLine();
            if (nome.Substring(nome.Length - 2) == "eu")
            {
                Console.WriteLine("Romeu, quer comer o teu! ");

            }
            else
            {
                Console.WriteLine("Hello " + nome);
            }

            //4 ---------------------------------------------------

            Console.WriteLine("Escreva seu nome completo: ");
            string nomeComp = Console.ReadLine();
            string[] comple = nomeComp.Split();
            Console.WriteLine(comple[0]);
            Console.WriteLine(comple[comple.Length -1]);


            //5 ---------------------------------------------------

            Console.WriteLine("insira uma palavra: ");
            string stri1 = Console.ReadLine();
            Console.WriteLine("insira segunda palavra: ");
            string stri2 = Console.ReadLine();
            Console.WriteLine("Insira a terceira palavra: ");
            string stri3 = Console.ReadLine();
            
            //a Primeira variavel vai se comparar se é maior com segunda e tecrceira. se o comprimento for maior imprime a primeira
            if(stri1.Length > stri2.Length && stri1.Length > stri3.Length )
            {
                Console.WriteLine(stri1);
            }
            //se a terceira variavel tiver o comprimento maior que a segunda imprime a terceira
            else if(stri3.Length > stri2.Length)
            {
                Console.WriteLine(stri3);
            }
            else
            {
                Console.WriteLine(stri2);
            }

            //6 -----------------------------------------------------------------------

            //tive que pesquisar a funcao All que verifica tudo que estar no array
            string[] nomes = { "Luan", "Felipe", "Morais", "Rodrigues" };
            bool NomesIguais = nomes.All(n => n.Length == nomes[0].Length);
            // All vai verificar, se todos dentro do array tem o mesmo comprimento usando o Length.
            // funciona como se fosse o FOR o n vai receber o comprimento do primeiro elemento do array e em seguinta vai comparar com todos se sao iguais 
            Console.WriteLine(NomesIguais);


            //7 ------------------------------------------------------------------------

            string[] NOmes = { "Luan", "Felipe", "Morais", "Rodrigues" };
            int TamNome = 0;
            foreach (string n in NOmes)
            {
                TamNome += n.Length;
            }
            Console.WriteLine(TamNome);

            //8 ------------------------------------------------------------------------

            Console.WriteLine("Insira uma pequena frase que contenha 'V' e 'AO': ");
            string frase = Console.ReadLine();
            frase = frase.ToLower();
            //transformei tudo em minusculo do que fazer comparacoes de maiusculos e menusculos.
            string Nfrase = "";
            
            /*
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'v')
                {
                    Nfrase += 'b';
                }
                else if (i < frase.Length - 1 && frase[i] == 'a' && frase[i +1] == 'o') 
                {
                    Nfrase += "om";
                    i++;
                }
                else
                {
                    Nfrase += frase[i];
                }

            }
            Console.WriteLine(Nfrase);
            */
            string NovaFrase = frase.Replace("v", "b").Replace("V", "B").Replace("ao", "om").Replace("AO", "OM");
            Console.WriteLine(NovaFrase);
            //pesquisando encontei o methodo Replace e achei muito melhor de usar.


            //9 --------------------------------------------------------------------------
            Console.WriteLine("Digite uma palavra ou numero ou nao: ");      
            string palavra = Console.ReadLine();
            

            bool numb = palavra.All(char.IsDigit);
            Console.WriteLine(numb);



            //10 -------------------------------------------------------------------------

            Console.WriteLine("Digite uma palavra ou numero ou nao: ");
            string palavra2 = Console.ReadLine();


            bool numb2 = !palavra2.All(char.IsDigit);
            Console.WriteLine(numb2);

            //11 -------------------------------------------------------------------------
            string? nome1, nome2;
            Console.Write("Prmeira palavra: ");
            nome1 = Console.ReadLine();
            Console.Write("Segunda palavra: ");
            nome2 = Console.ReadLine();


            string comparar(string s, string b)
            {


                if (s.CompareTo(b) < 0)
                {
                    return s;
                }
                else if (s.CompareTo(b) > 0)
                {
                    return b;
                }
                else
                {
                    return "erro";
                }

            }

            string ordem = comparar(nome1, nome2);

            Console.WriteLine(ordem);



            //12 --------------------------------------------------------------------------
            string[] Nomes = new string[10];

            Console.WriteLine("Escreva 10 nomes:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                Nomes[i] = Console.ReadLine();
            }

            Array.Sort(Nomes);

            Console.WriteLine("\nNomes ordenados alfabeticamente:");
            foreach (string Nome in Nomes)
            {
                Console.WriteLine(Nome);

            }

            // 13 ------------------------------------------------------------------------------

            string[] perguntas = {
            "Qual a cor do cavalo branco do Napoleão?",
            "Quanto é 2 + 2?",
            "Qual o maior satelite da terra?",
            "Qual a capital de Pernambuco?",
            "Quantos lados tem um triângulo?",
            "Qual maior clube de Recife?",
            "Maior e melhor Carnaval do mundo?",
            "Quem Gravou o cd Da Lamas ao Caos?",
            "Onde fica a veneza Brasileira?",
            "Onde Fica a ilha de Fernando de Noronha?"
            };

            string[][] alternativas = {
            new string[] {"a) Preto", "b) Branco", "c) Marrom"},
            new string[] {"a) 3", "b) 4", "c) 5"},
            new string[] {"a) Terra", "b) Lua", "c) Saturno"},
            new string[] {"a) Maceio", "b) Recife", "c) João Pessoa"},
            new string[] {"a) 2", "b) 3", "c) 4"},
            new string[] {"a) Sport", "b) Santa Cruz", "c) Nautico"},
            new string[] {"a) Olinda", "b) Recife", "c) Salvador"},
            new string[] {"a) Nação Zumbi", "b) Baiana Sistem", "c) M D2"},
            new string[] {"a) Maceio", "b) Recife", "c) Natal"},
            new string[] {"a) Paraiba", "b) Rio de Janeiro", "c) Pernambuco"}
            };

            char[] respostas = { 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'a', 'b', 'c' };

            int pontuacao = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nPergunta {i + 1}: {perguntas[i]}");
                foreach (string alt in alternativas[i])
                {
                    Console.WriteLine(alt);
                }

                Console.Write("Sua resposta (a, b ou c): ");
                char resposta = Console.ReadLine().ToLower()[0];

                if (resposta == respostas[i])
                {
                    Console.WriteLine("Correto!");
                    pontuacao++;
                }
                else
                {
                    Console.WriteLine($"Errouuuu! A resposta correta era {respostas[i]}");
                }
            }

            Console.WriteLine($"\nFim do jogo! Você acertou {pontuacao} de 10 perguntas.");

            //14 --------------------------------------------------------------------------------

            Console.Write("Digite uma palavra para verificar se é palíndromo: ");
            string texto = Console.ReadLine();

 
            string Novotexto = "";
            foreach (char c in texto.ToLower())
            {
                if (char.IsLetterOrDigit(c))
                {
                    Novotexto += c;
                }
            }


            bool ehPalindromo = true;
            int inicio = 0;
            int fim = Novotexto.Length - 1;

            while (inicio < fim)
            {
                if (Novotexto[inicio] != Novotexto[fim])
                {
                    ehPalindromo = false;
                    break;
                }
                inicio++;
                fim--;
            }

            if (ehPalindromo)
            {
                Console.WriteLine("É um palíndromo!");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo.");

            }

        }   
    }
}       
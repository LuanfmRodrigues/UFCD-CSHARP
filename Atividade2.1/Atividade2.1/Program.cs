namespace Atividade2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flagApro= false, flagRepro = false;
            if (!File.Exists("@NOTAS"))
            {
                Console.WriteLine("Ficheiro não existe!!");
                return;
            }
            using (StreamReader LNotas = new StreamReader(@"NOTAS.txt"))
            using (StreamWriter EAprovados = new StreamWriter(@"APROVADOS.txt"))
            using (StreamWriter EReprovados = new StreamWriter(@"REPROVADOS.txt"))
            {

                while (!LNotas.EndOfStream)
                {

                    string linha = LNotas.ReadLine();
                    string[] dados = linha.Split(" ");
                    if (int.Parse(dados[dados.Length - 1]) >= 9.5) 
                    { 
                        EAprovados.WriteLine(linha);
                        flagApro = true;
                    }
                    else 
                    {
                        EReprovados .WriteLine(linha);
                        flagRepro = true;
                    }
                    if (!flagApro)
                    {
                        EAprovados.WriteLine("Não Contém registro");
                        
                    }
                    if(!flagRepro)
                    {
                        EReprovados.WriteLine("Não Contém registro");
                    }
                }
                /*LNotas.Close();
                EAprovados.Close();
                EReprovados.Close();*/
            }
        }
    }
}

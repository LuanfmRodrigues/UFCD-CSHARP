namespace atividada2
{
    internal class Program
    {
        static void Main(string[] args)
        {    

            bool flag = false;
            if(!File.Exists("@Vencimentos.txt"))
            {
                Console.WriteLine("Ficheiro não existe!!");
                return;
            }

            using(StreamReader leituraVencimento = new StreamReader(@"Vencimentos.txt"))
            using(StreamWriter escritaVencimento = new StreamWriter(@"SUPMIL.txt"))
            {
                while (!leituraVencimento.EndOfStream) 
                    {
                        string linha = leituraVencimento.ReadLine();
                        string[] dados = linha.Split(" ");
                        
                        if(int.Parse(dados[dados.Length-1]) >= 1000) 
                        {
                            escritaVencimento.WriteLine(dados);
                            flag = true;
                          
                          
                        }
                        if(!flag)
                        {
                            escritaVencimento.WriteLine("Não Contém registro");
                        }
                    
                    }   
                leituraVencimento.Close();
                escritaVencimento.Close();
            }
        }
    }
}

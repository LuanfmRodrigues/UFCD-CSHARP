namespace Atividade3
{
    internal class Program
    {
        static void Main()
        {
            Coordenada origem = new Coordenada(2,3);
            Coordenada destino = new Coordenada(5,3);

            Remate remate = new Remate(origem, destino);

            Console.WriteLine(remate.Distancia);
        }
    }
}

namespace Aula02_Grafo;

class Program
{
    static void Main(string[] args)
    {
        IGrafo<string> grafo = new Grafo<string>();

        grafo.AdicionarVertice("A");
        grafo.AdicionarVertice("B");
        grafo.AdicionarVertice("C");
        
        grafo.Conectar("A", "B");
        grafo.Conectar("A", "C");

        Console.WriteLine($"A está conectado com B? {grafo.ExisteConexao("A", "B")}"); // True
        Console.WriteLine($"Vizinhos de A: {string.Join(", ", grafo.Vizinhos("A"))}"); // B, C

        // Demonstração de Tamanho
        Console.WriteLine($"Tamanho do grafo: {grafo.Tamanho}"); // 3
    }
}


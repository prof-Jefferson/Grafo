public class Grafo<T> : IGrafo<T>
{
    private Dictionary<T, HashSet<T>> adjacencias = new Dictionary<T, HashSet<T>>();

    public int Tamanho => adjacencias.Count;

    public void AdicionarVertice(T vertice)
    {
        if (!adjacencias.ContainsKey(vertice))
        {
            adjacencias[vertice] = new HashSet<T>();
        }
    }

    public void Conectar(T vertice1, T vertice2)
    {
        if (!adjacencias.ContainsKey(vertice1) || !adjacencias.ContainsKey(vertice2))
        {
            throw new ArgumentException("Um ou ambos os vértices não existem no grafo.");
        }

        adjacencias[vertice1].Add(vertice2);
        adjacencias[vertice2].Add(vertice1); // Remova esta linha para um grafo direcionado
    }

    public bool ExisteConexao(T vertice1, T vertice2)
    {
        return adjacencias.ContainsKey(vertice1) && adjacencias[vertice1].Contains(vertice2);
    }

    public IEnumerable<T> Vizinhos(T vertice)
    {
        if (!adjacencias.ContainsKey(vertice))
        {
            throw new ArgumentException("O vértice não existe no grafo.");
        }

        return adjacencias[vertice];
    }
}

public interface IGrafo<T>
{
    void AdicionarVertice(T vertice);
    void Conectar(T vertice1, T vertice2);
    bool ExisteConexao(T vertice1, T vertice2);
    IEnumerable<T> Vizinhos(T vertice);
    int Tamanho { get; }
}

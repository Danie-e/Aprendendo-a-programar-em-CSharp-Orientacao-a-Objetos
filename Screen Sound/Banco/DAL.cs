namespace Screen_Sound.Banco;

internal abstract class DAL<T>
{
    public abstract IEnumerable<T> Listar();
    public abstract void Inserir(T objeto);
    public abstract void Atualizar(T objeto);
    public abstract void Deletar(T objeto);

}

namespace Screen_Sound.Banco;

internal class DAL<T> where T : class
{
    protected internal DAL(ScreenSoundContext context)
    {
        this.context = context;
    }
    private readonly ScreenSoundContext context;

    public IEnumerable<T> Listar()
    {
        return context.Set<T>().ToList();
    }
    public void Inserir(T objeto)
    {
        context.Set<T>().Add(objeto);
        context.SaveChanges();
    }
    public void Atualizar(T objeto)
    {
        context.Set<T>().Update(objeto);
        context.SaveChanges();
    }
    public void Deletar(T objeto)
    {
        context.Set<T>().Remove(objeto);
        context.SaveChanges();
    }
    public T? ObterPor(Func<T, bool> condicao)
    {
        return context.Set<T>().FirstOrDefault(condicao);
    }
}

public class BrokenSingleton
{
    public Guid Id { get; } = Guid.NewGuid();

    public BrokenSingleton(ScopedService scopedService)
    {
        // Não precisa fazer nada aqui
        // O erro é só a dependência
    }
}

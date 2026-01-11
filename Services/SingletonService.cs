public class SingletonService : ILifetimeService
{
    public Guid Id { get; } = Guid.NewGuid();
}

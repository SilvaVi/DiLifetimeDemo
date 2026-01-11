public class ScopedService : ILifetimeService
{
    public Guid Id { get; } = Guid.NewGuid();
}

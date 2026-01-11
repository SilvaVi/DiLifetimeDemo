public class TransientService : ILifetimeService
{
    public Guid Id { get; } = Guid.NewGuid();
}

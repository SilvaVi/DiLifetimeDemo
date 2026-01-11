using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/lifetime")]
public class LifetimeController : ControllerBase
{
    private readonly BrokenSingleton _broken;
    private readonly SingletonService _singleton1;
    private readonly SingletonService _singleton2;

    private readonly ScopedService _scoped1;
    private readonly ScopedService _scoped2;

    private readonly TransientService _transient1;
    private readonly TransientService _transient2;

    public LifetimeController(
        BrokenSingleton broken,
        SingletonService singleton1,
        SingletonService singleton2,
        ScopedService scoped1,
        ScopedService scoped2,
        TransientService transient1,
        TransientService transient2)
    {
        _singleton1 = singleton1;
        _singleton2 = singleton2;
        _scoped1 = scoped1;
        _scoped2 = scoped2;
        _transient1 = transient1;
        _transient2 = transient2;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            Singleton = new
            {
                First = _singleton1.Id,
                Second = _singleton2.Id
            },
            Scoped = new
            {
                First = _scoped1.Id,
                Second = _scoped2.Id
            },
            Transient = new
            {
                First = _transient1.Id,
                Second = _transient2.Id
            }
        });
    }
}

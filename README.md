# ConvertJsonDocumentToClass
```csharp
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public TempClass? Post([FromBody] JsonDocument request)
        => request.Deserialize<TempClass>();
    }
```

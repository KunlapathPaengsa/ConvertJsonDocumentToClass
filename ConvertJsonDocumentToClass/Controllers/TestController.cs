using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace ConvertJsonDocumentToClass.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public TempClass? Post([FromBody] JsonDocument request)
        => request.Deserialize<TempClass>();
    }
}
public class TempClass
{
    public string description { get; set; }

    public string return_url { get; set; }

    public string hash { get; set; }
}

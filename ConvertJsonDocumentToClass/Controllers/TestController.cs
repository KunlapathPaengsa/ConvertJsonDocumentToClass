using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace ConvertJsonDocumentToClass.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpPost("T")]
        public TempClass? Post([FromBody] JsonDocument request)
        {
            var requestJson = new StringBuilder().Append('{');
            foreach (var property in request.RootElement.EnumerateObject())
            {
                requestJson.Append('\"')
                .Append(property.Name)
                .Append("\" : \"")
                .Append(property.Value)
                .Append("\",");
            }
            requestJson.Remove(requestJson.Length - 1, 1);
            requestJson.Append('}');
            return JsonSerializer.Deserialize<TempClass>(requestJson.ToString());
        }
    }
}
public class TempClass
{
    public string description { get; set; }

    public string return_url { get; set; }

    public string hash { get; set; }
}

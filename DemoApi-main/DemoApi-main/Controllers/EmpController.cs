using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/cmp")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        [HttpGet]
        public string EmpList()
        {
            return "Sathiya=123";
        }
    }
}

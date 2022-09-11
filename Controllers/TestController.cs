using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace PharmacyHome.Controllers
{
    [ApiController]
    public class TestController
    {      
        [HttpGet("/api/testresult")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(object))]
        public object GetTestData()
        {
            return new { Name = "Name", Value = "Value" };
        }
    }
}

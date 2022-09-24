using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using PharmacyHome.Services;

namespace PharmacyHome.Controllers
{
    [ApiController]
    public class TestController
    {
        private readonly IDatabase _db;
        public TestController(IDatabase db)
        {
            _db = db;
        }

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

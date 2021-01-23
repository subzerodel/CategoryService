using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcClient.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetProductAsync()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Category.CategoryClient(channel);

            return Ok();
        }
    }
}

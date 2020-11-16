using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WombleMockup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : Controller
    {
      

        [HttpGet("getlist")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public List<Product> GetList(int id)
        {
            Console.WriteLine($"ID parameter:{id}");

            var v1 = new Product { name = "product1", description = "some sort of description goes here for demo purposes", quantity = 4 };
            var v2 = new Product { name = "product2", description = "some sort of description goes here for demo purposes", quantity = 5 };
            var v3 = new Product { name = "product4", description = "some sort of description goes here for demo purposes", quantity = 6 };
            var v4 = new Product { name = "product5", description = "some sort of description goes here for demo purposes", quantity = 7 };
            var v5 = new Product { name = "product6", description = "some sort of description goes here for demo purposes", quantity = 8 };

            var list = new List<Product>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            list.Add(v5);

            return list;
        }

        [HttpGet("myactionname")]
        public string MyActionName()
        {
            return "Hi there!";
        }
    }
}

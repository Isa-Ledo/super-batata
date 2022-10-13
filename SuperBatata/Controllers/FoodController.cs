using Microsoft.AspNetCore.Mvc;
using SuperBatata.Api.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SuperBatata.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private List<Batata> Batatas = new List<Batata>()
        {
                new Batata
                {
                    Id = 1,
                    Name = "tradicional",
                    Price = 10.00M
                },
                new Batata
                {
                    Id = 2,
                    Name = "Crinkle",
                    Price = 10.00M
                },
                new Batata
                {
                    Id = 3,
                    Name = "Smile",
                    Price = 10.00M
                }
        };

        [HttpGet]
        public List<Batata> Get()
        {
            return Batatas;
        }

        [HttpGet("{id:int}")]
        public Batata GetById(int id)
        {
            return Batatas.FirstOrDefault(batata => batata.Id == id);
        }

        [HttpPost()]
        public void Post(Batata novaBatata)
        {
            Batatas.Add(novaBatata);
        }
    }
}

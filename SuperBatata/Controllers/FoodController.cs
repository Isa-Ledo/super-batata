using Microsoft.AspNetCore.Mvc;
using SuperBatata.Api.Entities;
using SuperBatata.Api.Repositories.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace SuperBatata.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly SuperBatataDbContext _dbContext;

        public FoodController()
        {
            _dbContext = new SuperBatataDbContext();
        }

        [HttpGet]
        public List<Potato> Get()
        {
            return _dbContext.Potato.ToList();
        }

        [HttpGet("{id:int}")]
        public Potato GetById(int id)
        {
            return _dbContext.Potato.FirstOrDefault(batata => batata.Id == id);
        }

        [HttpPost()]
        public void Post(Potato novaBatata)
        {
            _dbContext.Potato.Add(novaBatata);
            _dbContext.SaveChanges();
        }
    }
}

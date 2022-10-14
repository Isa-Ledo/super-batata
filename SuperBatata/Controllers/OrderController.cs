using Microsoft.AspNetCore.Mvc;
using SuperBatata.Api.Entities;
using SuperBatata.Api.Repositories.Configuration;

namespace SuperBatata.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly SuperBatataDbContext _dbContext;
        public OrderController()
        {
            _dbContext = new SuperBatataDbContext();
        }

        [HttpPost()]
        public void Post(Order newOrder)
        {
            _dbContext.Order.Add(newOrder);
            _dbContext.SaveChanges();
        }
    }
}

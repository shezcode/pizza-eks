using Microsoft.AspNetCore.Mvc;
using PizzeriaApi.Data;

namespace PizzeriaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzasController : ControllerBase
    {
        private readonly PizzeriaContext _context;

        public PizzasController(PizzeriaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get(int take = 10, int skip = 0)
        {
            return Ok(_context.Pizzas!.OrderBy(p => p.PizzaId).Skip(skip).Take(take));
        }
    }
}

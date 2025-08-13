using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc

namespace WebApplication_web_api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {


        public List<string> fruits = new List<string>()
        {
            "Apple",
            "Mango","Grapes",
            "Gauva"
        };


        [HttpGet]
        public List<String> getFruits()
        {
            return fruits;
        }
        [HttpGet("{id}")]
        public string getFruitsById(int id)
        {
            var f = fruits.ElementAt(id);
            return f;

        }
        [HttpDelete("{id}")]
        public void deleteFruits(int id)
        {
            fruits.RemoveAt(id);

        }
    }
}

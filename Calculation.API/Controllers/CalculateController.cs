using Calculation.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
namespace Calculation.API.Controllers
{
    [Route("/api/[controller]")]
    public class CalculateController : Controller
    {
        private ICalculation _calculation;
        public CalculateController(ICalculation calculation)
        {
            _calculation = calculation;
        }

        [Route("/api/[controller]/add")]
        [HttpGet]
        [HttpPost]
        public IActionResult Add(string value1, string value2) 
        {
            try
            {
                BigInteger result = 0;
                if (value1 == null || value2 == null)
                {
                    return BadRequest();
                }
                if (BigInteger.TryParse(value1.Trim(), out BigInteger addition1) && BigInteger.TryParse(value2.Trim(), out BigInteger addition2))
                {
                    result = _calculation.Add(addition1, addition2);
                }
                else
                {
                    //add  a log here
                    return BadRequest();
                }
                return Ok(result.ToString());
            }
            catch (System.Exception ex)
            {
                //Add Another log here
                return StatusCode(500, ex.Message); 
            }

        }
    }
}

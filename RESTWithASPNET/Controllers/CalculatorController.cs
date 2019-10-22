using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTWithASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/values
        [HttpGet("{FirstNumber}/{SecondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var Sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(Sum.ToString());
            }
            return BadRequest("Invalid input") ;
        }

        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(object firstNumber)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContinuousDeploymentSample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public IActionResult Sum(int a, int b)
        {
            var sum = Calculator.Sum(a, b);

            return Ok($"Sum is {sum}");
        }
    }

    public class Calculator
    {
        public static int Sum(int a, int b) { return a + b; }
    }
}

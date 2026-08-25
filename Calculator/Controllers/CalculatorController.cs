using Calculator.Calculator;
using Calculator.CalculatorService;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService calculator)
        {
            _calculatorService = calculator;
        }

        [HttpPost]
        public decimal CalculatorProcessing(CalculatorModel calculatorModel)
        {
           var response = _calculatorService.CalculatorProcess(calculatorModel);
            return response;
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;
    private Calc calc;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
        calc = new Calc();
    }

    [HttpGet(Name = "GetCalculatedTotal")]
    public Calculator Get(double num1, double num2, string op)
    {
        Calculator c1 = new Calculator();

        c1.total = calc.Compute(num1,num2,op);
        return c1;
    }
}


using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
    private readonly ILogger<CalculateController> _logger;
    private Calc calc;

    public CalculateController(ILogger<CalculateController> logger)
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


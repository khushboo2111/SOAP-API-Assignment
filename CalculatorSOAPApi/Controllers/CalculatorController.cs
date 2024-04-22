using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace CalculatorSOAPAPI.Controllers
{
    [ApiController]
    [Route("CalculatorController")]
    public class CalculatorController : Controller
    {
        [HttpGet("/Add")]
        public async Task<int> AddAsync()
        {
            ServiceReference1.ICalculator calculatorService = new CalculatorClient(CalculatorClient.EndpointConfiguration.BasicHttpBinding_ICalculator);
            return await calculatorService.AddAsync(10, 20);
        }
        [HttpGet("/Subtract")]
        public async Task<int> SubtractAsync()
        {
            ServiceReference1.ICalculator calculatorService = new CalculatorClient(CalculatorClient.EndpointConfiguration.BasicHttpBinding_ICalculator);
            return await calculatorService.SubtractAsync(10, 20);
        }
        [HttpGet("/Multiply")]
        public async Task<int> MultiplyAsync()
        {
            ServiceReference1.ICalculator calculatorService = new CalculatorClient(CalculatorClient.EndpointConfiguration.BasicHttpBinding_ICalculator);
            return await calculatorService.MultiplyAsync(10, 20);
        }
        [HttpGet("/Divide")]
        public async Task<int> DivideAsync()
        {
            ServiceReference1.ICalculator calculatorService = new CalculatorClient(CalculatorClient.EndpointConfiguration.BasicHttpBinding_ICalculator);
            return await calculatorService.DivideAsync(10, 20);
        }
    }
}

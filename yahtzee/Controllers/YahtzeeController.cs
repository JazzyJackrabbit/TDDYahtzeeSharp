using Microsoft.AspNetCore.Mvc;
using Services;

namespace api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class YahtzeeController 
  {
    private readonly IYahtzeeService _cartService;
    
    public YahtzeeController(
      IYahtzeeService cartService
    ) 
    {
      _cartService = cartService;
    }

  }
}
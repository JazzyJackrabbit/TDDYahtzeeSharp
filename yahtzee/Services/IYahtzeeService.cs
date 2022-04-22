using System.Collections.Generic;
using yahtzeeapi.Services;

namespace Services 
{
  public interface IYahtzeeService 
  {
    double Total();
    Player GamePlayer();
  }
}
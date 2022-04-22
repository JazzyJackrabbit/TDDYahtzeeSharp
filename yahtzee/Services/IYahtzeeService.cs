using System.Collections.Generic;

namespace Services 
{
  public interface IYahtzeeService 
  {
    double Total();
    Player GamePlayer();
  }
}
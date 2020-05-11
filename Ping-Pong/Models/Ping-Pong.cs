using System;
using System.Collections.Generic;

namespace PingPongGame 
{

  public class PingPong
  {  
    public List<int> numberList = new List<int>();
    public List<string> parsedList = new List<string>();
    
    public void Translate(int startNumber)
    {
      for (int index = 0; index <= startNumber; index++)
      {
        numberList.Add(index);
      }
      foreach (int number in numberList)
      {
        if ((number % 3) == 0 && (number % 5) == 0)
        {
          parsedList.Add("ping-pong");
        }
        else if ((number % 3) == 0)
        {
          parsedList.Add("ping");
        }
        else if ((number % 5 == 0))
        {
          parsedList.Add("pong");
        }
        else
        {
          parsedList.Add(number.ToString());
        }
      }
      foreach (string parsed in parsedList)
      {
        Console.WriteLine(parsed);
      }
    }
  }
}
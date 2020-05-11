using System;
using System.Collections.Generic;

class PingPong
{


  static void Main()
  {
    List<int> numberList = new List<int>();
    List<string> parsedList = new List<string>();
    Console.WriteLine("Enter a number!");
    int startNumber = int.Parse(Console.ReadLine());
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
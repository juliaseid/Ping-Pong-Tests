using System;
using PingPongGame;

public class Program
{
  public static void Main()
  {
    PingPong myPingPong = new PingPong();
    Console.WriteLine("Enter a number!");
    int startNumber = int.Parse(Console.ReadLine());
    myPingPong.Translate(startNumber);
  } 
}
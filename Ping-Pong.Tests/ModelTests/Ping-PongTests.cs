using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGame;

namespace Game.Tests
{
  [TestClass]
  public class PingPongTests
  {

    [TestMethod]
    public void Translate_NotDivisibleByThreeOrFive_Self()
    {
      PingPong testBingBong = new PingPong();
      testBingBong.Translate(4);
      List<string> myList = testBingBong.parsedList;
      Assert.AreEqual("4", myList[myList.Count-1]);
    }

    [TestMethod]
    public void Translate_DivisibleByThreeEquals_Ping()
    {
      PingPong testBingBong = new PingPong();
      testBingBong.Translate(3);
      List<string> myList = testBingBong.parsedList;
      Assert.AreEqual("ping", myList[myList.Count-1]);
    }

    [TestMethod]
    public void Translate_DivisibleByFiveEquals_Pong()
    {
      PingPong testBingBong = new PingPong();
      testBingBong.Translate(5);
      List<string> myList = testBingBong.parsedList;
      Assert.AreEqual("pong", myList[myList.Count-1]);
    }

    [TestMethod]
    public void Translate_DivisibleByThreeAndFiveEquals_PingPong()
    {
      PingPong testBingBong = new PingPong();
      testBingBong.Translate(15);
      List<string> myList = testBingBong.parsedList;
      Assert.AreEqual("ping-pong", myList[myList.Count-1]);
    }
  }
}


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queen.Models;

namespace Queen.Tests
{
  [TestClass]
  public class QueenTest
  {
    [TestMethod]
    public void CompareCoordinates_MatchXCoordinates_True()
    {
      Assert.AreEqual(true, Chess.CompareCoordinates(1, 0, 1, 1));
    }
    [TestMethod]
    public void CompareCoordinates_MatchYCoordinates_True()
    {
      Assert.AreEqual(true, Chess.CompareCoordinates(0, 2, 1, 2));
    }
    [TestMethod]
    public void CompareCoordinates_MatchXYCoordinates_True()
    {
      Assert.AreEqual(true, Chess.CompareCoordinates(1, 1, 2, 2));
    }
    [TestMethod]
    public void CompareCoordinates_MatchXYCoordinates_False()
    {
      Assert.AreEqual(false, Chess.CompareCoordinates(1, 2, 3, 3));
    }

  }
}

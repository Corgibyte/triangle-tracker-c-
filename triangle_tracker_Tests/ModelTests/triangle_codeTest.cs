using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]

  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsShapeTriangle_OneSideLongerThanSumOfOthers_False()
    {
      Triangle testTriangle = new Triangle(1, 1, 3);
      Assert.AreEqual(false, testTriangle.IsTriangle());
    }

    [TestMethod]

    public void IsShapeTriangle_AllSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle(2, 2, 2);
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }

    [TestMethod]

    public void IsShapeTriangle_SumOfTwoSidesLongerThanRemainingSide_True()
    {
      Triangle testTriangle = new Triangle(2, 2, 3);
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }

    [TestMethod]
    public void GetType_NotTriangle_NotTriangle()
    {
      Triangle testTriangle = new Triangle(1, 1, 3);
      Assert.AreEqual("Not a triangle", testTriangle.GetTriangleType());
    }

    [TestMethod]
    public void GetType_AllSidesEqual_Equilateral()
    {
      Triangle testTriangle = new Triangle(1, 1, 1);
      Assert.AreEqual("Equilateral", testTriangle.GetTriangleType());
    }

    [TestMethod]
    public void GetType_TwoSidesEqual_Isosceles()
    {
      Triangle testTriangle = new Triangle(2, 2, 1);
      Assert.AreEqual("Isosceles", testTriangle.GetTriangleType());
    }

    [TestMethod]
    public void GetType_NoSidesEqual_Scalene()
    {
      Triangle testTriangle = new Triangle(3, 4, 5);
      Assert.AreEqual("Scalene", testTriangle.GetTriangleType());
    }
  }
}
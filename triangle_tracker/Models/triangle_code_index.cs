using System;
using TriangleNamespace;

class TriangleUI
{
  static void Main()
  {
    Console.WriteLine("Enter a number for the length of side a");
    int sideA = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a number for the length of side b");
    int sideB = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a number for the length of side c");
    int sideC = int.Parse(Console.ReadLine());
  
    Triangle triangle = new Triangle(sideA, sideB, sideC);
    Console.WriteLine(triangle.GetTriangleType());
    Main();
  }
}
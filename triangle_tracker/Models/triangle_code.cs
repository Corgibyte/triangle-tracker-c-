namespace Triangle
{
  public class Triangle
  {
    private int _sideA;
    private int _sideB;
    private int _sideC;
    
    public Triangle(int a, int b, int c)
      {
        _sideA = a;
        _sideB = b;
        _sideC = c;
      }
    public bool IsTriangle()
    {
      return (_sideA + _sideB) > _sideC && (_sideA + _sideC) > _sideB && (_sideB + _sideC > _sideA);
    }

    public string GetTriangleType()
    {
      if (!IsTriangle())
      {
        return "Not a triangle";
      }
      else if ((_sideA == _sideB) && (_sideA == _sideC))
      {
        return "Equilateral";
      }
      else if ((_sideA == _sideB) || (_sideB == _sideC) || (_sideA == _sideC)) 
      {
        return "Isosceles";
      }
      else
      {
        return "Scalene";
      }
    }
  }
}  
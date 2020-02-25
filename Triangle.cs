using System;
using System.Collections.Generic;

public class Triangle
{
    public int FirstSide;
    public int SecondSide;
    public int ThirdSide;

    public Triangle(int firstSide, int secondSide, int thirdSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public bool TrueTriangle() 
    {
        if (FirstSide > SecondSide + ThirdSide) 
        {
            return false;
        } else if (SecondSide > FirstSide + ThirdSide) 
        {
            return false;
        } else if (ThirdSide > FirstSide + SecondSide)
        {   return false;
        } else
        {
            return true;
        }
    }

    public string Type()
    {
        if (this.TrueTriangle() == false)
        {
            return "This is not a triangle";
        }
        else if (FirstSide == SecondSide && FirstSide == ThirdSide)
        {
            return "Equilateral";
        } 
        else if (FirstSide == SecondSide || FirstSide == ThirdSide || SecondSide == ThirdSide)
        {
            return "Isosceles";
        }
        else {
            return "Scalene";
        }
    }
}

public class Program
{
    public static void Main()
    {
    Console.WriteLine("Enter three numbers that you will make triangle with");
    string strNumber1 = Console.ReadLine();
    string strNumber2 = Console.ReadLine();
    string strNumber3 = Console.ReadLine();
    int Number1 = int.Parse(strNumber1);
    int Number2 = int.Parse(strNumber2);
    int Number3 = int.Parse(strNumber3);

    Triangle triangle = new Triangle(Number1, Number2, Number3);
    Console.WriteLine(triangle.Type());
    }
}
   


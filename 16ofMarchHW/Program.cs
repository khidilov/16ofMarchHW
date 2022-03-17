using System;

namespace _16ofMarchHW
{
    //CalculateArea adlı int qaytaran metodlarınız olacaq (overload). Bu metodlar qəbul etdikləri arqumentlərdən asılı olaraq aşağıdaki hesablamaları aparmalıdır.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(2.4));
        }
        static double CalculateArea (double radius)
        {
            return 3 * radius * radius;
        } // 1.Çevrənin sahəsi - S = p*r² (p=3)

        static double CalculateArea (double length, double width) // 2.Düzbucaqlının sahəsi - S = a*b
        {    
            return length * width;
        }
        static double CalculateArea(double sideA, double sideB, double sideC) //Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a*b+a*c+b*c)
        { 
            return 2 * (sideA * sideB + sideA * sideC + sideB * sideC);
        }
    }
}

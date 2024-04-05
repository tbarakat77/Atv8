using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CalculateBMI(75, 1.7));
        Console.ReadLine();
    }

    // Calculates the BMI based on a weight and height.
    static double CalculateBMI(double weight, double height)
    {
        double bmi = weight / (height * height);
        return bmi;
    }
}
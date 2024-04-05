using System;

class Program
{
    static void Main(string[] args)
    {
        PrintStatusFromBMI(CalculateBMI(75, 1.75f));
        Console.ReadLine();
    }

    // Calculates the BMI based on a weight and height.
    static double CalculateBMI(double weight, double height)
    {
        double bmi = weight / (height * height);
        return bmi;
    }

    // Returns the status of a BMI.
    static void PrintStatusFromBMI(double bmi)
    {
        if (bmi < 18.5) Console.WriteLine("You are underweight.");
        else if (bmi >= 18.5 && bmi < 25) Console.WriteLine("You are normal weight.");
        else if (bmi >= 25 && bmi < 30) Console.WriteLine("You are overweight.");
        else Console.WriteLine("You are obese.");
    }
}
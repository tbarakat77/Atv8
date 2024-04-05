using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your weight in kilograms: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height in meters: ");
        double height = double.Parse(Console.ReadLine());

        double bmi = CalculateBMI(weight, height);
        Console.WriteLine($"Your BMI (IMC) is: {bmi}");
        PrintStatusFromBMI(bmi);

        Console.ReadLine();
    }

    // Calculates the BMI based on a weight and height.
    static double CalculateBMI(double weight, double height)
    {
        double bmi = weight / (height * height);
        return bmi;
    }

    // Prints the status of a BMI.
    static void PrintStatusFromBMI(double bmi)
    {
        if (bmi < 18.5) Console.WriteLine("You are underweight.");
        else if (bmi >= 18.5 && bmi < 25) Console.WriteLine("You are normal weight.");
        else if (bmi >= 25 && bmi < 30) Console.WriteLine("You are overweight.");
        else Console.WriteLine("You are obese.");
    }
}
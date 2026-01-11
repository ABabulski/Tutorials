// See https://aka.ms/new-console-template for more information


// Hypotenuese Calculator

Console.WriteLine("Enter side A");
double sideA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side B");
double sideB = Convert.ToDouble(Console.ReadLine());

double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

Console.WriteLine("Side C equals: " + sideC);
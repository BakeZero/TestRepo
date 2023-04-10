// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Enter a Radius:");
double radius = double.Parse(Console.ReadLine());
double area = radius * radius * Math.PI;
Console.WriteLine("Area: " + area);

double circumference = Math.PI * 2 * radius;
Console.WriteLine("Circumference: " + circumference);
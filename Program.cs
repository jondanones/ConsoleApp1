﻿using System.Globalization;

string[] eixos = Console.ReadLine().Split(' ');
double x = double.Parse(eixos[0], CultureInfo.InvariantCulture);
double y = double.Parse(eixos[1], CultureInfo.InvariantCulture);

if (x ==0 || y ==0)
{
    Console.WriteLine("Origem");
}
else if(x == 0)
{
    Console.WriteLine("Eixo Y");
}
else if (y == 0)
{
    Console.WriteLine("Eixo X");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Q1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Q2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else
{
    Console.WriteLine("Q4");
}
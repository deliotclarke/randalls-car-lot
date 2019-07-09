using System;
using System.Collections.Generic;

namespace RandallsCarLot
{
  internal class Car
  {
    public int Year { get; set; }

    public string Model { get; set; }

    public string Make { get; set; }

    public double Price { get; set; }

    public void Drive()
    {
      Console.WriteLine($"I'm drivin' my {Make} here!!!");
    }

    public void Drive(int miles)
    {
      Console.WriteLine($"{Make} is driving for {miles}.");
    }
  }
}
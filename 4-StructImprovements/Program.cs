using StructImprovements;
using System;

var money = new Money()
{
    Value = 10,
    Currency = "$"
};

var money2 = money with { Value = 20 };

Console.WriteLine(money2.Currency);
using System;

Console.WriteLine("Hello, World!");

var someValue = new
{
    Value = 10,
    Name = "test"
};

var someValue2 = someValue with { Value = 20 };
Console.WriteLine(someValue);
Console.WriteLine(someValue2);
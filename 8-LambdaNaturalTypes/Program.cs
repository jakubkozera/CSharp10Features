var parse = (string s) => int.Parse(s); // c#10

Func<string, int> parse2 = (s) => int.Parse(s); // c#9

var read = Console.Read; // Just one overload; Func<int> inferred
Action<string> write = Console.WriteLine; // ERROR: Multiple overloads, can't choose

var result = object (bool b) => b ? 1 : "0"; // lambda return type

var someLambda =[Obsolete](string s) => parse(s); // lambda attributes
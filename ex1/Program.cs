// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(7.0 < 5.1);   // saída: False
Console.WriteLine(5.1 < 5.1);   // saída: False
Console.WriteLine(0.0 < 5.1);   // saída: True

Console.WriteLine(double.NaN < 5.1);   // saída: False
Console.WriteLine(double.NaN >= 5.1);  // saída: False

Console.WriteLine(7.0 > 5.1);   // saída: True
Console.WriteLine(5.1 > 5.1);   // saída: False
Console.WriteLine(0.0 > 5.1);   // saída: False

Console.WriteLine(double.NaN > 5.1);   // saída: False
Console.WriteLine(double.NaN <= 5.1);  // saída: False

Console.WriteLine(7.0 <= 5.1);   // saída: False
Console.WriteLine(5.1 <= 5.1);   // saída: True
Console.WriteLine(0.0 <= 5.1);   // saída: True

Console.WriteLine(double.NaN > 5.1);   // saída: False
Console.WriteLine(double.NaN <= 5.1);  // saída: False

Console.WriteLine(7.0 >= 5.1);   // saída: True
Console.WriteLine(5.1 >= 5.1);   // saída: True
Console.WriteLine(0.0 >= 5.1);   // saída: False

Console.WriteLine(double.NaN < 5.1);   // saída: False
Console.WriteLine(double.NaN >= 5.1);  // saída: False
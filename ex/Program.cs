// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 3;
Console.WriteLine(i);   // saída: 3
Console.WriteLine(i++); // saída: 3
Console.WriteLine(i);   // saída: 4

double t = 1.5;
Console.WriteLine(t);   // saída: 1.5
Console.WriteLine(++t); // saída: 2.5
Console.WriteLine(t);   // saída: 2.5

int j = 3;
Console.WriteLine(j);   // saída: 3
Console.WriteLine(j--); // saída: 3
Console.WriteLine(j);   // saída: 2

double z = 1.5;
Console.WriteLine(z);   // saída: 1.5
Console.WriteLine(--z); // saída: 0.5
Console.WriteLine(z);   // saída: 0.5

Console.WriteLine(+4);     // saída: 4
Console.WriteLine(-4);     // saída: -4
Console.WriteLine(-(-4));  // saída: 4

Console.WriteLine(13 / 5);    // saída: 2
Console.WriteLine(-13 / 5);   // saída: -2
Console.WriteLine(13 / -5);   // saída: -2
Console.WriteLine(-13 / -5);  // saída: 2

Console.WriteLine(13 / 5.0);       // saída: 2.6
int a = 13;
int b = 5;
Console.WriteLine((double)a / b);  // saída: 2.6

Console.WriteLine(5 % 4);   // saída: 1
Console.WriteLine(5 % -4);  // saída: 1
Console.WriteLine(-5 % 4);  // saída: -1
Console.WriteLine(-5 % -4); // saída: -1

Console.WriteLine(5 + 4);       // saída: 9
Console.WriteLine(5 + 4.3);     // saída: 9.3

Console.WriteLine(47 - 3);      // saída: 44
Console.WriteLine(5 - 4.3);     // saída: 0.7
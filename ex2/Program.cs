// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*bool passed = false;
Console.WriteLine(!passed);  // output: True
Console.WriteLine(!true);    // output: False

bool SecondOperand()
{
    Console.WriteLine("Second operand is evaluated.");
    return true;
}

bool a = false & SecondOperand();
Console.WriteLine(a);
// Output:
// Second operand is evaluated.
// False

bool b = true & SecondOperand();
Console.WriteLine(b);
// Output:
// Second operand is evaluated.
// True

Console.WriteLine(true ^ true);    // output: False
Console.WriteLine(true ^ false);   // output: True
Console.WriteLine(false ^ true);   // output: True
Console.WriteLine(false ^ false);  // output: False*/


/*int z = 1 + 2 + 3;
int x = 6;
Console.WriteLine(z == x);  // output: True

char c1 = 'a';
char c2 = 'A';
Console.WriteLine(c1 == c2);  // output: False
Console.WriteLine(c1 == char.ToLower(c2));  // output: True

string s1 = "hello!";
string s2 = "HeLLo!";
Console.WriteLine(s1 == s2.ToLower());  // output: True

string s3 = "Hello!";
Console.WriteLine(s1 == s3);  // output: False*/

int Var1 = 10;
int Var2 = 20;
int Var3 = 30;

Console.WriteLine(Var1);
Console.WriteLine(Var2);
Console.WriteLine(Var3);

Console.WriteLine(Var1 < Var2);
Console.WriteLine(Var1 > Var2);
Console.WriteLine(Var2 == Var3);
Console.WriteLine(Var2 != Var3);

Var1++;
Var2--;

Console.WriteLine(Var1);
Console.WriteLine(Var2);

Console.WriteLine(Var1++);
Console.WriteLine(Var1);

Console.WriteLine(--Var2);
Console.WriteLine(Var2);



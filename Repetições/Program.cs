// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

for (int a = 0; a < 20; a++)
{
    Console.WriteLine(a);
}


int n = 0;
while (n < 5)
{
    Console.WriteLine(n);
    n++;
}

int c = 20;
while (c > 10)
{
    Console.WriteLine(c);
    c--;
}
*/


/*
int n = 0;
while (n < 5)
{
    if (n == 2)
    {
        n++;
        continue;
    }
    Console.WriteLine(n);
    n++;
}*/

int n = 0;
do
{
    Console.WriteLine(n);
    n++;
} while (n < 5);


var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
int count = 0;
foreach (int element in fibNumbers)
{
    Console.WriteLine($"Elemento #{count}: {element}");
    count++;
}
Console.WriteLine($"Número de elementos: {count}");


int Var1 = 10;
int Var2 = 20;
int Var3 = 30;


for (int z = 1; z <= 5; z++)
{
    Console.WriteLine(z);

    Console.WriteLine(Var1);
    Console.WriteLine(Var2);
    Console.WriteLine(Var3);

    Var1++;
    Var2--;
    Var3++;

    Console.WriteLine(Var1);
    Console.WriteLine(Var2);
    Console.WriteLine(Var3);

    Var1 = Var1 + 10;
    Var2 = Var2 + 10;
    Var3 = Var3 + 10;

}
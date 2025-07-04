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
// Показать числа Фибоначчи

int Fibonachi2(int n)
{
    int number=0;
    int sled=1;
    int tmp;
 
    for (int i=0; i<n; i++)
    {
        tmp=number;
        number=sled;
        sled=sled+tmp;
    }
 
    return number;
}


Console.Write("Введите предельное число для вывода ряда Фибоначи: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ряд Фибоначчи: ");
for (int j=1; j<=n; j++)
    Console.WriteLine($"f({j}): {Fibonachi2(j)}");

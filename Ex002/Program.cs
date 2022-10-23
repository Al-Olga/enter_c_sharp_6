// Показать числа Фибоначчи

int Fibonachi (int number)
{
    if (number==1 || number==2) return 1;
    else
        return Fibonachi(number-1)+Fibonachi(number-2);
}

Console.Write("Введите предельное число для вывода ряда Фибоначи: ");
int n = int.Parse(Console.ReadLine() ?? "0");

for (int i=1; i<=n; i++)
    Console.WriteLine($"f({i}): {Fibonachi(i)}");

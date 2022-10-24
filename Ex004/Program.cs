// Написать программу копирования массива

void EnterArray (int[,] array, int min, int max)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j]=new Random().Next(min,max);
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {

        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}

void CopyArray(int[,] array1, int[,] array2)
{
    for (int i=0; i<array1.GetLength(0); i++)
        for (int j=0; j<array1.GetLength(1); j++)
            array2[i,j]=array1[i,j];
}

Console.Write("Введите количество строк: ");
int strok=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int stolb=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальный элемент массива: ");
int minim=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный элемент массива: ");
int maxim=int.Parse(Console.ReadLine() ?? "0");

int[,] array1 = new int[strok,stolb];
int[,] array2 = new int[strok,stolb];

EnterArray(array1, minim, maxim);
Console.WriteLine("Заданный массив: ");
PrintArray(array1);
CopyArray(array1, array2);
Console.WriteLine("Копия массива: ");
PrintArray(array2);
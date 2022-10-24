// Написать программу масштабирования фигуры
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавать отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        Console.Write("(");
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}");
            if (j!=array.GetLength(1)-1) Console.Write(",");
        }  
        Console.Write(") ");
    }
    Console.WriteLine();
}

void MashArray(int[,] array, int koef)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j]=array[i,j]*koef;
}

int [,] array = new int[4,2];
Console.WriteLine("Введите вершины фигуры: ");

for (int i=0; i<array.GetLength(0); i++)
{
    Console.WriteLine($"Вершина {i+1}:");
    for (int j=0; j<array.GetLength(1); j++) 
        array[i,j]=int.Parse(Console.ReadLine() ?? "0");
}

Console.Write("Введите коэффициент масштабирования: ");
int k=int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введены координаты: ");
PrintArray(array);

MashArray(array, k);

Console.WriteLine("Координаты после масштабирования: ");
PrintArray(array);
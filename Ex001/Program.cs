// Найти точку пересечения двух прямых,
// заданных уравнением y = k1 * x + b1, y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы

Console.WriteLine("Введите переменные для уравнения прямой 1");
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите переменные для уравнения прямой 2");
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");

if (k1==k2 && b1==b2) Console.WriteLine("прямые совпадают");
else if (k1==k2) Console.WriteLine("прямые параллельны");
else 
{
    float x = (b2-b1)/(k1-k2);
    float y = (k1*x+b1);
    Console.WriteLine($"прямые пересекаются в точке с координатами [{x},{y}]");
}

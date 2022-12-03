//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void Zadanie1()
{ 
    Console.WriteLine(" Введите координаты b1, k1, b2 и k2:");
    Double b1 = Convert.ToInt32(Console.ReadLine());
    Double k1 = Convert.ToInt32(Console.ReadLine());
    Double b2 = Convert.ToInt32(Console.ReadLine());
    Double k2 = Convert.ToInt32(Console.ReadLine());
    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("прямые параллельны");
    }
    else
    {
        Double x= (b2-b1/k1-k2);
        Double x1=(k1 * x + b1);
        Double y1=(k2 * x + b2);
        Console.WriteLine($"Точка пересечения x({x1}), y({y1})");
    }
}
Zadanie1();
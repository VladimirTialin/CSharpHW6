/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
void intersectionPoint(double  b1, double  k1, double  b2, double  k2)
{
    if(k1!=k2)
    {
        double x = Math.Round(((b1 - b2)/(k2 - k1)),2);
        double  y = Math.Round((k1*x+b1),2);
        Console.WriteLine($"({x}; {y})");
    }
    else
    {
        System.Console.WriteLine($"При введеных параметров: ({k1}) ({k2}) - линии не пересекутся");
    }
}
int b1,k1,b2,k2;
Console.WriteLine("Поиск точки пересечения двух прямых!\nВведите необходимые параметры b1, k1, b2 и k2: ");
b1=Convert.ToInt32(Console.ReadLine());
k1=Convert.ToInt32(Console.ReadLine());
b2=Convert.ToInt32(Console.ReadLine());
k2=Convert.ToInt32(Console.ReadLine());
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2= {k2}: ");
intersectionPoint(b1, k1, b2, k2);

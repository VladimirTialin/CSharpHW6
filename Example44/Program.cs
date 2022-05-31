/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

void Fibonacci(int number,
                int numberNull = 0,
                int numberOne = 1)
{
Console.Write($"N = {number} -> {numberNull} {numberOne} ");
for(int i = 3; i <= number; i++)
{
    int Fibonacci = numberNull + numberOne;
    Console.Write(Fibonacci+" ");
    numberNull = numberOne;
    numberOne = Fibonacci;
}
}
Console.Write("Формируем ряд Фибоначчи! Введите число N = ");
int number=Convert.ToInt32(Console.ReadLine());
Fibonacci(number);
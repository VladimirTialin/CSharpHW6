/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
int [] AddArray(int [] array)
{
    Console.WriteLine($"Введите {array.Length} любых чисел: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void CopyArray(int[] array)
{       
    Console.WriteLine($"Поэлементное копирование массива размером [{array.Length}] ...");
    var ResultArray= new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        ResultArray[i]=array[i];
        Thread.Sleep(800);
        Console.WriteLine($"Array [{i}] = {array[i]} в NewArray [{i}] = {ResultArray[i]}");
    }
    Console.WriteLine("Копирование завершено!");
}
Console.Write("Введите размер массива: ");
int size=Convert.ToInt32(Console.ReadLine());
int [] Numbers= new int[size];
int[] result=AddArray(Numbers);
CopyArray(result);
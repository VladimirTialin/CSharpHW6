//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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
    Thread.Sleep(800);
    Console.WriteLine("Копирование завершено!");
}

Console.Write("Введите размер массива: ");
int size=Convert.ToInt32(Console.ReadLine());
int [] Numbers= new int[size];
int[] result=AddArray(Numbers);
CopyArray(result);
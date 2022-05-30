
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
void AddNumber(int [] array)
{
    int temp=0;
    try
    {
        for (int i = 0; i <= array.Length; i++)
        {
            
            int number = Convert.ToInt32(Console.ReadLine());
            array[i] = number;
            if (array[i] > 0)
            {
                temp++;
            }
            Array.Resize (ref array,array.Length+1);
        }
    } 
    catch
    {
       Array.Resize (ref array,array.Length-1); 
    }
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine($"Сумма чиcел > 0 = {temp}");
    Console.ResetColor();
}
int [] numbers= new int[1];
Console.WriteLine("Введите любое количество чисел:");
AddNumber(numbers);
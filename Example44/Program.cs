/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
int Fibonacci(int number)
{
    int FirstNumber=0;
    int NumberFibonacci=0;
    int SecondNumber=1;
    if(Math.Abs(number)==1)
    {
        NumberFibonacci=SecondNumber;
        for (int i = 0; i < Math.Abs(number)-1; i++)
    {
        if(number==1 || number==2)
        {
            NumberFibonacci=FirstNumber+SecondNumber;
            FirstNumber=SecondNumber;
            SecondNumber=NumberFibonacci;
        }
    }
    return number*NumberFibonacci;
}
int result =Fibonacci(5);
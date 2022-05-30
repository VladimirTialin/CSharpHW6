//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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
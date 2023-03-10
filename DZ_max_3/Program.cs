// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Здравствуйте, введите три числа!");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

 int max;
 if (a >= b)
 {
    if (c >= a)
    {
       max = c;
    }
    else
    {
       max = a;
    }
 }
 else
 {
    if (c >= b)
    {
       max = c;
    }
    else
    {
       max = b;
    }
 }


Console.Write(" Это самое большое число!");Console.Write(max);
{
    
}
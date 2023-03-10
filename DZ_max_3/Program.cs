// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа!");

int a = Convert.ToInt32( Console.ReadLine());
int b = Convert.ToInt32( Console.ReadLine());
int c = Convert.ToInt32( Console.ReadLine());
int max = a;

if (b > max){ b=max;
}  if(c > max){ c = max;
}
Console.WriteLine(" Это самое большое число!");Console.Write(max);
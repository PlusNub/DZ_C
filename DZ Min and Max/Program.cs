// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите 2 числа!");
int a = Convert.ToInt32( Console.ReadLine());
int b = Convert.ToInt32( Console.ReadLine());

if (a > b)  {
    
    Console.WriteLine( " Первое число больше"); Console.Write (a);
}
else
{
    
    Console.WriteLine( "Второе число больше") ; Console.Write (b);
}


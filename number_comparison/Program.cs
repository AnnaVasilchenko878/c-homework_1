// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if(number1>number2)
{
  Console.WriteLine($"Число {number1} больше числа {number2}");
}
else 
{
  Console.WriteLine($"Число {number2} больше числа {number1}");
}





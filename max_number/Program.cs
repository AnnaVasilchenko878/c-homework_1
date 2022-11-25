// // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double number3 = Convert.ToDouble(Console.ReadLine());
double maxNumber = number1;

if(maxNumber<number2) 
{
  maxNumber = number2;
}
if(maxNumber < number3)
{
  maxNumber = number3;
} 
Console.WriteLine($"Максимальное число: {maxNumber}");

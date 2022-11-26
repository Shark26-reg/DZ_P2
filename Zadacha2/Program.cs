// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ThirdDigit(int number)
{
     int result = 0;

    if (number >=100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
            result = number % 10;
    }
    return result;
       
    }
    
Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == 0)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Третье число -> {ThirdDigit(number1)}");

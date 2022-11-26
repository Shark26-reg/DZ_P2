// 4. Напишите программу,  которая выводит случайное трехзначное число и удаляет вторую цифру этого числа, не использовать строки для рассчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98



System.Console.WriteLine();

int Number = new Random().Next(100, 1000);
int NewNumber = 0;

int NumSecDig()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumSecDig();

System.Console.WriteLine($"{Number} -> {NewNumber}");


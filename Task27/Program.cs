/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

//int countDigit = CountDigit(number);
//Console.WriteLine($"В числе {number} цифр {countDigit}");

int sumDigit = (SumDigit (number));
Console.WriteLine($"Сумма чисел числа {number} = {sumDigit}");


int SumDigit(int num)
{
int result = 0;

while (num > 0)
{
    result += num %10;
    num = num /10;
    
}
return  result;
    
}



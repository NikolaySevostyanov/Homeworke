Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int summa = 0;
    while(num > 0)
    {
        summa += num % 10;
        num /= 10;
    }
    return summa;
}

if (number < 0) number = - number;
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр числа {number} = {sumNumbers}");

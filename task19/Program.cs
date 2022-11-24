// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome()
{
    int num1 = number / 10000;
    int num2 = number / 1000 % 10;
    int num4 = number % 100 / 10;
    int num5 = number % 10;

    return(num1 == num5 && num2 == num4);
}

Console.WriteLine(Palindrome() ? "Палиндром" : "Не является палиндромомо");

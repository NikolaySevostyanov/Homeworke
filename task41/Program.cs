// Задача 41: (ВАРИАНТ 2) Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Введите количество элементов: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int[] PrintNumbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите элемент {i} ----> ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int Count(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] array = PrintNumbers(numbers);
Console.WriteLine($"Число элементов больше нуля ----> {Count(array)}");

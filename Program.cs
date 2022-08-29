// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");

int[] numbers = GetArrayFromString(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0 -> {GetCountPositiveElements(numbers)}");

int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length;i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int GetCountPositiveElements(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if(item > 0) count++;
    }
    return count;
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 


Console.WriteLine($"Введите точку 1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите точку 2");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите точку 3");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите точку 4");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"точка пересечения двух прямых ({(b2-b1) / (k1 -k2)}; {(k1 *((b2-b1) / (k1 -k2))) + b1})");

/*/
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
/*/

int [] array = PrintStrAndGetArrayOfInt("Введите числа (через запятую)");
Console.WriteLine(PositiveNumbers(array));

int PositiveNumbers(int[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) k++;
    }
    return k;
}

int[] PrintStrAndGetArrayOfInt(string message) // пишем сообщение и задаем массив вещественных чисел
{
    Console.WriteLine(message);

    string ArrayInOneString = (Console.ReadLine());
    string[] ArrayOfString = ArrayInOneString.Split(",", StringSplitOptions.RemoveEmptyEntries);
    int[] ArrayOfInt = new int[ArrayOfString.Length];

    for (int i = 0; i < ArrayOfInt.Length; i++)
    {
        ArrayOfInt[i] = int.Parse(ArrayOfString[i]);
    }
    return ArrayOfInt;
}
/*/
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
/*/

double[] array = PrintStrAndGetArrayOfDouble("Введите числа (через пробел)");
Console.WriteLine(PositiveNumbers(array));

int PositiveNumbers(double[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) k++;
    }
    return k;
}

double[] PrintStrAndGetArrayOfDouble(string message) // пишем сообщение и задаем массив вещественных чисел
{
    Console.WriteLine(message);

    string ArrayInOneString = (Console.ReadLine());
    string[] ArrayOfString = ArrayInOneString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] ArrayOfDouble = new double[ArrayOfString.Length];

    for (int i = 0; i < ArrayOfDouble.Length; i++)
    {
        ArrayOfDouble[i] = double.Parse(ArrayOfString[i]);
    }
    return ArrayOfDouble;
}
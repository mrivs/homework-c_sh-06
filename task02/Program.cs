/*/
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*/

double b1 = PrintAndGetValue("Введите b1");
double k1 = PrintAndGetValue("Введите k1");
double b2 = PrintAndGetValue("Введите b2");
double k2 = PrintAndGetValue("Введите k2");

double[]point=IntersectionPoint(b1,k1,b2,k2);
Console.WriteLine("({0}; {1})",point[0],point[1]);

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    return point;
}

double PrintAndGetValue(string message) // пишем запрос, вводим число
{
    Console.WriteLine(message);
    double d = double.Parse(Console.ReadLine());
    return d;
}
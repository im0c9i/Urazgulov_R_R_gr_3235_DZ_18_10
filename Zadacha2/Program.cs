/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("введите значение b1");
double ferstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double threeNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double fourNum = Convert.ToInt32(Console.ReadLine());

double x = (-threeNum + ferstNum)/(-secondNum + fourNum);
double y = fourNum * x + threeNum;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
// Задача 23

// Напишите программу, которая
// принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

System.Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CubesTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            double cube = Math.Pow(i,3);
            Console.WriteLine($"{i,4} |  {cube,4}");
        }
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
    }
}
CubesTable(number);
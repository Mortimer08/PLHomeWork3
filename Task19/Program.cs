﻿// Задача 19

// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).


// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Reverse(int num)
{
    int decr = 10000;
    int reversedNumber = 0;
    for (int i = 1; i <= 5; i++)
    {
        int digit = num % 10;
        num = num / 10;
        reversedNumber = reversedNumber + digit * decr;
        decr = decr / 10;
    }
    return reversedNumber;
}

Console.Write("Введите пятизначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999) Console.WriteLine("Введено некорректное значение");
// Есть ли значение (с точки зрения читаемости)
// куда ставить основной код - в True или False
// проверки корректности ввода?
else
{
    string result = number == Reverse(number) ? "палиндром" : "не палиндром";
    Console.WriteLine($"Число {number} - {result}");
}
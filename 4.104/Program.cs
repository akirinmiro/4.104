﻿using System;
class Program
{
    public enum DayOfWeek
    {
        Понедельник = 0,
        Вторник = 1,
        Среда = 2,
        Четверг = 3,
        Пятница = 4,
        Суббота = 5,
        Воскресенье = 6
    }
    static void Main(string[] args)
    {
        Console.Write("Введите номер дня недели: ");
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine((DayOfWeek)((n - 1) % Enum.GetValues(typeof(DayOfWeek)).Length));
    }





}
    


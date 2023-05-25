﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();                                                                     // Очищаем терминал.

Console.Write("Введите любое целое число, состоящее из любого количества цифр: ");   // Запрашиваем число.
long num = long.Parse(Console.ReadLine()!);                                          /* Вводим число и парсим его из 
                                                                                       строкового формата в 
                                                                                       целочисленный.*/
if(num / 100 == 0)                                                                   /* Проверяем число на кратность ста
{                                                                                      для определения его трёхзначности.*/                        
    Console.Write($"{num} -> третьей цифры нет");                                    /* Если число имеет менее трёх знаков 
}                                                                                      в терминал выводится текс "третьей цифры нет".*/
else                                                                                 // иначе
{
    long num1 = (num / 100) % 10;                                                    
    if(num < 0) num1 = -num1;                                                        // Проверяем введённое число на знак по модулю и в случяе отрицательного значения умножаем результат на минус один для приведения к положительному значению.
    Console.Write($"{num} -> {num1}");                                               // Выводим результат в терминал.
}

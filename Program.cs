﻿/*
* Автор: Евгений Петров
* Почта: p174@mail.ru
* Цель: Обечение c#. пишу учебное ппроложение,
* https://learn.microsoft.com/ru-ru/training/modules/guided-project-calculate-print-student-grades/2-prepare
* Дата проекта: 25.10.2024
*/

// initialize variables - graded assignments 
int currentAssignments = 5;

// Данные учеников по успеваемости
int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;



// Данные среднее арисметическое

int sophiaSum = 0;
int nicolasSum = 0;
int zahirahSum = 0;
int jeongSum = 0;

decimal sophiaScore;
decimal nicolasScore;
decimal zahirahScore;
decimal jeongScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
jeongSum =  jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
nicolasScore = (decimal)nicolasSum /currentAssignments;
zahirahScore = (decimal)zahirahSum / currentAssignments;
jeongScore = (decimal)jeongSum / currentAssignments;


Console.WriteLine("Student\tGrade\n");
Console.WriteLine($"Sofia:\t\t{sophiaScore}\tA");
Console.WriteLine($"Nicolas:\t{nicolasScore}\tB");
Console.WriteLine($"Zahirah:\t{zahirahScore}\tB");
Console.WriteLine($"Jeong:\t\t{jeongScore}\tA");

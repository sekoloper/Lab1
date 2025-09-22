using System;
using Lab1;

internal class Program
{
    private static void Main()
    {
        Tasks tasks = new();
        string choice;
        Console.WriteLine("Задания:");
        Console.WriteLine("Методы\t\tУсловия\t\tЦиклы\t\tМассивы");
        Console.WriteLine("№2 - 1\t\t№2 - 6\t\t№2 - 11\t\t№2 - 16");
        Console.WriteLine("№4 - 2\t\t№4 - 7\t\t№4 - 12\t\t№4 - 17");
        Console.WriteLine("№6 - 3\t\t№6 - 8\t\t№6 - 13\t\t№6 - 18");
        Console.WriteLine("№8 - 4\t\t№8 - 9\t\t№8 - 14\t\t№8 - 19");
        Console.WriteLine("№10- 5\t\t№10- 10\t\t№10- 15\t\t№10 - 20");
        do
        {
            Console.WriteLine("Выберите номер задания. Чтобы выйти, введите 0.");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "0": break;
                case "1": tasks.SumLastNums(); break;
                case "2": tasks.IsPositive(); break;
                case "3": tasks.IsUpperCase(); break;
                case "4": tasks.IsDivisor(); break;
                case "5": tasks.LastNumSum(); break;
                case "6": tasks.SafeDiv(); break;
                case "7": tasks.MakeDecision(); break;
                case "8": tasks.Sum3(); break;
                case "9": tasks.Age(); break;
                case "10": tasks.PrintDays(); break;
                case "11": tasks.ReverseListNums(); break;
                case "12": tasks.Pow(); break;
                case "13": tasks.EqualNum(); break;
                case "14": tasks.LeftTriangle(); break;
                case "15": tasks.GuessGame(); break;
                case "16": tasks.FindLast(); break;
                case "17": tasks.Add(); break;
                case "18": tasks.Reverse(); break;
                case "19": tasks.Concat(); break;
                case "20": tasks.DeleteNegative(); break;
                default: Console.WriteLine("Неверный ввод."); break;
            }
        }
        while (choice != "0");
    }
}
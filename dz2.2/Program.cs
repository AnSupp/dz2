using System;
using static System.Console;

namespace dz2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float computerScienceScore;
            float mathScore;
            float physicsScore;

            float sumScores;
            float averageScores;

            WriteLine("Введите баллы по информатике:");
            computerScienceScore = Convert.ToSingle(ReadLine());
            WriteLine("Введите баллы по математике:");
            mathScore = Convert.ToSingle(ReadLine());
            WriteLine("Введите баллы по физике:");
            physicsScore = Convert.ToSingle(ReadLine());

            sumScores = computerScienceScore + mathScore + physicsScore;
            averageScores = sumScores / 3;

            WriteLine("Нажмите на любую кнопку, чтобы вывести информацию по баллам");
            ReadKey();
            Console.Clear();
            WriteLine($"{"Баллы по информатике ||",25}{computerScienceScore,10}");
            WriteLine($"{"Баллы по математике ||",25}{mathScore,10}");
            WriteLine($"{"Баллы по физике ||",25}{physicsScore,10}");
            WriteLine($"{"Сумма баллов ||",25}{sumScores,10}");

            string centerStr = $"{"Средний балл ||",25}{averageScores,10}";

            int centerX = (Console.WindowWidth / 2) - (centerStr.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            SetCursorPosition(centerX, centerY);
            Write(centerStr);

            ReadLine();
        }
    }
}

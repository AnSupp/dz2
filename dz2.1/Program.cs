using System;
using static System.Console;

namespace dz2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Кипятков Иван Петрович";
            byte age = 17;
            string email = "kipyatok@gmail.com";
            float computerScienceScore = 79.84f;
            float mathScore = 84.9f;
            float physicsScore = 76.12f;

            WriteLine($"{"ФИО ||",25}{fullName,25}");
            WriteLine($"{"Возраст ||",25}{age,25}");
            WriteLine($"{"Email ||",25}{email,25}");
            WriteLine($"{"Баллы по информатике ||",25}{computerScienceScore,25}");
            WriteLine($"{"Баллы по математике ||",25}{mathScore,25}");
            WriteLine($"{"Баллы по физике ||",25}{physicsScore,25}");

            ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2._7ConsoleApp
{
    class Programm

    {
        string fullName = "Гаргулян Гаргулья Гаргульевич";

        byte age = 19;

        string Email = "ligillespie@mail.ru";

        float programmingScores = 10.6f;
        float mathScores = 24.2f;
        float physicsScores = 30.2f;

        Console.WriteLine("Ф.И.О: {0} Возраст: {1} Почта: {2} Баллы по программированию: {3} Баллы по математике: {4} Баллы по физике: {5}",
                            fullName,
                            age,
                            Email,
                            programmingScores,
                            mathScores,
                            physicsScores);

    }
}

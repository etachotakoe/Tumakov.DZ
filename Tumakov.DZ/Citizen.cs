using System;

namespace HeatingSeason
{
    public class Citizen
    {
        public string Name { get; set; }
        public string PassportNumber { get; set; }
        public Problem Problem { get; set; }
        public Temperament Temperament { get; set; }

        public Citizen(string name, string passportNumber, Problem problem, Temperament temperament)
        {
            Name = name;
            PassportNumber = passportNumber;
            Problem = problem;
            Temperament = temperament;
        }

        public int GetPreferredWindow()
        {
            if (Temperament.Scandalous >= 5)
                return -1; // скандалист
            if (Temperament.Smart == 0)
                return new Random().Next(1, 4); // тупой, случайное окно
            return Problem.Number; // нормальный случай
        }
    }
}

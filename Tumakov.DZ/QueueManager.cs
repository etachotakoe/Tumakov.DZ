using System;
using System.Collections.Generic;

namespace HeatingSeason
{
    public class QueueManager
    {
        private Stack<Citizen> citizensStack = new Stack<Citizen>();

        public void AddCitizen(Citizen citizen)
        {
            citizensStack.Push(citizen);
        }

        public void ProcessQueue()
        {
            while (citizensStack.Count > 0)
            {
                Citizen citizen = citizensStack.Pop();
                int preferredWindow = citizen.GetPreferredWindow();

                if (preferredWindow == -1) // Скандалист
                {
                    Console.WriteLine($"{citizen.Name} (скандалист) обгоняет в очереди!");
                    Console.Write("На сколько человек он обгоняет? ");
                    int skipCount = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{citizen.Name} заходит в окно {GetWindowNumber(preferredWindow)}.");
                }
                else if (preferredWindow < 1 || preferredWindow > 3) // Тупой житель
                {
                    preferredWindow = new Random().Next(1, 4);
                    Console.WriteLine($"{citizen.Name} (тупой) заходит в окно {preferredWindow}.");
                }
                else // Нормальный житель
                {
                    Console.WriteLine($"{citizen.Name} заходит в окно {preferredWindow}.");
                }
            }
        }

        private string GetWindowNumber(int window)
        {
            switch (window)
            {
                case 1: return "1 (проблемы с отоплением)";
                case 2: return "2 (оплата отопления)";
                case 3: return "3 (прочие вопросы)";
                default: return "неизвестное";
            }
        }
    }
}

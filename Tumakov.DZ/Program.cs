using System;

namespace HeatingSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueManager queueManager = new QueueManager();

            // добавляем жителей в очередь
            queueManager.AddCitizen(new Citizen("Иван", "1234567890", new Problem(1, "Проблема с отоплением"), new Temperament(7, 1)));
            queueManager.AddCitizen(new Citizen("Мария", "0987654321", new Problem(2, "Оплата отопления"), new Temperament(4, 0)));
            queueManager.AddCitizen(new Citizen("Алексей", "1122334455", new Problem(3, "Прочие вопросы"), new Temperament(9, 0)));
            queueManager.AddCitizen(new Citizen("Ольга", "2233445566", new Problem(1, "Нет тепла в квартире"), new Temperament(2, 1)));

            // обрабатываем очередь
            queueManager.ProcessQueue();
        }
    }
}

using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger("logPD23.txt");

            publisher.MessageSent += logger.LogToFile;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Введи текст: ");
                string message = Console.ReadLine();

                publisher.Send(message);
            }

            Console.WriteLine("Повідомлення записані!");
        }
    }
}
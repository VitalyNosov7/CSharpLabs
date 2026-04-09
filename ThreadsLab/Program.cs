using System.Net.Sockets;

namespace ThreadsLab
{
    class Program
    {
        static int x = 0;
       static  object locker = new();  // объект-заглушка
        static void Print()
        {
            lock (locker)
            {
                x = 1;
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    Thread.Sleep(100);
                }
            }
        }

        static void Main(string[] args)
        {

            // запускаем пять потоков
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Поток {i}";   // устанавливаем имя для каждого потока
                myThread.Start();
            }

        }
    }
}

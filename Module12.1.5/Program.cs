using System;
using System.Threading;

namespace Module12._1._5
{
    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program main method
        /// </summary>
        /// <param name="args"> Entry parameter </param>
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь, введите свой Логин");
            var user = new User();
            string login = Console.ReadLine().ToLower();
            if (!user.CheckLogin(login))
            {
                Console.Write("Отсутствует такой пользователь, создание нового");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.WriteLine(".");
                user.AddUser(user);
            }

            try
            {
                var currentUser = user.Users[login];
                if (currentUser.IsPremium)
                {
                    Console.WriteLine("Добро пожаловать, пользователь!");
                }
                else
                {
                    var mainClass = new Program();
                    mainClass.ShowAdd();
                    Console.WriteLine("Добро пожаловать, пользователь!");
                }
            }
            catch
            {
                Console.WriteLine("Такого Логина нет!");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method ShowAdd show add to user
        /// </summary>
        public void ShowAdd()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");

            // Остановка на 1 с
            Thread.Sleep(1000);
            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");

            // Остановка на 2 с
            Thread.Sleep(2000);
            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");

            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}

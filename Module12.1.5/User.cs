using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12._1._5
{
    /// <summary>
    /// Class describes User
    /// </summary>
    public class User
    {
        /// <summary>
        /// Dictionary contains Users
        /// </summary>
        public Dictionary<string, User> Users;

        /// <summary>
        /// Kinds of User
        /// </summary>
        public User()
        {
            Users = new Dictionary<string, User>();
        }

        /// <summary>
        /// Login of User
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Name of User
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Have User premium account or not
        /// </summary>
        public bool IsPremium { get; set; }

        /// <summary>
        /// Method adds new user in dictionary
        /// </summary>
        /// <param name="user"> Parameter from main function </param>
        public void AddUser(User user)
        {
            string ans;
            Console.WriteLine("Введите логин");
            user.Login = Console.ReadLine().ToLower();
            Console.WriteLine("Введите Имя");
            user.Name = Console.ReadLine().ToLower();
            bool exit = false;

            do
            {
                Console.WriteLine("Хотите премиум-подписку?");
                ans = Console.ReadLine().ToLower();
                exit = CheckAnsw(ans);
            } while (exit == false);

            if(ans == "yes")
            {
                user.IsPremium = true;
            }
            else
            {
                user.IsPremium = false;
            }

                Users.Add(user.Login, user);
        }

        /// <summary>
        /// Method CheckAnsw checks answer to get out of cycle
        /// </summary>
        /// <param name="ans"> Parameter contains answer </param>
        /// <returns> Return true or false, after checking answer </returns>
        public bool CheckAnsw(string ans)
        {
            bool n = ans == "yes" | ans == "no";
            return n;
        }

        /// <summary>
        /// Method CheckLogin checks dictionary with login      
        /// </summary>
        /// <param name="login"> Login, that have to be checked </param>
        /// <returns> Return true or false, after checking the login </returns>
        public bool CheckLogin(string login)
        {
            bool n;
            try
            {
                n = Users.ContainsKey(login);
            }
            catch
            {
                n = false;
            }

            return n;
        }
    }
}

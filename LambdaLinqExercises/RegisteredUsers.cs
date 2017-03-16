using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LambdaLinqExercises
{
    public class RegisteredUsers
    {
        public static void Main()
        {
            string inputEntered = Console.ReadLine();
            var registeredUsers = new Dictionary<String, DateTime>();

            while (inputEntered!="end")
            {
                var entry = inputEntered
                    .Split(' ')
                    .ToList();

                var firstElement = entry.First();
                DateTime lastElement = DateTime.ParseExact(entry.Last(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                //най-стандартен начин за вкарване в речника

                registeredUsers[firstElement] = lastElement;

                //по-засукания начин за вкарване в речника
                                
                //if (!registeredUsers.ContainsKey(firstElement))
                //{
                //    registeredUsers[firstElement] = lastElement;
                //}
                inputEntered = Console.ReadLine();
            }
            var finalDictionary = registeredUsers
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var itemPair in finalDictionary)
            {
                var name = itemPair.Key;
                
                Console.WriteLine($"{name}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.defaultValues
{
    public class DefaultValues
    {
        public static void Main()
        {
            var line = Console.ReadLine();

            var defaultValueDict = new Dictionary<string, string>();
            

            while (line != "end")
            {
                var input = line
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var inputName = input.First();
                var inputValue = input.Last();

                defaultValueDict[inputName] = inputValue;
                                
                line = Console.ReadLine();
            }
            string lineSecond = Console.ReadLine();

            var sortedDict = defaultValueDict
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            var unsortedDict = defaultValueDict
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => lineSecond);

            
            foreach (var itemPair in sortedDict)
            {
                var name = itemPair.Key;
                var value = itemPair.Value;

                Console.WriteLine($"{name} <-> {value}");
            }

            foreach (var itemPair in unsortedDict)
            {
                var name = itemPair.Key;
                var value = itemPair.Value;

                Console.WriteLine($"{name} <-> {value}");
            }

        }
    }
}

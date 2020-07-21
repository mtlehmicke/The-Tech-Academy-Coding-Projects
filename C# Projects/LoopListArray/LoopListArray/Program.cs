using System;
using System.Collections.Generic;
using System.Linq;

namespace LoopListArray
{
    class Program
    {
        static void Main()
        {
            string[] oneArray = { "one", "two", "three", "four", "five" };
            Console.WriteLine("Enter some text:");
            string textAdd = Console.ReadLine();
            foreach (string i in oneArray)
            {
                Console.WriteLine(string.Concat(i + textAdd));
            }
            

            int intLoop = 1;
            while (intLoop > 0)
            {
                if (intLoop == 10)
                {
                    break;
                }
                Console.WriteLine(intLoop);
                intLoop++;
            }

            int lesserThan = 0;
            while (lesserThan < 5)
            {
                Console.WriteLine(lesserThan);
                lesserThan++;
            }

            int lesserEqual = 0;
            while (lesserEqual <= 5)
            {
                Console.WriteLine(lesserEqual);
                lesserEqual++;
            }

            List<string> findList = new List<string>
            {
                "Alpha",
                "Beta",
                "Charlie",
                "Delta"
            };
            Console.WriteLine("Enter the words Alpha, Beta, Charlie, or Delta to find the word's index in the array:");
            string theString = Console.ReadLine();
#pragma warning disable CS0162 // Unreachable code detected
            for (int idx = 0; idx < findList.Count; idx++)
#pragma warning restore CS0162 // Unreachable code detected
            {
                if (findList[idx].Contains(theString))
                {
                    Console.WriteLine(findList.IndexOf(theString));
                    break;
                }
                else
                {
                    Console.WriteLine("That is not part of the list.");
                    break;
                }
            }

            List<string> dupList = new List<string>
            {
                "Alpha",
                "Beta",
                "Charlie",
                "Delta",
                "Charlie",
                "Alpha",
            };
            Console.WriteLine("Enter the words Alpha, Beta, Charlie, or Delta to find the word's index/indices in the array:");
            string dupString = Console.ReadLine();
            for (int idd = 0; idd < dupList.Count; idd++)
            {
                if (dupList[idd].Contains(dupString))
                {
                    Console.WriteLine(idd);
                }
                else if (dupList.Contains(dupString) == false)
                {
                    Console.WriteLine("That is not part of the list.");
                    break;
                }
            }

            var dupDict = new Dictionary<string, int>();
            foreach (string listItem in dupList)
            {
                if (dupDict.ContainsKey(listItem))
                {
                    dupDict[listItem]++;
                    Console.WriteLine(listItem + " has appeared in the array before.");
                }   
                else
                {
                    dupDict[listItem] = 1;
                    Console.WriteLine(listItem + " has not appeared in the array before.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Define a Dictionary that contains information about several members of your family.

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>()
            { 
                {"name", "Jessi"},
                {"age", "32"}
            });

              myFamily.Add("brother", new Dictionary<string, string>()
            { 
                {"name", "Joey"},
                {"age", "28"}
            });

              myFamily.Add("mother", new Dictionary<string, string>()
            { 
                {"name", "Beth"},
                {"age", "49"}
            });

              myFamily.Add("father", new Dictionary<string, string>()
            { 
                {"name", "Steve"},
                {"age", "49"}
            });

            //Next, iterate over each item in myFamily and produce the following output.
            
            foreach(KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old. ");
            }
        }
    }
}

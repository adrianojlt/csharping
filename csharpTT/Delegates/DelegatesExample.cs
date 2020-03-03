namespace csharpTT.Generics
{
    using System;
    using System.Collections.Generic;

    public class DelegatesExample
    {
        public string[] names { get; set; }

        public delegate bool Filters(string name);

        public bool LessThanFive(string name)
        {
            return name.Length < 5;
        }

        public bool MoreThanFive(string name)
        {
            return name.Length > 5;
        }

        public bool ExactlyFive(string name)
        {
            return name.Length == 5;
        }

        public void PrintNames()
        {
            List<string> lessThanFiveChars = LessThanFive(names);
            List<string> moreThanFiveChars = NamesFilter(names, name => name.Length > 5);
            List<string> exactlyFive = NamesFilter(names, ExactlyFive);

            Console.WriteLine("Names less than five chars: " + string.Join(", ", lessThanFiveChars));
            Console.WriteLine("Names more than five chars: " + string.Join(", ", moreThanFiveChars));
            Console.WriteLine("Names with exactly five chars: " + string.Join(", ", exactlyFive));

            Console.ReadLine();
        }
       

        public List<string> NamesFilter(string[] names, Filters Filter)
        {
            List<string> result = new List<string>();

            foreach (var name in names)
            {
                if (Filter(name))
                {
                    result.Add(name);
                }
            }

            return result;
        }

        public List<string> LessThanFive(string[] names)
        {
            List<string> result = new List<string>();

            foreach (var name in names)
            {
                if (name.Length < 5)
                {
                    result.Add(name);
                }
            }

            return result;
        }
    }
}

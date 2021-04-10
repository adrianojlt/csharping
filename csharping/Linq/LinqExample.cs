namespace csharpTT.Linq
{
    using System.Collections.Generic;
    using System.Linq;

    public class LinqExample
    {
        List<int> numbers = new List<int>() { 2,3,56,34,33,3000,4395,54,10 };

        List<string> names = new List<string>() { "a", "b" };

        public void oddNumbers()
        {
            var oddNumbers = numbers.Where(n => n % 2 == 1);

            numbers.Max();
        }

        public void Temp()
        {
        }
    }
}

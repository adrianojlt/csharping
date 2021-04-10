namespace csharpTT.Delegates
{
    using System.Collections.Generic;
    using System.Linq;

    public static class ListExtensions
    {
        private delegate bool Filter(string name);

        public static IEnumerable<string> Exactly(this IEnumerable<string> names, int nameLength)
        {
            return ExtractStrings(names?.ToArray(), name => name.Length == nameLength);
        }

        public static IEnumerable<string> LessThan(this IEnumerable<string> names, int nameLength)
        {
            return ExtractStrings(names.ToArray(), name => name.Length < nameLength);
        }

        public static IEnumerable<string> MoreThan(this IEnumerable<string> names, int nameLength)
        {
            return ExtractStrings(names.ToArray(), name => name.Length > nameLength);
        }

        private static IEnumerable<string> ExtractStrings(string[] names, Filter filter) // ... or use Func<string, bool> instead of delegate Filter
        {
            List<string> result = Enumerable.Empty<string>().ToList();

            if (names == null || !names.Any())
            {
                return result;
            }

            foreach( string name in names )
            {
                if (filter(name))
                {
                    result.Add(name);
                }
            }
           
            return result;
        }
    }
}

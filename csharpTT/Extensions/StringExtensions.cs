namespace csharpTT.Extensions
{
    using System;

    public static class StringExtensions
    {
        public static bool Contem(this String name, string content)
        {
            return name.ToLower().Contains(content);
        }
    }
}
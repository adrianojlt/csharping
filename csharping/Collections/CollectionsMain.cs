using csharping.MenuConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharping.Collections
{
    public class CollectionsMain : MenuPage
    {
        public CollectionsMain(Program program) : base("Collections Page", program,
            new Option("Linq", () => program.NavigateTo<Linq>()),
            new Option("Collections", () => program.NavigateTo<CollectionsExample>()))
        {

        }

        public void Menu()
        {

        }

        public static void exec()
        {
        }

        public static void Temp()
        {
            var language = new Dictionary<string, string>();
            language.Add("primeiro", "1");
            //string value = string.Empty;
            language.TryGetValue("asdf", out var value);
            Console.Write("value = " + value);
            Console.Write("***");
            language.TryGetValue("primeiro", out value);
            Console.Write("value = " + value);
            Console.ReadLine();
        }
    }
}
namespace csharping.Types
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class TypesMain
    {
        private static TypesMain instance;

        private TypesMain() { }

        public static TypesMain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TypesMain();
                }

                return instance;
            }
        }

        public void start()
        {
            while (Menu()) { }
        }

        private bool Menu()
        {
            Console.WriteLine("01) Show Assembly info");
            Console.WriteLine("00) Back");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    printNumberOfTypesAndMethods();
                    return true;
                case "00":
                    Console.Clear();
                    return false;
                default:
                    return true;
            }
        }

        private void printNumberOfTypesAndMethods()
        {
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));

                int methodCount = 0;

                foreach (var t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();
                }

                Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name);
            }
        }
    }
}

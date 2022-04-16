namespace csharping
{
    using System;
    using csharping.DesignPatterns;
    using csharping.Temp;
    using csharping.Types;

    public class Menu
    {

        public void Start()
        {
            //while (PrintMenu()) { }
        }
        private static bool PrintMenu()
        {
            //Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("01) Collections");
            Console.WriteLine("02) Delegates");
            Console.WriteLine("03) Patterns");
            Console.WriteLine("04) Generics");
            Console.WriteLine("05) Types");
            Console.WriteLine("99) Temp");
            Console.WriteLine("00) Exit");

            switch(Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    return true;
                case "2":
                    Console.Clear();
                    return true;
                case "3":
                    Console.Clear();
                    Patterns.Instance.Start();
                    return true;
                case "5":
                    Console.Clear();
                    TypesMain.Instance.start();
                    return true;
                case "99":
                    Console.Clear();
                    TempMain.Instance.start();
                    return true;
                case "00":
                    Console.Clear();
                    return false;
                default:
                    Console.Clear();
                    return true;
            }
        }

        private static void Collections()
        {
            
        }

        private static void Delegates()
        {
            Delegates.Delegates delegates = new Delegates.Delegates();


            var res = csharping.Delegates.Delegates.Calc(6.0,13.0);
            
        }
    }
}

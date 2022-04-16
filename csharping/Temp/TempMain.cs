using System;
using System.Linq;

namespace csharping.Temp
{
    public enum Gender
    {
        All = 0,
        Men = 248
    }

    public class TempMain
    {
        private static TempMain instance;
        private TempMain() { }

        public static TempMain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TempMain();
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
            Console.WriteLine("01) Cenas");
            Console.WriteLine("02) Option 02");
            Console.WriteLine("03) Option 03");
            Console.WriteLine("04) Option 04");
            Console.WriteLine("00) Back");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Cenas();
                    return true;
                case "2":
                    Console.Clear();
                    return true;
                case "3":
                    Console.Clear();
                    return true;
                case "00":
                    Console.Clear();
                    return false;
                default:
                    return true;
            }
        }

        public static void Cenas()
        {
            string all = ((Gender)0).ToString();
            string unknown = ((Gender)10).ToString();

            Console.WriteLine(all);
            Console.WriteLine(unknown);

            /*
            MenuConsole.Write(all);
            MenuConsole.Write(unknown);
            MenuConsole.ReadLine();
            */
        }

        public static void linqExample()
        {
            int[] scores = new int[] { 23, 223, 948 };

            scores.Where(x => x > 100);
        }
    }
}

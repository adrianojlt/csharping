using System;

namespace csharping.Collections
{
    public class Collections
    {
        private static Collections instance;

        private Collections() { }

        public static Collections Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Collections();
                }

                return instance;
            }
        }

        public void Start()
        {
            while (Menu()) { }
        }

        private bool Menu()
        {
            Console.WriteLine("01) Option 01");
            Console.WriteLine("02) Option 02");
            Console.WriteLine("03) Option 03");
            Console.WriteLine("00) Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                case "00":
                    return false;
                default:
                    return true;
            }
        }
    }
}

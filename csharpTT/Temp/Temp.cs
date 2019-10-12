using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT.Temp
{
    public enum Gender
    {
        All = 0,
        Men = 248
    }

    public static class Temp
    {
        public static void Cenas()
        {
            string all = ((Gender)0).ToString();
            string unknown = ((Gender)10).ToString();

            /*
            MenuConsole.Write(all);
            MenuConsole.Write(unknown);
            MenuConsole.ReadLine();
            */
        }
    }
}

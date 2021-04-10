using csharpTT.MenuConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT.Collections
{
    
    public class Linq : Page
    {
        private static readonly string title = "Linq Examples";

        public Linq(Program program) : base(title, program)
        {

        }

        public override void Display()
        {

            base.Display();

            Console.WriteLine(title);

            base.Navigation();
        }

        public void temp()
        {

        }
    }
}

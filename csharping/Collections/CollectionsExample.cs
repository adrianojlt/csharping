namespace csharping.Collections
{
    using csharping.MenuConsole;
    using System.Collections.Generic;

    public class CollectionsExample : Page
    {
        private static Dictionary<string, Element> cenas = new Dictionary<string, Element>
        {
            {"K", new Element() { Symbol = "K", Name = "Potassium", AtomicNumber = 19 } }
        };

        public CollectionsExample(Program program) : base("Collections examples", program)
        {

        }

        public override void Display()
        {
            base.Display();
        }

        public void Temp()
        {
            cenas.Add("asdf", null);
                
        }
    }
}

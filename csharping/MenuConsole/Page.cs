namespace csharping.MenuConsole
{
    using System;
    using System.Linq;

    public abstract class Page
    {
        public string Title { get; private set; }

        private enum NavKeys { Exit = 0, None = 9, Back = 1, Home = 2 }

        public Program Program { get; set; }

        public Page(string title, Program program)
        {
            Title = title;
            Program = program;
        }

        public virtual void Display()
        {
            if (Program.History.Count > 1 && Program.BreadcrumbHeader)
            {
                string breadcrumb = null;
                foreach (var title in Program.History.Select((page) => page.Title).Reverse())
                    breadcrumb += title + " > ";
                breadcrumb = breadcrumb.Remove(breadcrumb.Length - 3);
                Console.WriteLine(breadcrumb);
            }
            else
            {
                Console.WriteLine(Title);
            }
            Console.WriteLine("---");
        }

        public virtual void Navigation()
        {
            NavKeys input = NavKeys.None;

            while ( input == NavKeys.None )
            {
                if (!Enum.TryParse(Input.ReadString("Press [1] to go Back. [2] to go Home or [0] to exit"), out input))
                {
                    input = NavKeys.None;
                }

                switch (input)
                {
                    case NavKeys.Back:
                        Program.NavigateBack();
                        break;
                    case NavKeys.Home:
                        Program.NavigateHome();
                        break;
                    case NavKeys.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        input = NavKeys.None;
                        Console.WriteLine("Invalid Input!!!");
                        break;
                }
            }
        }
    }
}

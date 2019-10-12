namespace csharpTT
{
    using csharpTT.Collections;
    using csharpTT.MenuConsole;

    public class Start: Program
    {
        public Start(): base("C sharp Tutorial", breadcrumbHeader: true)
        {
            AddPage(new Main(this));

            AddPage(new CollectionsMain(this));
            AddPage(new Collections.Collections(this));
            AddPage(new Linq(this));

            SetPage<Main>();
        }
    }
}
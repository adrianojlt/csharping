namespace csharping
{
    using csharping.Collections;
    using csharping.MenuConsole;

    public class Start: Program
    {
        public Start(): base("C sharp Tutorial", breadcrumbHeader: true)
        {
            AddPage(new Main1(this));

            AddPage(new CollectionsMain(this));
            AddPage(new Collections.CollectionsExample(this));
            //AddPage(new Linq(this));

            SetPage<Main1>();
        }

    }
}
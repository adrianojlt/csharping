using csharping.Collections;
using csharping.MenuConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharping
{
    class Main1 : MenuPage
    {
        public Main1(Program program) : base("Main Page", program,
            new Option("Collections", () => program.NavigateTo<CollectionsMain>()))
        {

        }
    }
}

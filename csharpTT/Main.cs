using csharpTT.Collections;
using csharpTT.MenuConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT
{
    class Main : MenuPage
    {
        public Main(Program program) : base("Main Page", program,
            new Option("Collections", () => program.NavigateTo<CollectionsMain>()))
        {

        }
    }
}

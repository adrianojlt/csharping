using csharpTT.Collections;
using csharpTT.MenuConsole;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT
{
    class Main1 : MenuPage
    {
        public Main1(Program program) : base("Main Page", program,
            new Option("Collections", () => program.NavigateTo<CollectionsMain>()))
        {

        }
    }
}

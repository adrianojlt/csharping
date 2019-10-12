using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT.Patterns.SOLID.Visitor.Employe
{
    interface IVisitor
    {
        void Visit(Element element);
    }
}

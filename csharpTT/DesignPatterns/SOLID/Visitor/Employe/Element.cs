using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT.DesignPatterns.SOLID.Visitor.Employe
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}

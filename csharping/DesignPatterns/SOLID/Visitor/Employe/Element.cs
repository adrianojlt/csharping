using System;
using System.Collections.Generic;
using System.Text;

namespace csharping.DesignPatterns.SOLID.Visitor.Employe
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}

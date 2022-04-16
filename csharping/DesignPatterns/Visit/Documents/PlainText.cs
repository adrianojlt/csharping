using System;
using System.Collections.Generic;
using System.Text;

namespace csharping.DesignPatterns.Visit.Documents
{
    public class PlainText : DocumentPart
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

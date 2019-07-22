using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT.Patterns.Visit.Documents
{
    public interface IVisitor
    {
        void Visit(PlainText docPart);
        void Visit(BoldText docPart);
        void Visit(HyperLink docPart);
    }
}

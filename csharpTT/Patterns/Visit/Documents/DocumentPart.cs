using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT.Patterns.Visit.Documents
{
    public abstract class DocumentPart
    {
        public string Text { get; private set; }
        public abstract void Accept(IVisitor visitor);
    }
}

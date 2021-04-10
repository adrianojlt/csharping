using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT.DesignPatterns.Visit.Documents
{
    public class HyperLink: DocumentPart
    {
        public string Url { get; private set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

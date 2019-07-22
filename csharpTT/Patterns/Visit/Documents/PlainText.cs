﻿using System;
using System.Collections.Generic;
using System.Text;

namespace csharpTT.Patterns.Visit.Documents
{
    public class PlainText : DocumentPart
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

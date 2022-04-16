﻿using System.Collections.Generic;

namespace csharping.DesignPatterns.Visit.Documents
{
    public class Document
    {
        private List<DocumentPart> m_parts;

        public void Accept(IVisitor visitor)
        {
            foreach(DocumentPart part in m_parts)
            {
                part.Accept(visitor);
            }
        }

        public void Exec()
        {
            HtmlVisitor visitor = new HtmlVisitor();

            Accept(visitor);
        }
    }
}

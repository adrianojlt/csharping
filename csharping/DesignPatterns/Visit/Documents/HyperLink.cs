namespace csharping.DesignPatterns.Visit.Documents
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

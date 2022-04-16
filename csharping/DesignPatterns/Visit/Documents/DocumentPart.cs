namespace csharping.DesignPatterns.Visit.Documents
{
    public abstract class DocumentPart
    {
        public string Text { get; private set; }

        public abstract void Accept(IVisitor visitor);
    }
}

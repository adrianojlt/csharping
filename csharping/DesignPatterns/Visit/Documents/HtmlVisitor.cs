namespace csharping.DesignPatterns.Visit.Documents
{
    public class HtmlVisitor : IVisitor
    {
        private string m_output = "";

        public string Output
        {
            set { }
            get { return this.m_output; }
        }
        
        public void Visit(PlainText docPart)
        {
            this.Output += docPart.Text;
        }

        public void Visit(BoldText docPart)
        {
            this.m_output += "<b>" + docPart.Text + "</b>";
        }

        public void Visit(HyperLink docPart)
        {
            this.m_output += "<a href=\"" + docPart.Url + "\">" + docPart.Text + "</a>";
        }
    }
}

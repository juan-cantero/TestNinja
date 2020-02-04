namespace TestNinja.Fundamentals
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            // $ this is for using interpolated string
            return $"<strong>{content}</strong>";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTest
{
    class HTMLGeneratorBuilder : IGeneratorBuilder
    {
        GeneratedText _generator;
        public HTMLGeneratorBuilder()
        {
            _generator = new GeneratedText()
            {
                Type = "HTML",
                Text = new List<string>()
            };
        }

        public void StartDocument()
        {
            _generator.Text.Add("<html>");
        }

        public void AddLine()
        {
            _generator.Text.Add("<hr>");
        }

        public void AddParagraph(string text)
        {
            _generator.Text.Add($"<p>{text}</p>");
        }

        public void EndDocument()
        {
            _generator.Text.Add("</html>");
        }

        public GeneratedText GetGeneratedText()
        {
            return _generator;
        }

        public void Clear()
        {
            _generator.Text.Clear();
        }
    }
}

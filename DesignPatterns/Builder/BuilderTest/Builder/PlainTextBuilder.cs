using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTest
{
    class PlainTextGeneratorBuilder : IGeneratorBuilder
    {
        private GeneratedText _generator;

        public PlainTextGeneratorBuilder()
        {
            _generator = new GeneratedText()
            {
                Type = "PlainText",
                Text = new List<string>()
            };
        }

        public void StartDocument()
        {
            
        }

        public void AddLine()
        {
            _generator.Text.Add("----------------------------");
        }

        public void AddParagraph(string text)
        {
            _generator.Text.Add(text);
        }

        public void EndDocument()
        {
         
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

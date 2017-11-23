using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTest
{
    interface IGeneratorBuilder
    {
        void StartDocument();
        void AddParagraph(string text);
        void AddLine();
        void EndDocument();
        GeneratedText GetGeneratedText();
        void Clear();
        
    }
}

using System.Collections.Generic;

namespace BuilderTest
{
    class GeneratorDirector
    {
        public IGeneratorBuilder Builder { get; set; }

        public GeneratorDirector(IGeneratorBuilder builder)
        {
            Builder = builder;
        }
        public GeneratedText CreateArticle(List<string> input)
        {
            Builder.StartDocument();
            foreach(string line in input)
            {
                Builder.AddLine();
                Builder.AddParagraph(line);
            }
            Builder.EndDocument();
            return Builder.GetGeneratedText(); 
        }
        public GeneratedText CreateBlog(List<string> input)
        {
            Builder.StartDocument();
            foreach (string line in input)
            {
                Builder.AddLine();
                Builder.AddLine();
                Builder.AddLine();
                Builder.AddParagraph(line);
            }
            Builder.EndDocument();
            return Builder.GetGeneratedText();
        }

    }
}

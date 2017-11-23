using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTest
{
    class Program
    {
        static void DisplayList(List<string> list)
        {
            foreach(string line in list)
            {
                Console.WriteLine(line);
            }
        }
        static void Main(string[] args)
        {
            List<string> text = new List<string>() { "Arka", "Gdynia", "Kurwa", "Swinia" };
            //DisplayList(text);
            GeneratorDirector director = new GeneratorDirector(new PlainTextGeneratorBuilder());
            //DisplayList(director.CreateArticle(text).Text);
            director.CreateArticle(text);
            //Console.WriteLine();
             DisplayList(director.CreateBlog(text).Text);


        }
    }
}

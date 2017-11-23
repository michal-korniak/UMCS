using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositAndTemplatePattern
{
    public abstract class SchoolSerialization
    {
        public void SerializeObject(ISchoolComponent component, string outFileName)
        {
            string serializationString = Serialize(component);
            string extension = GetExtension();
            SaveToFile(outFileName,extension,serializationString);
        }

        protected abstract string Serialize(ISchoolComponent component);
        protected abstract string GetExtension();

        private void SaveToFile(string fileName, string extension, string content)
        {
            string path = fileName + "." + extension;
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.Write(content);
            }
        }


    }
}

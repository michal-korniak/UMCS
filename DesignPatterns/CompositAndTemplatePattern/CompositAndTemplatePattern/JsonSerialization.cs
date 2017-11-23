using System.Text;

namespace CompositAndTemplatePattern
{
    public class JsonSerialization : SchoolSerialization
    {

        protected override string Serialize(ISchoolComponent component)
        {
            var builder = new StringBuilder();
            if (component is SchoolComposite)
            {

                var schoolComposite = (SchoolComposite) component;
                builder.Append($"\"{component.Name}\":");
                builder.AppendLine();
                builder.AppendLine("{");
                for (int i = 0; i < schoolComposite.CountChild(); ++i)
                {
                    builder.Append(Serialize(schoolComposite.GetChild(i)));
                    
                }

                builder.AppendLine("},");
            }
            else
            {
                var schoolLeaf = (SchoolLeaf) component;
                builder.Append($"\"{schoolLeaf.Title}\":\"{schoolLeaf.Name}\"");
                builder.AppendLine();
            }
            
            return builder.ToString();
        }

        protected override string GetExtension()
        {
            return "json";
        }
    }
}
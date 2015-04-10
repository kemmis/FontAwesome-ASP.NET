using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace FontAwesome.Parser
{
    public class Parser
    {
        public List<Icon> Parse(string filePath)
        {
            var input = new StringReader(File.ReadAllText(filePath));
            var desserializer = new Deserializer();
            var root = desserializer.Deserialize<Rootobject>(input);
            return root.icons.OrderBy(i=>i.name).ToList();
        } 
    }
}

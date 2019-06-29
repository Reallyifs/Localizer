using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Localizer
{
    static class DataContainer
    {
        public static JArray json = (JArray) JsonConvert.DeserializeObject(json_text);
        public static Dictionary<string, string> dict = new Dictionary<string, string>();

        static DataContainer()
        {
            foreach (JToken jt in json)
                dict.Add((string)jt["origin"], (string)jt["loc"]);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilderPkmn
{
    public class Pokemon
    {
        public string Name { get; set; }
        public Type Type1 { get; set; }
        public Type Type2 { get; set; }
        public Pokemon()
        {
            this.Type1 = Type.GetType("none");
            this.Type2 = Type.GetType("none");
        }
        public Pokemon(string name)
        {
            this.Name = name;
            this.Type1 = Type.GetType("none");
            this.Type2 = Type.GetType("none");
        }

        public Dictionary<string, float> GetWeakness()
        {
            Dictionary<string, float> type1Weakness = Type1.GetWeaknesses();
            Dictionary<string, float> type2Weakness = Type2.GetWeaknesses();
            Dictionary<string, float> result = new Dictionary<string, float>();
            foreach (KeyValuePair<string, float> modifier in type1Weakness)
            {
                result.Add(modifier.Key, type1Weakness[modifier.Key] * type2Weakness[modifier.Key]);
            }
            return result;
        }


    }
}

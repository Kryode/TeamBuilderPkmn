using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilderPkmn
{
    public class Pokemon
    {
        public Type Type1 { get; set; }
        public Type Type2 { get; set; }
        public Pokemon()
        {
            this.Type1 = Type.GetType(Type.types.none);
            this.Type2 = Type.GetType(Type.types.none);
        }
        
        public Dictionary<Type.types, float> GetWeakness()
        {
            Dictionary<Type.types, float> type1Weakness = Type1.GetWeaknesses();
            Dictionary<Type.types, float> type2Weakness = Type2.GetWeaknesses();
            Dictionary<Type.types, float> result = new Dictionary<Type.types, float>()    ;
            foreach (KeyValuePair<Type.types, float> modifier in type1Weakness)
            {
                result.Add(modifier.Key,type1Weakness[modifier.Key] * type2Weakness[modifier.Key]);
            }
            return result;
        }


    }
}

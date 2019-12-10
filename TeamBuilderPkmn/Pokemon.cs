using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilderPkmn
{
    class Pokemon
    {
        public Type Type1 { get; set; }
        public Type Type2 { get; set; }
        public Pokemon()
        {
            this.Type1 = Type.SetType(Type.types.none);
            this.Type2 = Type.SetType(Type.types.none);
        }
        /*
        public void SetType(string type, bool isSecondType = false)
        {
            if (isSecondType)
            {
                switch (type)
                {
                    case "Normal":
                        Type2 = Type.types.Normal;
                        return;
                    case "Fighting":
                        Type2 = Type.types.Fighting;
                        return;
                    case "Flying":
                        Type2 = Type.types.Flying;
                        return;
                    case "Poison":
                        Type2 = Type.types.Poison;
                        return;
                    case "Ground":
                        Type2 = Type.types.Ground;
                        return;
                    case "Rock":
                        Type2 = Type.types.Rock;
                        return;
                    case "Bug":
                        Type2 = Type.types.Bug;
                        return;
                    case "Ghost":
                        Type2 = Type.types.Ghost;
                        return;
                    case "Steel":
                        Type2 = Type.types.Steel;
                        return;
                    case "Fire":
                        Type2 = Type.types.Fire;
                        return;
                    case "Water":
                        Type2 = Type.types.Water;
                        return;
                    case "Grass":
                        Type2 = Type.types.Grass;
                        return;
                    case "Electric":
                        Type2 = Type.types.Electric;
                        return;
                    case "Psychic":
                        Type2 = Type.types.Psychic;
                        return;
                    case "Ice":
                        Type2 = Type.types.Ice;
                        return;
                    case "Dragon":
                        Type2 = Type.types.Dragon;
                        return;
                    case "Dark":
                        Type2 = Type.types.Dark;
                        return;
                    case "Fairy":
                        Type2 = Type.types.Fairy;
                        return;
                    default:
                        Type2 = Type.types.none;
                        return;
                }
            }
            else
            {
                switch (type)
                {
                    case "Normal":
                        Type1 = Type.types.Normal;
                        return;
                    case "Combat":
                        Type1 = Type.types.Fighting;
                        return;
                    case "Vol":
                        Type1 = Type.types.Flying;
                        return;
                    case "Poison":
                        Type1 = Type.types.Poison;
                        return;
                    case "Sol":
                        Type1 = Type.types.Ground;
                        return;
                    case "Roche":
                        Type1 = Type.types.Rock;
                        return;
                    case "Insecte":
                        Type1 = Type.types.Bug;
                        return;
                    case "Spectre":
                        Type1 = Type.types.Ghost;
                        return;
                    case "Acier":
                        Type1 = Type.types.Steel;
                        return;
                    case "Feu":
                        Type1 = Type.types.Fire;
                        return;
                    case "Eau":
                        Type1 = Type.types.Water;
                        return;
                    case "Plante":
                        Type1 = Type.types.Grass;
                        return;
                    case "Electrik":
                        Type1 = Type.types.Electric;
                        return;
                    case "Psy":
                        Type1 = Type.types.Psychic;
                        return;
                    case "Glace":
                        Type1 = Type.types.Ice;
                        return;
                    case "Dragon":
                        Type1 = Type.types.Dragon;
                        return;
                    case "Tenebres":
                        Type1 = Type.types.Dark;
                        return;
                    case "Fee":
                        Type1 = Type.types.Fairy;
                        return;
                    default:
                        Type1 = Type.types.none;
                        return;
                }
            }
        }
        */
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

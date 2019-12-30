using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilderPkmn
{
    public class Type
    {
        public string Name { get; set; }

        public static readonly Type[] TYPES = LoadTypes();

        private readonly static Dictionary<string, float> normalType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",2 },
            {"Flying",1 },
            {"Poison",1 },
            {"Ground",1 },
            {"Rock",1 },
            {"Bug",1 },
            {"Ghost",0 },
            {"Steel",1 },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",1 },
            {"Electric",1 },
            {"Psychic",1 },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> figthingType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",1 },
            {"Flying",2 },
            {"Poison",1 },
            {"Ground",1 },
            {"Rock",0.5f },
            {"Bug",0.5f },
            {"Ghost",1 },
            {"Steel",1 },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",1 },
            {"Electric",1 },
            {"Psychic",2 },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",0.5f },
            {"Fairy",2 }
        };

        private readonly static Dictionary<string, float> flyingType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",0.5f },
            {"Flying",1 },
            {"Poison",1 },
            {"Ground",0 },
            {"Rock",2 },
            {"Bug",0.5f },
            {"Ghost",1 },
            {"Steel",1 },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",0.5f },
            {"Electric",2 },
            {"Psychic",1 },
            {"Ice",2 },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> poisonType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",0.5f },
            {"Flying",1 },
            {"Poison",0.5f },
            {"Ground",2 },
            {"Rock",1 },
            {"Bug",0.5f },
            {"Ghost",1 },
            {"Steel",1 },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",0.5f },
            {"Electric",1 },
            {"Psychic",2 },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",0.5f }
        };

        private readonly static Dictionary<string, float> groundType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",1 },
            {"Flying",1 },
            {"Poison",0.5f },
            {"Ground",1 },
            {"Rock",0.5f},
            {"Bug",1 },
            {"Ghost",1 },
            {"Steel",1 },
            {"Fire",1 },
            {"Water",2 },
            {"Grass",2 },
            {"Electric",0 },
            {"Psychic",1 },
            {"Ice",2 },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> rockType = new Dictionary<string, float> {
            {"Normal",0.5f },
            {"Fighting",2 },
            {"Flying",0.5f },
            {"Poison",0.5f },
            {"Ground",2 },
            {"Rock",1},
            {"Bug",1 },
            {"Ghost",1 },
            {"Steel",2 },
            {"Fire",0.5f},
            {"Water",2 },
            {"Grass",2 },
            {"Electric",1 },
            {"Psychic",1 },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> bugType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",0.5f },
            {"Flying",2 },
            {"Poison",1 },
            {"Ground",0.5f },
            {"Rock",2},
            {"Bug",1 },
            {"Ghost",1 },
            {"Steel",1 },
            {"Fire",2},
            {"Water",1 },
            {"Grass",0.5f },
            {"Electric",1 },
            {"Psychic",1 },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> ghostType = new Dictionary<string, float> {
            {"Normal",0 },
            {"Fighting",0 },
            {"Flying",1 },
            {"Poison",0.5f },
            {"Ground",1 },
            {"Rock",1 },
            {"Bug",0.5f },
            {"Ghost",2 },
            {"Steel",1 },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",1 },
            {"Electric",1 },
            {"Psychic",1 },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",2 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> steelType = new Dictionary<string, float> {
            {"Normal",0.5f },
            {"Fighting",2 },
            {"Flying",0.5f },
            {"Poison",0 },
            {"Ground",2 },
            {"Rock",0.5f },
            {"Bug",0.5f },
            {"Ghost",1 },
            {"Steel",0.5f },
            {"Fire",2 },
            {"Water",1 },
            {"Grass",0.5f },
            {"Electric",1 },
            {"Psychic",0.5f },
            {"Ice",0.5f },
            {"Dragon",0.5f },
            {"Dark",1 },
            {"Fairy",0.5f }
        };

        private readonly static Dictionary<string, float> fireType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",1 },
            {"Flying",1 },
            {"Poison",1 },
            {"Ground",2 },
            {"Rock",2 },
            {"Bug",0.5f },
            {"Ghost",1 },
            {"Steel",0.5f },
            {"Fire",0.5f },
            {"Water",2 },
            {"Grass",0.5f },
            {"Electric",1 },
            {"Psychic",1 },
            {"Ice",0.5f },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",0.5f }
        };

        private readonly static Dictionary<string, float> waterType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",1 },
            {"Flying",1 },
            {"Poison",1 },
            {"Ground",1 },
            {"Rock",1 },
            {"Bug",1 },
            {"Ghost",1 },
            {"Steel",0.5f },
            {"Fire",0.5f },
            {"Water",0.5f },
            {"Grass",2 },
            {"Electric",2 },
            {"Psychic",1 },
            {"Ice",0.5f },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> grassType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",1 },
            {"Flying",2 },
            {"Poison",2 },
            {"Ground",0.5f },
            {"Rock",1},
            {"Bug",2 },
            {"Ghost",1 },
            {"Steel",1 },
            {"Fire",2},
            {"Water",0.5f },
            {"Grass",0.5f },
            {"Electric",0.5f },
            {"Psychic",1 },
            {"Ice",2 },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> electricType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",1 },
            {"Flying",0.5f },
            {"Poison",1 },
            {"Ground",2 },
            {"Rock",1 },
            {"Bug",1 },
            {"Ghost",1 },
            {"Steel",0.5f },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",1 },
            {"Electric",0.5f },
            {"Psychic",1 },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> psychicType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",0.5f },
            {"Flying",1 },
            {"Poison",1 },
            {"Ground",1 },
            {"Rock",1 },
            {"Bug",2 },
            {"Ghost",2 },
            {"Steel",1 },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",1 },
            {"Electric",1 },
            {"Psychic",0.5f },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",2 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> iceType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",2 },
            {"Flying",1 },
            {"Poison",1 },
            {"Ground",1 },
            {"Rock",2 },
            {"Bug",1 },
            {"Ghost",1 },
            {"Steel",2 },
            {"Fire",2 },
            {"Water",1 },
            {"Grass",1 },
            {"Electric",1 },
            {"Psychic",1 },
            {"Ice",0.5f },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> dragonType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",1 },
            {"Flying",1 },
            {"Poison",1 },
            {"Ground",1 },
            {"Rock",1 },
            {"Bug",1 },
            {"Ghost",1 },
            {"Steel",1 },
            {"Fire",0.5f },
            {"Water",0.5f },
            {"Grass",0.5f },
            {"Electric",0.5f },
            {"Psychic",1 },
            {"Ice",2 },
            {"Dragon",2 },
            {"Dark",1 },
            {"Fairy",2 }
        };

        private readonly static Dictionary<string, float> darkType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",2 },
            {"Flying",1 },
            {"Poison",1 },
            {"Ground",1 },
            {"Rock",1 },
            {"Bug",2 },
            {"Ghost",0.5f },
            {"Steel",1 },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",1 },
            {"Electric",1 },
            {"Psychic",0 },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",0.5f },
            {"Fairy",2 }
        };

        private readonly static Dictionary<string, float> fairyType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",0.5f },
            {"Flying",1 },
            {"Poison",2 },
            {"Ground",1 },
            {"Rock",1 },
            {"Bug",0.5f },
            {"Ghost",1 },
            {"Steel",2 },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",1 },
            {"Electric",1 },
            {"Psychic",1 },
            {"Ice",1 },
            {"Dragon",0 },
            {"Dark",0.5f },
            {"Fairy",1 }
        };

        private readonly static Dictionary<string, float> noType = new Dictionary<string, float> {
            {"Normal",1 },
            {"Fighting",1 },
            {"Flying",1 },
            {"Poison",1 },
            {"Ground",1 },
            {"Rock",1 },
            {"Bug",1 },
            {"Ghost",1 },
            {"Steel",1 },
            {"Fire",1 },
            {"Water",1 },
            {"Grass",1 },
            {"Electric",1 },
            {"Psychic",1 },
            {"Ice",1 },
            {"Dragon",1 },
            {"Dark",1 },
            {"Fairy",1 }
        };

        private Type(string name)
        {
            this.Name = name;
        }

        public static Type GetType(string GetType)
        {
            foreach (Type type in TYPES)
            {
                if(type.Name == GetType)
                {
                    
                    return type;
                }
            }
            return new Type("none");
        }

        public Dictionary<string, float> GetWeaknesses()
        {
            switch (Name)
            {
                case "Normal":
                    return normalType;
                case "Fighting":
                    return figthingType;
                case "Flying":
                    return flyingType;
                case "Poison":
                    return poisonType;
                case "Ground":
                    return groundType;
                case "Rock":
                    return rockType;
                case "Bug":
                    return bugType;
                case "Ghost":
                    return ghostType;
                case "Steel":
                    return steelType;
                case "Fire":
                    return fireType;
                case "Water":
                    return waterType;
                case "Grass":
                    return grassType;
                case "Electric":
                    return electricType;
                case "Psychic":
                    return psychicType;
                case "Ice":
                    return iceType;
                case "Dragon":
                    return dragonType;
                case "Dark":
                    return darkType;
                case "Fairy":
                    return fairyType;
                case "none":
                default:
                    return noType;
            }
        }

        private static Type[] LoadTypes()
        {
            return new Type[]
            {
                new Type("none"),
                new Type("Normal"),
                new Type("Fighting"),
                new Type("Flying"),
                new Type("Poison"),
                new Type("Ground"),
                new Type("Rock"),
                new Type("Bug"),
                new Type("Ghost"),
                new Type("Steel"),
                new Type("Fire"),
                new Type("Water"),
                new Type("Grass"),
                new Type("Electric"),
                new Type("Psychic"),
                new Type("Ice"),
                new Type("Dragon"),
                new Type("Dark"),
                new Type("Fairy")
            };
        }

        public static List<Type> GetListPossibleTypes(Type excludedType,bool isNoneOk= true)
        {
            List<Type> types = TYPES.ToList();
            types.Remove(excludedType);
            if (!isNoneOk)
            {
                types.Remove(GetType("none"));
            }
            return types;
        }
    }



}

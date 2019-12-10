using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilderPkmn
{
    public class Type
    {
        public types Name;

        public string StringType { get; set; }

        public static readonly Type[] TYPES = LoadTypes();

        public enum types
        {
            Normal,
            Fighting,
            Flying,
            Poison,
            Ground,
            Rock,
            Bug,
            Ghost,
            Steel,
            Fire,
            Water,
            Grass,
            Electric,
            Psychic,
            Ice,
            Dragon,
            Dark,
            Fairy,
            none
        }

        private static Dictionary<types, float> normalType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,2 },
            {types.Flying,1 },
            {types.Poison,1 },
            {types.Ground,1 },
            {types.Rock,1 },
            {types.Bug,1 },
            {types.Ghost,0 },
            {types.Steel,1 },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,1 },
            {types.Electric,1 },
            {types.Psychic,1 },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> figthingType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,1 },
            {types.Flying,2 },
            {types.Poison,1 },
            {types.Ground,1 },
            {types.Rock,0.5f },
            {types.Bug,0.5f },
            {types.Ghost,1 },
            {types.Steel,1 },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,1 },
            {types.Electric,1 },
            {types.Psychic,2 },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,0.5f },
            {types.Fairy,2 }
        };

        private static Dictionary<types, float> flyingType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,0.5f },
            {types.Flying,1 },
            {types.Poison,1 },
            {types.Ground,0 },
            {types.Rock,2 },
            {types.Bug,0.5f },
            {types.Ghost,1 },
            {types.Steel,1 },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,0.5f },
            {types.Electric,2 },
            {types.Psychic,1 },
            {types.Ice,2 },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> poisonType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,0.5f },
            {types.Flying,1 },
            {types.Poison,0.5f },
            {types.Ground,2 },
            {types.Rock,1 },
            {types.Bug,0.5f },
            {types.Ghost,1 },
            {types.Steel,1 },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,0.5f },
            {types.Electric,1 },
            {types.Psychic,2 },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,0.5f }
        };

        private static Dictionary<types, float> groundType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,1 },
            {types.Flying,1 },
            {types.Poison,0.5f },
            {types.Ground,1 },
            {types.Rock,0.5f},
            {types.Bug,1 },
            {types.Ghost,1 },
            {types.Steel,1 },
            {types.Fire,1 },
            {types.Water,2 },
            {types.Grass,2 },
            {types.Electric,0 },
            {types.Psychic,1 },
            {types.Ice,2 },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> rockType = new Dictionary<types, float> {
            {types.Normal,0.5f },
            {types.Fighting,2 },
            {types.Flying,0.5f },
            {types.Poison,0.5f },
            {types.Ground,2 },
            {types.Rock,1},
            {types.Bug,1 },
            {types.Ghost,1 },
            {types.Steel,2 },
            {types.Fire,0.5f},
            {types.Water,2 },
            {types.Grass,2 },
            {types.Electric,1 },
            {types.Psychic,1 },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> bugType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,0.5f },
            {types.Flying,2 },
            {types.Poison,1 },
            {types.Ground,0.5f },
            {types.Rock,2},
            {types.Bug,1 },
            {types.Ghost,1 },
            {types.Steel,1 },
            {types.Fire,2},
            {types.Water,1 },
            {types.Grass,0.5f },
            {types.Electric,1 },
            {types.Psychic,1 },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> ghostType = new Dictionary<types, float> {
            {types.Normal,0 },
            {types.Fighting,0 },
            {types.Flying,1 },
            {types.Poison,0.5f },
            {types.Ground,1 },
            {types.Rock,1 },
            {types.Bug,0.5f },
            {types.Ghost,2 },
            {types.Steel,1 },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,1 },
            {types.Electric,1 },
            {types.Psychic,1 },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,2 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> steelType = new Dictionary<types, float> {
            {types.Normal,0.5f },
            {types.Fighting,2 },
            {types.Flying,0.5f },
            {types.Poison,0 },
            {types.Ground,2 },
            {types.Rock,0.5f },
            {types.Bug,0.5f },
            {types.Ghost,1 },
            {types.Steel,0.5f },
            {types.Fire,2 },
            {types.Water,1 },
            {types.Grass,0.5f },
            {types.Electric,1 },
            {types.Psychic,0.5f },
            {types.Ice,0.5f },
            {types.Dragon,0.5f },
            {types.Dark,1 },
            {types.Fairy,0.5f }
        };

        private static Dictionary<types, float> fireType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,1 },
            {types.Flying,1 },
            {types.Poison,1 },
            {types.Ground,2 },
            {types.Rock,2 },
            {types.Bug,0.5f },
            {types.Ghost,1 },
            {types.Steel,0.5f },
            {types.Fire,0.5f },
            {types.Water,2 },
            {types.Grass,0.5f },
            {types.Electric,1 },
            {types.Psychic,1 },
            {types.Ice,0.5f },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,0.5f }
        };

        private static Dictionary<types, float> waterType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,1 },
            {types.Flying,1 },
            {types.Poison,1 },
            {types.Ground,1 },
            {types.Rock,1 },
            {types.Bug,1 },
            {types.Ghost,1 },
            {types.Steel,0.5f },
            {types.Fire,0.5f },
            {types.Water,0.5f },
            {types.Grass,2 },
            {types.Electric,2 },
            {types.Psychic,1 },
            {types.Ice,0.5f },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> grassType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,1 },
            {types.Flying,2 },
            {types.Poison,2 },
            {types.Ground,0.5f },
            {types.Rock,1},
            {types.Bug,2 },
            {types.Ghost,1 },
            {types.Steel,1 },
            {types.Fire,2},
            {types.Water,0.5f },
            {types.Grass,0.5f },
            {types.Electric,0.5f },
            {types.Psychic,1 },
            {types.Ice,2 },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> electricType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,1 },
            {types.Flying,0.5f },
            {types.Poison,1 },
            {types.Ground,2 },
            {types.Rock,1 },
            {types.Bug,1 },
            {types.Ghost,1 },
            {types.Steel,0.5f },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,1 },
            {types.Electric,0.5f },
            {types.Psychic,1 },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> psychicType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,0.5f },
            {types.Flying,1 },
            {types.Poison,1 },
            {types.Ground,1 },
            {types.Rock,1 },
            {types.Bug,2 },
            {types.Ghost,2 },
            {types.Steel,1 },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,1 },
            {types.Electric,1 },
            {types.Psychic,0.5f },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,2 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> iceType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,2 },
            {types.Flying,1 },
            {types.Poison,1 },
            {types.Ground,1 },
            {types.Rock,2 },
            {types.Bug,1 },
            {types.Ghost,1 },
            {types.Steel,2 },
            {types.Fire,2 },
            {types.Water,1 },
            {types.Grass,1 },
            {types.Electric,1 },
            {types.Psychic,1 },
            {types.Ice,0.5f },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> dragonType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,1 },
            {types.Flying,1 },
            {types.Poison,1 },
            {types.Ground,1 },
            {types.Rock,1 },
            {types.Bug,1 },
            {types.Ghost,1 },
            {types.Steel,1 },
            {types.Fire,0.5f },
            {types.Water,0.5f },
            {types.Grass,0.5f },
            {types.Electric,0.5f },
            {types.Psychic,1 },
            {types.Ice,2 },
            {types.Dragon,2 },
            {types.Dark,1 },
            {types.Fairy,2 }
        };

        private static Dictionary<types, float> darkType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,2 },
            {types.Flying,1 },
            {types.Poison,1 },
            {types.Ground,1 },
            {types.Rock,1 },
            {types.Bug,2 },
            {types.Ghost,0.5f },
            {types.Steel,1 },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,1 },
            {types.Electric,1 },
            {types.Psychic,0 },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,0.5f },
            {types.Fairy,2 }
        };

        private static Dictionary<types, float> fairyType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,0.5f },
            {types.Flying,1 },
            {types.Poison,2 },
            {types.Ground,1 },
            {types.Rock,1 },
            {types.Bug,0.5f },
            {types.Ghost,1 },
            {types.Steel,2 },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,1 },
            {types.Electric,1 },
            {types.Psychic,1 },
            {types.Ice,1 },
            {types.Dragon,0 },
            {types.Dark,0.5f },
            {types.Fairy,1 }
        };

        private static Dictionary<types, float> noType = new Dictionary<types, float> {
            {types.Normal,1 },
            {types.Fighting,1 },
            {types.Flying,1 },
            {types.Poison,1 },
            {types.Ground,1 },
            {types.Rock,1 },
            {types.Bug,1 },
            {types.Ghost,1 },
            {types.Steel,1 },
            {types.Fire,1 },
            {types.Water,1 },
            {types.Grass,1 },
            {types.Electric,1 },
            {types.Psychic,1 },
            {types.Ice,1 },
            {types.Dragon,1 },
            {types.Dark,1 },
            {types.Fairy,1 }
        };

        private Type(types type)
        {
            this.Name = type;
            this.StringType = Name.ToString();
        }

        static public Type SetType(types setType)
        {
            foreach (Type type in TYPES)
            {
                if(type.Name == setType)
                {
                    return type;
                }
            }
            return new Type(types.none);
        }

        public Dictionary<types, float> GetWeaknesses()
        {
            switch (Name)
            {
                case types.Normal:
                    return normalType;
                case types.Fighting:
                    return figthingType;
                case types.Flying:
                    return flyingType;
                case types.Poison:
                    return poisonType;
                case types.Ground:
                    return groundType;
                case types.Rock:
                    return rockType;
                case types.Bug:
                    return bugType;
                case types.Ghost:
                    return ghostType;
                case types.Steel:
                    return steelType;
                case types.Fire:
                    return fireType;
                case types.Water:
                    return waterType;
                case types.Grass:
                    return grassType;
                case types.Electric:
                    return electricType;
                case types.Psychic:
                    return psychicType;
                case types.Ice:
                    return iceType;
                case types.Dragon:
                    return dragonType;
                case types.Dark:
                    return darkType;
                case types.Fairy:
                    return fairyType;
                case types.none:
                default:
                    return noType;
            }
        }

        private static Type[] LoadTypes()
        {
            return new Type[] 
            {
                new Type(types.Normal),
                new Type(types.Fighting),
                new Type(types.Flying),
                new Type(types.Poison),
                new Type(types.Ground),
                new Type(types.Rock),
                new Type(types.Bug),
                new Type(types.Ghost),
                new Type(types.Steel),
                new Type(types.Fire),
                new Type(types.Water),
                new Type(types.Grass),
                new Type(types.Electric),
                new Type(types.Psychic),
                new Type(types.Ice),
                new Type(types.Dragon),
                new Type(types.Dark),
                new Type(types.Fairy)
            };
        }
    }



}

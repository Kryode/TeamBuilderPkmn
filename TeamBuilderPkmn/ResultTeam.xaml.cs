using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TeamBuilderPkmn
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class ResultTeam : Window
    {
        public ResultTeam(Pokemon[] pokemons)
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    Label label = new Label();
                    
                    if(i == 0)
                    {
                        label.Content = Type.TYPES[j].Name;
                    }

                    else if (i == 7)
                    {
                        if (j > 0)
                        {
                            float average = 0f;
                            for (int k = 0; k < 6; k++)
                            {
                                average += pokemons[k].GetWeakness().Values.ElementAt(j - 1);
                            }
                            average /= 6f;
                            label.Content = average.ToString(); 
                        }
                        else
                        {
                            label.Content = "average";
                        }
                    }

                    else if(j == 0)
                    {
                        label.Content = pokemons[i-1].Type1.Name + " / " + pokemons[i-1].Type2.Name;
                    }

                    else
                    {
                        float weakness = pokemons[i - 1].GetWeakness().Values.ElementAt(j-1);
                        label.Content = weakness.ToString();
                    }
                    label.HorizontalAlignment = HorizontalAlignment.Center;
                    Grid.SetColumn(label, i);
                    Grid.SetRow(label, j);
                    GridResult.Children.Add(label);
                }
            }
        }
    }
}

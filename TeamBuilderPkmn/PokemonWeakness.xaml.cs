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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TeamBuilderPkmn
{
    /// <summary>
    /// Logique d'interaction pour PokemonWeakness.xaml
    /// </summary>
    public partial class PokemonWeakness : Window
    {
        public List<Type> TypesList { get; set; }
        public Pokemon pkmn = new Pokemon();
        public PokemonWeakness()
        {
            InitializeComponent();
            DataContext = this;
            TypesList = Type.GetListPossibleTypes(Type.GetType("none"));
            typeTwo.ItemsSource = TypesList;
            typeTwo.DisplayMemberPath = "Name";
            typeTwo.SelectedValuePath = "Type.GetType(Name)";
            typeTwo.SelectionChanged += typeTwo_SelectionChanged;

            typeOne.ItemsSource = TypesList;
            typeOne.DisplayMemberPath = "Name";
            typeOne.SelectedValuePath = "Type.GetType(Name)";
            typeOne.SelectionChanged += TypeOne_SelectionChanged;
        }

        private void TypeOne_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            pkmn.Type1 = (Type)box.SelectedItem;
            PrintWeaknesses(pkmn);
            typeTwo.ItemsSource = Type.GetListPossibleTypes(pkmn.Type1, false);
        }

        private void typeTwo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            pkmn.Type2 = (Type)box.SelectedItem;
            typeOne.ItemsSource = TypesList;
            PrintWeaknesses(pkmn);
            typeOne.ItemsSource = Type.GetListPossibleTypes(pkmn.Type2, false);
        }

        private void PrintWeaknesses(Pokemon pkmn)
        {
            EmptyEntry();
            Dictionary<string, float> weaknesses = pkmn.GetWeakness();
            foreach (KeyValuePair<string, float> type in weaknesses)
            {
                switch (type.Value)
                {
                    case 0:
                        EntryZero.Content += type.Key + " ";
                        break;
                    case 0.25f:
                        EntryQuart.Content += type.Key + " ";
                        break;
                    case 0.5f:
                        EntryHalf.Content += type.Key + " ";
                        break;
                    case 1:
                        EntryOne.Content += type.Key + " ";
                        break;
                    case 2:
                        EntryDouble.Content += type.Key + " ";
                        break;
                    case 4:
                        EntryQuart.Content += type.Key + " ";
                        break;
                    default:
                        break;
                }
            }
        }


        private void EmptyEntry()
        {
            EntryZero.Content = "";
            EntryQuart.Content = "";
            EntryHalf.Content = "";
            EntryOne.Content = "";
            EntryDouble.Content = "";
            EntryQuad.Content = "";
        }
    }
}


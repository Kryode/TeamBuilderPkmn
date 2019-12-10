using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Type> TypesList { get; set; }
        public Pokemon pkmn = new Pokemon();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            TypesList = new List<Type>();
            TypesList.Add(Type.SetType(Type.types.none));
            TypesList.AddRange(Type.TYPES); 

            typeOne.ItemsSource = TypesList;
            typeOne.DisplayMemberPath = "StringType";
            typeOne.SelectedValuePath = "Name";
            typeOne.SelectionChanged += TypeOne_SelectionChanged;

            typeTwo.ItemsSource = TypesList;
            typeTwo.DisplayMemberPath = "StringType";
            typeTwo.SelectedValuePath = "Name";
            typeTwo.SelectionChanged += typeTwo_SelectionChanged;

        }

        private void TypeOne_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            pkmn.Type1 = Type.SetType((Type.types)box.SelectedValue);
            PrintWeaknesses(pkmn);
            TypesList = Type.TYPES.ToList();
            TypesList.Remove(Type.SetType((Type.types)box.SelectedValue));
            typeTwo.ItemsSource = TypesList;
        }

        private void typeTwo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            pkmn.Type2 = Type.SetType((Type.types)box.SelectedValue);
            PrintWeaknesses(pkmn);
            TypesList = Type.TYPES.ToList();
            TypesList.Remove(Type.SetType((Type.types)box.SelectedValue));
            typeOne.ItemsSource = TypesList;
        }

        private void PrintWeaknesses(Pokemon pkmn)
        {
            EmptyEntry();
            Dictionary<Type.types, float> weaknesses = pkmn.GetWeakness();
            foreach (KeyValuePair<Type.types,float> type in weaknesses)
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

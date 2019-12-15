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

            TypesList = Type.TYPES.ToList();
            typeTwo.ItemsSource = TypesList;
            typeTwo.DisplayMemberPath = "StringType";
            typeTwo.SelectedValuePath = "Name";
            typeTwo.SelectionChanged += typeChanged;

            TypesList.Remove(Type.GetType(Type.types.none));
            typeOne.ItemsSource = TypesList;
            typeOne.DisplayMemberPath = "StringType";
            typeOne.SelectedValuePath = "Name";
            typeOne.SelectionChanged += typeChanged;
        }

        private void typeChanged(object sender, SelectionChangedEventArgs args)
        {
            ComboBox box = (ComboBox)args.Source;
            if(box.Name == "typeOne")
            {
                pkmn.Type1 = Type.GetType((Type.types)box.SelectedValue);
                typeTwo.ItemsSource = Type.GetListPossibleTypes(pkmn.Type1);
            }
            else
            {
                pkmn.Type2 = Type.GetType((Type.types)box.SelectedValue);
                typeOne.ItemsSource = Type.GetListPossibleTypes(pkmn.Type2,false);
            }
            PrintWeaknesses(pkmn);
        }

        private void PrintWeaknesses(Pokemon pkmn)
        {
            EmptyEntries();
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
                        EntryQuad.Content += type.Key + " ";
                        break;
                    default:
                        break;
                }
            }
        }
        private void EmptyEntries()
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

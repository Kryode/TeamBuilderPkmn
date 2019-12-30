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
            typeTwo.DisplayMemberPath = "Name";
            typeTwo.SelectedValuePath = "Name";
            typeTwo.SelectionChanged += TypeChanged;

            TypesList.Remove(Type.GetType("none"));
            typeOne.ItemsSource = TypesList;
            typeOne.DisplayMemberPath = "Name";
            typeOne.SelectedValuePath = "Name";
            typeOne.SelectionChanged += TypeChanged;
        }

        private void TypeChanged(object sender, SelectionChangedEventArgs args)
        {
            ComboBox box = (ComboBox)args.Source;
            if(box.Name == "typeOne")
            {
                pkmn.Type1 = Type.GetType(box.Text);
                typeTwo.ItemsSource = Type.GetListPossibleTypes(pkmn.Type1);
            }
            else
            {
                pkmn.Type2 = Type.GetType(box.Text);
                typeOne.ItemsSource = Type.GetListPossibleTypes(pkmn.Type2,false);
            }
            PrintWeaknesses(pkmn);
        }

        private void PrintWeaknesses(Pokemon pkmn)
        {
            EmptyEntries();
            Dictionary<string, float> weaknesses = pkmn.GetWeakness();
            foreach (KeyValuePair<string,float> type in weaknesses)
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

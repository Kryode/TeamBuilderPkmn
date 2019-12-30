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
    /// Logique d'interaction pour TeamForm.xaml
    /// </summary>
    public partial class TeamForm : Window
    {
        public List<Type> TypesList { get; set; }
        public ComboBox[] ComboBoxes { get; set; }
        public Pokemon[] Pkmns { get; set; }

        public TeamForm()
        {
            InitializeComponent();
            DataContext = this;
            ComboBoxes = new ComboBox[] {
                pkmn1Type1,
                pkmn1Type2,
                pkmn2Type1,
                pkmn2Type2,
                pkmn3Type1,
                pkmn3Type2,
                pkmn4Type1,
                pkmn4Type2,
                pkmn5Type1,
                pkmn5Type2,
                pkmn6Type1,
                pkmn6Type2
            };

            Pkmns = new Pokemon[]
            {
                new Pokemon("pkmn1"),
                new Pokemon("pkmn2"),
                new Pokemon("pkmn3"),
                new Pokemon("pkmn4"),
                new Pokemon("pkmn5"),
                new Pokemon("pkmn6")
            };

            TypesList = Type.TYPES.ToList();
            
            foreach (ComboBox cb in ComboBoxes)
            {
                cb.ItemsSource = TypesList;
                cb.DisplayMemberPath = "Name";
                cb.SelectedValuePath = "Name";
                cb.SelectionChanged += TypeChanged;
            }
            
        }

        //private RoutedEventHandler SendResult()
        //{
        //    throw new NotImplementedException();
        //}

        private void SendResult(object sender, RoutedEventArgs args)
        {
            ResultTeam resultTeam = new ResultTeam(Pkmns);
            resultTeam.Show();
            this.Close();
            //this.IsEnabled = false;
        }

        private void TypeChanged(object sender, SelectionChangedEventArgs args)
        {
            ComboBox comboBox = (ComboBox)args.Source;
            int cbIndex = 0;

            while (!comboBox.Equals(ComboBoxes[cbIndex]))
            {
                cbIndex++;
            }
            if (cbIndex % 2 == 0)
            {
                Pkmns[cbIndex/2].Type1 = (Type)comboBox.SelectedItem;
                ComboBoxes[cbIndex+1].ItemsSource = Type.GetListPossibleTypes(Pkmns[cbIndex/2].Type1);
                if(Pkmns[cbIndex/2].Type1 == Type.GetType("none"))
                {
                    ComboBoxes[cbIndex + 1].SelectedValue = Type.GetType("none");
                    ComboBoxes[cbIndex + 1].IsEnabled = false;
                }
                else
                {
                    ComboBoxes[cbIndex + 1].IsEnabled = true;
                }
            }
            else
            {
                Pkmns[cbIndex / 2].Type2 = (Type)comboBox.SelectedItem;
                ComboBoxes[cbIndex - 1].ItemsSource = Type.GetListPossibleTypes(Pkmns[cbIndex / 2].Type2);
            }
        }
    }
}

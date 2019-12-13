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
        public ComboBox[] comboBoxes { get; set; }
        public Pokemon[] pkmns { get; set; }

        public TeamForm()
        {
            InitializeComponent();
            DataContext = this;
            comboBoxes = new ComboBox[] {
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

            pkmns = new Pokemon[]
            {
                new Pokemon(),
                new Pokemon(),
                new Pokemon(),
                new Pokemon(),
                new Pokemon(),
                new Pokemon()
            };

            TypesList = Type.TYPES.ToList();
            
            foreach (ComboBox cb in comboBoxes)
            {
                cb.ItemsSource = TypesList;
                cb.DisplayMemberPath = "StringType";
                cb.SelectedValuePath = "Name";
                cb.SelectionChanged += typeChanged;
            }

            
        }

        public void typeChanged(object sender, SelectionChangedEventArgs args)
        {
            ComboBox comboBox = (ComboBox)args.Source;
            int cbIndex = 0;

            while (!comboBox.Equals(comboBoxes[cbIndex]))
            {
                cbIndex++;
            }
            if (cbIndex % 2 == 0)
            {
                pkmns[cbIndex/2].Type1 = Type.GetType((Type.types)comboBox.SelectedValue);
                comboBoxes[cbIndex+1].ItemsSource = Type.GetListPossibleTypes(pkmns[cbIndex/2].Type1);
                if(pkmns[cbIndex/2].Type1 == Type.GetType(Type.types.none))
                {
                    comboBoxes[cbIndex + 1].SelectedValue = Type.GetType(Type.types.none);
                    comboBoxes[cbIndex + 1].IsEnabled = false;
                }
                else
                {
                    comboBoxes[cbIndex + 1].IsEnabled = true;
                }
            }
            else
            {
                pkmns[cbIndex / 2].Type2 = Type.GetType((Type.types)comboBox.SelectedValue);
                comboBoxes[cbIndex - 1].ItemsSource = Type.GetListPossibleTypes(pkmns[cbIndex / 2].Type2);
            }
        }
    }
}

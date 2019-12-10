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
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            TypesList = new List<Type>();
            TypesList.Add(Type.SetType(Type.types.none));
            TypesList.AddRange(Type.TYPES); 

            typeOne.ItemsSource = TypesList;
            typeOne.DisplayMemberPath = "StringType";

            typeTwo.ItemsSource = TypesList;
            typeTwo.DisplayMemberPath = "StringType";

        }
    }
}

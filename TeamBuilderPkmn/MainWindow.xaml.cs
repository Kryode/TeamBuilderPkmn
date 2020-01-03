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
        public MainWindow()
        {
            InitializeComponent();    
        }

        private void GoToTeamWeaknesses(object sender, RoutedEventArgs args)
        {
            TeamForm teamForm = new TeamForm();
            teamForm.Show();
            this.Close();
        }

        private void Quit(object sender, RoutedEventArgs args)
        {
            this.Close();
        }
    }
}

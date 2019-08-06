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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_menu_test
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        bool StateClosed = true;

        public Page01 p1;
        public Page02 p2;

        public MainWindow()
        {
            InitializeComponent();

            p1 = new Page01();
            p2 = new Page02();

            MainFrame.Content = p1;        

        }


        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (StateClosed)
            {
                Storyboard sb = this.FindResource("OpenMenu") as Storyboard;
                sb.Begin();
            }
            else
            {
                Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
                sb.Begin();
            }

            StateClosed = !StateClosed;
        }

        private void ButtonP1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = p1;

            p1.gm1.qntMadeira = p2.gi1.qntMadeira;
            p1.gm1.qntPedra = p2.gi1.qntPedra;

            Button_01.IsEnabled = false;
            Button_02.IsEnabled = true;

        }

        private void ButtonP2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = p2;

            p2.gi1.qntMadeira = p1.gm1.qntMadeira;
            p2.gi1.qntPedra = p1.gm1.qntPedra;

            p2.gi1.AtualizaInv();

            Button_01.IsEnabled = true;
            Button_02.IsEnabled = false;
        }
    }
}

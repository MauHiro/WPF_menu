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

namespace WPF_menu_test
{
    /// <summary>
    /// Interação lógica para Page02.xam
    /// </summary>
    public partial class Page02 : Page
    {
        public GeraItem gi1;

        public Page02()
        {
            InitializeComponent();

            gi1 = new GeraItem(TXTpedra, TXTmadeira, TXTmachado, BT_CR_axe, CR_axe);
        }

        private void BT_CR_axe_Click(object sender, RoutedEventArgs e)
        {
            gi1.CriaItem();
        }

    }
}

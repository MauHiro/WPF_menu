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
    /// Interação lógica para Page01.xam
    /// </summary>
    public partial class Page01 : Page
    {        
        //private BlocoEntulho be1;
        public GeraMaterial gm1;

        public Page01()
        {
            InitializeComponent();

            //be1 = new BlocoEntulho();
            gm1 = new GeraMaterial(new BlocoEntulho(), TXTmensagem);
        }

        private void BTentulho_Click(object sender, RoutedEventArgs e)
        {
          gm1.CriaMaterial();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF_menu_test
{
    public class GeraItem
    {
        public int qntMadeira;
        public int qntPedra;
        public int qntMachado;

        public TextBlock TxtPedra { get; set; }
        public TextBlock TxtMadeira { get; set; }
        public TextBlock TxtMachado { get; set; }
        public Button BtnMachado { get; set; }
        public Grid GridMachado { get; set; }


        public GeraItem(TextBlock _txtPedra, TextBlock _txtMadeira, TextBlock _txtMachado, Button _btnMachado, Grid _gridMachado)
        {
            TxtPedra = _txtPedra;
            TxtMadeira = _txtMadeira;
            TxtMachado = _txtMachado;
            BtnMachado = _btnMachado;
            GridMachado = _gridMachado;
        }

        public void CriaItem()
        {
            if (qntMadeira >= 1 && qntPedra >= 1)
            {
                qntPedra--;
                qntMadeira--;
                qntMachado++;

                TxtMachado.Text = qntMachado.ToString();
                TxtMadeira.Text = qntMadeira.ToString();
                TxtPedra.Text = qntPedra.ToString();

                if (qntMadeira < 1 || qntPedra < 1)
                {
                    BtnMachado.IsEnabled = false;
                }
            }
        }

        public void AtualizaInv()
        {
            TxtMadeira.Text = qntMadeira.ToString();
            TxtPedra.Text = qntPedra.ToString();

            if (qntMadeira >= 1 && qntPedra >= 1)
            {
                GridMachado.Visibility = Visibility.Visible;
                BtnMachado.IsEnabled = true;
            }

        }

    }
}

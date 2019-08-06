using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_menu_test
{
    public class GeraMaterial
    {
        public int qntMadeira;
        public int qntPedra;

        public BlocoEntulho Bloco { get; set; }
        public TextBox TextMensagem { get; set; }

        Random ranDrop;

        //to do: Criar metodo construtor obrigando inserir o paramentro bloco

        public GeraMaterial(BlocoEntulho _bloco, TextBox _textMensagem)
        {
            ranDrop = new Random();
            Bloco = _bloco;
            TextMensagem = _textMensagem;
        }

        private int Randomisa(int de, int ate)
        {
            return ranDrop.Next(de, ate);
        }

        public void CriaMaterial()
        {
            Bloco.HP--;

            if(Bloco.HP == 0 && Randomisa(1, 3) == 1)
            {
                this.qntMadeira++;
                TextMensagem.Text += "Madeira: " + this.qntMadeira + "\n";
                Bloco.HP = 3;
            }
            else if (Bloco.HP == 0)
            {
                this.qntPedra++;
                TextMensagem.Text += "Pedra: " + this.qntPedra + "\n";
                Bloco.HP = 3;
            }

        }
    }
}

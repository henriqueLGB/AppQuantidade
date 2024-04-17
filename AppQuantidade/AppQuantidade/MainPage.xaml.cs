using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        //VARIÁVEL COMEÇA COM O VALOR 1
        int quantidade = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Acrescimo(object sender, EventArgs e)
        {
            quantidade++;
            LblQuantidade.Text = quantidade.ToString();
        }

        private void Decrescimo(object sender, EventArgs e)
        {
            //CASO SEJA DIFERENTE DE ZERO ELE EXECUTA AÇÃO
            if(quantidade != 0)
            {
                quantidade--;
                LblQuantidade.Text = quantidade.ToString();
            }
        }
    }
}

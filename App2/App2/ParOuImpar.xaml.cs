using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();

            btExecutar.Clicked += BtExecutar_Clicked;
        }

        private void BtExecutar_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(etValor.Text);
            String resp = "o num " + etValor.Text + " é ";
            if(n%2==0)
            {
                resp += "par";
            }
            else
            {
                resp += "impar";
            }
            lbResp.Text = resp;
        }
    }
}
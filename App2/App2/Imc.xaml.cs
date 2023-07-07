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
	public partial class Imc : ContentPage
	{
		public Imc ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Double a=0, p = 0, imc = 0;
            int i = 0;
            var n = etValorN.Text;

            i = Convert.ToInt32(etValorI.Text);
            p = Convert.ToDouble(etValorP.Text);
            a = Convert.ToDouble(etValorA.Text);

            imc = p / (a * a);
            lbImc.Text = "O IMC de " + n + " com a idade de: " + i +" é : " + imc;
        }
    }
}
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
	public partial class Email : ContentPage
	{
		public Email ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            string[] vetorNome = etValorN.Text.Split(' ');
            string[] vetorSobrenome = etValorS.Text.Split(' ');
            lbEmail.Text = vetorSobrenome[vetorSobrenome.Length - 1].ToLower() + "_" +
               vetorNome[0].ToLower() + "@ufn.edu.br";
        }
    }
}
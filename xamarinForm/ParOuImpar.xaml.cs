using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
            button_executar.Clicked += Button_executar_Clicked;
            button_calculadora.Clicked += Button_calculadora_Clicked;
        }

        private void Button_calculadora_Clicked(object sender, EventArgs e)
        {

            App.Current.MainPage = new Calculadora();

        }

        private void Button_executar_Clicked(object sender, EventArgs e)
        {
            int n =Convert.ToInt32(entry_valor.Text);

            label_resposta.Text = (n % 2 == 0  && n != 0 ? "Par" : (n != 0 ? "Ímpar" : "Nulo") );
        }
    }
}
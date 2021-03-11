using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excercise03.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Excs1 : ContentPage
    {
        public Excs1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.Excs2());
        }
    }
}
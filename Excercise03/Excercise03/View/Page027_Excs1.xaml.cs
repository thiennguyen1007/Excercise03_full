using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excercise03.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page027_Excs1 : ContentPage
    {
        public Page027_Excs1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.Page027_excs2());
        }
    }
}
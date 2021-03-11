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
    public partial class Page30_excs01 : ContentPage
    {
        public Page30_excs01()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.Page30_excs2());
        }
    }
}
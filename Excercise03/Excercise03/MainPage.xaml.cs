using Xamarin.Forms;

namespace Excercise03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.Excs1());
        }

        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.Page027_Excs1());
        }

        private void Button_Clicked_2(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new View.Page30_excs01());
        }
    }
}


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excercise03.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Excs2 : ContentPage
    {
        public Excs2()
        {           
            InitializeComponent();
            img.Source = $"https://images.unsplash.com/photo-1458724338480-79bc7a8352e4?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=750&q=80";
        }
    }
}
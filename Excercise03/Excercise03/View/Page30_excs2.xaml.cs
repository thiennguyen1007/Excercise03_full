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
    public partial class Page30_excs2 : ContentPage
    {
        public Page30_excs2()
        {
            InitializeComponent();
            img.Source =$"https://images.unsplash.com/photo-1615339700936-d74e64fd1d1e?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=334&q=80";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM.ViewModels;

namespace MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendPage : ContentPage
    {
        public FriendPage(FriendViewModel vm)
        {
            InitializeComponent();
            //ViewModel = vm;
            //this.BindingContext = ViewModel;
        }
    }
}
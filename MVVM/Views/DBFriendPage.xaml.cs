using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DBFriendPage : ContentPage
    {
        public DBFriendPage()
        {
            InitializeComponent();
        }
        void SaveFriend(object sender, EventArgs e)
        {
            var friend = (DBFriend)BindingContext;
            if (!String.IsNullOrEmpty(friend.Name))
            {
                App.Database.SaveItem(friend);
            }           
            this.Navigation.PopAsync();
        }
        void DeleteFriend(object sender, EventArgs e)
        {
            var friend = (DBFriend)BindingContext;
            App.Database.DeleteItem(friend.Id);
            this.Navigation.PopAsync();
        }
        void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}
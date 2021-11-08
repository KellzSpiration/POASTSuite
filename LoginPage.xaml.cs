using POASTSuite.Table;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDataBase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(u => u.Username.Equals(Entryusername.Text) && u.Password.Equals(Entrypassword.Text)).FirstOrDefault();

            string userName = Entryusername.Text;
            string greeting = $"Hello {userName}";

            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new WelcomePage(greeting));
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () => {
                    var results = await this.DisplayAlert("Error", "Failed Username and Password", "Yes", "Cancel");
                    if (results)
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }

                });
            }
        }

        private void SignUpButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
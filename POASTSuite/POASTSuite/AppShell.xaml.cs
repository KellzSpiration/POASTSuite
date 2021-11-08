using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POASTSuite
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
       

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}

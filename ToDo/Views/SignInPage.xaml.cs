using System;
using Microsoft.Maui.Controls;

namespace ToDo.Views
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private async void OnSignUpTapped(object sender, EventArgs e)
        {
            // Use Shell navigation to move to SignUpPage
            await Shell.Current.GoToAsync("///SignUpPage");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DisplayAlert
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private async void Button_Clicked(object sender, EventArgs e)
        {
            var action = await this.DisplayAlert("Exit?", "Are you sure you want to save", "Yes", "No");
            if (action == true)
            {
                await DisplayAlert("Yes", "Saved", "Oky");

            }
            else
            {
                 await DisplayAlert("No", "Cancelled", "Oky"); 

            }
        }
    }
}

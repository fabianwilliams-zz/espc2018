using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace speakerRoomTA1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void firstButton_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "This is all stuff you do already?", "Yes", "No");
        }
    }
}

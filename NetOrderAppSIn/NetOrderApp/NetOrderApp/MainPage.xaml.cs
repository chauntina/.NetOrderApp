using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetOrderApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OrderButton_Clicked(object sender, EventArgs e)
        {
         Navigation.PushAsync(new OrderPage());
        }

      
    }
}

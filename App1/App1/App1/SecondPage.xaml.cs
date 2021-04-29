using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            
            //Subscribe
            MessagingCenter.Subscribe<object,string> (this, "Arrived", (sender,helper) =>
            {
                Label.Text = helper;
            });
        }
    }
}
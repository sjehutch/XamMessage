﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var name = "Scott";
            Navigation.PushModalAsync(new NavigationPage(new SecondPage()));
            MessagingCenter.Send<object,string> (this, "Arrived","Hola");
            
        }

        
    }
}
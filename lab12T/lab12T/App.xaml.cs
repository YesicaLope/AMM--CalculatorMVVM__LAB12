﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab12T
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.Calculator();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

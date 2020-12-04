﻿using Activitat_1_1.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Actividad_1_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PrincipalView());
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

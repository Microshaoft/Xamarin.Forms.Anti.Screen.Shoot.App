﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.AntiScreenShoot.App
{
    public partial class App : Application
    {
        public App(Action<bool> action)
        {
            InitializeComponent();

            MainPage = new MainPage(action);
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
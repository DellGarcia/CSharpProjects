﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AwesomeApp.Pages;
using XamWebApiClient;
using AwesomeApp.Services;
using AwesomeApp.ViewModels;

namespace AwesomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Startup.ConfigureServices();
            DependencyService.Register<IUserService, UserService>();
            DependencyService.Register<TestViewModel>();
            DependencyService.Register<UserRegisterViewModel>();

            MainPage = new NavigationPage(new UserRegisterPage());
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

﻿namespace Ejercicio1._1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaPrincipal());
        }
    }
}

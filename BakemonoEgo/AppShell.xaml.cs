﻿namespace BakemonoEgo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Register a route
            Routing.RegisterRoute(nameof(Views.Question1), typeof(Views.Question1));
        }
    }
}

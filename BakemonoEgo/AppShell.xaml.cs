﻿namespace BakemonoEgo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Register a route
            Routing.RegisterRoute(nameof(Views.Question1), typeof(Views.Question1));
            Routing.RegisterRoute(nameof(Views.Question2), typeof(Views.Question2));
            Routing.RegisterRoute(nameof(Views.Question3), typeof(Views.Question3));
            Routing.RegisterRoute(nameof(Views.Question4), typeof(Views.Question4));
            Routing.RegisterRoute(nameof(Views.Question5), typeof(Views.Question5));
            Routing.RegisterRoute(nameof(Views.Question6), typeof(Views.Question6));
            Routing.RegisterRoute(nameof(Views.Question7), typeof(Views.Question7));
            Routing.RegisterRoute(nameof(Views.Question8), typeof(Views.Question8));
            Routing.RegisterRoute(nameof(Views.Question9), typeof(Views.Question9));
            Routing.RegisterRoute(nameof(Views.ResultBadger), typeof(Views.ResultBadger));
            Routing.RegisterRoute(nameof(Views.ResultBird), typeof(Views.ResultBird));
            Routing.RegisterRoute(nameof(Views.ResultCat), typeof(Views.ResultCat));
            Routing.RegisterRoute(nameof(Views.ResultDog), typeof(Views.ResultDog));
            Routing.RegisterRoute(nameof(Views.ResultError), typeof(Views.ResultError));
            Routing.RegisterRoute(nameof(Views.ResultFox), typeof(Views.ResultFox));
            Routing.RegisterRoute(nameof(Views.ResultRacoon), typeof(Views.ResultRacoon));
        }
    }
}

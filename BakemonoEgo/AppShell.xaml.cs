namespace BakemonoEgo
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
        }
    }
}

namespace BakemonoEgo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void NavigateToQuestion1_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Views.Question1));
        }
    }

}

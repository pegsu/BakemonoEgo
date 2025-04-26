namespace BakemonoEgo.Views;

public partial class Question4 : ContentPage
{
	public Question4()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion5_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Question5));
    }
}
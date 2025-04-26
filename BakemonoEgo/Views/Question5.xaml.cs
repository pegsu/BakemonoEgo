namespace BakemonoEgo.Views;

public partial class Question5 : ContentPage
{
	public Question5()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion6_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Question6));
    }
}
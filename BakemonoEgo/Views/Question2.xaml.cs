namespace BakemonoEgo.Views;

public partial class Question2 : ContentPage
{
	public Question2()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion3_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Question3));
    }
}
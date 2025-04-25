namespace BakemonoEgo.Views;

public partial class Question1 : ContentPage
{
	public Question1()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion2_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Question2));
    }
}
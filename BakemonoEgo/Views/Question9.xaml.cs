namespace BakemonoEgo.Views;

public partial class Question9 : ContentPage
{
	public Question9()
	{
		InitializeComponent();
	}

    private async void NavigateToResults_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Results));
    }
}
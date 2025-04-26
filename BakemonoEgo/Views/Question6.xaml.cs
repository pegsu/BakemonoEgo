namespace BakemonoEgo.Views;

public partial class Question6 : ContentPage
{
	public Question6()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion7_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Question7));
    }
}
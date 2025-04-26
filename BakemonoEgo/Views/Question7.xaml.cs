namespace BakemonoEgo.Views;

public partial class Question7 : ContentPage
{
	public Question7()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion8_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Question8));
    }
}
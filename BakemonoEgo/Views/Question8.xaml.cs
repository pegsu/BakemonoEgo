namespace BakemonoEgo.Views;

public partial class Question8 : ContentPage
{
	public Question8()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion9_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Question9));
    }
}
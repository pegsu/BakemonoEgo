namespace BakemonoEgo.Views;

public partial class Question3 : ContentPage
{
	public Question3()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion4_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.Question4));
    }
}
namespace BakemonoEgo.Views;

public partial class Question9 : ContentPage
{
	public Question9()
	{
		InitializeComponent();
	}

    private async void NavigateToResults_Clicked(object sender, EventArgs e)
    {
        Result result = new Result();
        await result.DisplayResult(); 
    }
}
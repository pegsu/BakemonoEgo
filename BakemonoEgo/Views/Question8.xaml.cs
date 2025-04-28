namespace BakemonoEgo.Views;

public partial class Question8 : ContentPage
{
	public Question8()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion9_Clicked(object sender, EventArgs e)
    {
        if ((sender as Button) == A1) //Badger
        {
            CountTracking.MyCount += 10;
            await Shell.Current.GoToAsync(nameof(Views.Question9));
        }
        else if ((sender as Button) == A2) //Bird
        {
            CountTracking.MyCount += 0;
            await Shell.Current.GoToAsync(nameof(Views.Question9));
        }
        else if ((sender as Button) == A3) //Dog
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question9));
        }
        else if ((sender as Button) == A4) //Fox, Racoon
        {
            CountTracking.MyCount += 7;
            await Shell.Current.GoToAsync(nameof(Views.Question9));
        }
        else if ((sender as Button) == A5) //Cat
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question9));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }
    }
}
namespace BakemonoEgo.Views;

public partial class Question6 : ContentPage
{
	public Question6()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion7_Clicked(object sender, EventArgs e)
    {
        if ((sender as Button) == A1) //Fox
        {
            CountTracking.MyCount += 7;
            await Shell.Current.GoToAsync(nameof(Views.Question7));
        }
        else if ((sender as Button) == A2) //Bird
        {
            CountTracking.MyCount += 0;
            await Shell.Current.GoToAsync(nameof(Views.Question7));
        }
        else if ((sender as Button) == A3) //Badger
        {
            CountTracking.MyCount += 10;
            await Shell.Current.GoToAsync(nameof(Views.Question7));
        }
        else if ((sender as Button) == A4) //Dog
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question7));
        }
        else if ((sender as Button) == A5) //Racoon
        {
            CountTracking.MyCount += 5;
            await Shell.Current.GoToAsync(nameof(Views.Question7));
        }
        else if ((sender as Button) == A6) //Cat
        { 
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question7));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }
    }
}
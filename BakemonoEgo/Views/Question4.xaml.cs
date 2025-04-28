namespace BakemonoEgo.Views;

public partial class Question4 : ContentPage
{
	public Question4()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion5_Clicked(object sender, EventArgs e)
    {
        if ((sender as Button) == A1) //Badger
        {
            CountTracking.MyCount += 10;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A2) //Dog
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A3) //Cat
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A4) //Bird
        {
            CountTracking.MyCount += 0;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A5) //Fox
        {
            CountTracking.MyCount += 7;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A6) //Racoon
        {
            CountTracking.MyCount += 5;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }
    }
}
namespace BakemonoEgo.Views;

public partial class Question5 : ContentPage
{
	public Question5()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion6_Clicked(object sender, EventArgs e)
    {
        if ((sender as Button) == A1) //Racoon, Fox
        {
            CountTracking.MyCount += 5;
            await Shell.Current.GoToAsync(nameof(Views.Question6));
        }
        else if ((sender as Button) == A2) //Dog
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question6));
        }
        else if ((sender as Button) == A3) //Bird
        {
            CountTracking.MyCount += 0;
            await Shell.Current.GoToAsync(nameof(Views.Question6));
        }
        else if ((sender as Button) == A4) //Cat
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question6));
        }
        else if ((sender as Button) == A5) //Badger
        {
            CountTracking.MyCount += 10;
            await Shell.Current.GoToAsync(nameof(Views.Question6));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }
    }
}
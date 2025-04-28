namespace BakemonoEgo.Views;

public partial class Question2 : ContentPage
{
	public Question2()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion3_Clicked(object sender, EventArgs e)
    {
        if ((sender as Button) == A1) //Cat
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else if ((sender as Button) == A2) //Racoon
        {
            CountTracking.MyCount += 5;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else if ((sender as Button) == A3) //Bird
        {
            CountTracking.MyCount += 0;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else if ((sender as Button) == A4) //Dog
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else if ((sender as Button) == A5) //Badger, Fox
        {
            CountTracking.MyCount += 7;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }
    }
}
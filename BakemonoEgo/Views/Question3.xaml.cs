namespace BakemonoEgo.Views;

public partial class Question3 : ContentPage
{
	public Question3()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion4_Clicked(object sender, EventArgs e)
    {
        if ((sender as Button) == A1) //Dog
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question4));
        }
        else if ((sender as Button) == A2) //Cat
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question4));
        }
        else if ((sender as Button) == A3) //Racoon, Fox
        {
            CountTracking.MyCount += 5;
            await Shell.Current.GoToAsync(nameof(Views.Question4));
        }
        else if ((sender as Button) == A4) //Bird
        {
            CountTracking.MyCount += 0;
            await Shell.Current.GoToAsync(nameof(Views.Question4));
        }
        else if ((sender as Button) == A5) //Badger
        {
            CountTracking.MyCount += 10;
            await Shell.Current.GoToAsync(nameof(Views.Question4));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }
    }
}
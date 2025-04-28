namespace BakemonoEgo.Views;

public partial class Question7 : ContentPage
{
	public Question7()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion8_Clicked(object sender, EventArgs e)
    {
        if ((sender as Button) == A1) //Cat
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question8));
        }
        else if ((sender as Button) == A2) //Dog
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question8));
        }
        else if ((sender as Button) == A3) //Badger
        {
            CountTracking.MyCount += 10;
            await Shell.Current.GoToAsync(nameof(Views.Question8));
        }
        else if ((sender as Button) == A4) //Fox, Racoon
        {
            CountTracking.MyCount += 7;
            await Shell.Current.GoToAsync(nameof(Views.Question8));
        }
        else if ((sender as Button) == A5) //Bird
        {
            CountTracking.MyCount += 0;
            await Shell.Current.GoToAsync(nameof(Views.Question8));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }
    }
}
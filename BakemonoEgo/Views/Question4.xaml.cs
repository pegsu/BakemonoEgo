namespace BakemonoEgo.Views;

public partial class Question4 : ContentPage
{
	public Question4()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion5_Clicked(object sender, EventArgs e)
    {
        if ((sender as Button) == A1)
        {
            CountTracking.MyCount += 1;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A2)
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A3)
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A4)
        {
            CountTracking.MyCount += 4;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A5)
        {
            CountTracking.MyCount += 5;
            await Shell.Current.GoToAsync(nameof(Views.Question5));
        }
        else if ((sender as Button) == A6) 
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
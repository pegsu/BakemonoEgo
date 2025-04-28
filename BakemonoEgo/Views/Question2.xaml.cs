namespace BakemonoEgo.Views;

public partial class Question2 : ContentPage
{
	public Question2()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion3_Clicked(object sender, EventArgs e)
    {
        if ((sender as Button) == A1)
        {
            CountTracking.MyCount += 1;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else if ((sender as Button) == A2)
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else if ((sender as Button) == A3)
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else if ((sender as Button) == A4)
        {
            CountTracking.MyCount += 4;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else if ((sender as Button) == A5)
        {
            CountTracking.MyCount += 5;
            await Shell.Current.GoToAsync(nameof(Views.Question3));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }
    }
}
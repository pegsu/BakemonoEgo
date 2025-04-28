namespace BakemonoEgo.Views;

public partial class Question1 : ContentPage
{
	public Question1()
	{
		InitializeComponent();
	}

    private async void NavigateToQuestion2_Clicked(object sender, EventArgs e)
    {
        if( (sender as Button)  == A1)
        {
            CountTracking.MyCount += 1;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else if((sender as Button) == A2)
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else if ((sender as Button) == A3)
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else if ((sender as Button) == A4)
        {
            CountTracking.MyCount += 4;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else if ((sender as Button) == A5)
        {
            CountTracking.MyCount += 5;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }


        /*if ((sender  as Button).FindByName("A1"))
        {
            CountTracking.MyCount += 1;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else if (sender is Button A2)
        {
            CountTracking.MyCount += 2;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else if (sender is Button A3)
        {
            CountTracking.MyCount += 3;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else if (sender is Button A4)
        {
            CountTracking.MyCount += 4;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else if (sender is Button A5)
        {
            CountTracking.MyCount += 5;
            await Shell.Current.GoToAsync(nameof(Views.Question2));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(Views.ResultError));
        }*/
    }
}
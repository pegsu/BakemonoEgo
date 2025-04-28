using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakemonoEgo.Views
{
    class Result
    {
        public async Task DisplayResult()
        {
            int count = CountTracking.MyCount;

            if (count <= 10)
            {
                await Shell.Current.GoToAsync(nameof(Views.ResultBird));

            }
            else if (count <= 20)
            {
                await Shell.Current.GoToAsync(nameof(Views.ResultCat));

            }
            else if (count <= 30)
            {
                await Shell.Current.GoToAsync(nameof(Views.ResultDog));
            }
            else if (count <= 40)
            {
                await Shell.Current.GoToAsync(nameof(Views.ResultRacoon));
            }
            else if (count <= 50)
            {
                await Shell.Current.GoToAsync(nameof(Views.ResultFox));
            }
            else if (count >= 51)
            {
                await Shell.Current.GoToAsync(nameof(Views.ResultBadger));
            }
            else 
            {
                await Shell.Current.GoToAsync(nameof(Views.ResultError));
            }
        }
    }
}

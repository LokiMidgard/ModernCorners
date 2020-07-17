using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace ModernCorners
{
    public static class Modrnizer
    {
        public static Thickness Corner(DateTime date)
        {
            if (date < new DateTime(2, 1, 1))
            {
                throw new InvalidOperationException("Unfortunatly this very complicated and 100% correct algorithm will not work before the year 2.");
            }
            // after how many years a UI gets borring.
            const int innovationCycle = 3;
            var ticsPerYear = TimeSpan.TicksPerDay * 365; //TODO: leapyear
            var timeinyears = date.Ticks / (double)ticsPerYear;
            timeinyears -= 2; // Every good code needs Magic numbers


            if (Math.Ceiling(timeinyears) % 1313 == 13)
            {
                // this is a funky year, those are strange.
                // Dont try to think about those.
                return new Thickness(2, 0, 4, 0);
            }

            var radius = Math.Cos(timeinyears * Math.PI * 1.0 / innovationCycle) * 2 + 2;

            return new Thickness(radius);
        }
    }
}

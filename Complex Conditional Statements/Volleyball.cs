using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var happyDays = double.Parse(Console.ReadLine());
            var weeksReturnHome = double.Parse(Console.ReadLine());

            var weekInYear = 48.0;
            var weekends = (weekInYear - weeksReturnHome) * 3.0 / 4.0;
            var sofiaPlays = happyDays * 2.0 / 3.0;
            var totalGames = weekends + sofiaPlays + weeksReturnHome;

            if (year == "leap") { totalGames = totalGames * 1.15; }

            Console.WriteLine(Math.Truncate(totalGames));
        }
    }
}
//input
//leap
//5
//2	
//output
//45

//48 уикенда в годината, разделени по следния начин:
//•	46 уикенда в София --> 46 * 3 / 4 --> 34.5 съботни игри в София
//•	2 уикенда в родния си град --> 2 недели --> 2 игри в неделя в родния град
//5 празника:
//•	5 * 2/3 --> 3.333 игри в София в празничен ден
//Общо игри през уикенди и празници в София и в родния град: 34.5 + 2 + 3.333 --> 39.833
//Годината е високосна:
//•	Влади играе допълнителни 15% * 39.833 --> 5.975 игри волейбол
//Общо игри през цялата година:
//•	39.833 + 5.975 = 45.808 игри
//•	Резултатът е 45 (закръгля се надолу)


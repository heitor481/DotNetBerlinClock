using BerlinClock.Classes;
using BerlinClock.Classes.Interfaces;
using System;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private readonly IMarkColorClock markColorClock = new MarkColorClock();

        public string convertTime(string aTime)
        {
            StringBuilder lampColorsOfTheClock = new StringBuilder();
            var newTime = aTime.Split(':');

            int hoursSplited = Convert.ToInt32(newTime[0]);
            int minutesSplited = Convert.ToInt32(newTime[1]);
            int secondsSplited = Convert.ToInt32(newTime[2]);

            string firstLampBlink = this.markColorClock.FindFirstLampBlink(secondsSplited);
            string firstRowLampsBlink = this.markColorClock.FindFirstRowLampBlink(hoursSplited, firstLampBlink);
            string secondRowLampsBlink = this.markColorClock.FindSecondRowLampBlink(hoursSplited, firstRowLampsBlink);

            string thirdRowLampsBlink = this.markColorClock.FindThirdRowLampBlink(minutesSplited, secondRowLampsBlink);
            string lastRowLampsBlink = this.markColorClock.FindLastRowLampBlink(minutesSplited, thirdRowLampsBlink);

            return lampColorsOfTheClock.Append(lastRowLampsBlink).ToString();
        }
    }
}

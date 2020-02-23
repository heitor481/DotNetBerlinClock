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
            var newTime = aTime.Split(':');

            int hoursSplited = Convert.ToInt32(newTime[0]);
            int minutesSplited = Convert.ToInt32(newTime[1]);
            int secondsSplited = Convert.ToInt32(newTime[2]);

            StringBuilder firstLampBlink = this.markColorClock.FindFirstLampBlink(secondsSplited);
            StringBuilder firstRowLampsBlink = this.markColorClock.FindFirstRowLampBlink(hoursSplited, firstLampBlink);
            StringBuilder secondRowLampsBlink = this.markColorClock.FindSecondRowLampBlink(hoursSplited, firstRowLampsBlink);

            StringBuilder thirdRowLampsBlink = this.markColorClock.FindThirdRowLampBlink(minutesSplited, secondRowLampsBlink);
            StringBuilder lastRowLampsBlink = this.markColorClock.FindLastRowLampBlink(minutesSplited, thirdRowLampsBlink);

            return lastRowLampsBlink.ToString();
        }
    }
}

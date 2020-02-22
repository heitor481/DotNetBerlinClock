using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Interfaces
{
    public interface IMarkColorClock
    {
        string FindFirstLampBlink(int secondsComingFromTheClock);

        string FindFirstRowLampBlink(int hoursCommingFromTheClock, string firstLampBlink);

        string FindSecondRowLampBlink(int hoursCommingFromTheClock, string firstLampBlink);

        string FindThirdRowLampBlink(int minutesCommingFromTheClock, string firstLampBlink);

        string FindLastRowLampBlink(int minutesCommingFromTheClock, string firstLampBlink);
    }
}

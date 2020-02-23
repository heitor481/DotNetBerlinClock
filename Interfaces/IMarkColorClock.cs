using System.Text;

namespace BerlinClock.Interfaces
{
    public interface IMarkColorClock
    {
        StringBuilder FindFirstLampBlink(int secondsComingFromTheClock);

        StringBuilder FindFirstRowLampBlink(int hoursCommingFromTheClock, StringBuilder firstLampBlink);

        StringBuilder FindSecondRowLampBlink(int hoursCommingFromTheClock, StringBuilder firstLampBlink);

        StringBuilder FindThirdRowLampBlink(int minutesCommingFromTheClock, StringBuilder firstLampBlink);

        StringBuilder FindLastRowLampBlink(int minutesCommingFromTheClock, StringBuilder firstLampBlink);
    }
}

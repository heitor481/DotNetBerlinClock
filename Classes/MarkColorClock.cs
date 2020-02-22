using BerlinClock.Classes.Interfaces;
using System.Text;

namespace BerlinClock.Classes
{
    public class MarkColorClock : IMarkColorClock
    {
        private const int TotalOfSecondsThatTheFirstLampBlinks = 2;
        private const int HourOfTheFirstRowLamp = 5;

        private const int FirstQuarterPositionOfAnHour = 3;
        private const int HalfQuarterPositionOfAnHour = 6;
        private const int LastQuarterPositionOfAnHour = 9;

        private const int MinuteOfTheFirstLastLamp = 1;
        private const int MinuteOfTheSecondtLastLamp = 2;
        private const int MinuteOfTheThirdLastLamp = 3;
        private const int MinuteOfTheForthLastLamp = 4;

        private const int HourOfTheFirstLampOfSecondRow = 1;
        private const int HourOfTheSecondLampRow = 2;
        private const int HourOfTheThirdLampOfSecondRow = 3;
        private const int HourOfTheForthLampOfSecondRow = 4;

        public string FindFirstLampBlink(int secondsComingFromTheClock)
        {
            StringBuilder firstLampBlink = new StringBuilder();

            if (secondsComingFromTheClock % TotalOfSecondsThatTheFirstLampBlinks == 0)
            {
                firstLampBlink.Append("Y\r\n");
            }
            else
            {
                firstLampBlink.Append("O\r\n");
            }

            return firstLampBlink.ToString();
        }

        public string FindFirstRowLampBlink(int hoursCommingFromTheClock, string firstLampBlink)
        {
            StringBuilder firstRowLampBlink = new StringBuilder();

            if (hoursCommingFromTheClock < HourOfTheFirstRowLamp)
            {
                firstRowLampBlink.Append("OOOO\r\n");
            }

            if (hoursCommingFromTheClock == HourOfTheFirstRowLamp)
            {
                firstRowLampBlink.Append("ROOO\r\n");
            }

            if (hoursCommingFromTheClock >= 10 && hoursCommingFromTheClock <= 14)
            {
                firstRowLampBlink.Append("RROO\r\n");
            }

            if (hoursCommingFromTheClock >= 15 && hoursCommingFromTheClock < 20)
            {
                firstRowLampBlink.Append("RRRO\r\n");
            }

            if (hoursCommingFromTheClock >= 20)
            {
                firstRowLampBlink.Append("RRRR\r\n");
            }

            return firstLampBlink += firstRowLampBlink.ToString();
        }

        public string FindSecondRowLampBlink(int hoursCommingFromTheClock, string firstLampBlink)
        {
            StringBuilder secondRowLampBlink = new StringBuilder();
            int hoursModule = hoursCommingFromTheClock % HourOfTheFirstRowLamp;

            switch (hoursModule)
            {
                case HourOfTheFirstLampOfSecondRow:
                    secondRowLampBlink.Append("ROOO\r\n");
                    break;
                case HourOfTheSecondLampRow:
                    secondRowLampBlink.Append("RROO\r\n");
                    break;
                case HourOfTheThirdLampOfSecondRow:
                    secondRowLampBlink.Append("RRRO\r\n");
                    break;
                case HourOfTheForthLampOfSecondRow:
                    secondRowLampBlink.Append("RRRR\r\n");
                    break;
                default:
                    secondRowLampBlink.Append("OOOO\r\n");
                    break;
            }

            return firstLampBlink += secondRowLampBlink.ToString();
        }

        public string FindThirdRowLampBlink(int minutesCommingFromTheClock, string firstLampBlink)
        {
            StringBuilder thirdRowLampBlink = new StringBuilder();
            int minutesDivided = minutesCommingFromTheClock / HourOfTheFirstRowLamp;

            switch (minutesDivided)
            {
                case FirstQuarterPositionOfAnHour:
                    thirdRowLampBlink.Append("YYROOOOOOOO\r\n");
                    break;
                case HalfQuarterPositionOfAnHour:
                    thirdRowLampBlink.Append("YYRYYROOOOO\r\n");
                    break;
                case LastQuarterPositionOfAnHour:
                    thirdRowLampBlink.Append("YYRYYRYYROO\r\n");
                    break;
                case 11:
                    thirdRowLampBlink.Append("YYRYYRYYRYY\r\n");
                    break;
                default:
                    thirdRowLampBlink.Append("OOOOOOOOOOO\r\n");
                    break;
            }

            return firstLampBlink += thirdRowLampBlink.ToString();

        }


        public string FindLastRowLampBlink(int minutesCommingFromTheClock, string firstLampBlink)
        {
            StringBuilder lastRowLampBlink = new StringBuilder();
            int minutesModule = minutesCommingFromTheClock % HourOfTheFirstRowLamp;

            switch (minutesModule)
            {
                case MinuteOfTheFirstLastLamp:
                    lastRowLampBlink.Append("YOOO");
                    break;
                case MinuteOfTheSecondtLastLamp:
                    lastRowLampBlink.Append("YYOO");
                    break;
                case MinuteOfTheThirdLastLamp:
                    lastRowLampBlink.Append("YYYO");
                    break;
                case MinuteOfTheForthLastLamp:
                    lastRowLampBlink.Append("YYYY");
                    break;
                default:
                    lastRowLampBlink.Append("OOOO");
                    break;
            }

            return firstLampBlink += lastRowLampBlink.ToString();
        }
    }
}

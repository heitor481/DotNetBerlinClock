using BerlinClock.Interfaces;
using System.Text;

namespace BerlinClock.Classes
{
    public class MarkColorClock : IMarkColorClock
    {
        public StringBuilder FindFirstLampBlink(int secondsComingFromTheClock)
        {
            StringBuilder firstLampBlink = new StringBuilder();

            if (secondsComingFromTheClock % ClockLamps.TotalOfSecondsThatTheFirstLampBlinks == 0)
            {
                firstLampBlink.Append("Y\r\n");
            }
            else
            {
                firstLampBlink.Append("O\r\n");
            }

            return firstLampBlink;
        }

        public StringBuilder FindFirstRowLampBlink(int hoursCommingFromTheClock, StringBuilder firstLampBlink)
        {

            if (hoursCommingFromTheClock < ClockLamps.HourOfTheFirstRowLamp)
            {
                firstLampBlink.Append("OOOO\r\n");
            }

            if (hoursCommingFromTheClock == ClockLamps.HourOfTheFirstRowLamp)
            {
                firstLampBlink.Append("ROOO\r\n");
            }

            if (hoursCommingFromTheClock >= ClockLamps.TenthPositionOfAnHour && hoursCommingFromTheClock <= 14)
            {
                firstLampBlink.Append("RROO\r\n");
            }

            if (hoursCommingFromTheClock >= 15 && hoursCommingFromTheClock < 20)
            {
                firstLampBlink.Append("RRRO\r\n");
            }

            if (hoursCommingFromTheClock >= 20)
            {
                firstLampBlink.Append("RRRR\r\n");
            }

            return firstLampBlink;
        }

        public StringBuilder FindSecondRowLampBlink(int hoursCommingFromTheClock, StringBuilder firstLampBlink)
        {
            int hoursModule = hoursCommingFromTheClock % ClockLamps.HourOfTheFirstRowLamp;

            switch (hoursModule)
            {
                case ClockLamps.HourOfTheFirstLampOfSecondRow:
                    firstLampBlink.Append("ROOO\r\n");
                    break;
                case ClockLamps.HourOfTheSecondLampRow:
                    firstLampBlink.Append("RROO\r\n");
                    break;
                case ClockLamps.HourOfTheThirdLampOfSecondRow:
                    firstLampBlink.Append("RRRO\r\n");
                    break;
                case ClockLamps.HourOfTheForthLampOfSecondRow:
                    firstLampBlink.Append("RRRR\r\n");
                    break;
                default:
                    firstLampBlink.Append("OOOO\r\n");
                    break;
            }

            return firstLampBlink;
        }

        public StringBuilder FindThirdRowLampBlink(int minutesCommingFromTheClock, StringBuilder firstLampBlink)
        {
            int minutesDivided = minutesCommingFromTheClock / ClockLamps.HourOfTheFirstRowLamp;

            switch (minutesDivided)
            {
                case ClockLamps.FirstPositionOfAnHour:
                    firstLampBlink.Append("YOOOOOOOOOO\r\n");
                    break;
                case ClockLamps.SecondPositionOfAnHour:
                    firstLampBlink.Append("YYOOOOOOOOO\r\n");
                    break;
                case ClockLamps.FirstQuarterPositionOfAnHour:
                    firstLampBlink.Append("YYROOOOOOOO\r\n");
                    break;
                case ClockLamps.ForthPositionOfAnHour:
                    firstLampBlink.Append("YYRYOOOOOOO\r\n");
                    break;
                case ClockLamps.FithPositionOfAnHour:
                    firstLampBlink.Append("YYRYYOOOOOO\r\n");
                    break;
                case ClockLamps.HalfQuarterPositionOfAnHour:
                    firstLampBlink.Append("YYRYYROOOOO\r\n");
                    break;
                case ClockLamps.SeventhPositionOfAnHour:
                    firstLampBlink.Append("YYRYYRYOOOO\r\n");
                    break;
                case ClockLamps.EigthPositionOfAnHour:
                    firstLampBlink.Append("YYRYYRYYOOO\r\n");
                    break;
                case ClockLamps.LastQuarterPositionOfAnHour:
                    firstLampBlink.Append("YYRYYRYYROO\r\n");
                    break;
                case ClockLamps.TenthPositionOfAnHour:
                    firstLampBlink.Append("YYRYYRYYRYO\r\n");
                    break;
                case ClockLamps.EleventhPositionOfAnHour:
                    firstLampBlink.Append("YYRYYRYYRYY\r\n");
                    break;
                default:
                    firstLampBlink.Append("OOOOOOOOOOO\r\n");
                    break;
            }

            return firstLampBlink;

        }


        public StringBuilder FindLastRowLampBlink(int minutesCommingFromTheClock, StringBuilder firstLampBlink)
        {
            int minutesModule = minutesCommingFromTheClock % ClockLamps.HourOfTheFirstRowLamp;

            switch (minutesModule)
            {
                case ClockLamps.MinuteOfTheFirstLastLamp:
                    firstLampBlink.Append("YOOO");
                    break;
                case ClockLamps.MinuteOfTheSecondtLastLamp:
                    firstLampBlink.Append("YYOO");
                    break;
                case ClockLamps.MinuteOfTheThirdLastLamp:
                    firstLampBlink.Append("YYYO");
                    break;
                case ClockLamps.MinuteOfTheForthLastLamp:
                    firstLampBlink.Append("YYYY");
                    break;
                default:
                    firstLampBlink.Append("OOOO");
                    break;
            }

            return firstLampBlink;
        }
    }
}

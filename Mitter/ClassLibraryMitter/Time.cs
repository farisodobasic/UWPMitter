using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMitter
{
    public class Time
    {
        private int day;
        private int month;
        private int hour;
        private int minutes;

        //ako ne bude moglo sa intovima onda dan i mjesec u ovu varijablu...ima poseban ctor
        /*private DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }*/

        public int Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }

            set
            {
                month = value;
            }
        }

        public int Hour
        {
            get
            {
                return hour;
            }

            set
            {
                hour = value;
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }

            set
            {
                minutes = value;
            }
        }

        /*public Time(DateTime _date; int hour, int _minutes)
        {
            Date = _date;
            Hour = _hour;
            Minutes = _minutes;
        }*/

        public Time(int _day, int _month, int _hour, int _minutes)
        {
            Day = _day;
            Month = _month;
            Hour = _hour;
            Minutes = _minutes;
        }

        public Time()
        {

        }
    }
}

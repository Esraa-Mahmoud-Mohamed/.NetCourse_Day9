using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Duration
    {
        public int Hours {  get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int _hour, int _min, int _sec)
        {
            Hours = _hour;
            Minutes = _min; 
            Seconds = _sec;
            NormalizeTime();
        }

        public Duration(int _sec)
        {
            Hours = _sec / 3600;
            Minutes = (_sec % 3600) / 60;
            Seconds = (_sec % 3600) % 60;
            NormalizeTime();
        }

        private void NormalizeTime()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        public override string ToString() 
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours},Minutes: {Minutes},Seconds: {Seconds}";
            }
            else if (Minutes > 0)
            {
                return $"Minutes: {Minutes},Seconds: {Seconds}";
            }
            else
            {
                return $"Seconds: {Seconds}";
            }
        }

        public static Duration operator +(Duration left, Duration right)
        {
            Duration result = new Duration(
                left.Hours + right.Hours,
                left.Minutes + right.Minutes,
                left.Seconds + right.Seconds
            );
            result.NormalizeTime();
            return result ;
        }

        public static Duration operator +(Duration left, int _sec)
        {
            //Duration result = new Duration(
            //    left.Hours + (_sec / 3600),
            //    left.Minutes + ((_sec % 3600) / 60),
            //    left.Seconds + ((_sec % 3600) % 60)
            //    );
            Duration right = new Duration(_sec);
            Duration result = left + right ;
            return result;
        }

        public static Duration operator +(int _sec, Duration right)
        {
            //Duration result = new Duration(
            //    left.Hours + (_sec / 3600),
            //    left.Minutes + ((_sec % 3600) / 60),
            //    left.Seconds + ((_sec % 3600) % 60)
            //    );

            //Duration left = new Duration(_sec);
            //Duration result = left + right;

            Duration result = right + _sec;
            return result;
        }

        public static Duration operator ++(Duration left)
        {
            return new Duration(left.Hours, left.Minutes + 1, left.Seconds);
        }

        public static Duration operator --(Duration left)
        {
            return new Duration(left.Hours, left.Minutes - 1, left.Seconds);
        }

        public static bool operator >(Duration left, Duration right)
        {
            return left.Hours > right.Hours && left.Minutes > right.Minutes && left.Seconds > right.Seconds;
        }

        public static bool operator <(Duration left, Duration right)
        {
            return left.Hours < right.Hours && left.Minutes < right.Minutes && left.Seconds < right.Seconds;
        }

        public static bool operator >=(Duration left, Duration right)
        {
            return left.Hours >= right.Hours && left.Minutes >= right.Minutes && left.Seconds >= right.Seconds;
        }

        public static bool operator <=(Duration left, Duration right)
        {
            return left.Hours <= right.Hours && left.Minutes <= right.Minutes && left.Seconds <= right.Seconds;
        }
    }
}

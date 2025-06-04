namespace TimeStruct
{
    public struct Time
    {
        const int maxValue = 59;
        const int secondsInMinute = 60;
        const int secondsInHour = 3600;

        int hours;
        public int Hours
        {
            get => hours;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Значение должно быть неотрицательным");
                hours = value;
            }
        }

        int minutes;
        public int Minutes
        {
            get => minutes;
            set
            {
                if (value < 0 || value > maxValue)
                    throw new ArgumentException("Значение должно быть неотрицательным и не более 59");
                minutes = value;
            }
        }
        int seconds;
        public int Seconds
        {
            get => seconds;
            set
            {
                if (value < 0 || value > maxValue)
                    throw new ArgumentException("Значение должно быть неотрицательным и не более 59");
                seconds = value;
            }
        }
        public int DurationInSeconds
        {
            get => hours * secondsInHour + minutes * secondsInMinute + seconds;
        }
        public Time(int hours, int minutes, int seconds) : this()
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public override string ToString() => $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        public override bool Equals(object obj)
        {
            if (obj is Time)
                return DurationInSeconds == ((Time)obj).DurationInSeconds;
            throw new ArgumentException("Объект для сравнения не является временным интервалом");
        }
        public override int GetHashCode() => DurationInSeconds.GetHashCode();

        public static bool operator ==(Time x, Time y) => x.Equals(y);
        public static bool operator !=(Time x, Time y) => !x.Equals(y);
        public static bool operator >(Time x, Time y) => x.DurationInSeconds > y.DurationInSeconds;
        public static bool operator >=(Time x, Time y) => x.DurationInSeconds >= y.DurationInSeconds;
        public static bool operator <(Time x, Time y) => x.DurationInSeconds < y.DurationInSeconds;
        public static bool operator <=(Time x, Time y) => x.DurationInSeconds <= y.DurationInSeconds;
        public static Time operator +(Time x, Time y) =>
            GetTimeByDurationInSeconds(x.DurationInSeconds + y.DurationInSeconds);
        public static Time operator -(Time x, Time y)
        {
            if (x.DurationInSeconds < y.DurationInSeconds)
                throw new ArgumentException("Вычитаемое больше уменьшаемого");
            return GetTimeByDurationInSeconds(x.DurationInSeconds - y.DurationInSeconds);
        }
        public static Time operator *(double k, Time time) =>
            GetTimeByDurationInSeconds((int)Math.Round(k * time.DurationInSeconds));
        public static Time operator *(Time time, double k) => k * time;
        private static Time GetTimeByDurationInSeconds(int totalSeconds)
        {
            if (totalSeconds < 0)
                throw new ArgumentException("Длительность не может быть отрицательной.");

            int hours = totalSeconds / secondsInHour;
            int remainingSeconds = totalSeconds % secondsInHour;
            int minutes = remainingSeconds / secondsInMinute;
            int seconds = remainingSeconds % secondsInMinute;

            return new Time(hours, minutes, seconds);
        }
    }
}

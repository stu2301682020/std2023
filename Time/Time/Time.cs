namespace Excercise
{
    class Time
    {
        private readonly int hour;
        private readonly int minute;
        private readonly int second;

        Time() {
            var date = DateTime.Now;

            hour = date.Hour;
            minute = date.Minute;
            second = date.Second;
        }
        Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        string getTime()
        {
            return $"{hour:D2}:{minute:D2}:{second:D2}";
        }

        public static void Main(string[] args)
        {
            Time time = new(12, 4, 2);
            Console.WriteLine(time.getTime());

            Time currentTime = new();
            Console.WriteLine(currentTime.getTime());
        }
    }
}
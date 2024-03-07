using System;

namespace ClassLib_v7
{
    public class Pair
    {
        private DateTime startTime;
        private DateTime endTime;
        private DateTime breakStartTime;
        private DateTime breakEndTime;
        private string shiftLink;

        public Pair(DateTime startTime, DateTime endTime, DateTime breakStartTime, DateTime breakEndTime, string shiftLink)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.breakStartTime = breakStartTime;
            this.breakEndTime = breakEndTime;
            this.shiftLink = shiftLink;
        }

        public Pair(TimeSpan startTime, TimeSpan endTime, TimeSpan breakStartTime, TimeSpan breakEndTime, string shiftLink)
        {
            DateTime currentDate = DateTime.Today;

            this.startTime = currentDate.Add(startTime);
            this.endTime = currentDate.Add(endTime);
            this.breakStartTime = currentDate.Add(breakStartTime);
            this.breakEndTime = currentDate.Add(breakEndTime);
            this.shiftLink = shiftLink;
        }
    }
}

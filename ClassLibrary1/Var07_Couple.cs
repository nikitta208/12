using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
    internal class Var07_Couple
    {

        internal static Var07_Couple ToString(string value)
        {
            throw new NotImplementedException();
        }

        private DateTime startTime;
        private DateTime endTime;
        private DateTime breakStartTime;
        private DateTime breakEndTime;
        private string shiftLink;

        public Var07_Couple(DateTime startTime, DateTime endTime, DateTime breakStartTime, DateTime breakEndTime, string shiftLink)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.breakStartTime = breakStartTime;
            this.breakEndTime = breakEndTime;
            this.shiftLink = shiftLink;
        }

        public Var07_Couple(TimeSpan startTime, TimeSpan endTime, TimeSpan breakStartTime, TimeSpan breakEndTime, string shiftLink)
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

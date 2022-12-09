using Ddc.TimelogAggregatorApp.WebApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ddc.TimelogAggregatorApp.WebApi.Models
{
    public class Timelog
    {
        public string Id { get; set; }


        public string EEId { get; set; }

        public DateTime LogDate { get; set; }

        public DateTime Timestamp { get; set; }

        public string FormattedTimestamp { get => Timestamp.ToString("MM-dd HH:mm:ss"); }

        public TimelogStatus Status { get; set; }

        public DateTime? DateSent { get; set; }

        public string GenerateId() => $"{EEId}_{LogDate:yyMMdd}_{Status}";

        public TimelogStatus GetNextLogStatus(DateTime nextTimestamp)
        {
            //ensures that the timelog is not empty or too old
            if ((nextTimestamp - LogDate).TotalDays > 7) return TimelogStatus.TimeIn;

            TimelogStatus status = TimelogStatus.TimeIn;
            if (Status == TimelogStatus.TimeIn)
            {
                if ((nextTimestamp - Timestamp).TotalHours > 20 && DateTime.Now.Day != Timestamp.Day)
                    status = TimelogStatus.TimeIn;
                else
                    status = TimelogStatus.TimeOut;
            }
            else// is time out
            {
                if ((nextTimestamp - Timestamp).TotalHours >= 8)
                    status = TimelogStatus.TimeIn;
                else
                    status = TimelogStatus.TimeOut;
            }

            return status;
        }

        public DateTime GetNextLogDate(DateTime nextTimestamp,TimelogStatus nextLogStatus)
        {
            DateTime nextLogDate = nextTimestamp;
            // check if the last and the next log date is not match, copy last log date to the new
            if (nextLogStatus == TimelogStatus.TimeOut && Status == TimelogStatus.TimeIn)
            {
                var timeDiff = (nextTimestamp - LogDate).TotalHours;
                var dayDiff = (nextTimestamp - LogDate).Days;
                if (timeDiff < 24 && dayDiff > 0)
                    nextLogDate = LogDate;
            }


            //copy last log date to the new
            else if (nextLogStatus == TimelogStatus.TimeOut && Status == TimelogStatus.TimeOut)
                nextLogDate = LogDate;


            if (nextLogStatus == TimelogStatus.TimeIn && int.Parse(nextTimestamp.ToString("HHmm")) >= 2331)
                nextLogDate = LogDate.AddDays(1);


            return nextLogDate;
        }
    }
}

using System;
namespace DigitalEntryAPI.Models
{
    public class EnterHistoryModel
    {
        public EnterHistoryModel(DateTime timeEvent, bool isLeave = false)
        {
            TimeEvent = timeEvent;
            IsLeave = isLeave;
        }

        public DateTime TimeEvent { get; set; }
        public bool IsLeave { get; set; }
    }
}
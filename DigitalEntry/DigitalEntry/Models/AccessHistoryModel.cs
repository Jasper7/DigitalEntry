using System;
namespace DigitalEntry.Models
{
    public class AccessHistoryModel
    {
        public AccessHistoryModel(string parentName, DateTime timeEvent, string reason, bool isUsed = false, bool isSecurityForbidden = false, bool isEmergencyEntry = false)
        {
            ParentName = parentName;
            Reason = reason;
            TimeEvent = timeEvent;
            IsUsed = isUsed;
            IsSecurityForbidden = isSecurityForbidden;
            IsEmergencyEntry = isEmergencyEntry;
        }

        public string ParentName { get; set; }
        public DateTime TimeEvent { get; set; }
        public string Reason { get; set; }
        public bool IsUsed { get; set; }
        public bool IsEmergencyEntry { get; set; }
        public bool IsSecurityForbidden { get; set; }
    }
}
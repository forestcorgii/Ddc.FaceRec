using Neurotec.Biometrics;
using Neurotec.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddc.FaceRecApp.FrontEnd.Domain
{
    public class Timelog
    {
        public string Id { get; set; }
        public string EEId { get; set; }

        public DateTime Timestamp { get; set; }
        public string FormattedTimestamp { get => Timestamp.ToString("MM-dd HH:mm:ss"); }

        public DateTime? DateSent { get; set; }
    }
}

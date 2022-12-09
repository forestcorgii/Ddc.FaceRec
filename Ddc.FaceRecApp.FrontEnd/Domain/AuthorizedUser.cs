using Neurotec.Biometrics;
using Neurotec.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddc.FaceRecApp.FrontEnd.Domain
{
    public class Administrator
    {
        public int Id { get; set; }
        public string EEId { get; set; }

        public DateTime DateAdded { get; set; }
    }
}

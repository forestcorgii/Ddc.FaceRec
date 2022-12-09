using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ddc.FaceRecApp.FrontEnd.Domain;
using Ddc.FaceRecApp.FrontEnd.Persistence;
using Ddc.FaceRecApp.FrontEnd.Services;
using Ddc.FaceRecApp.FrontEnd.Shared;
using Neurotec.Biometrics;

namespace Ddc.FaceRecApp.FrontEnd.Controllers
{
    public class TimelogSenderController 
    {
        TimelogDbManager TimelogDbManager;

        public TimelogSenderController(TimelogDbManager timelogDbManager)
        {
            TimelogDbManager = timelogDbManager;
        }


    }
}

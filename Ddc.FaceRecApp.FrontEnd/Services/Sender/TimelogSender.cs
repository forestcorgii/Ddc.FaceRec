using Ddc.FaceRecApp.FrontEnd.Domain;
using Ddc.FaceRecApp.FrontEnd.Persistence;
using Ddc.FaceRecApp.FrontEnd.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddc.FaceRecApp.FrontEnd.Services.Sender
{
    public class TimelogSender
    {
        private TimelogDbManager TimelogDbManager;

        public TimelogSender(TimelogDbManager timelogDbManager)
        {
            TimelogDbManager = timelogDbManager;
        }

 


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ddc.FaceRecApp.FrontEnd.Domain;
using Ddc.FaceRecApp.FrontEnd.Persistence;
using Ddc.FaceRecApp.FrontEnd.Services;
using Ddc.FaceRecApp.FrontEnd.Services.Sender;
using Ddc.FaceRecApp.FrontEnd.Shared;
using Neurotec.Biometrics;

namespace Ddc.FaceRecApp.FrontEnd.Controllers
{
    public class MainController : VerilookControllerBase
    {
        TimelogDbManager TimelogDbManager;

        public MainController(VerilookManager verilookManager, TimelogDbManager timelogDbManager) : base(verilookManager)
        {
            TimelogDbManager = timelogDbManager;
        }


        public IEnumerable<Timelog> LoadPreviewTimelogs() => TimelogDbManager.GetTimelogs();

        private bool ValidateTimelog(string id, DateTime timestamp)
        {
            Timelog latestTimelog = TimelogDbManager.FindLatestTimelogByEEId(id);
            if (latestTimelog != null)
            {
                TimeSpan gap = timestamp - latestTimelog.Timestamp;
                if (gap.TotalMinutes >= 1)
                    return true;
            }
            else
                return true;
            return false;
        }

        public Timelog SaveTimelog(string id, DateTime timestamp)
        {
            if (ValidateTimelog(id, timestamp))
            {
                Timelog newTimelog = new Timelog() { EEId = id, Timestamp = timestamp };
                TimelogDbManager.SaveTimelog(newTimelog);
                return newTimelog;
            }

            return null;
        }


        public async Task<object> IdentifyFace()
        {
            if (CurrentSubject != null && CurrentSubject.Faces.Any())
            {
                NFace[] result = await Manager.DetectAsync(CurrentSubject);
                if (result.Any())
                {
                    List<string> idsFound = new List<string>();
                    foreach (NFace face in result)
                    {
                        NSubject subjectFound = new NSubject();
                        subjectFound.Faces.Add(face);
                        string resultId = await Manager.IdentifyAsync(subjectFound);
                        if (resultId != "NOMATCH")
                            idsFound.Add(resultId);
                    }
                    if (idsFound.Any())
                        return idsFound;
                    return "NOMATCH";
                }
            }
            return "NOFACE";
        }


    }
}

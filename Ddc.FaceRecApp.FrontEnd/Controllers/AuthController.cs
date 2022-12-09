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
    public class AuthController : VerilookControllerBase
    {
        AdministratorDbManager UserDbManager;

        public AuthController(VerilookManager verilookManager, AdministratorDbManager userDbManager) : base(verilookManager)
        {
            UserDbManager = userDbManager;
        }

        public async Task<bool> Authenticate()
        {
            if (CurrentSubject != null && CurrentSubject.Faces.Any())
            {
                NFace[] result = await Manager.DetectAsync(CurrentSubject);
                if (result.Any())
                {
                    NSubject subjectFound = new NSubject();
                    subjectFound.Faces.Add(result[0]);
                    string eeId = await Manager.IdentifyAsync(subjectFound);
                    return UserDbManager.FindAdministrator(eeId) != null;
                }
            }
            return false;
        }
    }
}

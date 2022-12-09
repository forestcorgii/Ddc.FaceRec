using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ddc.FaceRecApp.FrontEnd.Domain;
using Ddc.FaceRecApp.FrontEnd.Services;
using Ddc.FaceRecApp.FrontEnd.Shared;
using Neurotec.Biometrics;

namespace Ddc.FaceRecApp.FrontEnd.Controllers
{
    public class VerilookControllerBase
    {
        protected VerilookManager Manager;
        protected NSubject CurrentSubject;

        public VerilookControllerBase(VerilookManager verilookManager)
        {
            Manager = verilookManager;
            Manager.Client.Force();

            CurrentSubject = new NSubject();
        }

        public async Task<bool> ValidateId(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (await Manager.FindSubjectById(id) is null)
                    return true;
                else
                    MessageBoxes.Error("Employee Id already exists.");
            }
            else
                MessageBoxes.Error("Invalid Employee Id format.");

            return false;
        }

        public async Task<NBiometricStatus> StartCapture() =>
            await Manager.CaptureFaceAsync(CurrentSubject);

        public async Task ForceStopCapture()
        {
            Manager.StreamClient.ForceStart();
            await Manager.StreamClient.ClearAsync();
            
            if (CurrentSubject.Faces.Any())
                CurrentSubject.Faces[0].Image = null;
        }

    }
}

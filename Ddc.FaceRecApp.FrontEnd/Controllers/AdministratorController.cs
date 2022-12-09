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
    public class AdministratorController : VerilookControllerBase
    {
        AdministratorDbManager AdministratorDbManager;

        public AdministratorController(VerilookManager verilookManager, AdministratorDbManager administratorDbManager) :
            base(verilookManager)
        {
            AdministratorDbManager = administratorDbManager;
        }


        public IEnumerable<Administrator> LoadAdministrators() => AdministratorDbManager.LoadAdministrators();
        public void Save(Administrator admin) => AdministratorDbManager.SaveAdmin(admin);
        public void Delete(Administrator admin) => AdministratorDbManager.DeleteAdmin(admin);


        public async Task<bool> EnrollFace(string id)
        {
            string res = await Manager.EnrollAsync(CurrentSubject, id);
            return res != string.Empty;
        }

        public async Task<bool> UpdateFace(string id)
        {
            string res = await Manager.UpdateAsync(CurrentSubject, id);
            return res != string.Empty;
        }

    }
}

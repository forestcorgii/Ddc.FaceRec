using Ddc.FaceRecApp.FrontEnd.Controllers;
using Ddc.FaceRecApp.FrontEnd.Services;
using Ddc.FaceRecApp.FrontEnd.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddc.FaceRecApp.FrontEnd.Views
{
    public partial class AdministratorView : Form
    {
        AdministratorController Controller;

        public AdministratorView()
        {
            InitializeComponent();

            Controller = new AdministratorController(
               Program.VerilookFactory.CreateManager(MainFaceView, Neurotec.Biometrics.NBiometricCaptureOptions.Stream),
               Program.AdministratorDbManager
            );
        }

        private async void BtnCapture_Click(object sender, EventArgs e)
        {
            if (await Controller.ValidateId(TbEmployeeId.Text))
            {
                await Controller.ForceStopCapture();
                var res = await Controller.StartCapture();
                LbCaptureStatus.Text = res.ToString();
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var res = await Controller.EnrollFace(TbEmployeeId.Text);
            if (res)
            {
                MessageBoxes.Prompt("Saved.");
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}

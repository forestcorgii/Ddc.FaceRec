using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Biometrics.Gui;
using Neurotec.Licensing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ddc.FaceRecApp.FrontEnd.Shared.MessageBoxes;

namespace Ddc.FaceRecApp.FrontEnd.Services
{
    public class VerilookManagerFactory
    {
        private string OdbcConnectionString { get; set; }
        private string TableName { get; set; }

        private bool _licenseSetupSuccessfully { get; set; }


        public VerilookManagerFactory(string odbcconnectionString, string tableName)
        {
            if (odbcconnectionString != string.Empty)
                OdbcConnectionString = odbcconnectionString;

            if (tableName != string.Empty)
                TableName = tableName;


            LicenseSetup();


            FaceClient = new NBiometricClient()
            {
                MatchingMaximalResultCount = 5,
                FacesDetectAllFeaturePoints = false,
                BiometricTypes = NBiometricType.Face,
                FacesTemplateSize = NTemplateSize.Small,
                FacesMatchingSpeed = NMatchingSpeed.High,
            };
            FaceClient.SetDatabaseConnectionToOdbc(OdbcConnectionString, TableName);

            StreamClient = new NBiometricClient()
            {
                UseDeviceManager = true,
                FacesDetectAllFeaturePoints = false,
                MatchingMaximalResultCount = 5,
                BiometricTypes = NBiometricType.Face,
                FacesTemplateSize = NTemplateSize.Small,
                FacesMatchingSpeed = NMatchingSpeed.High,
                Timeout = new TimeSpan(1, 0, 0, 1)
            };
        }

        NBiometricClient FaceClient;
        NBiometricClient StreamClient;

        public VerilookManager CreateManager(NFaceView faceView, NBiometricCaptureOptions captureOptions = NBiometricCaptureOptions.Stream)
        {
            return new VerilookManager(FaceClient, StreamClient, faceView, captureOptions);
        }


        private void LicenseSetup()
        {
            if (!_licenseSetupSuccessfully)
            {
                _licenseSetupSuccessfully = true;

                _licenseSetupSuccessfully = AddLicenseFiles();

                string[] requiredComponents = new string[]
                {
                    "Biometrics.FaceExtraction",
                    "Biometrics.FaceMatching",
                    "Biometrics.FaceDetection",
                    "Devices.Cameras"
                };

                string server = "/local";
                string port = "5000";
                foreach (string component in requiredComponents)
                    if (!NLicense.ObtainComponents(server, port, component))
                    {
                        Error($"{component} Component License is not activated", "License setup failed");
                        _licenseSetupSuccessfully = false;
                    }
            }
        }

        private bool AddLicenseFiles()
        {
            string licenseDirectory = $@"{Application.StartupPath}\Data\Licenses";
            if (Directory.Exists(licenseDirectory))
            {
                string[] licenseFiles = Directory.GetFiles(licenseDirectory, "*.lic");
                if (licenseFiles.Any())
                {
                    foreach (string licenseFile in licenseFiles)
                        NLicense.Add(File.ReadAllText(licenseFile));
                    return true;
                }
                else
                    Error("No License file was found.", "License setup failed");
            }
            else
                Error("License Directory was not found.", "License setup failed");
            return false;
        }

    }
}

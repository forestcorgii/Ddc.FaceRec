using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Biometrics.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ddc.FaceRecApp.FrontEnd.Domain;
using Ddc.FaceRecApp.FrontEnd.Shared;
using Neurotec;
using Neurotec.Images;

namespace Ddc.FaceRecApp.FrontEnd.Services
{
    public class VerilookManager
    {
        public NBiometricClient Client { get; set; }
        public NBiometricClient StreamClient { get; set; }
        public NFaceView FaceView { get; set; }

        private NBiometricCaptureOptions CaptureOption { get; set; }


        public VerilookManager(NBiometricClient faceClient,
            NBiometricClient streamClient,
            NFaceView faceView,
            NBiometricCaptureOptions captureOptions)
        {
            Client = faceClient;
            StreamClient = streamClient;

            FaceView = faceView;
            CaptureOption = captureOptions;
        }

        public async Task<NSubject> FindSubjectById(string id)
        {
            NSubject subj = new NSubject { Id = id };
            NBiometricStatus status = await Client.GetAsync(subj);
            if (status == NBiometricStatus.Ok)
                return subj;
            return null;
        }

        public async Task<NBiometricStatus> CaptureFaceAsync(NSubject subject)
        {
            subject.Faces.Add(new NFace() { CaptureOptions = CaptureOption });
            FaceView.Face = subject.Faces.First();

            try
            {
                return await StreamClient.CaptureAsync(subject);
            }
            catch (Exception ex) { MessageBoxes.Error(ex.Message); }

            return NBiometricStatus.None;
        }

        public async Task<string> EnrollAsync(NSubject subject, string id)
        {
            if (subject != null)
            {
                subject.Id = id;
                NBiometricStatus enrollStatus = await Client.EnrollAsync(subject, true);
                if (enrollStatus == NBiometricStatus.Ok)
                    return subject.Id;
                else if (enrollStatus == NBiometricStatus.DuplicateFound)
                {
                    string duplicateSubjectId = await IdentifyAsync(subject);
                    if (duplicateSubjectId != "NOMATCH")
                        MessageBoxes.Error($"Face subject conflicted with {duplicateSubjectId}. ");
                }
                else
                    MessageBoxes.Error(enrollStatus.ToString());
            }
            return "";
        }

        public async Task<string> UpdateAsync(NSubject subject, string id)
        {
            if (subject != null)
            {
                subject.Id = id;
                NBiometricStatus da = await Client.UpdateAsync(subject);
                if (da == NBiometricStatus.Ok)
                    return subject.Id;
                else
                    MessageBoxes.Error(da.ToString());
            }
            return "";
        }

        public async Task<NFace[]> DetectAsync(NSubject subject)
        {
            List<NFace> extractedFaces = new List<NFace>();

            if (subject != null && subject.Faces.First().Image != null)
            {
                NImage nImage = subject.Faces.First().Image;

                NFace nFace = await Client.DetectFacesAsync(nImage);
                foreach (NLAttributes faceObject in nFace.Objects)
                {
                    var newFaceObject = new NLAttributes()
                    {
                        BoundingRect = faceObject.BoundingRect
                    };
                    NFace extractedFace = NFace.FromImageAndAttributes(nImage, newFaceObject);
                    extractedFaces.Add(extractedFace);
                }
            }
            return extractedFaces.ToArray();
        }

        public async Task<string> IdentifyAsync(NSubject subject)
        {
            try
            {
                if (subject != null)
                {
                    NBiometricStatus res = await Client.IdentifyAsync(subject);
                    if (res == NBiometricStatus.Ok)
                        return subject.MatchingResults.First().Id;
                }
            }
            catch (Exception ex) { MessageBoxes.Error(ex.Message); }
            return "NOMATCH";
        }
    }
}

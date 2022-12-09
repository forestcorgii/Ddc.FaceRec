
namespace Ddc.FaceRecApp.FrontEnd.Views
{
    partial class AdministratorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainFaceView = new Neurotec.Biometrics.Gui.NFaceView();
            this.TbEmployeeId = new System.Windows.Forms.TextBox();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbCaptureStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainFaceView
            // 
            this.MainFaceView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFaceView.BackColor = System.Drawing.Color.Black;
            this.MainFaceView.Face = null;
            this.MainFaceView.FaceIds = null;
            this.MainFaceView.IcaoArrowsColor = System.Drawing.Color.Red;
            this.MainFaceView.Location = new System.Drawing.Point(10, 10);
            this.MainFaceView.Margin = new System.Windows.Forms.Padding(1);
            this.MainFaceView.Name = "MainFaceView";
            this.MainFaceView.ShowIcaoArrows = true;
            this.MainFaceView.ShowTokenImageRectangle = true;
            this.MainFaceView.Size = new System.Drawing.Size(303, 176);
            this.MainFaceView.TabIndex = 19;
            this.MainFaceView.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // TbEmployeeId
            // 
            this.TbEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbEmployeeId.Location = new System.Drawing.Point(86, 190);
            this.TbEmployeeId.Name = "TbEmployeeId";
            this.TbEmployeeId.Size = new System.Drawing.Size(144, 20);
            this.TbEmployeeId.TabIndex = 20;
            // 
            // BtnCapture
            // 
            this.BtnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCapture.Location = new System.Drawing.Point(238, 188);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(75, 23);
            this.BtnCapture.TabIndex = 21;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(238, 261);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Employee Id:";
            // 
            // LbCaptureStatus
            // 
            this.LbCaptureStatus.AutoSize = true;
            this.LbCaptureStatus.Location = new System.Drawing.Point(83, 213);
            this.LbCaptureStatus.Name = "LbCaptureStatus";
            this.LbCaptureStatus.Size = new System.Drawing.Size(21, 13);
            this.LbCaptureStatus.TabIndex = 24;
            this.LbCaptureStatus.Text = "Ok";
            // 
            // EnrollmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 296);
            this.Controls.Add(this.LbCaptureStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCapture);
            this.Controls.Add(this.TbEmployeeId);
            this.Controls.Add(this.MainFaceView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnrollmentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EnrollmentView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Neurotec.Biometrics.Gui.NFaceView MainFaceView;
        private System.Windows.Forms.TextBox TbEmployeeId;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbCaptureStatus;
    }
}
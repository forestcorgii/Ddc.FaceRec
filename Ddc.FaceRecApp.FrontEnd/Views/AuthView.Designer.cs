
namespace Ddc.FaceRecApp.FrontEnd.Views
{
    partial class AuthView
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
            this.BtnRetry = new System.Windows.Forms.Button();
            this.MainFaceView.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFaceView
            // 
            this.MainFaceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFaceView.BackColor = System.Drawing.Color.Black;
            this.MainFaceView.Controls.Add(this.BtnRetry);
            this.MainFaceView.Face = null;
            this.MainFaceView.FaceIds = null;
            this.MainFaceView.IcaoArrowsColor = System.Drawing.Color.Red;
            this.MainFaceView.Location = new System.Drawing.Point(11, 11);
            this.MainFaceView.Margin = new System.Windows.Forms.Padding(2);
            this.MainFaceView.Name = "MainFaceView";
            this.MainFaceView.ShowIcaoArrows = true;
            this.MainFaceView.ShowTokenImageRectangle = true;
            this.MainFaceView.Size = new System.Drawing.Size(637, 358);
            this.MainFaceView.TabIndex = 19;
            this.MainFaceView.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // BtnRetry
            // 
            this.BtnRetry.Location = new System.Drawing.Point(201, 238);
            this.BtnRetry.Name = "BtnRetry";
            this.BtnRetry.Size = new System.Drawing.Size(214, 52);
            this.BtnRetry.TabIndex = 0;
            this.BtnRetry.Text = "Try Again";
            this.BtnRetry.UseVisualStyleBackColor = true;
            this.BtnRetry.Click += new System.EventHandler(this.BtnRetry_Click);
            // 
            // AuthView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 380);
            this.Controls.Add(this.MainFaceView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AuthView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Face Authentication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthView_FormClosing);
            this.MainFaceView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Neurotec.Biometrics.Gui.NFaceView MainFaceView;
        private System.Windows.Forms.Button BtnRetry;
    }
}
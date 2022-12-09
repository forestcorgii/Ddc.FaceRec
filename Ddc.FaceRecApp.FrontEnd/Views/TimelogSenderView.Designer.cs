
namespace Ddc.FaceRecApp.FrontEnd.Views
{
    partial class TimelogSenderView
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
            this.PbTimelogSent = new System.Windows.Forms.ProgressBar();
            this.LbProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PbTimelogSent
            // 
            this.PbTimelogSent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbTimelogSent.Location = new System.Drawing.Point(12, 44);
            this.PbTimelogSent.Name = "PbTimelogSent";
            this.PbTimelogSent.Size = new System.Drawing.Size(187, 8);
            this.PbTimelogSent.TabIndex = 0;
            // 
            // LbProgress
            // 
            this.LbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbProgress.Location = new System.Drawing.Point(12, 9);
            this.LbProgress.Name = "LbProgress";
            this.LbProgress.Size = new System.Drawing.Size(187, 32);
            this.LbProgress.TabIndex = 1;
            this.LbProgress.Text = "label1";
            this.LbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimelogSenderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 59);
            this.Controls.Add(this.LbProgress);
            this.Controls.Add(this.PbTimelogSent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "TimelogSenderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TimelogSenderView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar PbTimelogSent;
        private System.Windows.Forms.Label LbProgress;
    }
}
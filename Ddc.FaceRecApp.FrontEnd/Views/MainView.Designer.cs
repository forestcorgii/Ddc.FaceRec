
namespace Ddc.FaceRecApp.FrontEnd
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.MainFaceView = new Neurotec.Biometrics.Gui.NFaceView();
            this.lbStatusMessage = new System.Windows.Forms.Label();
            this.FsTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clEEId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTimestamp2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MbtnEnroll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LbSubjectCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.MainFaceView.Location = new System.Drawing.Point(17, 27);
            this.MainFaceView.Margin = new System.Windows.Forms.Padding(2);
            this.MainFaceView.Name = "MainFaceView";
            this.MainFaceView.ShowIcaoArrows = true;
            this.MainFaceView.ShowTokenImageRectangle = true;
            this.MainFaceView.Size = new System.Drawing.Size(687, 219);
            this.MainFaceView.TabIndex = 18;
            this.MainFaceView.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // lbStatusMessage
            // 
            this.lbStatusMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatusMessage.Location = new System.Drawing.Point(14, 652);
            this.lbStatusMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatusMessage.Name = "lbStatusMessage";
            this.lbStatusMessage.Size = new System.Drawing.Size(691, 37);
            this.lbStatusMessage.TabIndex = 20;
            this.lbStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FsTimer
            // 
            this.FsTimer.Interval = 2000;
            this.FsTimer.Tick += new System.EventHandler(this.FsTimer_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clEEId,
            this.clTimestamp,
            this.clTimestamp2,
            this.clDateSent});
            this.dataGridView1.Location = new System.Drawing.Point(18, 253);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(686, 394);
            this.dataGridView1.TabIndex = 21;
            // 
            // clEEId
            // 
            this.clEEId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clEEId.DataPropertyName = "EEId";
            this.clEEId.HeaderText = "Employee Id";
            this.clEEId.Name = "clEEId";
            this.clEEId.ReadOnly = true;
            this.clEEId.Width = 120;
            // 
            // clTimestamp
            // 
            this.clTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTimestamp.DataPropertyName = "FormattedTimestamp";
            this.clTimestamp.HeaderText = "Timestamp";
            this.clTimestamp.Name = "clTimestamp";
            this.clTimestamp.ReadOnly = true;
            // 
            // clTimestamp2
            // 
            this.clTimestamp2.DataPropertyName = "Timestamp";
            this.clTimestamp2.HeaderText = "Timestamp";
            this.clTimestamp2.Name = "clTimestamp2";
            this.clTimestamp2.ReadOnly = true;
            this.clTimestamp2.Visible = false;
            // 
            // clDateSent
            // 
            this.clDateSent.DataPropertyName = "DateSent";
            this.clDateSent.HeaderText = "Date Sent";
            this.clDateSent.Name = "clDateSent";
            this.clDateSent.ReadOnly = true;
            this.clDateSent.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MbtnEnroll});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(722, 25);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MbtnEnroll
            // 
            this.MbtnEnroll.Name = "MbtnEnroll";
            this.MbtnEnroll.Size = new System.Drawing.Size(49, 19);
            this.MbtnEnroll.Text = "Enroll";
            this.MbtnEnroll.Click += new System.EventHandler(this.MbtnEnroll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LbSubjectCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 698);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LbSubjectCount
            // 
            this.LbSubjectCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LbSubjectCount.Name = "LbSubjectCount";
            this.LbSubjectCount.Size = new System.Drawing.Size(0, 17);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 720);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbStatusMessage);
            this.Controls.Add(this.MainFaceView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Neurotec.Biometrics.Gui.NFaceView MainFaceView;
        private System.Windows.Forms.Label lbStatusMessage;
        private System.Windows.Forms.Timer FsTimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MbtnEnroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEEId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTimestamp2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateSent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LbSubjectCount;
    }
}


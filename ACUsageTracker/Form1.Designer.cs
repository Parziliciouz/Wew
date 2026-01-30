namespace ACUsageTracker;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.lblCurrentSession = new System.Windows.Forms.Label();
        this.lblTotalToday = new System.Windows.Forms.Label();
        this.btnStartStop = new System.Windows.Forms.Button();
        this.panelSessions = new System.Windows.Forms.FlowLayoutPanel();
        this.btnClear = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.panelMain = new System.Windows.Forms.Panel();
        this.panelHistory = new System.Windows.Forms.Panel();
        this.lblHistoryTitle = new System.Windows.Forms.Label();
        this.panelTodayTotal = new System.Windows.Forms.Panel();
        this.lblTodayLabel = new System.Windows.Forms.Label();
        this.lblHeader = new System.Windows.Forms.Label();
        this.panelMain.SuspendLayout();
        this.panelHistory.SuspendLayout();
        this.panelTodayTotal.SuspendLayout();
        this.SuspendLayout();

        // 
        // panelMain
        // 
        this.panelMain.BackColor = System.Drawing.Color.White;
        this.panelMain.Controls.Add(this.lblHeader);
        this.panelMain.Controls.Add(this.lblStatus);
        this.panelMain.Controls.Add(this.lblCurrentSession);
        this.panelMain.Controls.Add(this.btnStartStop);
        this.panelMain.Controls.Add(this.panelTodayTotal);
        this.panelMain.Location = new System.Drawing.Point(20, 20);
        this.panelMain.Name = "panelMain";
        this.panelMain.Size = new System.Drawing.Size(400, 320);
        this.panelMain.TabIndex = 0;

        // 
        // lblHeader
        // 
        this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
        this.lblHeader.Location = new System.Drawing.Point(0, 20);
        this.lblHeader.Name = "lblHeader";
        this.lblHeader.Size = new System.Drawing.Size(400, 30);
        this.lblHeader.TabIndex = 0;
        this.lblHeader.Text = "⏻ AC Usage Tracker";
        this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // 
        // lblStatus
        // 
        this.lblStatus.ForeColor = System.Drawing.Color.Gray;
        this.lblStatus.Location = new System.Drawing.Point(0, 60);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(400, 20);
        this.lblStatus.TabIndex = 1;
        this.lblStatus.Text = "Current Session";
        this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // 
        // lblCurrentSession
        // 
        this.lblCurrentSession.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
        this.lblCurrentSession.Location = new System.Drawing.Point(0, 80);
        this.lblCurrentSession.Name = "lblCurrentSession";
        this.lblCurrentSession.Size = new System.Drawing.Size(400, 80);
        this.lblCurrentSession.TabIndex = 2;
        this.lblCurrentSession.Text = "00:00:00";
        this.lblCurrentSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // 
        // btnStartStop
        // 
        this.btnStartStop.BackColor = System.Drawing.Color.FromArgb(25, 135, 84);
        this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnStartStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnStartStop.ForeColor = System.Drawing.Color.White;
        this.btnStartStop.Location = new System.Drawing.Point(30, 180);
        this.btnStartStop.Name = "btnStartStop";
        this.btnStartStop.Size = new System.Drawing.Size(340, 50);
        this.btnStartStop.TabIndex = 3;
        this.btnStartStop.Text = "⏻ Start AC";
        this.btnStartStop.UseVisualStyleBackColor = false;
        this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);

        // 
        // panelTodayTotal
        // 
        this.panelTodayTotal.BackColor = System.Drawing.Color.FromArgb(240, 247, 255);
        this.panelTodayTotal.Controls.Add(this.lblTodayLabel);
        this.panelTodayTotal.Controls.Add(this.lblTotalToday);
        this.panelTodayTotal.Location = new System.Drawing.Point(30, 250);
        this.panelTodayTotal.Name = "panelTodayTotal";
        this.panelTodayTotal.Size = new System.Drawing.Size(340, 50);
        this.panelTodayTotal.TabIndex = 4;

        // 
        // lblTodayLabel
        // 
        this.lblTodayLabel.AutoSize = true;
        this.lblTodayLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblTodayLabel.Location = new System.Drawing.Point(10, 15);
        this.lblTodayLabel.Name = "lblTodayLabel";
        this.lblTodayLabel.Size = new System.Drawing.Size(100, 19);
        this.lblTodayLabel.TabIndex = 0;
        this.lblTodayLabel.Text = "📅 Total Today";

        // 
        // lblTotalToday
        // 
        this.lblTotalToday.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblTotalToday.Location = new System.Drawing.Point(230, 15);
        this.lblTotalToday.Name = "lblTotalToday";
        this.lblTotalToday.Size = new System.Drawing.Size(100, 20);
        this.lblTotalToday.TabIndex = 1;
        this.lblTotalToday.Text = "00:00:00";
        this.lblTotalToday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        // 
        // panelHistory
        // 
        this.panelHistory.BackColor = System.Drawing.Color.White;
        this.panelHistory.Controls.Add(this.lblHistoryTitle);
        this.panelHistory.Controls.Add(this.btnClear);
        this.panelHistory.Controls.Add(this.panelSessions);
        this.panelHistory.Location = new System.Drawing.Point(20, 360);
        this.panelHistory.Name = "panelHistory";
        this.panelHistory.Size = new System.Drawing.Size(400, 300);
        this.panelHistory.TabIndex = 1;

        // 
        // lblHistoryTitle
        // 
        this.lblHistoryTitle.AutoSize = true;
        this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblHistoryTitle.Location = new System.Drawing.Point(15, 15);
        this.lblHistoryTitle.Name = "lblHistoryTitle";
        this.lblHistoryTitle.Size = new System.Drawing.Size(126, 20);
        this.lblHistoryTitle.TabIndex = 0;
        this.lblHistoryTitle.Text = "🕐 Today\'s Sessions";

        // 
        // btnClear
        // 
        this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClear.ForeColor = System.Drawing.Color.Gray;
        this.btnClear.Location = new System.Drawing.Point(320, 12);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(60, 25);
        this.btnClear.TabIndex = 1;
        this.btnClear.Text = "Clear";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

        // 
        // panelSessions
        // 
        this.panelSessions.AutoScroll = true;
        this.panelSessions.Location = new System.Drawing.Point(10, 50);
        this.panelSessions.Name = "panelSessions";
        this.panelSessions.Size = new System.Drawing.Size(380, 240);
        this.panelSessions.TabIndex = 2;

        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
        this.ClientSize = new System.Drawing.Size(440, 680);
        this.Controls.Add(this.panelHistory);
        this.Controls.Add(this.panelMain);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "AC Usage Tracker";
        this.panelMain.ResumeLayout(false);
        this.panelHistory.ResumeLayout(false);
        this.panelHistory.PerformLayout();
        this.panelTodayTotal.ResumeLayout(false);
        this.panelTodayTotal.PerformLayout();
        this.ResumeLayout(false);

    }

    private System.Windows.Forms.Label lblCurrentSession;
    private System.Windows.Forms.Label lblTotalToday;
    private System.Windows.Forms.Button btnStartStop;
    private System.Windows.Forms.FlowLayoutPanel panelSessions;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.Panel panelHistory;
    private System.Windows.Forms.Label lblHistoryTitle;
    private System.Windows.Forms.Panel panelTodayTotal;
    private System.Windows.Forms.Label lblTodayLabel;
    private System.Windows.Forms.Label lblHeader;

    #endregion
}

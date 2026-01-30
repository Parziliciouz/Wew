namespace ACUsageTracker;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.panelSidebar = new System.Windows.Forms.Panel();
        this.btnNavDashboard = new ACUsageTracker.SoftButton();
        this.btnNavStats = new ACUsageTracker.SoftButton();
        this.lblSidebarTitle = new System.Windows.Forms.Label();
        this.tabControlMain = new System.Windows.Forms.TabControl();
        this.tabPageDashboard = new System.Windows.Forms.TabPage();
        this.tabPageStats = new System.Windows.Forms.TabPage();
        
        // Dashboard Controls
        this.lblCurrentSession = new System.Windows.Forms.Label();
        this.lblTotalToday = new System.Windows.Forms.Label();
        this.btnStartStop = new ACUsageTracker.SoftButton();
        this.panelSessions = new System.Windows.Forms.FlowLayoutPanel();
        this.btnClear = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.panelMain = new System.Windows.Forms.Panel();
        this.panelHistory = new System.Windows.Forms.Panel();
        this.lblHistoryTitle = new System.Windows.Forms.Label();
        this.panelTodayTotal = new ACUsageTracker.SoftPanel();
        this.lblTodayLabel = new System.Windows.Forms.Label();
        
        // Stats Controls
        this.panelStatsWeekly = new ACUsageTracker.SoftPanel();
        this.lblWeeklyTotalLabel = new System.Windows.Forms.Label();
        this.lblWeeklyTotal = new System.Windows.Forms.Label();
        this.panelStatsMonthly = new ACUsageTracker.SoftPanel();
        this.lblMonthlyTotalLabel = new System.Windows.Forms.Label();
        this.lblMonthlyTotal = new System.Windows.Forms.Label();
        this.panelDailyAvg = new ACUsageTracker.SoftPanel();
        this.lblDailyAvgLabel = new System.Windows.Forms.Label();
        this.lblDailyAvg = new System.Windows.Forms.Label();
        this.lblStatsHeader = new System.Windows.Forms.Label();

        this.panelSidebar.SuspendLayout();
        this.tabControlMain.SuspendLayout();
        this.tabPageDashboard.SuspendLayout();
        this.tabPageStats.SuspendLayout();
        this.panelMain.SuspendLayout();
        this.panelHistory.SuspendLayout();
        this.panelTodayTotal.SuspendLayout();
        this.panelStatsWeekly.SuspendLayout();
        this.panelStatsMonthly.SuspendLayout();
        this.panelDailyAvg.SuspendLayout();
        this.SuspendLayout();

        // panelSidebar
        this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(224, 242, 254);
        this.panelSidebar.Controls.Add(this.btnNavDashboard);
        this.panelSidebar.Controls.Add(this.btnNavStats);
        this.panelSidebar.Controls.Add(this.lblSidebarTitle);
        this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.panelSidebar.Location = new System.Drawing.Point(0, 0);
        this.panelSidebar.Name = "panelSidebar";
        this.panelSidebar.Size = new System.Drawing.Size(200, 680);

        // lblSidebarTitle
        this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
        this.lblSidebarTitle.Location = new System.Drawing.Point(0, 30);
        this.lblSidebarTitle.Name = "lblSidebarTitle";
        this.lblSidebarTitle.Size = new System.Drawing.Size(200, 40);
        this.lblSidebarTitle.Text = "✨ AC Tracker";
        this.lblSidebarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // btnNavDashboard
        this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(186, 230, 253);
        this.btnNavDashboard.FlatAppearance.BorderSize = 0;
        this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        this.btnNavDashboard.Location = new System.Drawing.Point(15, 100);
        this.btnNavDashboard.Name = "btnNavDashboard";
        this.btnNavDashboard.Size = new System.Drawing.Size(170, 45);
        this.btnNavDashboard.Text = "🏠 Dashboard";
        this.btnNavDashboard.UseVisualStyleBackColor = false;
        this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
        this.btnNavDashboard.BorderRadius = 15;

        // btnNavStats
        this.btnNavStats.BackColor = System.Drawing.Color.Transparent;
        this.btnNavStats.FlatAppearance.BorderSize = 0;
        this.btnNavStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavStats.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnNavStats.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        this.btnNavStats.Location = new System.Drawing.Point(15, 155);
        this.btnNavStats.Name = "btnNavStats";
        this.btnNavStats.Size = new System.Drawing.Size(170, 45);
        this.btnNavStats.Text = "📊 Statistics";
        this.btnNavStats.UseVisualStyleBackColor = true;
        this.btnNavStats.Click += new System.EventHandler(this.btnNavStats_Click);
        this.btnNavStats.BorderRadius = 15;

        // tabControlMain
        this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
        this.tabControlMain.Controls.Add(this.tabPageDashboard);
        this.tabControlMain.Controls.Add(this.tabPageStats);
        this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControlMain.ItemSize = new System.Drawing.Size(0, 1);
        this.tabControlMain.Location = new System.Drawing.Point(200, 0);
        this.tabControlMain.Name = "tabControlMain";
        this.tabControlMain.Size = new System.Drawing.Size(440, 680);
        this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;

        // tabPageDashboard
        this.tabPageDashboard.BackColor = System.Drawing.Color.White;
        this.tabPageDashboard.Controls.Add(this.panelHistory);
        this.tabPageDashboard.Controls.Add(this.panelMain);
        this.tabPageDashboard.Location = new System.Drawing.Point(4, 5);
        this.tabPageDashboard.Name = "tabPageDashboard";
        this.tabPageDashboard.Size = new System.Drawing.Size(432, 671);
        this.tabPageDashboard.Text = "Dashboard";

        // panelMain
        this.panelMain.BackColor = System.Drawing.Color.White;
        this.panelMain.Controls.Add(this.lblStatus);
        this.panelMain.Controls.Add(this.lblCurrentSession);
        this.panelMain.Controls.Add(this.btnStartStop);
        this.panelMain.Controls.Add(this.panelTodayTotal);
        this.panelMain.Location = new System.Drawing.Point(16, 20);
        this.panelMain.Name = "panelMain";
        this.panelMain.Size = new System.Drawing.Size(400, 280);

        // lblStatus
        this.lblStatus.ForeColor = System.Drawing.Color.Gray;
        this.lblStatus.Location = new System.Drawing.Point(0, 40);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(400, 20);
        this.lblStatus.Text = "Current Cooling Session ☁";
        this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblCurrentSession
        this.lblCurrentSession.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
        this.lblCurrentSession.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        this.lblCurrentSession.Location = new System.Drawing.Point(0, 60);
        this.lblCurrentSession.Name = "lblCurrentSession";
        this.lblCurrentSession.Size = new System.Drawing.Size(400, 80);
        this.lblCurrentSession.Text = "00:00:00";
        this.lblCurrentSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // btnStartStop
        this.btnStartStop.BackColor = System.Drawing.Color.FromArgb(134, 239, 172);
        this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnStartStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnStartStop.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        this.btnStartStop.Location = new System.Drawing.Point(30, 160);
        this.btnStartStop.Name = "btnStartStop";
        this.btnStartStop.Size = new System.Drawing.Size(340, 60);
        this.btnStartStop.Text = "✨ Start AC";
        this.btnStartStop.UseVisualStyleBackColor = false;
        this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
        this.btnStartStop.BorderRadius = 25;

        // panelTodayTotal
        this.panelTodayTotal.BackColor = System.Drawing.Color.FromArgb(254, 249, 195);
        this.panelTodayTotal.Controls.Add(this.lblTodayLabel);
        this.panelTodayTotal.Controls.Add(this.lblTotalToday);
        this.panelTodayTotal.Location = new System.Drawing.Point(30, 230);
        this.panelTodayTotal.Name = "panelTodayTotal";
        this.panelTodayTotal.Size = new System.Drawing.Size(340, 40);
        this.panelTodayTotal.BorderRadius = 15;

        // lblTodayLabel
        this.lblTodayLabel.AutoSize = true;
        this.lblTodayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblTodayLabel.ForeColor = System.Drawing.Color.FromArgb(161, 98, 7);
        this.lblTodayLabel.Location = new System.Drawing.Point(15, 12);
        this.lblTodayLabel.Name = "lblTodayLabel";
        this.lblTodayLabel.Size = new System.Drawing.Size(89, 15);
        this.lblTodayLabel.Text = "📅 Total Today";

        // lblTotalToday
        this.lblTotalToday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblTotalToday.ForeColor = System.Drawing.Color.FromArgb(161, 98, 7);
        this.lblTotalToday.Location = new System.Drawing.Point(230, 12);
        this.lblTotalToday.Name = "lblTotalToday";
        this.lblTotalToday.Size = new System.Drawing.Size(100, 20);
        this.lblTotalToday.Text = "00:00:00";
        this.lblTotalToday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        // panelHistory
        this.panelHistory.BackColor = System.Drawing.Color.White;
        this.panelHistory.Controls.Add(this.lblHistoryTitle);
        this.panelHistory.Controls.Add(this.btnClear);
        this.panelHistory.Controls.Add(this.panelSessions);
        this.panelHistory.Location = new System.Drawing.Point(16, 315);
        this.panelHistory.Name = "panelHistory";
        this.panelHistory.Size = new System.Drawing.Size(400, 340);

        // lblHistoryTitle
        this.lblHistoryTitle.AutoSize = true;
        this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
        this.lblHistoryTitle.Location = new System.Drawing.Point(15, 15);
        this.lblHistoryTitle.Name = "lblHistoryTitle";
        this.lblHistoryTitle.Size = new System.Drawing.Size(126, 20);
        this.lblHistoryTitle.Text = "🕒 Today\'s History";

        // btnClear
        this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.btnClear.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        this.btnClear.Location = new System.Drawing.Point(320, 12);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(60, 25);
        this.btnClear.Text = "Wipe";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

        // panelSessions
        this.panelSessions.AutoScroll = true;
        this.panelSessions.Location = new System.Drawing.Point(10, 50);
        this.panelSessions.Name = "panelSessions";
        this.panelSessions.Size = new System.Drawing.Size(380, 280);

        // tabPageStats
        this.tabPageStats.BackColor = System.Drawing.Color.White;
        this.tabPageStats.Controls.Add(this.lblStatsHeader);
        this.tabPageStats.Controls.Add(this.panelStatsWeekly);
        this.tabPageStats.Controls.Add(this.panelStatsMonthly);
        this.tabPageStats.Controls.Add(this.panelDailyAvg);
        this.tabPageStats.Location = new System.Drawing.Point(4, 5);
        this.tabPageStats.Name = "tabPageStats";
        this.tabPageStats.Size = new System.Drawing.Size(432, 671);
        this.tabPageStats.Text = "Stats";

        // lblStatsHeader
        this.lblStatsHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblStatsHeader.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
        this.lblStatsHeader.Location = new System.Drawing.Point(20, 30);
        this.lblStatsHeader.Name = "lblStatsHeader";
        this.lblStatsHeader.Size = new System.Drawing.Size(392, 40);
        this.lblStatsHeader.Text = "Cooling Overview ✨";

        // panelStatsWeekly
        this.panelStatsWeekly.BackColor = System.Drawing.Color.FromArgb(224, 242, 254);
        this.panelStatsWeekly.Controls.Add(this.lblWeeklyTotalLabel);
        this.panelStatsWeekly.Controls.Add(this.lblWeeklyTotal);
        this.panelStatsWeekly.Location = new System.Drawing.Point(20, 90);
        this.panelStatsWeekly.Name = "panelStatsWeekly";
        this.panelStatsWeekly.Size = new System.Drawing.Size(392, 100);
        this.panelStatsWeekly.BorderRadius = 20;

        // lblWeeklyTotalLabel
        this.lblWeeklyTotalLabel.AutoSize = true;
        this.lblWeeklyTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
        this.lblWeeklyTotalLabel.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
        this.lblWeeklyTotalLabel.Location = new System.Drawing.Point(20, 20);
        this.lblWeeklyTotalLabel.Name = "lblWeeklyTotalLabel";
        this.lblWeeklyTotalLabel.Size = new System.Drawing.Size(117, 19);
        this.lblWeeklyTotalLabel.Text = "Weekly Magic ☁";

        // lblWeeklyTotal
        this.lblWeeklyTotal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
        this.lblWeeklyTotal.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
        this.lblWeeklyTotal.Location = new System.Drawing.Point(20, 40);
        this.lblWeeklyTotal.Name = "lblWeeklyTotal";
        this.lblWeeklyTotal.Size = new System.Drawing.Size(350, 50);
        this.lblWeeklyTotal.Text = "00:00:00";

        // panelStatsMonthly
        this.panelStatsMonthly.BackColor = System.Drawing.Color.FromArgb(254, 249, 195);
        this.panelStatsMonthly.Controls.Add(this.lblMonthlyTotalLabel);
        this.panelStatsMonthly.Controls.Add(this.lblMonthlyTotal);
        this.panelStatsMonthly.Location = new System.Drawing.Point(20, 210);
        this.panelStatsMonthly.Name = "panelStatsMonthly";
        this.panelStatsMonthly.Size = new System.Drawing.Size(392, 100);
        this.panelStatsMonthly.BorderRadius = 20;

        // lblMonthlyTotalLabel
        this.lblMonthlyTotalLabel.AutoSize = true;
        this.lblMonthlyTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
        this.lblMonthlyTotalLabel.ForeColor = System.Drawing.Color.FromArgb(161, 98, 7);
        this.lblMonthlyTotalLabel.Location = new System.Drawing.Point(20, 20);
        this.lblMonthlyTotalLabel.Name = "lblMonthlyTotalLabel";
        this.lblMonthlyTotalLabel.Size = new System.Drawing.Size(125, 19);
        this.lblMonthlyTotalLabel.Text = "Monthly Dream 🌙";

        // lblMonthlyTotal
        this.lblMonthlyTotal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
        this.lblMonthlyTotal.ForeColor = System.Drawing.Color.FromArgb(161, 98, 7);
        this.lblMonthlyTotal.Location = new System.Drawing.Point(20, 40);
        this.lblMonthlyTotal.Name = "lblMonthlyTotal";
        this.lblMonthlyTotal.Size = new System.Drawing.Size(350, 50);
        this.lblMonthlyTotal.Text = "00:00:00";

        // panelDailyAvg
        this.panelDailyAvg.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        this.panelDailyAvg.Controls.Add(this.lblDailyAvgLabel);
        this.panelDailyAvg.Controls.Add(this.lblDailyAvg);
        this.panelDailyAvg.Location = new System.Drawing.Point(20, 330);
        this.panelDailyAvg.Name = "panelDailyAvg";
        this.panelDailyAvg.Size = new System.Drawing.Size(392, 100);
        this.panelDailyAvg.BorderRadius = 20;

        // lblDailyAvgLabel
        this.lblDailyAvgLabel.AutoSize = true;
        this.lblDailyAvgLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
        this.lblDailyAvgLabel.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblDailyAvgLabel.Location = new System.Drawing.Point(20, 20);
        this.lblDailyAvgLabel.Name = "lblDailyAvgLabel";
        this.lblDailyAvgLabel.Size = new System.Drawing.Size(130, 19);
        this.lblDailyAvgLabel.Text = "Daily Average ✨";

        // lblDailyAvg
        this.lblDailyAvg.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
        this.lblDailyAvg.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblDailyAvg.Location = new System.Drawing.Point(20, 40);
        this.lblDailyAvg.Name = "lblDailyAvg";
        this.lblDailyAvg.Size = new System.Drawing.Size(350, 50);
        this.lblDailyAvg.Text = "00:00:00";

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(640, 680);
        this.Controls.Add(this.tabControlMain);
        this.Controls.Add(this.panelSidebar);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "AC Usage Tracker - Cute Edition";

        this.panelSidebar.ResumeLayout(false);
        this.tabControlMain.ResumeLayout(false);
        this.tabPageDashboard.ResumeLayout(false);
        this.tabPageStats.ResumeLayout(false);
        this.panelMain.ResumeLayout(false);
        this.panelHistory.ResumeLayout(false);
        this.panelHistory.PerformLayout();
        this.panelTodayTotal.ResumeLayout(false);
        this.panelTodayTotal.PerformLayout();
        this.panelStatsWeekly.ResumeLayout(false);
        this.panelStatsWeekly.PerformLayout();
        this.panelStatsMonthly.ResumeLayout(false);
        this.panelStatsMonthly.PerformLayout();
        this.panelDailyAvg.ResumeLayout(false);
        this.panelDailyAvg.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelSidebar;
    private ACUsageTracker.SoftButton btnNavDashboard;
    private ACUsageTracker.SoftButton btnNavStats;
    private System.Windows.Forms.Label lblSidebarTitle;
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageDashboard;
    private System.Windows.Forms.TabPage tabPageStats;

    private System.Windows.Forms.Label lblCurrentSession;
    private System.Windows.Forms.Label lblTotalToday;
    private ACUsageTracker.SoftButton btnStartStop;
    private System.Windows.Forms.FlowLayoutPanel panelSessions;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.Panel panelHistory;
    private System.Windows.Forms.Label lblHistoryTitle;
    private ACUsageTracker.SoftPanel panelTodayTotal;
    private System.Windows.Forms.Label lblTodayLabel;

    private ACUsageTracker.SoftPanel panelStatsWeekly;
    private System.Windows.Forms.Label lblWeeklyTotalLabel;
    private System.Windows.Forms.Label lblWeeklyTotal;
    private ACUsageTracker.SoftPanel panelStatsMonthly;
    private System.Windows.Forms.Label lblMonthlyTotalLabel;
    private System.Windows.Forms.Label lblMonthlyTotal;
    private ACUsageTracker.SoftPanel panelDailyAvg;
    private System.Windows.Forms.Label lblDailyAvgLabel;
    private System.Windows.Forms.Label lblDailyAvg;
    private System.Windows.Forms.Label lblStatsHeader;

    #endregion
}

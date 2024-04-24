namespace CPactServerDBBackup
{
    public partial class Form1 : Form
    {
        // Backup variable.
        DateTime backupLast = DateTime.UnixEpoch;

        // Constructor.
        public Form1()
        {
            InitializeComponent();
        }

        // Loading.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initializing timer.
            backupLabel.ForeColor = Color.Gray;
            backupLabel.Text = "Field unlocked...";
        }

        // Toggling text field.
        private void backupToggle_Click(object sender, EventArgs e)
        {
            // Toggling.
            backupText.Enabled = !backupText.Enabled;
            backupToggle.Text = (backupText.Enabled ? "Lock" : "Unlock");

            // Starting timer.
            if (!backupText.Enabled)
            {
                backupLast = DateTime.UnixEpoch;
                backupTimer.Interval = 1;
                backupTimer.Start();
            }

            // Ending timer.
            else
            {
                backupLabel.ForeColor = Color.Gray;
                backupLabel.Text = "Field unlocked...";
                backupTimer.Stop();
            }
        }

        // Timer tick.
        private void backupTimer_Tick(object sender, EventArgs e)
        {
            // Must have been at least an hour since the previous backup.
            if (DateTime.Now - backupLast >= TimeSpan.FromHours(1))
            {
                // Updating log.
                backupLabel.ForeColor = Color.Black;
                backupLabel.Text = $"{DateTime.Now}";

                // Getting file and directory.
                string _tempFileFull = backupText.Text;
                string _tempDir = _tempFileFull.Substring(0, _tempFileFull.IndexOf("/") + 1);
                string _tempFile = _tempFileFull.Substring(_tempFileFull.IndexOf("/") + 1);
                _tempFile = _tempFile.Insert(_tempFile.LastIndexOf("."), $"_BACKUP_{DateTime.Now.Hour}");

                // File must exist.
                if (File.Exists(_tempFileFull))
                {
                    // Try.
                    try
                    {
                        if (!Directory.Exists($"{_tempDir}backups/")) Directory.CreateDirectory($"{_tempDir}backups/");
                        string _copyFile = $"{_tempDir}backups/{_tempFile}";
                        if (File.Exists(_copyFile)) File.Delete(_copyFile);
                        File.Copy(_tempFileFull, _copyFile, false);
                    }

                    // Catch.
                    catch (Exception ex)
                    {
                        backupLabel.Text = "Backup failed";
                    }
                }

                // File is missing.
                else
                {
                    backupLabel.ForeColor = Color.Red;
                    backupLabel.Text = "File not found";
                }
            }

            // Reset.
            backupTimer.Interval = 60000;
            backupTimer.Start();
        }
    }
}
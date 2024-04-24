namespace CPactServerDBBackup
{
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
            this.backupTimer = new System.Windows.Forms.Timer(this.components);
            this.backupText = new System.Windows.Forms.TextBox();
            this.backupToggle = new System.Windows.Forms.Button();
            this.backupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backupTimer
            // 
            this.backupTimer.Tick += new System.EventHandler(this.backupTimer_Tick);
            // 
            // backupText
            // 
            this.backupText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupText.Location = new System.Drawing.Point(12, 12);
            this.backupText.Name = "backupText";
            this.backupText.Size = new System.Drawing.Size(230, 25);
            this.backupText.TabIndex = 0;
            this.backupText.Text = "cpact_item_database.db";
            // 
            // backupToggle
            // 
            this.backupToggle.Location = new System.Drawing.Point(189, 43);
            this.backupToggle.Name = "backupToggle";
            this.backupToggle.Size = new System.Drawing.Size(53, 23);
            this.backupToggle.TabIndex = 1;
            this.backupToggle.Text = "Lock";
            this.backupToggle.UseVisualStyleBackColor = true;
            this.backupToggle.Click += new System.EventHandler(this.backupToggle_Click);
            // 
            // backupLabel
            // 
            this.backupLabel.AutoSize = true;
            this.backupLabel.Location = new System.Drawing.Point(12, 47);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(70, 15);
            this.backupLabel.TabIndex = 2;
            this.backupLabel.Text = "Initializing...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 79);
            this.Controls.Add(this.backupLabel);
            this.Controls.Add(this.backupToggle);
            this.Controls.Add(this.backupText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Database Backup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer backupTimer;
        private TextBox backupText;
        private Button backupToggle;
        private Label backupLabel;
    }
}
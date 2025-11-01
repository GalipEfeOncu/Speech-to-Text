namespace Speech_to_Text
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
            btnStart = new Button();
            txtResults = new TextBox();
            btnStop = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            lblStatus = new Label();
            radioEnglish = new RadioButton();
            radioTurkish = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(58, 58, 92);
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(7, 7);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 36);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // txtResults
            // 
            txtResults.BackColor = Color.FromArgb(20, 20, 35);
            txtResults.BorderStyle = BorderStyle.None;
            txtResults.Dock = DockStyle.Fill;
            txtResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResults.ForeColor = Color.White;
            txtResults.Location = new Point(0, 50);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(784, 361);
            txtResults.TabIndex = 1;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(58, 58, 92);
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Location = new Point(113, 7);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 36);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(58, 58, 92);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(219, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 47);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(radioEnglish);
            panel1.Controls.Add(radioTurkish);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnStop);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(784, 50);
            panel1.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(490, 17);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(128, 19);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Language: English";
            // 
            // radioEnglish
            // 
            radioEnglish.AutoSize = true;
            radioEnglish.Checked = true;
            radioEnglish.Location = new Point(331, 16);
            radioEnglish.Name = "radioEnglish";
            radioEnglish.Size = new Size(73, 23);
            radioEnglish.TabIndex = 5;
            radioEnglish.TabStop = true;
            radioEnglish.Text = "English";
            radioEnglish.UseVisualStyleBackColor = true;
            radioEnglish.CheckedChanged += radioEnglish_CheckedChanged;
            // 
            // radioTurkish
            // 
            radioTurkish.AutoSize = true;
            radioTurkish.Location = new Point(410, 16);
            radioTurkish.Name = "radioTurkish";
            radioTurkish.Size = new Size(74, 23);
            radioTurkish.TabIndex = 4;
            radioTurkish.Text = "Turkish";
            radioTurkish.UseVisualStyleBackColor = true;
            radioTurkish.CheckedChanged += radioTurkish_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(txtResults);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Speech to Text";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txtResults;
        private Button btnStop;
        private Button btnSave;
        private Panel panel1;
        private RadioButton radioEnglish;
        private RadioButton radioTurkish;
        private Label lblStatus;
    }
}

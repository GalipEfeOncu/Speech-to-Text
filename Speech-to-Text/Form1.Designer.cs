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
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 44);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtResults
            // 
            txtResults.Dock = DockStyle.Fill;
            txtResults.Location = new Point(0, 50);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(800, 400);
            txtResults.TabIndex = 1;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(109, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 44);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(215, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 44);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(radioEnglish);
            panel1.Controls.Add(radioTurkish);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnStop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(460, 14);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "label1";
            // 
            // radioEnglish
            // 
            radioEnglish.AutoSize = true;
            radioEnglish.Checked = true;
            radioEnglish.Location = new Point(321, 12);
            radioEnglish.Name = "radioEnglish";
            radioEnglish.Size = new Size(63, 19);
            radioEnglish.TabIndex = 5;
            radioEnglish.TabStop = true;
            radioEnglish.Text = "English";
            radioEnglish.UseVisualStyleBackColor = true;
            radioEnglish.CheckedChanged += radioEnglish_CheckedChanged;
            // 
            // radioTurkish
            // 
            radioTurkish.AutoSize = true;
            radioTurkish.Location = new Point(390, 12);
            radioTurkish.Name = "radioTurkish";
            radioTurkish.Size = new Size(64, 19);
            radioTurkish.TabIndex = 4;
            radioTurkish.Text = "Turkish";
            radioTurkish.UseVisualStyleBackColor = true;
            radioTurkish.CheckedChanged += radioTurkish_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResults);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
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

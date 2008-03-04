namespace ChairExperiment
{
    partial class administratorWindow
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
            this.textBoxFirstArrayPos = new System.Windows.Forms.TextBox();
            this.textBoxSecondArrayPos = new System.Windows.Forms.TextBox();
            this.textBoxFirstFreq = new System.Windows.Forms.TextBox();
            this.textBoxSecondFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSessionNumber = new System.Windows.Forms.Label();
            this.labelIsPlaying = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderSession = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFirstPos = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSecondPos = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFirst = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSecond = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAnswer = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCorrect = new System.Windows.Forms.ColumnHeader();
            this.buttonFindThresholds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstArrayPos
            // 
            this.textBoxFirstArrayPos.Location = new System.Drawing.Point(214, 30);
            this.textBoxFirstArrayPos.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFirstArrayPos.Name = "textBoxFirstArrayPos";
            this.textBoxFirstArrayPos.Size = new System.Drawing.Size(196, 31);
            this.textBoxFirstArrayPos.TabIndex = 0;
            // 
            // textBoxSecondArrayPos
            // 
            this.textBoxSecondArrayPos.Location = new System.Drawing.Point(214, 93);
            this.textBoxSecondArrayPos.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSecondArrayPos.Name = "textBoxSecondArrayPos";
            this.textBoxSecondArrayPos.Size = new System.Drawing.Size(196, 31);
            this.textBoxSecondArrayPos.TabIndex = 1;
            // 
            // textBoxFirstFreq
            // 
            this.textBoxFirstFreq.Location = new System.Drawing.Point(214, 163);
            this.textBoxFirstFreq.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFirstFreq.Name = "textBoxFirstFreq";
            this.textBoxFirstFreq.Size = new System.Drawing.Size(196, 31);
            this.textBoxFirstFreq.TabIndex = 2;
            // 
            // textBoxSecondFreq
            // 
            this.textBoxSecondFreq.Location = new System.Drawing.Point(214, 230);
            this.textBoxSecondFreq.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSecondFreq.Name = "textBoxSecondFreq";
            this.textBoxSecondFreq.Size = new System.Drawing.Size(196, 31);
            this.textBoxSecondFreq.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "1st Array Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "2nd Array Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "1st Frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "2nd Frequency";
            // 
            // labelSessionNumber
            // 
            this.labelSessionNumber.AutoSize = true;
            this.labelSessionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionNumber.Location = new System.Drawing.Point(26, 311);
            this.labelSessionNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSessionNumber.Name = "labelSessionNumber";
            this.labelSessionNumber.Size = new System.Drawing.Size(89, 25);
            this.labelSessionNumber.TabIndex = 8;
            this.labelSessionNumber.Text = "Session";
            // 
            // labelIsPlaying
            // 
            this.labelIsPlaying.AutoSize = true;
            this.labelIsPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsPlaying.Location = new System.Drawing.Point(26, 365);
            this.labelIsPlaying.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIsPlaying.Name = "labelIsPlaying";
            this.labelIsPlaying.Size = new System.Drawing.Size(83, 25);
            this.labelIsPlaying.TabIndex = 9;
            this.labelIsPlaying.Text = "Playing";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(26, 418);
            this.labelAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(83, 25);
            this.labelAnswer.TabIndex = 10;
            this.labelAnswer.Text = "Answer";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSession,
            this.columnHeaderFirstPos,
            this.columnHeaderSecondPos,
            this.columnHeaderFirst,
            this.columnHeaderSecond,
            this.columnHeaderAnswer,
            this.columnHeaderCorrect});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(457, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(493, 510);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSession
            // 
            this.columnHeaderSession.Text = "Session";
            this.columnHeaderSession.Width = 64;
            // 
            // columnHeaderFirstPos
            // 
            this.columnHeaderFirstPos.Text = "Fpos";
            // 
            // columnHeaderSecondPos
            // 
            this.columnHeaderSecondPos.Text = "SPos";
            // 
            // columnHeaderFirst
            // 
            this.columnHeaderFirst.Text = "First Stim";
            this.columnHeaderFirst.Width = 79;
            // 
            // columnHeaderSecond
            // 
            this.columnHeaderSecond.Text = "Second Stim";
            this.columnHeaderSecond.Width = 98;
            // 
            // columnHeaderAnswer
            // 
            this.columnHeaderAnswer.Text = "Answer";
            // 
            // columnHeaderCorrect
            // 
            this.columnHeaderCorrect.Text = "Correct";
            this.columnHeaderCorrect.Width = 62;
            // 
            // buttonFindThresholds
            // 
            this.buttonFindThresholds.Location = new System.Drawing.Point(28, 519);
            this.buttonFindThresholds.Name = "buttonFindThresholds";
            this.buttonFindThresholds.Size = new System.Drawing.Size(186, 33);
            this.buttonFindThresholds.TabIndex = 12;
            this.buttonFindThresholds.Text = "Find Thresholds";
            this.buttonFindThresholds.UseVisualStyleBackColor = true;
            this.buttonFindThresholds.Click += new System.EventHandler(this.buttonFindThresholds_Click);
            // 
            // administratorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 573);
            this.Controls.Add(this.buttonFindThresholds);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelIsPlaying);
            this.Controls.Add(this.labelSessionNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSecondFreq);
            this.Controls.Add(this.textBoxFirstFreq);
            this.Controls.Add(this.textBoxSecondArrayPos);
            this.Controls.Add(this.textBoxFirstArrayPos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "administratorWindow";
            this.Text = "Administrator Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.administratorWindow_Close);
            this.Load += new System.EventHandler(this.administratorWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxFirstArrayPos;
        public System.Windows.Forms.TextBox textBoxSecondArrayPos;
        public System.Windows.Forms.TextBox textBoxFirstFreq;
        public System.Windows.Forms.TextBox textBoxSecondFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelSessionNumber;
        public System.Windows.Forms.Label labelIsPlaying;
        public System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.ColumnHeader columnHeaderSession;
        private System.Windows.Forms.ColumnHeader columnHeaderFirst;
        private System.Windows.Forms.ColumnHeader columnHeaderSecond;
        private System.Windows.Forms.ColumnHeader columnHeaderAnswer;
        private System.Windows.Forms.ColumnHeader columnHeaderCorrect;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderSecondPos;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstPos;
        private System.Windows.Forms.Button buttonFindThresholds;

    }
}
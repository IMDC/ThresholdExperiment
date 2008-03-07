namespace ChairExperiment
{
    partial class Form1
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton60 = new System.Windows.Forms.RadioButton();
            this.radioButton50 = new System.Windows.Forms.RadioButton();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonNovice = new System.Windows.Forms.RadioButton();
            this.radioButtonIntermediate = new System.Windows.Forms.RadioButton();
            this.radioButtonExpert = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonPro = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonLeftHand = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonRightHand = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(242, 193);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(270, 88);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start New Experiment";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(15, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 4;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(15, 42);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 5;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Location = new System.Drawing.Point(32, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.Location = new System.Drawing.Point(23, 51);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(52, 17);
            this.radioButton30.TabIndex = 5;
            this.radioButton30.Text = "30-39";
            this.radioButton30.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(23, 28);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(52, 17);
            this.radioButton19.TabIndex = 4;
            this.radioButton19.Text = "19-29";
            this.radioButton19.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton60);
            this.groupBox2.Controls.Add(this.radioButton50);
            this.groupBox2.Controls.Add(this.radioButton40);
            this.groupBox2.Controls.Add(this.radioButton30);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioButton19);
            this.groupBox2.Location = new System.Drawing.Point(135, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 149);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Age";
            // 
            // radioButton60
            // 
            this.radioButton60.AutoSize = true;
            this.radioButton60.Location = new System.Drawing.Point(23, 120);
            this.radioButton60.Name = "radioButton60";
            this.radioButton60.Size = new System.Drawing.Size(43, 17);
            this.radioButton60.TabIndex = 8;
            this.radioButton60.Text = "60+";
            this.radioButton60.UseVisualStyleBackColor = true;
            // 
            // radioButton50
            // 
            this.radioButton50.AutoSize = true;
            this.radioButton50.Location = new System.Drawing.Point(23, 97);
            this.radioButton50.Name = "radioButton50";
            this.radioButton50.Size = new System.Drawing.Size(52, 17);
            this.radioButton50.TabIndex = 7;
            this.radioButton50.Text = "50-59";
            this.radioButton50.UseVisualStyleBackColor = true;
            // 
            // radioButton40
            // 
            this.radioButton40.AutoSize = true;
            this.radioButton40.Location = new System.Drawing.Point(23, 74);
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.Size = new System.Drawing.Size(52, 17);
            this.radioButton40.TabIndex = 6;
            this.radioButton40.Text = "40-49";
            this.radioButton40.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonNo);
            this.groupBox3.Controls.Add(this.radioButtonNovice);
            this.groupBox3.Controls.Add(this.radioButtonIntermediate);
            this.groupBox3.Controls.Add(this.radioButtonExpert);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.radioButtonPro);
            this.groupBox3.Location = new System.Drawing.Point(242, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 149);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Computer Experience";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(23, 120);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(94, 17);
            this.radioButtonNo.TabIndex = 8;
            this.radioButtonNo.Text = "No experience";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonNovice
            // 
            this.radioButtonNovice.AutoSize = true;
            this.radioButtonNovice.Location = new System.Drawing.Point(23, 97);
            this.radioButtonNovice.Name = "radioButtonNovice";
            this.radioButtonNovice.Size = new System.Drawing.Size(59, 17);
            this.radioButtonNovice.TabIndex = 7;
            this.radioButtonNovice.Text = "Novice";
            this.radioButtonNovice.UseVisualStyleBackColor = true;
            // 
            // radioButtonIntermediate
            // 
            this.radioButtonIntermediate.AutoSize = true;
            this.radioButtonIntermediate.Location = new System.Drawing.Point(23, 74);
            this.radioButtonIntermediate.Name = "radioButtonIntermediate";
            this.radioButtonIntermediate.Size = new System.Drawing.Size(83, 17);
            this.radioButtonIntermediate.TabIndex = 6;
            this.radioButtonIntermediate.Text = "Intermediate";
            this.radioButtonIntermediate.UseVisualStyleBackColor = true;
            // 
            // radioButtonExpert
            // 
            this.radioButtonExpert.AutoSize = true;
            this.radioButtonExpert.Location = new System.Drawing.Point(23, 51);
            this.radioButtonExpert.Name = "radioButtonExpert";
            this.radioButtonExpert.Size = new System.Drawing.Size(55, 17);
            this.radioButtonExpert.TabIndex = 5;
            this.radioButtonExpert.Text = "Expert";
            this.radioButtonExpert.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // radioButtonPro
            // 
            this.radioButtonPro.AutoSize = true;
            this.radioButtonPro.Location = new System.Drawing.Point(23, 28);
            this.radioButtonPro.Name = "radioButtonPro";
            this.radioButtonPro.Size = new System.Drawing.Size(85, 17);
            this.radioButtonPro.TabIndex = 4;
            this.radioButtonPro.Text = "Profressional";
            this.radioButtonPro.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonLeftHand);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.radioButtonRightHand);
            this.groupBox4.Location = new System.Drawing.Point(394, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 91);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Handedness";
            // 
            // radioButtonLeftHand
            // 
            this.radioButtonLeftHand.AutoSize = true;
            this.radioButtonLeftHand.Location = new System.Drawing.Point(23, 51);
            this.radioButtonLeftHand.Name = "radioButtonLeftHand";
            this.radioButtonLeftHand.Size = new System.Drawing.Size(43, 17);
            this.radioButtonLeftHand.TabIndex = 5;
            this.radioButtonLeftHand.Text = "Left";
            this.radioButtonLeftHand.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // radioButtonRightHand
            // 
            this.radioButtonRightHand.AutoSize = true;
            this.radioButtonRightHand.Location = new System.Drawing.Point(23, 28);
            this.radioButtonRightHand.Name = "radioButtonRightHand";
            this.radioButtonRightHand.Size = new System.Drawing.Size(50, 17);
            this.radioButtonRightHand.TabIndex = 4;
            this.radioButtonRightHand.Text = "Right";
            this.radioButtonRightHand.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonLeft);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.radioButtonRight);
            this.groupBox5.Location = new System.Drawing.Point(551, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 91);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Speaker Side";
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.AutoSize = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(23, 51);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(43, 17);
            this.radioButtonLeft.TabIndex = 5;
            this.radioButtonLeft.Text = "Left";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.AutoSize = true;
            this.radioButtonRight.Location = new System.Drawing.Point(23, 28);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(50, 17);
            this.radioButtonRight.TabIndex = 4;
            this.radioButtonRight.Text = "Right";
            this.radioButtonRight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 304);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton30;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton50;
        private System.Windows.Forms.RadioButton radioButton40;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton60;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonNovice;
        private System.Windows.Forms.RadioButton radioButtonIntermediate;
        private System.Windows.Forms.RadioButton radioButtonExpert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonPro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonLeftHand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonRightHand;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonRight;



    }
}


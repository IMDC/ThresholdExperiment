

namespace ChairExperiment
{
    partial class subjectWindow
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
            Mitov.AudioLab.AudioFormat audioFormat3 = new Mitov.AudioLab.AudioFormat();
            OpenWire.Proxy.SinkPin sinkPin11 = new OpenWire.Proxy.SinkPin();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subjectWindow));
            OpenWire.Proxy.StatePin statePin7 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.StatePin statePin8 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.SourcePin sourcePin5 = new OpenWire.Proxy.SourcePin();
            OpenWire.Proxy.SinkPin sinkPin12 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.PinList pinList19 = new OpenWire.Proxy.PinList();
            Mitov.AudioLab.DSAudioOutputDevice dsAudioOutputDevice3 = new Mitov.AudioLab.DSAudioOutputDevice();
            OpenWire.Proxy.StatePin statePin9 = new OpenWire.Proxy.StatePin();
            Mitov.AudioLab.DSGraph dsGraph3 = new Mitov.AudioLab.DSGraph();
            OpenWire.Proxy.SinkPin sinkPin13 = new OpenWire.Proxy.SinkPin();
            Mitov.AudioLab.SystemMixerControlGroups systemMixerControlGroups3 = new Mitov.AudioLab.SystemMixerControlGroups();
            Mitov.AudioLab.SystemMixerControlPinGroups systemMixerControlPinGroups3 = new Mitov.AudioLab.SystemMixerControlPinGroups();
            OpenWire.Proxy.PinList pinList20 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList21 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList22 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList23 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList24 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList25 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList26 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList27 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.SinkPin sinkPin14 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SinkPin sinkPin15 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SourcePin sourcePin6 = new OpenWire.Proxy.SourcePin();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlay1 = new System.Windows.Forms.Button();
            this.buttonDifferent = new System.Windows.Forms.Button();
            this.buttonSame = new System.Windows.Forms.Button();
            this.labelSession = new System.Windows.Forms.Label();
            this.signalGen1 = new Mitov.AudioLab.SignalGen(this);
            this.audioToReal1 = new Mitov.AudioLab.AudioToReal(this);
            this.dsAudioOut1 = new Mitov.AudioLab.DSAudioOut(this);
            this.systemMixer1 = new Mitov.AudioLab.SystemMixer(this);
            this.amplifier1 = new Mitov.AudioLab.Amplifier(this);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmp = new System.Windows.Forms.TextBox();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signalGen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioToReal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemMixer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vibration 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vibration 1";
            // 
            // buttonPlay1
            // 
            this.buttonPlay1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay1.Location = new System.Drawing.Point(254, 189);
            this.buttonPlay1.Name = "buttonPlay1";
            this.buttonPlay1.Size = new System.Drawing.Size(190, 94);
            this.buttonPlay1.TabIndex = 8;
            this.buttonPlay1.Text = "PLAY";
            this.buttonPlay1.UseVisualStyleBackColor = true;
            this.buttonPlay1.Click += new System.EventHandler(this.buttonPlay1_Click);
            // 
            // buttonDifferent
            // 
            this.buttonDifferent.Enabled = false;
            this.buttonDifferent.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDifferent.Location = new System.Drawing.Point(369, 330);
            this.buttonDifferent.Name = "buttonDifferent";
            this.buttonDifferent.Size = new System.Drawing.Size(294, 126);
            this.buttonDifferent.TabIndex = 7;
            this.buttonDifferent.Text = "DIFFERENT";
            this.buttonDifferent.UseVisualStyleBackColor = true;
            this.buttonDifferent.Click += new System.EventHandler(this.buttonDifferent_Click);
            // 
            // buttonSame
            // 
            this.buttonSame.Enabled = false;
            this.buttonSame.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSame.Location = new System.Drawing.Point(26, 332);
            this.buttonSame.Name = "buttonSame";
            this.buttonSame.Size = new System.Drawing.Size(297, 122);
            this.buttonSame.TabIndex = 6;
            this.buttonSame.Text = "SAME";
            this.buttonSame.UseVisualStyleBackColor = true;
            this.buttonSame.Click += new System.EventHandler(this.buttonSame_Click);
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSession.Location = new System.Drawing.Point(225, 9);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(229, 52);
            this.labelSession.TabIndex = 12;
            this.labelSession.Text = "Session 1";
            // 
            // signalGen1
            // 
            this.signalGen1.Amplitude = 32767;
            this.signalGen1.Asymmetry = 0;
            audioFormat3.Bits = ((uint)(16u));
            audioFormat3.BufferSize = ((uint)(1024u));
            audioFormat3.ChannelMask = new Mitov.AudioLab.Speakers(3);
            audioFormat3.Channels = ((uint)(2u));
            audioFormat3.SampleRate = ((uint)(11025u));
            this.signalGen1.AudioFormat = audioFormat3;
            sinkPin11.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin11.ConnectionData")));
            this.signalGen1.ClockPin = sinkPin11;
            statePin7.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("statePin7.ConnectionData")));
            this.signalGen1.EnablePin = statePin7;
            this.signalGen1.Frequency = 300;
            statePin8.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("statePin8.ConnectionData")));
            this.signalGen1.FrequencyPin = statePin8;
            sourcePin5.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin5.ConnectionData")));
            this.signalGen1.OutputPin = sourcePin5;
            this.signalGen1.Phase = 0F;
            this.signalGen1.PumpPriority = 0;
            this.signalGen1.SignalType = Mitov.AudioLab.SignalType.Square;
            // 
            // audioToReal1
            // 
            sinkPin12.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin12.ConnectionData")));
            this.audioToReal1.InputPin = sinkPin12;
            pinList19.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList19.ConnectionData")));
            this.audioToReal1.OutputPins = pinList19;
            // 
            // dsAudioOut1
            // 
            dsAudioOutputDevice3.DeviceName = "Default";
            dsAudioOutputDevice3.InternalData = ((Vcl.VclBinaryData)(resources.GetObject("dsAudioOutputDevice3.InternalData")));
            this.dsAudioOut1.AudioOutputDevice = dsAudioOutputDevice3;
            statePin9.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("statePin9.ConnectionData")));
            this.dsAudioOut1.EnablePin = statePin9;
            this.dsAudioOut1.Graph = dsGraph3;
            sinkPin13.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin13.ConnectionData")));
            this.dsAudioOut1.InputPin = sinkPin13;
            // 
            // systemMixer1
            // 
            this.systemMixer1.ControlGroups = systemMixerControlGroups3;
            pinList20.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList20.ConnectionData")));
            systemMixerControlPinGroups3.BoolMeterPins = pinList20;
            pinList21.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList21.ConnectionData")));
            systemMixerControlPinGroups3.FaderPins = pinList21;
            pinList22.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList22.ConnectionData")));
            systemMixerControlPinGroups3.IntegerMeterPins = pinList22;
            pinList23.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList23.ConnectionData")));
            systemMixerControlPinGroups3.ListPins = pinList23;
            pinList24.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList24.ConnectionData")));
            systemMixerControlPinGroups3.NumberPins = pinList24;
            pinList25.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList25.ConnectionData")));
            systemMixerControlPinGroups3.SliderPins = pinList25;
            pinList26.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList26.ConnectionData")));
            systemMixerControlPinGroups3.SwitchPins = pinList26;
            pinList27.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList27.ConnectionData")));
            systemMixerControlPinGroups3.TimePins = pinList27;
            this.systemMixer1.ControlPins = systemMixerControlPinGroups3;
            // 
            // amplifier1
            // 
            this.amplifier1.Coefficient = 2;
            sinkPin14.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin14.ConnectionData")));
            this.amplifier1.EnablePin = sinkPin14;
            sinkPin15.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin15.ConnectionData")));
            this.amplifier1.InputPin = sinkPin15;
            sourcePin6.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin6.ConnectionData")));
            this.amplifier1.OutputPin = sourcePin6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 23;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 482);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Amplitude Co";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 482);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Freq";
            // 
            // textBoxAmp
            // 
            this.textBoxAmp.Location = new System.Drawing.Point(361, 513);
            this.textBoxAmp.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAmp.Name = "textBoxAmp";
            this.textBoxAmp.Size = new System.Drawing.Size(76, 20);
            this.textBoxAmp.TabIndex = 20;
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(259, 513);
            this.textBoxFreq.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(76, 20);
            this.textBoxFreq.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAmp);
            this.Controls.Add(this.textBoxFreq);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay1);
            this.Controls.Add(this.buttonDifferent);
            this.Controls.Add(this.buttonSame);
            this.Name = "subjectWindow";
            this.Text = "startexperiment";
            this.Load += new System.EventHandler(this.subjectWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signalGen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioToReal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemMixer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlay1;
        private System.Windows.Forms.Button buttonDifferent;
        private System.Windows.Forms.Button buttonSame;
        private System.Windows.Forms.Label labelSession;
        private Mitov.AudioLab.SignalGen signalGen1;
        private Mitov.AudioLab.AudioToReal audioToReal1;
        private Mitov.AudioLab.DSAudioOut dsAudioOut1;
        private Mitov.AudioLab.SystemMixer systemMixer1;
        private Mitov.AudioLab.Amplifier amplifier1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxAmp;
        public System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.Button button1;
    }
}
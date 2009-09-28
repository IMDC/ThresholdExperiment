

namespace ChairExperiment
{
    partial class CalibrationForm
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
            Mitov.AudioLab.OptionalAudioFormat optionalAudioFormat1 = new Mitov.AudioLab.OptionalAudioFormat();
            OpenWire.Proxy.PinList pinList1 = new OpenWire.Proxy.PinList();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationForm));
            OpenWire.Proxy.SourcePin sourcePin1 = new OpenWire.Proxy.SourcePin();
            Mitov.AudioLab.AudioFormat audioFormat1 = new Mitov.AudioLab.AudioFormat();
            OpenWire.Proxy.SinkPin sinkPin1 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.StatePin statePin1 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.StatePin statePin2 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.SourcePin sourcePin2 = new OpenWire.Proxy.SourcePin();
            OpenWire.Proxy.SinkPin sinkPin2 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.PinList pinList2 = new OpenWire.Proxy.PinList();
            Mitov.AudioLab.DSAudioOutputDevice dsAudioOutputDevice1 = new Mitov.AudioLab.DSAudioOutputDevice();
            OpenWire.Proxy.StatePin statePin3 = new OpenWire.Proxy.StatePin();
            Mitov.AudioLab.DSGraph dsGraph1 = new Mitov.AudioLab.DSGraph();
            OpenWire.Proxy.SinkPin sinkPin3 = new OpenWire.Proxy.SinkPin();
            Mitov.AudioLab.MasterPumping masterPumping1 = new Mitov.AudioLab.MasterPumping();
            Mitov.AudioLab.SystemMixerControlGroups systemMixerControlGroups1 = new Mitov.AudioLab.SystemMixerControlGroups();
            Mitov.AudioLab.SystemMixerControlPinGroups systemMixerControlPinGroups1 = new Mitov.AudioLab.SystemMixerControlPinGroups();
            OpenWire.Proxy.PinList pinList3 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList4 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList5 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList6 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList7 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList8 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList9 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList10 = new OpenWire.Proxy.PinList();
            Mitov.AudioLab.SystemMixerDevice systemMixerDevice1 = new Mitov.AudioLab.SystemMixerDevice();
            OpenWire.Proxy.SinkPin sinkPin4 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SinkPin sinkPin5 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SourcePin sourcePin3 = new OpenWire.Proxy.SourcePin();
            Mitov.AudioLab.AudioFormat audioFormat2 = new Mitov.AudioLab.AudioFormat();
            OpenWire.Proxy.SinkPin sinkPin6 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.StatePin statePin4 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.StatePin statePin5 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.SourcePin sourcePin4 = new OpenWire.Proxy.SourcePin();
            OpenWire.Proxy.SinkPin sinkPin7 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SinkPin sinkPin8 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SourcePin sourcePin5 = new OpenWire.Proxy.SourcePin();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFreq1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxamp2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFreq2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.channelMerger1 = new Mitov.AudioLab.ChannelMerger(this.components);
            this.signalGen1 = new Mitov.AudioLab.SignalGen(this.components);
            this.audioToReal1 = new Mitov.AudioLab.AudioToReal(this.components);
            this.dsAudioOut1 = new Mitov.AudioLab.DSAudioOut(this.components);
            this.systemMixer1 = new Mitov.AudioLab.SystemMixer(this.components);
            this.amplifier1 = new Mitov.AudioLab.Amplifier(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.signalGen2 = new Mitov.AudioLab.SignalGen(this.components);
            this.amplifier2 = new Mitov.AudioLab.Amplifier(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelMerger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalGen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioToReal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemMixer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalGen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amplitude Co";
            // 
            // textBoxAmp
            // 
            this.textBoxAmp.Location = new System.Drawing.Point(329, 78);
            this.textBoxAmp.Name = "textBoxAmp";
            this.textBoxAmp.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmp.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frequency";
            // 
            // textBoxFreq1
            // 
            this.textBoxFreq1.Location = new System.Drawing.Point(40, 92);
            this.textBoxFreq1.Name = "textBoxFreq1";
            this.textBoxFreq1.Size = new System.Drawing.Size(100, 20);
            this.textBoxFreq1.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(238, 78);
            this.trackBar1.Maximum = 32500;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 129);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amplitude Co";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Amplitude Co";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 50;
            this.trackBar2.Location = new System.Drawing.Point(450, 76);
            this.trackBar2.Maximum = 32500;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 129);
            this.trackBar2.TabIndex = 19;
            this.trackBar2.Value = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Amplitude Co";
            // 
            // textboxamp2
            // 
            this.textboxamp2.Location = new System.Drawing.Point(541, 76);
            this.textboxamp2.Name = "textboxamp2";
            this.textboxamp2.Size = new System.Drawing.Size(100, 20);
            this.textboxamp2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Frequency";
            // 
            // textBoxFreq2
            // 
            this.textBoxFreq2.Location = new System.Drawing.Point(40, 162);
            this.textBoxFreq2.Name = "textBoxFreq2";
            this.textBoxFreq2.Size = new System.Drawing.Size(100, 20);
            this.textBoxFreq2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Channel 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Channel 1";
            // 
            // channelMerger1
            // 
            optionalAudioFormat1.Bits = ((uint)(16u));
            optionalAudioFormat1.BufferSize = ((uint)(1024u));
            optionalAudioFormat1.ChannelMask = new Mitov.AudioLab.Speakers(3);
            optionalAudioFormat1.Channels = ((uint)(2u));
            optionalAudioFormat1.SampleRate = ((uint)(11025u));
            this.channelMerger1.AudioFormat = optionalAudioFormat1;
            pinList1.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList1.ConnectionData")));
            this.channelMerger1.InputPins = pinList1;
            this.channelMerger1.InternalData = ((Vcl.VclBinaryData)(resources.GetObject("channelMerger1.InternalData")));
            sourcePin1.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin1.ConnectionData")));
            this.channelMerger1.OutputPin = sourcePin1;
            // 
            // signalGen1
            // 
            this.signalGen1.Amplitude = 20000;
            this.signalGen1.Asymmetry = 0;
            audioFormat1.Bits = ((uint)(16u));
            audioFormat1.BufferSize = ((uint)(1024u));
            audioFormat1.ChannelMask = new Mitov.AudioLab.Speakers(3);
            audioFormat1.Channels = ((uint)(2u));
            audioFormat1.SampleRate = ((uint)(11025u));
            this.signalGen1.AudioFormat = audioFormat1;
            sinkPin1.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin1.ConnectionData")));
            this.signalGen1.ClockPin = sinkPin1;
            statePin1.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("statePin1.ConnectionData")));
            this.signalGen1.EnablePin = statePin1;
            this.signalGen1.Frequency = 300;
            statePin2.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("statePin2.ConnectionData")));
            this.signalGen1.FrequencyPin = statePin2;
            sourcePin2.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin2.ConnectionData")));
            this.signalGen1.OutputPin = sourcePin2;
            this.signalGen1.Phase = 0F;
            this.signalGen1.PumpPriority = 0;
            this.signalGen1.SignalType = Mitov.AudioLab.SignalType.Square;
            // 
            // audioToReal1
            // 
            sinkPin2.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin2.ConnectionData")));
            this.audioToReal1.InputPin = sinkPin2;
            pinList2.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList2.ConnectionData")));
            this.audioToReal1.OutputPins = pinList2;
            // 
            // dsAudioOut1
            // 
            dsAudioOutputDevice1.DeviceName = "Default";
            dsAudioOutputDevice1.InternalData = ((Vcl.VclBinaryData)(resources.GetObject("dsAudioOutputDevice1.InternalData")));
            this.dsAudioOut1.AudioOutputDevice = dsAudioOutputDevice1;
            statePin3.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("statePin3.ConnectionData")));
            this.dsAudioOut1.EnablePin = statePin3;
            this.dsAudioOut1.Graph = dsGraph1;
            sinkPin3.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin3.ConnectionData")));
            this.dsAudioOut1.InputPin = sinkPin3;
            this.dsAudioOut1.InternalData = ((Vcl.VclBinaryData)(resources.GetObject("dsAudioOut1.InternalData")));
            this.dsAudioOut1.MasterPumping = masterPumping1;
            this.dsAudioOut1.PrefillInterval = ((uint)(300u));
            // 
            // systemMixer1
            // 
            this.systemMixer1.ControlGroups = systemMixerControlGroups1;
            pinList3.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList3.ConnectionData")));
            systemMixerControlPinGroups1.BoolMeterPins = pinList3;
            pinList4.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList4.ConnectionData")));
            systemMixerControlPinGroups1.FaderPins = pinList4;
            pinList5.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList5.ConnectionData")));
            systemMixerControlPinGroups1.IntegerMeterPins = pinList5;
            pinList6.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList6.ConnectionData")));
            systemMixerControlPinGroups1.ListPins = pinList6;
            pinList7.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList7.ConnectionData")));
            systemMixerControlPinGroups1.NumberPins = pinList7;
            pinList8.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList8.ConnectionData")));
            systemMixerControlPinGroups1.SliderPins = pinList8;
            pinList9.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList9.ConnectionData")));
            systemMixerControlPinGroups1.SwitchPins = pinList9;
            pinList10.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList10.ConnectionData")));
            systemMixerControlPinGroups1.TimePins = pinList10;
            this.systemMixer1.ControlPins = systemMixerControlPinGroups1;
            systemMixerDevice1.DeviceName = "Default";
            this.systemMixer1.Device = systemMixerDevice1;
            // 
            // amplifier1
            // 
            this.amplifier1.Coefficient = 2;
            sinkPin4.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin4.ConnectionData")));
            this.amplifier1.EnablePin = sinkPin4;
            sinkPin5.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin5.ConnectionData")));
            this.amplifier1.InputPin = sinkPin5;
            this.amplifier1.InternalData = ((Vcl.VclBinaryData)(resources.GetObject("amplifier1.InternalData")));
            sourcePin3.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin3.ConnectionData")));
            this.amplifier1.OutputPin = sourcePin3;
            // 
            // signalGen2
            // 
            this.signalGen2.Amplitude = 20000;
            this.signalGen2.Asymmetry = 0;
            audioFormat2.Bits = ((uint)(16u));
            audioFormat2.BufferSize = ((uint)(1024u));
            audioFormat2.ChannelMask = new Mitov.AudioLab.Speakers(3);
            audioFormat2.Channels = ((uint)(2u));
            audioFormat2.SampleRate = ((uint)(11025u));
            this.signalGen2.AudioFormat = audioFormat2;
            sinkPin6.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin6.ConnectionData")));
            this.signalGen2.ClockPin = sinkPin6;
            statePin4.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("statePin4.ConnectionData")));
            this.signalGen2.EnablePin = statePin4;
            this.signalGen2.Frequency = 500;
            statePin5.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("statePin5.ConnectionData")));
            this.signalGen2.FrequencyPin = statePin5;
            sourcePin4.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin4.ConnectionData")));
            this.signalGen2.OutputPin = sourcePin4;
            this.signalGen2.Phase = 0F;
            this.signalGen2.PumpPriority = 0;
            this.signalGen2.SignalType = Mitov.AudioLab.SignalType.Square;
            // 
            // amplifier2
            // 
            this.amplifier2.Coefficient = 1;
            sinkPin7.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin7.ConnectionData")));
            this.amplifier2.EnablePin = sinkPin7;
            sinkPin8.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin8.ConnectionData")));
            this.amplifier2.InputPin = sinkPin8;
            this.amplifier2.InternalData = ((Vcl.VclBinaryData)(resources.GetObject("amplifier2.InternalData")));
            sourcePin5.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin5.ConnectionData")));
            this.amplifier2.OutputPin = sourcePin5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Channel 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Channel 2";
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 276);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxamp2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFreq2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFreq1);
            this.Name = "CalibrationForm";
            this.Text = "startexperiment";
            this.Load += new System.EventHandler(this.CalibrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelMerger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalGen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioToReal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemMixer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalGen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFreq1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxamp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFreq2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public Mitov.AudioLab.ChannelMerger channelMerger1;
        public Mitov.AudioLab.SignalGen signalGen1;
        private Mitov.AudioLab.AudioToReal audioToReal1;
        private Mitov.AudioLab.DSAudioOut dsAudioOut1;
        private Mitov.AudioLab.SystemMixer systemMixer1;
        public Mitov.AudioLab.Amplifier amplifier1;
        private System.Windows.Forms.Timer timer1;
        public Mitov.AudioLab.SignalGen signalGen2;
        public Mitov.AudioLab.Amplifier amplifier2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
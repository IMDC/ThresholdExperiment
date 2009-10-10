

namespace ChairExperiment
{
    partial class experiment1_DirectScaling
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
            Mitov.AudioLab.AudioFormat audioFormat1 = new Mitov.AudioLab.AudioFormat();
            OpenWire.Proxy.SinkPin sinkPin1 = new OpenWire.Proxy.SinkPin();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(experiment1_DirectScaling));
            OpenWire.Proxy.StatePin statePin1 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.StatePin statePin2 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.SourcePin sourcePin1 = new OpenWire.Proxy.SourcePin();
            OpenWire.Proxy.SinkPin sinkPin2 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.PinList pinList1 = new OpenWire.Proxy.PinList();
            Mitov.AudioLab.DSAudioOutputDevice dsAudioOutputDevice1 = new Mitov.AudioLab.DSAudioOutputDevice();
            OpenWire.Proxy.StatePin statePin3 = new OpenWire.Proxy.StatePin();
            Mitov.AudioLab.DSGraph dsGraph1 = new Mitov.AudioLab.DSGraph();
            OpenWire.Proxy.SinkPin sinkPin3 = new OpenWire.Proxy.SinkPin();
            Mitov.AudioLab.MasterPumping masterPumping1 = new Mitov.AudioLab.MasterPumping();
            Mitov.AudioLab.SystemMixerControlGroups systemMixerControlGroups1 = new Mitov.AudioLab.SystemMixerControlGroups();
            Mitov.AudioLab.SystemMixerControlPinGroups systemMixerControlPinGroups1 = new Mitov.AudioLab.SystemMixerControlPinGroups();
            OpenWire.Proxy.PinList pinList2 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList3 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList4 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList5 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList6 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList7 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList8 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.PinList pinList9 = new OpenWire.Proxy.PinList();
            Mitov.AudioLab.SystemMixerDevice systemMixerDevice1 = new Mitov.AudioLab.SystemMixerDevice();
            OpenWire.Proxy.SinkPin sinkPin4 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SinkPin sinkPin5 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SourcePin sourcePin2 = new OpenWire.Proxy.SourcePin();
            Mitov.AudioLab.AudioFormat audioFormat2 = new Mitov.AudioLab.AudioFormat();
            OpenWire.Proxy.SinkPin sinkPin6 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.StatePin statePin4 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.StatePin statePin5 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.SourcePin sourcePin3 = new OpenWire.Proxy.SourcePin();
            Mitov.AudioLab.OptionalAudioFormat optionalAudioFormat1 = new Mitov.AudioLab.OptionalAudioFormat();
            OpenWire.Proxy.PinList pinList10 = new OpenWire.Proxy.PinList();
            OpenWire.Proxy.SourcePin sourcePin4 = new OpenWire.Proxy.SourcePin();
            OpenWire.Proxy.SinkPin sinkPin7 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SinkPin sinkPin8 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SourcePin sourcePin5 = new OpenWire.Proxy.SourcePin();
            this.buttonStartVibration = new System.Windows.Forms.Button();
            this.labelSession = new System.Windows.Forms.Label();
            this.signalGen1 = new Mitov.AudioLab.SignalGen(this.components);
            this.audioToReal1 = new Mitov.AudioLab.AudioToReal(this.components);
            this.dsAudioOut1 = new Mitov.AudioLab.DSAudioOut(this.components);
            this.systemMixer1 = new Mitov.AudioLab.SystemMixer(this.components);
            this.amplifier1 = new Mitov.AudioLab.Amplifier(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.signalGen2 = new Mitov.AudioLab.SignalGen(this.components);
            this.channelMerger1 = new Mitov.AudioLab.ChannelMerger(this.components);
            this.amplifier2 = new Mitov.AudioLab.Amplifier(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonHigher = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signalGen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioToReal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemMixer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalGen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelMerger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartVibration
            // 
            this.buttonStartVibration.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartVibration.Location = new System.Drawing.Point(129, 121);
            this.buttonStartVibration.Name = "buttonStartVibration";
            this.buttonStartVibration.Size = new System.Drawing.Size(371, 162);
            this.buttonStartVibration.TabIndex = 6;
            this.buttonStartVibration.Text = "START VIBRATION";
            this.buttonStartVibration.UseVisualStyleBackColor = true;
            this.buttonStartVibration.Click += new System.EventHandler(this.buttonStartVibration_Click);
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSession.Location = new System.Drawing.Point(203, 47);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(229, 52);
            this.labelSession.TabIndex = 12;
            this.labelSession.Text = "Session 1";
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
            sourcePin1.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin1.ConnectionData")));
            this.signalGen1.OutputPin = sourcePin1;
            this.signalGen1.Phase = 0F;
            this.signalGen1.PumpPriority = 0;
            // 
            // audioToReal1
            // 
            sinkPin2.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin2.ConnectionData")));
            this.audioToReal1.InputPin = sinkPin2;
            pinList1.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList1.ConnectionData")));
            this.audioToReal1.OutputPins = pinList1;
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
            pinList2.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList2.ConnectionData")));
            systemMixerControlPinGroups1.BoolMeterPins = pinList2;
            pinList3.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList3.ConnectionData")));
            systemMixerControlPinGroups1.FaderPins = pinList3;
            pinList4.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList4.ConnectionData")));
            systemMixerControlPinGroups1.IntegerMeterPins = pinList4;
            pinList5.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList5.ConnectionData")));
            systemMixerControlPinGroups1.ListPins = pinList5;
            pinList6.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList6.ConnectionData")));
            systemMixerControlPinGroups1.NumberPins = pinList6;
            pinList7.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList7.ConnectionData")));
            systemMixerControlPinGroups1.SliderPins = pinList7;
            pinList8.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList8.ConnectionData")));
            systemMixerControlPinGroups1.SwitchPins = pinList8;
            pinList9.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList9.ConnectionData")));
            systemMixerControlPinGroups1.TimePins = pinList9;
            this.systemMixer1.ControlPins = systemMixerControlPinGroups1;
            systemMixerDevice1.DeviceName = "Default";
            this.systemMixer1.Device = systemMixerDevice1;
            // 
            // amplifier1
            // 
            this.amplifier1.Coefficient = 1;
            sinkPin4.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin4.ConnectionData")));
            this.amplifier1.EnablePin = sinkPin4;
            sinkPin5.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin5.ConnectionData")));
            this.amplifier1.InputPin = sinkPin5;
            this.amplifier1.InternalData = ((Vcl.VclBinaryData)(resources.GetObject("amplifier1.InternalData")));
            sourcePin2.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin2.ConnectionData")));
            this.amplifier1.OutputPin = sourcePin2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            sourcePin3.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin3.ConnectionData")));
            this.signalGen2.OutputPin = sourcePin3;
            this.signalGen2.Phase = 0F;
            this.signalGen2.PumpPriority = 0;
            // 
            // channelMerger1
            // 
            optionalAudioFormat1.Bits = ((uint)(16u));
            optionalAudioFormat1.BufferSize = ((uint)(1024u));
            optionalAudioFormat1.ChannelMask = new Mitov.AudioLab.Speakers(3);
            optionalAudioFormat1.Channels = ((uint)(2u));
            optionalAudioFormat1.SampleRate = ((uint)(11025u));
            this.channelMerger1.AudioFormat = optionalAudioFormat1;
            pinList10.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("pinList10.ConnectionData")));
            this.channelMerger1.InputPins = pinList10;
            this.channelMerger1.InternalData = ((Vcl.VclBinaryData)(resources.GetObject("channelMerger1.InternalData")));
            sourcePin4.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin4.ConnectionData")));
            this.channelMerger1.OutputPin = sourcePin4;
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
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonHigher
            // 
            this.buttonHigher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHigher.Location = new System.Drawing.Point(338, 307);
            this.buttonHigher.Name = "buttonHigher";
            this.buttonHigher.Size = new System.Drawing.Size(162, 147);
            this.buttonHigher.TabIndex = 44;
            this.buttonHigher.Text = "HIGHER";
            this.buttonHigher.UseVisualStyleBackColor = true;
            this.buttonHigher.Click += new System.EventHandler(this.buttonHigher_Click);
            // 
            // buttonLower
            // 
            this.buttonLower.Enabled = false;
            this.buttonLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLower.Location = new System.Drawing.Point(129, 307);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(166, 147);
            this.buttonLower.TabIndex = 42;
            this.buttonLower.Text = "LOWER";
            this.buttonLower.UseVisualStyleBackColor = true;
            this.buttonLower.Click += new System.EventHandler(this.buttonLower_Click);
            // 
            // experiment1_DirectScaling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 537);
            this.Controls.Add(this.buttonHigher);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.buttonStartVibration);
            this.Name = "experiment1_DirectScaling";
            this.Text = "Experiment 1 - Direct Scaling";
            ((System.ComponentModel.ISupportInitialize)(this.signalGen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioToReal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemMixer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalGen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelMerger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartVibration;
        private System.Windows.Forms.Label labelSession;
        private Mitov.AudioLab.AudioToReal audioToReal1;
        private Mitov.AudioLab.DSAudioOut dsAudioOut1;
        private Mitov.AudioLab.SystemMixer systemMixer1;
        private System.Windows.Forms.Timer timer1;
        public Mitov.AudioLab.SignalGen signalGen1;
        public Mitov.AudioLab.Amplifier amplifier1;
        public Mitov.AudioLab.SignalGen signalGen2;
        public Mitov.AudioLab.ChannelMerger channelMerger1;
        public Mitov.AudioLab.Amplifier amplifier2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonHigher;
        private System.Windows.Forms.Button buttonLower;
    }
}
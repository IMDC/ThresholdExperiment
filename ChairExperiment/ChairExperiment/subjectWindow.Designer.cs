

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
            Mitov.AudioLab.AudioFormat audioFormat1 = new Mitov.AudioLab.AudioFormat();
            OpenWire.Proxy.SinkPin sinkPin1 = new OpenWire.Proxy.SinkPin();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subjectWindow));
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlay1 = new System.Windows.Forms.Button();
            this.buttonFaster = new System.Windows.Forms.Button();
            this.buttonSlower = new System.Windows.Forms.Button();
            this.labelSession = new System.Windows.Forms.Label();
            this.signalGen1 = new Mitov.AudioLab.SignalGen(this.components);
            this.audioToReal1 = new Mitov.AudioLab.AudioToReal(this.components);
            this.dsAudioOut1 = new Mitov.AudioLab.DSAudioOut(this.components);
            this.systemMixer1 = new Mitov.AudioLab.SystemMixer(this.components);
            this.amplifier1 = new Mitov.AudioLab.Amplifier(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.signalGen2 = new Mitov.AudioLab.SignalGen(this.components);
            this.buttonPlay2 = new System.Windows.Forms.Button();
            this.channelMerger1 = new Mitov.AudioLab.ChannelMerger(this.components);
            this.buttonstop = new System.Windows.Forms.Button();
            this.amplifier2 = new Mitov.AudioLab.Amplifier(this.components);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vibration 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.buttonPlay1.Location = new System.Drawing.Point(133, 188);
            this.buttonPlay1.Name = "buttonPlay1";
            this.buttonPlay1.Size = new System.Drawing.Size(190, 94);
            this.buttonPlay1.TabIndex = 8;
            this.buttonPlay1.Text = "PLAY_C";
            this.buttonPlay1.UseVisualStyleBackColor = true;
            this.buttonPlay1.Click += new System.EventHandler(this.buttonPlay1_Click);
            // 
            // buttonFaster
            // 
            this.buttonFaster.Enabled = false;
            this.buttonFaster.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaster.Location = new System.Drawing.Point(369, 363);
            this.buttonFaster.Name = "buttonFaster";
            this.buttonFaster.Size = new System.Drawing.Size(294, 126);
            this.buttonFaster.TabIndex = 7;
            this.buttonFaster.Text = "FASTER";
            this.buttonFaster.UseVisualStyleBackColor = true;
            this.buttonFaster.Click += new System.EventHandler(this.buttonFaster_Click);
            // 
            // buttonSlower
            // 
            this.buttonSlower.Enabled = false;
            this.buttonSlower.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlower.Location = new System.Drawing.Point(12, 367);
            this.buttonSlower.Name = "buttonSlower";
            this.buttonSlower.Size = new System.Drawing.Size(297, 122);
            this.buttonSlower.TabIndex = 6;
            this.buttonSlower.Text = "SLOWER";
            this.buttonSlower.UseVisualStyleBackColor = true;
            this.buttonSlower.Click += new System.EventHandler(this.buttonSlower_Click);
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
            // buttonPlay2
            // 
            this.buttonPlay2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay2.Location = new System.Drawing.Point(369, 188);
            this.buttonPlay2.Name = "buttonPlay2";
            this.buttonPlay2.Size = new System.Drawing.Size(190, 94);
            this.buttonPlay2.TabIndex = 13;
            this.buttonPlay2.Text = "PLAY_D";
            this.buttonPlay2.UseVisualStyleBackColor = true;
            this.buttonPlay2.Click += new System.EventHandler(this.button2_Click);
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
            // buttonstop
            // 
            this.buttonstop.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstop.Location = new System.Drawing.Point(257, 307);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(197, 39);
            this.buttonstop.TabIndex = 14;
            this.buttonstop.Text = "stop";
            this.buttonstop.UseVisualStyleBackColor = true;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
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
            // subjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 514);
            this.Controls.Add(this.buttonstop);
            this.Controls.Add(this.buttonPlay2);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay1);
            this.Controls.Add(this.buttonFaster);
            this.Controls.Add(this.buttonSlower);
            this.Name = "subjectWindow";
            this.Text = "startexperiment";
            this.Load += new System.EventHandler(this.subjectWindow_Load);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlay1;
        private System.Windows.Forms.Button buttonFaster;
        private System.Windows.Forms.Button buttonSlower;
        private System.Windows.Forms.Label labelSession;
        private Mitov.AudioLab.AudioToReal audioToReal1;
        private Mitov.AudioLab.DSAudioOut dsAudioOut1;
        private Mitov.AudioLab.SystemMixer systemMixer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonPlay2;
        private System.Windows.Forms.Button buttonstop;
        public Mitov.AudioLab.SignalGen signalGen1;
        public Mitov.AudioLab.Amplifier amplifier1;
        public Mitov.AudioLab.SignalGen signalGen2;
        public Mitov.AudioLab.ChannelMerger channelMerger1;
        public Mitov.AudioLab.Amplifier amplifier2;
    }
}
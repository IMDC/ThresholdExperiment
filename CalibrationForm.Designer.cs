

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
            Mitov.AudioLab.AudioFormat audioFormat1 = new Mitov.AudioLab.AudioFormat();
            OpenWire.Proxy.SinkPin sinkPin1 = new OpenWire.Proxy.SinkPin();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalibrationForm));
            OpenWire.Proxy.StatePin statePin1 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.StatePin statePin2 = new OpenWire.Proxy.StatePin();
            OpenWire.Proxy.SourcePin sourcePin1 = new OpenWire.Proxy.SourcePin();
            OpenWire.Proxy.SinkPin sinkPin2 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.PinList pinList1 = new OpenWire.Proxy.PinList();
            Mitov.AudioLab.DSAudioOutputDevice dsAudioOutputDevice1 = new Mitov.AudioLab.DSAudioOutputDevice();
            OpenWire.Proxy.StatePin statePin3 = new OpenWire.Proxy.StatePin();
            Mitov.AudioLab.DSGraph dsGraph1 = new Mitov.AudioLab.DSGraph();
            OpenWire.Proxy.SinkPin sinkPin3 = new OpenWire.Proxy.SinkPin();
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
            OpenWire.Proxy.SinkPin sinkPin4 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SinkPin sinkPin5 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SourcePin sourcePin2 = new OpenWire.Proxy.SourcePin();
            this.signalGen1 = new Mitov.AudioLab.SignalGen(this);
            this.audioToReal1 = new Mitov.AudioLab.AudioToReal(this);
            this.dsAudioOut1 = new Mitov.AudioLab.DSAudioOut(this);
            this.systemMixer1 = new Mitov.AudioLab.SystemMixer(this);
            this.amplifier1 = new Mitov.AudioLab.Amplifier(this);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signalGen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioToReal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemMixer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier1)).BeginInit();
            this.SuspendLayout();
            // 
            // signalGen1
            // 
            this.signalGen1.Amplitude = 32767;
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
            this.signalGen1.SignalType = Mitov.AudioLab.SignalType.Square;
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
            // 
            // amplifier1
            // 
            this.amplifier1.Coefficient = 2;
            sinkPin4.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin4.ConnectionData")));
            this.amplifier1.EnablePin = sinkPin4;
            sinkPin5.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sinkPin5.ConnectionData")));
            this.amplifier1.InputPin = sinkPin5;
            sourcePin2.ConnectionData = ((OpenWire.PinConnections)(resources.GetObject("sourcePin2.ConnectionData")));
            this.amplifier1.OutputPin = sourcePin2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amplitude Co";
            // 
            // textBoxAmp
            // 
            this.textBoxAmp.Location = new System.Drawing.Point(40, 95);
            this.textBoxAmp.Name = "textBoxAmp";
            this.textBoxAmp.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmp.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frequency";
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(40, 44);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(100, 20);
            this.textBoxFreq.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 334);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFreq);
            this.Controls.Add(this.button1);
            this.Name = "CalibrationForm";
            this.Text = "startexperiment";
            this.Load += new System.EventHandler(this.CalibrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signalGen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioToReal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAudioOut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemMixer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mitov.AudioLab.SignalGen signalGen1;
        private Mitov.AudioLab.AudioToReal audioToReal1;
        private Mitov.AudioLab.DSAudioOut dsAudioOut1;
        private Mitov.AudioLab.SystemMixer systemMixer1;
        private Mitov.AudioLab.Amplifier amplifier1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.Button button1;
    }
}
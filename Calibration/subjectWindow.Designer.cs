

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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlay1 = new System.Windows.Forms.Button();
            this.buttonFaster = new System.Windows.Forms.Button();
            this.buttonSlower = new System.Windows.Forms.Button();
            this.labelSession = new System.Windows.Forms.Label();
            this.signalGen1 = new Mitov.AudioLab.SignalGen(this);
            this.audioToReal1 = new Mitov.AudioLab.AudioToReal(this);
            this.dsAudioOut1 = new Mitov.AudioLab.DSAudioOut(this);
            this.systemMixer1 = new Mitov.AudioLab.SystemMixer(this);
            this.amplifier1 = new Mitov.AudioLab.Amplifier(this);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.buttonPlay1.Location = new System.Drawing.Point(254, 177);
            this.buttonPlay1.Name = "buttonPlay1";
            this.buttonPlay1.Size = new System.Drawing.Size(190, 94);
            this.buttonPlay1.TabIndex = 8;
            this.buttonPlay1.Text = "PLAY";
            this.buttonPlay1.UseVisualStyleBackColor = true;
            this.buttonPlay1.Click += new System.EventHandler(this.buttonPlay1_Click);
            // 
            // buttonFaster
            // 
            this.buttonFaster.Enabled = false;
            this.buttonFaster.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaster.Location = new System.Drawing.Point(369, 330);
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
            this.buttonSlower.Location = new System.Drawing.Point(26, 332);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // subjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 514);
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
        private Mitov.AudioLab.SignalGen signalGen1;
        private Mitov.AudioLab.AudioToReal audioToReal1;
        private Mitov.AudioLab.DSAudioOut dsAudioOut1;
        private Mitov.AudioLab.SystemMixer systemMixer1;
        private Mitov.AudioLab.Amplifier amplifier1;
        private System.Windows.Forms.Timer timer1;
    }
}
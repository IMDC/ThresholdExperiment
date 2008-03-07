using System;
using System.Drawing;
using System.Collections;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
//using Exocortex.DSP;
//using AviFile;
//using QuartzTypeLib;
using DirectShowLib;
using DirectShowLib.DMO;

namespace ChairExperiment
{
    /// <summary>
    /// Summary description for ProcessWavefileSampleGrabber.
    /// </summary>
    public class GenerateTonesSampleGrabber : ISampleGrabberCB
    {
        

        private IProgressCallback callback;
        public IProgressCallback internalCallback;

       


        // JL102706
        public GenerateTonesSampleGrabber()
        {
        }
        // JL102706

        

        

        int ISampleGrabberCB.BufferCB(double sampleTime, System.IntPtr ip, int bufferLength)
        {
            int length = bufferLength / 2;
            short[] bufferArray = new short[length]; ///buffer to store sample values

           



            Marshal.Copy(ip, bufferArray, 0, length);//get samples into buffer				

            return 0;

            
        }
        int ISampleGrabberCB.SampleCB(double sampleTime, DirectShowLib.IMediaSample mediaSample)
        {

            return 0;


        }

    }
}

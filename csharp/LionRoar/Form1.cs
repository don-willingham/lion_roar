using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

// See https://stackoverflow.com/questions/1243070/how-to-read-and-write-from-the-serial-port
// See https://msdn.microsoft.com/en-us/library/zyzhdc6b(v=vs.110).aspx
// See https://stackoverflow.com/questions/3502311/how-to-play-a-sound-in-c-net
namespace LionRoar
{
    public partial class Form1 : Form
    {
        private SerialPort mSerialPort = null;
        private delegate void AddListItem(string iNewItem, Boolean iRoar);
        private AddListItem mListViewAddDelegate;
        System.Media.SoundPlayer mSndPlayer = new System.Media.SoundPlayer(@"lion_roar.wav");
        private string mSerialInBuffer;
        private int mRoarCount = 0; /// Number of roars
        private DateTime mLastRoar = DateTime.Now; /// Time of last roar
        private int mRoarDelay = 300; /// Minimum time, in seconds, between roars

        public Form1()
        {
            InitializeComponent();
            mSerialInBuffer = "";
            mListViewAddDelegate = new AddListItem(AddListItemMethod);

            string[] wPorts = SerialPort.GetPortNames();
            foreach(string wCurrPort in wPorts)
            {
                mSelSerial.Items.Add(wCurrPort);
            }
            if (wPorts.Length > 0)
            {
                mSelSerial.SelectedIndex = wPorts.Length - 1;
            }
        }

        private void mSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            mSerialInBuffer = mSerialInBuffer + mSerialPort.ReadExisting();
            int wCrLf = mSerialInBuffer.IndexOf("\r\n");
            if (wCrLf > -1)
            {
                string wTmp = mSerialInBuffer.Substring(0, wCrLf);
                mSerialInBuffer = mSerialInBuffer.Substring(wCrLf + 2);
                Boolean wRoar = false;
                if (wTmp.Contains("Motion detected!"))
                {
                    DateTime wNow = DateTime.Now;
                    if ((mRoarCount <= 0) || (wNow >= mLastRoar.AddSeconds(mRoarDelay)))
                    {
                        mRoarCount++;
                        mLastRoar = wNow;
                        wRoar = true;
                        mSndPlayer.Play();
                    }
                }
                object[] wObjArr = {wTmp, wRoar};
                mConsoleText.Invoke(mListViewAddDelegate, wObjArr);
            }
        }

        private void AddListItemMethod(string iNewItem, Boolean iRoar)
        {
            mTxtLastTime.Text = mLastRoar.ToString("hh:mm:ss tt");
            string wTimeStr = DateTime.Now.ToString("hh:mm:ss tt");
            ListViewItem wNewItem = this.mConsoleText.Items.Add(wTimeStr);
            wNewItem.SubItems.Add(iNewItem);
            wNewItem.SubItems.Add(iRoar ? "Yes" : "No");
            while (mConsoleText.Items.Count > 10)
            {
                mConsoleText.Items.RemoveAt(0);
            }
        }

        private void mBtnStart_Click(object sender, EventArgs e)
        {
            // Disable from COM port select and Start buttons
            mBtnStart.Enabled = mSelSerial.Enabled = false;
            // 
            mSerialPort = new SerialPort(mSelSerial.Text, 9600, Parity.None, 8, StopBits.One);
            mSerialPort.DataReceived += new SerialDataReceivedEventHandler(mSerialPort_DataReceived);
            mSerialPort.Open();
        }

        private void mTxtDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mRoarDelay = int.Parse(mTxtDelay.Text);
                if (mRoarDelay < 60)
                {
                    mRoarDelay = 60;
                    mTxtDelay.Text = mRoarDelay.ToString();
                }
            }
            catch (Exception wEx)
            {
                mTxtDelay.Text = mRoarDelay.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Reflection;
using BitField;

namespace KVLS2C1_Reports
{

    [BitFieldNumberOfBitsAttribute(16)]
    struct BitField : IBitField
    {
        [BitFieldInfo(0, 1)]
        public byte Bit1 { get; set; }

        [BitFieldInfo(1, 1)]
        public byte Bit2 { get; set; }

        [BitFieldInfo(2, 1)]
        public byte Bit3 { get; set; }

        [BitFieldInfo(3, 1)]
        public byte Bit4 { get; set; }

        [BitFieldInfo(4, 1)]
        public byte Bit5 { get; set; }

        [BitFieldInfo(5, 1)]
        public byte Bit6 { get; set; }

        [BitFieldInfo(6, 1)]
        public byte Bit7 { get; set; }

        [BitFieldInfo(7, 1)]
        public byte Bit8 { get; set; }

        [BitFieldInfo(8, 1)]
        public byte Bit9 { get; set; }

        [BitFieldInfo(9, 1)]
        public byte Bit10 { get; set; }

        [BitFieldInfo(10, 1)]
        public byte Bit11 { get; set; }

        [BitFieldInfo(11, 1)]
        public byte Bit12 { get; set; }

        [BitFieldInfo(12, 1)]
        public byte Bit13 { get; set; }

        [BitFieldInfo(13, 1)]
        public byte Bit14 { get; set; }

        [BitFieldInfo(14, 1)]
        public byte Bit15 { get; set; }

        [BitFieldInfo(15, 1)]
        public byte Bit16 { get; set; }

    }

    public partial class Form1 : Form
    {

        public enum BIT_ENUM
        {
            MPIO =0,
            LAN,
            DISK,
            MAX
        }
        BitField bitField1 = new BitField();

        public Form1()
        {
            InitializeComponent();
            comCombo.DataSource = SerialPort.GetPortNames();
            comSendbtn.Enabled = false;
            comClearBtn.Enabled = false;

            BITList_Init();

            #region BitField Test Section

            bitField1.Bit1 = 1;
            bitField1.Bit2 = 0;
            bitField1.Bit3 = 1;
            bitField1.Bit4 = 0;
            bitField1.Bit5 = 1;
            bitField1.Bit6 = 0;
            bitField1.Bit7 = 1;
            bitField1.Bit8 = 0;

            bitField1.Bit9 = 0;
            bitField1.Bit10 = 1;
            bitField1.Bit11 = 1;
            bitField1.Bit12 = 0;
            bitField1.Bit13 = 1;
            bitField1.Bit14 = 0;
            bitField1.Bit15 = 0;
            bitField1.Bit16 = 1;


            ulong bits = bitField1.ToUInt64();
            Console.WriteLine("ulong:  0x{0:X4}", bits);

            string s = bitField1.ToBinaryString();
            Console.WriteLine("string: {0}", s);

            #endregion



        }

        #region Serial 통신
        private void comBtn_Click(object sender, EventArgs e)
        {
            if(!serialPort.IsOpen)
            {
                serialPort.PortName = comCombo.Text;
                serialPort.BaudRate = int.Parse(comBaudBox.SelectedItem.ToString());
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);

                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    comBtn.Text = "Disconnection";
                    comCombo.Enabled = false;
                    comSendbtn.Enabled = true;
                    comClearBtn.Enabled = true;
                }
                }
            else
            {
                comBtn.Text = "Connection";
                comCombo.Enabled = true;
                comSendbtn.Enabled = false;
                comClearBtn.Enabled = false;
                serialPort.Close();
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)  
        {
            this.Invoke(new EventHandler(COMReceive));  
        }

        private void comSendbtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[TX] : ");
            sb.Append(comSendTbox.Text);
            sb.Append("\r\n");

            if (comCrLfBox.Checked == true)
            {
                serialPort.Write(comSendTbox.Text + "\r\n");
                comRichbox.Text += sb.ToString();
                
            }
            else
            {
                string txData = string.Empty;

                txData = "[Tx] : ";
                txData += comSendTbox.Text;
                serialPort.Write(comSendTbox.Text);
                comRichbox.Text += txData;
            }
            
        }

        private void COMReceive(object s, EventArgs e)
        {
            //int ReceiveData = serialPort.ReadByte();
            //comRichbox.Text = comRichbox.Text + string.Format("{0:X2}", ReceiveData);
            string RxData = serialPort.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("[RX] : ");
            sb.Append(RxData);
            comRichbox.Text += sb;
    
        }

        private void comClearBtn_Click(object sender, EventArgs e)
        {
            comRichbox.Clear();
        }
        #endregion

        private void BITList_Init()
        {
            BITCombo.Items.Add("MPIO");
            BITCombo.Items.Add("LAN");
            BITCombo.Items.Add("DISK");
            BITCombo.SelectedIndex = 0;

            comBaudBox.Items.Add("9600");
            comBaudBox.Items.Add("19200");
            comBaudBox.Items.Add("38400");
            comBaudBox.Items.Add("57600");
            comBaudBox.Items.Add("115200");
            comBaudBox.Items.Add("230400");

            comBaudBox.SelectedIndex = 0;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void BITCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox select = (ComboBox)sender;
            BITRichBox.Clear();

            StringBuilder sb = new StringBuilder();


            switch (select.SelectedIndex)
            {
                case (int)BIT_ENUM.DISK:

                    SelectQuery selectQuery = new SelectQuery("Win32_DiskDrive");
                    ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(selectQuery);

                    string deviceName = "";
                    string tmpSize = "";
                    ulong volume = 0;
                    foreach (ManagementObject managementObject in managementObjectSearcher.Get())
                    {
                        
                        deviceName = managementObject.Properties["Caption"].Value.ToString();
                        tmpSize = managementObject.Properties["Size"].Value.ToString();
                        volume = ((Convert.ToUInt64(tmpSize) / 1024) / 1024) / 1024;
                        sb.Append(deviceName);
                        sb.Append("\t");
                        sb.Append(volume.ToString());
                        sb.Append("GB");

                    }      
                    break;

                case 3:
                    break;

                case 4:
                    break;

            }

        }
    }

}

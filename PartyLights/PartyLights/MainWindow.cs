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

using Phidgets;
using Phidgets.Events;


namespace PartyLights
{
    public partial class MainWindow : Form
    {
        private InterfaceKit kit = new InterfaceKit();
        private SerialPort serial = new SerialPort();
        private bool isParty = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        // ================ Main Function ====================

        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                kit.Attach += new AttachEventHandler(kit_Attach);
                kit.Detach += new DetachEventHandler(kit_Detach);
                kit.SensorChange += new SensorChangeEventHandler(kit_SensorChange);
                kit.open("192.168.0.22", 5001);
                //kit.open("phidgetsbc");
            }
            catch (PhidgetException ex)
            {
                MessageBox.Show(ex.Description.ToString());
            }

            foreach (String str in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbCOM.Items.Add(str);
            }


        }

        private void MainWindow_FormClosing(object sender, EventArgs e)
        {

            kit.Attach -= new AttachEventHandler(kit_Attach);
            kit.Detach -= new DetachEventHandler(kit_Detach);
            kit.SensorChange -= new SensorChangeEventHandler(kit_SensorChange);
            Application.DoEvents();
            kit.close();
            kit = null;
        }

        // ============== Event Subscribers ==================

        private void kit_Attach(object sender, AttachEventArgs e)
        {
            kit.sensors[0].Sensitivity = 150;
            kit.sensors[0].DataRate = 32;
            kit.outputs[0] = false;
            kit.outputs[1] = false;
            kit.outputs[2] = false;
        }

        private void kit_Detach(object sender, DetachEventArgs e)
        {
            kit.outputs[0] = false;
            kit.outputs[1] = false;
            kit.outputs[2] = false;
        }

        private void kit_SensorChange(object sender, SensorChangeEventArgs e)
        {
            if (e.Index == 0)
            {
                lblSensorValue.Text = e.Value.ToString();

                if (e.Value < 400 || e.Value > 600)
                {
                    isParty = true;
                    tmrMotion.Enabled = true;
                }
            }

            lblPartyMode.Text = (isParty) ? "ON" : "OFF";
        }

        private void tmrMotion_Tick(object sender, EventArgs e)
        {
            
            if (kit != null)
            {
                kit.outputs[0] = false;
                kit.outputs[1] = false;
                kit.outputs[2] = false;
                isParty = false;
            }
            
        }

        static void printError(int number, String description)
        {
            Console.WriteLine("Error on function call: {0} - {1}!", number, description);

        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            if (isParty)
            {
                kit.outputs[0] = kit.outputs[0] ? false : true;
                kit.outputs[1] = kit.outputs[0];
                kit.outputs[2] = kit.outputs[1];
                tmrTick.Enabled = true;
            }

        }

        private void cmbCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            initiateRead(serial);
            //readSensorValues(serial);
            //tmrRefresh.Enabled = true;
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            readSensorValues(serial);
            tmrRefresh.Enabled = true;
        }

        // ========= Regular Functions ============

        public void initiateRead(SerialPort s)
        {
            if (cmbCOM.SelectedItem == null || s.IsOpen == true)
            {
                return;
            }
            try
            {
                s.PortName = (String)cmbCOM.SelectedItem;
                s.Open();
                if (s.IsOpen == true)
                {
                    lblCO2.Text = "andrew";
                }
                /*
                Byte[] Cmd1 = new Byte[] { 0xFE, 0x41, 0x00, 0x60, 0x01, 0x30 };
                addCheckSum(ref Cmd1);

                while (true)
                {
                    s.DiscardInBuffer();
                    s.Write(Cmd1, 0, Cmd1.Length);
                    DateTime timeOut = DateTime.Now;
                    while (s.BytesToRead < 4)
                    {
                        TimeSpan timePeriod = DateTime.Now - timeOut;
                        if (timePeriod > TimeSpan.FromMilliseconds(90))
                        {
                            break;
                        }
                        System.Threading.Thread.Sleep(5);
                    }

                    if (s.BytesToRead >= 4)
                    {
                        Byte[] theResult = new Byte[4];
                        s.Read(theResult, 0, 4);
                        if (validatePacket(theResult))
                        {
                            break;
                        }
                    }

                }
                 */
                s.Close();
            }
            catch
            {

            }
            
        }

        private void readSensorValues(SerialPort s)
        {
            if (cmbCOM.SelectedItem == null || s.IsOpen == true)
            {
                return;
            }

            s.PortName = (String)cmbCOM.SelectedItem;
            s.Open();

            /* READ CO2 */
            Byte[] Cmd1 = new Byte[] { 0xFE, 0x44, 0x00, 0x08, 0x02 };
            addCheckSum(ref Cmd1);
            while (true)
            {
                s.DiscardInBuffer();
                s.Write(Cmd1, 0, Cmd1.Length);
                DateTime timeOut = DateTime.Now;
                while (s.BytesToRead < 7)
                {
                    TimeSpan timePeriod = DateTime.Now - timeOut;
                    if (timePeriod > TimeSpan.FromMilliseconds(90))
                    {
                        break;
                    }
                    System.Threading.Thread.Sleep(5);
                }
                if (s.BytesToRead >= 7)
                {
                    Byte[] theResult = new Byte[7];
                    s.Read(theResult, 0, 7);
                    if (validatePacket(theResult))
                    {
                        lblCO2.Text = Convert.ToString(getInteger(theResult, 3));
                        break;
                    }
                }
            }

            /* READ TEMP */
            Byte[] Cmd2 = new Byte[] { 0xFE, 0x44, 0x00, 0x12, 0x02 };
            addCheckSum(ref Cmd2);
            while (true)
            {
                s.DiscardInBuffer();
                s.Write(Cmd2, 0, Cmd2.Length);
                DateTime timeOut = DateTime.Now;
                while (s.BytesToRead < 7)
                {
                    TimeSpan timePeriod = DateTime.Now - timeOut;
                    if (timePeriod > TimeSpan.FromMilliseconds(90))
                    {
                        break;
                    }
                    System.Threading.Thread.Sleep(5);
                }
                if (s.BytesToRead >= 7)
                {
                    Byte[] theResult = new Byte[7];
                    s.Read(theResult, 0, 7);
                    if (validatePacket(theResult))
                    {
                        lblTemp.Text = Convert.ToString(getInteger(theResult, 3));
                        break;
                    }
                }
            }

            /* READ HUMIDITY */
            Byte[] Cmd3 = new Byte[] { 0xFE, 0x44, 0x00, 0x14, 0x02 };
            addCheckSum(ref Cmd3);
            while (true)
            {
                s.DiscardInBuffer();
                s.Write(Cmd3, 0, Cmd3.Length);
                DateTime timeOut = DateTime.Now;
                while (s.BytesToRead < 7)
                {
                    TimeSpan timePeriod = DateTime.Now - timeOut;
                    if (timePeriod > TimeSpan.FromMilliseconds(90))
                    {
                        break;
                    }
                    System.Threading.Thread.Sleep(5);
                }
                if (s.BytesToRead >= 7)
                {
                    Byte[] theResult = new Byte[7];
                    s.Read(theResult, 0, 7);
                    if (validatePacket(theResult))
                    {
                        lblHumidity.Text = Convert.ToString(getInteger(theResult, 3));
                        break;
                    }
                }
            }
            s.Close();

        }

        public short getInteger(Byte[] bytes, int offset)
        {
            Byte[] tempArray = { bytes[offset + 1], bytes[offset] };
            return BitConverter.ToInt16(tempArray, 0);
        }

        public long CRC16(Byte[] MB_array, int mNum)
        {
            uint temp = 0;
            uint CRC = 65535;
            for (int i = 0; i < mNum; i++)
            {
                temp = CRC;
                CRC = temp ^ MB_array[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((CRC & 1) > 0)
                    {
                        CRC = ((CRC >> 1) ^ 40961); //1021
                    }
                    else
                    {
                        CRC = (CRC >> 1); //And 65535
                    }
                }
            }

            return CRC & 65535;
        }

        public Boolean validatePacket(Byte[] packet)
        {
            int CRC = (int)CRC16(packet, packet.Length - 2);
            int crcCompare = BitConverter.ToUInt16(packet, packet.Length - 2);
            if (CRC != crcCompare)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void addCheckSum(ref Byte[] packet)
        {
            Byte[] CRC = BitConverter.GetBytes((short)(CRC16(packet, packet.Length)));
            Byte[] outputArray = new Byte[packet.Length + 2];
            packet.CopyTo(outputArray, 0);
            CRC.CopyTo(outputArray, packet.Length);
            packet = outputArray;
        }
    }       
}

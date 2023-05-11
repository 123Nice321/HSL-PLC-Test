using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication;
using HslCommunication.Profinet;
using HslCommunication.Profinet.Melsec; //三菱使用
using HslCommunication.Profinet.Omron;  //欧姆龙使用
using HslCommunication.Profinet.Delta;  //台达使用
using HslCommunication.Profinet.FATEK;  //永宏使用
using HslCommunication.Profinet.Siemens; //西门子使用
using HslCommunication.Profinet.Inovance;//汇川PLC使用
namespace 三菱通讯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            com串口名欧姆龙.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBox1台达.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBox1永宏用.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBox1汇川串口.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        } 
        private MelsecMcNet melsec_net = new MelsecMcNet("192.168.177.150", 3000);//实例化三菱 使用以太网通讯
        private OmronHostLink OmronHostLink = new OmronHostLink(); //实例化欧姆龙 使用232端口通讯
        private DeltaSerialAscii DeltaSerialAscii = new DeltaSerialAscii();//实例化台达 使用COM2口通讯
        private FatekProgram FatekProgram = new FatekProgram();//实例化永宏PLC 使用编程口通讯
        private SiemensS7Net SiemensS7Net = new SiemensS7Net(SiemensPLCS.S200Smart, "192.168.177.151") { ConnectTimeOut = 5000 };//实例化西门子PLC
        private InovanceSerial InovanceSerial = new InovanceSerial();//实例化汇川Modbus-Rtu串口通讯

        //三菱程序段++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void 三菱PLC连接_Click(object sender, EventArgs e)
        {
            melsec_net.ConnectTimeOut = 2000; // 网络连接的超时时间
            melsec_net.NetworkNumber = 0x00;  // 网络号
            melsec_net.NetworkStationNumber = 0x00; // 网络站号
            melsec_net.ConnectClose();
            OperateResult connect = melsec_net.ConnectServer();
            if (connect.IsSuccess)
            {
                MessageBox.Show("连接成功！");
            }
            else
            {
                MessageBox.Show("连接失败！");
            }
        }
        private void 三菱启动_Click(object sender, EventArgs e)
        {
            三菱time.Enabled = true;

        }
        private void 三菱time_Tick(object sender, EventArgs e)
        {
            ushort[] ushort_D1000 = melsec_net.ReadUInt16("D100",1).Content; // 读取D1000的ushort值
            三菱显示.Text = ushort_D1000[0].ToString();

        }


        //欧姆龙程序段++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void 欧姆龙连接_Click(object sender, EventArgs e)
        {
            try
            {
                OmronHostLink.SerialPortInni(sp =>
                {
                    sp.PortName = com串口名欧姆龙.Text;
                    sp.BaudRate = 9600;
                    sp.DataBits = 7;
                    sp.StopBits = System.IO.Ports.StopBits.One;
                    sp.Parity = System.IO.Ports.Parity.Even;
                });

                OmronHostLink.Open();
                if (OmronHostLink.IsOpen())
                {
                    MessageBox.Show("连接成功");
                }
                else
                {
                    MessageBox.Show("连接失败");
                }
            }
            catch
            {
                MessageBox.Show("错误请检查！");
            }
        }

        private void 欧姆龙time_Tick(object sender, EventArgs e)
        {
            short int_D100 = OmronHostLink.ReadInt16("D100").Content;
            欧姆龙显示.Text = int_D100.ToString();
        }

        private void 欧姆龙启动_Click(object sender, EventArgs e)
        {
            欧姆龙time.Enabled = true;
 
        }


        //台达程序段++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void 台达连接_Click(object sender, EventArgs e)
        {
            DeltaSerialAscii.SerialPortInni(sp =>
            {
                sp.PortName = comboBox1台达.Text;
                sp.BaudRate = 9600;
                sp.DataBits = 7;
                sp.StopBits = System.IO.Ports.StopBits.One;
                sp.Parity = System.IO.Ports.Parity.Even;
            });
            DeltaSerialAscii.Open();
            if (DeltaSerialAscii.IsOpen())
            {
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }

        private void 台达启动_Click(object sender, EventArgs e)
        {
            台达time.Enabled = true;
        }

        private void 台达time_Tick(object sender, EventArgs e)
        {
            short int_D100 = DeltaSerialAscii.ReadInt16("D100").Content;
            台达显示.Text = int_D100.ToString();
        }



        //永宏程序段++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void 永宏连接_Click(object sender, EventArgs e)
        {
            FatekProgram.SerialPortInni(sp =>
            {
                sp.PortName = comboBox1永宏用.Text;
                sp.BaudRate = 9600;
                sp.DataBits = 7;
                sp.StopBits = System.IO.Ports.StopBits.One;
                sp.Parity = System.IO.Ports.Parity.Even;
            });
            FatekProgram.Open();
            if (FatekProgram.IsOpen())
            {
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }

        private void 永宏启动_Click(object sender, EventArgs e)
        {
            永宏time.Enabled = true;
        }

        private void 永宏time_Tick(object sender, EventArgs e)
        {
            short int_D100 = FatekProgram.ReadInt16("D100").Content;
            永宏显示.Text = int_D100.ToString();
        }
        
        private void 永宏PLCRun_Click(object sender, EventArgs e)
        {
            FatekProgram.Run();
        }

        private void 永宏PLCStop_Click(object sender, EventArgs e)
        {
            FatekProgram.Stop();
        }



        //西门子Smart200程序段++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void butS200Smart连接_Click(object sender, EventArgs e)
        {
            SiemensS7Net.ConnectClose();
            OperateResult connect = SiemensS7Net.ConnectServer();
            if (connect.IsSuccess)
            {
                MessageBox.Show("连接成功！");
            }
            else
            {
                MessageBox.Show("连接失败！");
            }
        }

        private void butS200Smart启动_Click(object sender, EventArgs e)
        {
            西门子time.Enabled = true;
        }

        private void 西门子time_Tick(object sender, EventArgs e)
        {
            short short_M100 = SiemensS7Net.ReadInt16("VW100").Content; 
            S200Smart显示.Text = short_M100.ToString();
        }

        //汇川程序段++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void 汇川连接_Click(object sender, EventArgs e)
        {
            InovanceSerial.SerialPortInni(sp =>
            {
                sp.PortName = comboBox1汇川串口.Text;
                sp.BaudRate = 115200;
                sp.DataBits = 8;
                sp.StopBits = System.IO.Ports.StopBits.One;
                sp.Parity = System.IO.Ports.Parity.None;
            });
            InovanceSerial.Series = InovanceSeries.H3U;
            InovanceSerial.Open();
            if (InovanceSerial.IsOpen())
            {
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }

        private void 汇川启动_Click(object sender, EventArgs e)
        {
            汇川time.Enabled = true;
        }

        private void 汇川time_Tick(object sender, EventArgs e)
        {
            short int_D100 = InovanceSerial.ReadInt16("D100").Content;
            汇川显示.Text = int_D100.ToString();
        }
    }
}


namespace 三菱通讯
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.三菱PLC连接 = new System.Windows.Forms.Button();
            this.三菱显示 = new System.Windows.Forms.Label();
            this.三菱启动 = new System.Windows.Forms.Button();
            this.三菱time = new System.Windows.Forms.Timer(this.components);
            this.欧姆龙显示 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.com串口名欧姆龙 = new System.Windows.Forms.ComboBox();
            this.欧姆龙连接 = new System.Windows.Forms.Button();
            this.欧姆龙启动 = new System.Windows.Forms.Button();
            this.欧姆龙time = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.台达显示 = new System.Windows.Forms.Label();
            this.comboBox1台达 = new System.Windows.Forms.ComboBox();
            this.台达连接 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.台达启动 = new System.Windows.Forms.Button();
            this.台达time = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.永宏PLC状态显示 = new System.Windows.Forms.Label();
            this.永宏PLCStop = new System.Windows.Forms.Button();
            this.永宏PLCRun = new System.Windows.Forms.Button();
            this.永宏显示 = new System.Windows.Forms.Label();
            this.comboBox1永宏用 = new System.Windows.Forms.ComboBox();
            this.永宏连接 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.永宏启动 = new System.Windows.Forms.Button();
            this.永宏time = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.S200Smart显示 = new System.Windows.Forms.Label();
            this.butS200Smart连接 = new System.Windows.Forms.Button();
            this.butS200Smart启动 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.西门子time = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.汇川显示 = new System.Windows.Forms.Label();
            this.comboBox1汇川串口 = new System.Windows.Forms.ComboBox();
            this.汇川连接 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.汇川启动 = new System.Windows.Forms.Button();
            this.汇川time = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // 三菱PLC连接
            // 
            this.三菱PLC连接.Location = new System.Drawing.Point(20, 20);
            this.三菱PLC连接.Name = "三菱PLC连接";
            this.三菱PLC连接.Size = new System.Drawing.Size(141, 51);
            this.三菱PLC连接.TabIndex = 0;
            this.三菱PLC连接.Text = "三菱连接";
            this.三菱PLC连接.UseVisualStyleBackColor = true;
            this.三菱PLC连接.Click += new System.EventHandler(this.三菱PLC连接_Click);
            // 
            // 三菱显示
            // 
            this.三菱显示.AutoSize = true;
            this.三菱显示.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.三菱显示.Location = new System.Drawing.Point(74, 186);
            this.三菱显示.Name = "三菱显示";
            this.三菱显示.Size = new System.Drawing.Size(164, 48);
            this.三菱显示.TabIndex = 1;
            this.三菱显示.Text = "label1";
            // 
            // 三菱启动
            // 
            this.三菱启动.Location = new System.Drawing.Point(209, 20);
            this.三菱启动.Name = "三菱启动";
            this.三菱启动.Size = new System.Drawing.Size(141, 51);
            this.三菱启动.TabIndex = 0;
            this.三菱启动.Text = "启动";
            this.三菱启动.UseVisualStyleBackColor = true;
            this.三菱启动.Click += new System.EventHandler(this.三菱启动_Click);
            // 
            // 三菱time
            // 
            this.三菱time.Tick += new System.EventHandler(this.三菱time_Tick);
            // 
            // 欧姆龙显示
            // 
            this.欧姆龙显示.AutoSize = true;
            this.欧姆龙显示.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.欧姆龙显示.Location = new System.Drawing.Point(133, 197);
            this.欧姆龙显示.Name = "欧姆龙显示";
            this.欧姆龙显示.Size = new System.Drawing.Size(164, 48);
            this.欧姆龙显示.TabIndex = 1;
            this.欧姆龙显示.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(40, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "三菱PLCTCP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(47, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 48);
            this.label4.TabIndex = 1;
            this.label4.Text = "欧姆龙PLC串口";
            // 
            // com串口名欧姆龙
            // 
            this.com串口名欧姆龙.Font = new System.Drawing.Font("宋体", 12F);
            this.com串口名欧姆龙.FormattingEnabled = true;
            this.com串口名欧姆龙.Location = new System.Drawing.Point(304, 20);
            this.com串口名欧姆龙.Name = "com串口名欧姆龙";
            this.com串口名欧姆龙.Size = new System.Drawing.Size(75, 24);
            this.com串口名欧姆龙.TabIndex = 6;
            // 
            // 欧姆龙连接
            // 
            this.欧姆龙连接.Font = new System.Drawing.Font("宋体", 14F);
            this.欧姆龙连接.Location = new System.Drawing.Point(273, 50);
            this.欧姆龙连接.Name = "欧姆龙连接";
            this.欧姆龙连接.Size = new System.Drawing.Size(138, 33);
            this.欧姆龙连接.TabIndex = 5;
            this.欧姆龙连接.Text = "连接";
            this.欧姆龙连接.UseVisualStyleBackColor = true;
            this.欧姆龙连接.Click += new System.EventHandler(this.欧姆龙连接_Click);
            // 
            // 欧姆龙启动
            // 
            this.欧姆龙启动.Location = new System.Drawing.Point(93, 44);
            this.欧姆龙启动.Name = "欧姆龙启动";
            this.欧姆龙启动.Size = new System.Drawing.Size(141, 51);
            this.欧姆龙启动.TabIndex = 0;
            this.欧姆龙启动.Text = "启动";
            this.欧姆龙启动.UseVisualStyleBackColor = true;
            this.欧姆龙启动.Click += new System.EventHandler(this.欧姆龙启动_Click);
            // 
            // 欧姆龙time
            // 
            this.欧姆龙time.Interval = 200;
            this.欧姆龙time.Tick += new System.EventHandler(this.欧姆龙time_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.三菱PLC连接);
            this.groupBox1.Controls.Add(this.三菱启动);
            this.groupBox1.Controls.Add(this.三菱显示);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 247);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "三菱PLC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.欧姆龙显示);
            this.groupBox2.Controls.Add(this.com串口名欧姆龙);
            this.groupBox2.Controls.Add(this.欧姆龙连接);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.欧姆龙启动);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox2.Location = new System.Drawing.Point(862, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 260);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "欧姆龙PLC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.台达显示);
            this.groupBox3.Controls.Add(this.comboBox1台达);
            this.groupBox3.Controls.Add(this.台达连接);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.台达启动);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 296);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "台达PLC";
            // 
            // 台达显示
            // 
            this.台达显示.AutoSize = true;
            this.台达显示.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.台达显示.Location = new System.Drawing.Point(121, 205);
            this.台达显示.Name = "台达显示";
            this.台达显示.Size = new System.Drawing.Size(164, 48);
            this.台达显示.TabIndex = 1;
            this.台达显示.Text = "label1";
            // 
            // comboBox1台达
            // 
            this.comboBox1台达.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1台达.FormattingEnabled = true;
            this.comboBox1台达.Location = new System.Drawing.Point(265, 22);
            this.comboBox1台达.Name = "comboBox1台达";
            this.comboBox1台达.Size = new System.Drawing.Size(75, 24);
            this.comboBox1台达.TabIndex = 6;
            // 
            // 台达连接
            // 
            this.台达连接.Font = new System.Drawing.Font("宋体", 14F);
            this.台达连接.Location = new System.Drawing.Point(219, 52);
            this.台达连接.Name = "台达连接";
            this.台达连接.Size = new System.Drawing.Size(138, 33);
            this.台达连接.TabIndex = 5;
            this.台达连接.Text = "连接";
            this.台达连接.UseVisualStyleBackColor = true;
            this.台达连接.Click += new System.EventHandler(this.台达连接_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(73, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 48);
            this.label6.TabIndex = 1;
            this.label6.Text = "台达PLC串口";
            // 
            // 台达启动
            // 
            this.台达启动.Location = new System.Drawing.Point(49, 34);
            this.台达启动.Name = "台达启动";
            this.台达启动.Size = new System.Drawing.Size(141, 51);
            this.台达启动.TabIndex = 0;
            this.台达启动.Text = "启动";
            this.台达启动.UseVisualStyleBackColor = true;
            this.台达启动.Click += new System.EventHandler(this.台达启动_Click);
            // 
            // 台达time
            // 
            this.台达time.Tick += new System.EventHandler(this.台达time_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.永宏PLC状态显示);
            this.groupBox4.Controls.Add(this.永宏PLCStop);
            this.groupBox4.Controls.Add(this.永宏PLCRun);
            this.groupBox4.Controls.Add(this.永宏显示);
            this.groupBox4.Controls.Add(this.comboBox1永宏用);
            this.groupBox4.Controls.Add(this.永宏连接);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.永宏启动);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox4.Location = new System.Drawing.Point(432, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 260);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "永宏 PLC";
            // 
            // 永宏PLC状态显示
            // 
            this.永宏PLC状态显示.AutoSize = true;
            this.永宏PLC状态显示.BackColor = System.Drawing.Color.Snow;
            this.永宏PLC状态显示.ForeColor = System.Drawing.Color.Red;
            this.永宏PLC状态显示.Location = new System.Drawing.Point(77, 178);
            this.永宏PLC状态显示.Name = "永宏PLC状态显示";
            this.永宏PLC状态显示.Size = new System.Drawing.Size(267, 38);
            this.永宏PLC状态显示.TabIndex = 8;
            this.永宏PLC状态显示.Text = "运行和停止直接作用在PLC状态\r\n参数 9600 7 偶 1\r\n";
            // 
            // 永宏PLCStop
            // 
            this.永宏PLCStop.Location = new System.Drawing.Point(209, 219);
            this.永宏PLCStop.Name = "永宏PLCStop";
            this.永宏PLCStop.Size = new System.Drawing.Size(100, 35);
            this.永宏PLCStop.TabIndex = 7;
            this.永宏PLCStop.Text = "STOP";
            this.永宏PLCStop.UseVisualStyleBackColor = true;
            this.永宏PLCStop.Click += new System.EventHandler(this.永宏PLCStop_Click);
            // 
            // 永宏PLCRun
            // 
            this.永宏PLCRun.Location = new System.Drawing.Point(103, 219);
            this.永宏PLCRun.Name = "永宏PLCRun";
            this.永宏PLCRun.Size = new System.Drawing.Size(100, 36);
            this.永宏PLCRun.TabIndex = 7;
            this.永宏PLCRun.Text = "RUN";
            this.永宏PLCRun.UseVisualStyleBackColor = true;
            this.永宏PLCRun.Click += new System.EventHandler(this.永宏PLCRun_Click);
            // 
            // 永宏显示
            // 
            this.永宏显示.AutoSize = true;
            this.永宏显示.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.永宏显示.Location = new System.Drawing.Point(135, 121);
            this.永宏显示.Name = "永宏显示";
            this.永宏显示.Size = new System.Drawing.Size(164, 48);
            this.永宏显示.TabIndex = 1;
            this.永宏显示.Text = "label1";
            // 
            // comboBox1永宏用
            // 
            this.comboBox1永宏用.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1永宏用.FormattingEnabled = true;
            this.comboBox1永宏用.Location = new System.Drawing.Point(340, 31);
            this.comboBox1永宏用.Name = "comboBox1永宏用";
            this.comboBox1永宏用.Size = new System.Drawing.Size(75, 24);
            this.comboBox1永宏用.TabIndex = 6;
            // 
            // 永宏连接
            // 
            this.永宏连接.Font = new System.Drawing.Font("宋体", 14F);
            this.永宏连接.Location = new System.Drawing.Point(196, 28);
            this.永宏连接.Name = "永宏连接";
            this.永宏连接.Size = new System.Drawing.Size(138, 33);
            this.永宏连接.TabIndex = 5;
            this.永宏连接.Text = "连接";
            this.永宏连接.UseVisualStyleBackColor = true;
            this.永宏连接.Click += new System.EventHandler(this.永宏连接_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(73, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "永宏PLC串口";
            // 
            // 永宏启动
            // 
            this.永宏启动.Location = new System.Drawing.Point(49, 19);
            this.永宏启动.Name = "永宏启动";
            this.永宏启动.Size = new System.Drawing.Size(141, 51);
            this.永宏启动.TabIndex = 0;
            this.永宏启动.Text = "启动";
            this.永宏启动.UseVisualStyleBackColor = true;
            this.永宏启动.Click += new System.EventHandler(this.永宏启动_Click);
            // 
            // 永宏time
            // 
            this.永宏time.Tick += new System.EventHandler(this.永宏time_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.S200Smart显示);
            this.groupBox6.Controls.Add(this.butS200Smart连接);
            this.groupBox6.Controls.Add(this.butS200Smart启动);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox6.Location = new System.Drawing.Point(442, 287);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(424, 260);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "西门子 S200Smart PLC";
            // 
            // S200Smart显示
            // 
            this.S200Smart显示.AutoSize = true;
            this.S200Smart显示.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.S200Smart显示.Location = new System.Drawing.Point(125, 194);
            this.S200Smart显示.Name = "S200Smart显示";
            this.S200Smart显示.Size = new System.Drawing.Size(164, 48);
            this.S200Smart显示.TabIndex = 1;
            this.S200Smart显示.Text = "label1";
            // 
            // butS200Smart连接
            // 
            this.butS200Smart连接.Font = new System.Drawing.Font("宋体", 14F);
            this.butS200Smart连接.Location = new System.Drawing.Point(57, 30);
            this.butS200Smart连接.Name = "butS200Smart连接";
            this.butS200Smart连接.Size = new System.Drawing.Size(136, 49);
            this.butS200Smart连接.TabIndex = 5;
            this.butS200Smart连接.Text = "连接";
            this.butS200Smart连接.UseVisualStyleBackColor = true;
            this.butS200Smart连接.Click += new System.EventHandler(this.butS200Smart连接_Click);
            // 
            // butS200Smart启动
            // 
            this.butS200Smart启动.Location = new System.Drawing.Point(224, 30);
            this.butS200Smart启动.Name = "butS200Smart启动";
            this.butS200Smart启动.Size = new System.Drawing.Size(141, 51);
            this.butS200Smart启动.TabIndex = 0;
            this.butS200Smart启动.Text = "启动";
            this.butS200Smart启动.UseVisualStyleBackColor = true;
            this.butS200Smart启动.Click += new System.EventHandler(this.butS200Smart启动_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(14, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(404, 48);
            this.label8.TabIndex = 1;
            this.label8.Text = "S200SmartPLC网口";
            // 
            // 西门子time
            // 
            this.西门子time.Tick += new System.EventHandler(this.西门子time_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.汇川显示);
            this.groupBox5.Controls.Add(this.comboBox1汇川串口);
            this.groupBox5.Controls.Add(this.汇川连接);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.汇川启动);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox5.Location = new System.Drawing.Point(872, 287);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 260);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "汇川PLC";
            // 
            // 汇川显示
            // 
            this.汇川显示.AutoSize = true;
            this.汇川显示.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.汇川显示.Location = new System.Drawing.Point(153, 194);
            this.汇川显示.Name = "汇川显示";
            this.汇川显示.Size = new System.Drawing.Size(164, 48);
            this.汇川显示.TabIndex = 1;
            this.汇川显示.Text = "label1";
            // 
            // comboBox1汇川串口
            // 
            this.comboBox1汇川串口.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1汇川串口.FormattingEnabled = true;
            this.comboBox1汇川串口.Location = new System.Drawing.Point(304, 20);
            this.comboBox1汇川串口.Name = "comboBox1汇川串口";
            this.comboBox1汇川串口.Size = new System.Drawing.Size(75, 24);
            this.comboBox1汇川串口.TabIndex = 6;
            // 
            // 汇川连接
            // 
            this.汇川连接.Font = new System.Drawing.Font("宋体", 14F);
            this.汇川连接.Location = new System.Drawing.Point(273, 50);
            this.汇川连接.Name = "汇川连接";
            this.汇川连接.Size = new System.Drawing.Size(138, 33);
            this.汇川连接.TabIndex = 5;
            this.汇川连接.Text = "连接";
            this.汇川连接.UseVisualStyleBackColor = true;
            this.汇川连接.Click += new System.EventHandler(this.汇川连接_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(85, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 48);
            this.label5.TabIndex = 1;
            this.label5.Text = "汇川PLC串口";
            // 
            // 汇川启动
            // 
            this.汇川启动.Location = new System.Drawing.Point(93, 44);
            this.汇川启动.Name = "汇川启动";
            this.汇川启动.Size = new System.Drawing.Size(141, 51);
            this.汇川启动.TabIndex = 0;
            this.汇川启动.Text = "启动";
            this.汇川启动.UseVisualStyleBackColor = true;
            this.汇川启动.Click += new System.EventHandler(this.汇川启动_Click);
            // 
            // 汇川time
            // 
            this.汇川time.Tick += new System.EventHandler(this.汇川time_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(131, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "参数 9600 7 偶 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Snow;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(119, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "参数 9600 7 偶 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Snow;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(45, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "参数 192.168.177.150；3000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Snow;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(81, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "参数 192.168.177.150";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Snow;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(143, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 38);
            this.label11.TabIndex = 8;
            this.label11.Text = "参数 115200 8 无 1\r\n需要选择系列 F3U\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 637);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 三菱PLC连接;
        private System.Windows.Forms.Label 三菱显示;
        private System.Windows.Forms.Button 三菱启动;
        private System.Windows.Forms.Timer 三菱time;
        private System.Windows.Forms.Label 欧姆龙显示;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox com串口名欧姆龙;
        private System.Windows.Forms.Button 欧姆龙连接;
        private System.Windows.Forms.Button 欧姆龙启动;
        private System.Windows.Forms.Timer 欧姆龙time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label 台达显示;
        private System.Windows.Forms.ComboBox comboBox1台达;
        private System.Windows.Forms.Button 台达连接;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button 台达启动;
        private System.Windows.Forms.Timer 台达time;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label 永宏显示;
        private System.Windows.Forms.ComboBox comboBox1永宏用;
        private System.Windows.Forms.Button 永宏连接;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 永宏启动;
        private System.Windows.Forms.Timer 永宏time;
        private System.Windows.Forms.Button 永宏PLCRun;
        private System.Windows.Forms.Button 永宏PLCStop;
        private System.Windows.Forms.Label 永宏PLC状态显示;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label S200Smart显示;
        private System.Windows.Forms.Button butS200Smart连接;
        private System.Windows.Forms.Button butS200Smart启动;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer 西门子time;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label 汇川显示;
        private System.Windows.Forms.ComboBox comboBox1汇川串口;
        private System.Windows.Forms.Button 汇川连接;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button 汇川启动;
        private System.Windows.Forms.Timer 汇川time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}


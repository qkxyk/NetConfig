
namespace NetConfig
{
    partial class FrmNetConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNetConfig));
            this.btnClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox_MQTT_Index = new System.Windows.Forms.ComboBox();
            this.textBox_SYS_uuid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MQTT_KeepAliveTime = new System.Windows.Forms.TextBox();
            this.textBox_MQTT_Password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_MQTT_User = new System.Windows.Forms.TextBox();
            this.comboBox_MQTT_Ver = new System.Windows.Forms.ComboBox();
            this.checkBox_MQTT_CleanSession = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_MQTT_ClientID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_MQTT_Port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_MQTT_DomainIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox_TOPIC_Publish_Interval = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_TOPIC_Publish_Qos = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_TOPIC_Publish_TopicName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboBox_TOPIC_Subscribe_Qos = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_TOPIC_Subscribe_TopicName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.gbNet = new System.Windows.Forms.GroupBox();
            this.txtGw = new ControlLibrary.IPControl.IPAddressControl();
            this.txtMask = new ControlLibrary.IPControl.IPAddressControl();
            this.txtIp = new ControlLibrary.IPControl.IPAddressControl();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox_TOPIC_Will_Content = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBox_TOPIC_Will_Qos = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox_TOPIC_Will_TopicName = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.textbox_IpAddress = new ControlLibrary.IPControl.IPAddressControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.readStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReadConfig = new System.Windows.Forms.Button();
            this.lvSub = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.gbNet.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(335, 29);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(63, 23);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "连接设备";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "设备地址:";
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(286, 29);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(78, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "666";
            this.txtPort.Visible = false;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox_MQTT_Index);
            this.groupBox6.Controls.Add(this.textBox_SYS_uuid);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.textBox_MQTT_KeepAliveTime);
            this.groupBox6.Controls.Add(this.textBox_MQTT_Password);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.textBox_MQTT_User);
            this.groupBox6.Controls.Add(this.comboBox_MQTT_Ver);
            this.groupBox6.Controls.Add(this.checkBox_MQTT_CleanSession);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.textBox_MQTT_ClientID);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.textBox_MQTT_Port);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox_MQTT_DomainIP);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(11, 71);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(409, 284);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MQTT";
            // 
            // comboBox_MQTT_Index
            // 
            this.comboBox_MQTT_Index.FormattingEnabled = true;
            this.comboBox_MQTT_Index.Location = new System.Drawing.Point(301, 19);
            this.comboBox_MQTT_Index.Name = "comboBox_MQTT_Index";
            this.comboBox_MQTT_Index.Size = new System.Drawing.Size(121, 20);
            this.comboBox_MQTT_Index.TabIndex = 22;
            this.comboBox_MQTT_Index.Visible = false;
            // 
            // textBox_SYS_uuid
            // 
            this.textBox_SYS_uuid.Location = new System.Drawing.Point(92, 18);
            this.textBox_SYS_uuid.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SYS_uuid.Name = "textBox_SYS_uuid";
            this.textBox_SYS_uuid.Size = new System.Drawing.Size(183, 21);
            this.textBox_SYS_uuid.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "UUID:";
            // 
            // textBox_MQTT_KeepAliveTime
            // 
            this.textBox_MQTT_KeepAliveTime.Location = new System.Drawing.Point(92, 227);
            this.textBox_MQTT_KeepAliveTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MQTT_KeepAliveTime.Name = "textBox_MQTT_KeepAliveTime";
            this.textBox_MQTT_KeepAliveTime.Size = new System.Drawing.Size(76, 21);
            this.textBox_MQTT_KeepAliveTime.TabIndex = 14;
            // 
            // textBox_MQTT_Password
            // 
            this.textBox_MQTT_Password.Location = new System.Drawing.Point(92, 168);
            this.textBox_MQTT_Password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MQTT_Password.Name = "textBox_MQTT_Password";
            this.textBox_MQTT_Password.PasswordChar = '*';
            this.textBox_MQTT_Password.Size = new System.Drawing.Size(152, 21);
            this.textBox_MQTT_Password.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 173);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 231);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "KeepAliveTime:";
            // 
            // textBox_MQTT_User
            // 
            this.textBox_MQTT_User.Location = new System.Drawing.Point(92, 138);
            this.textBox_MQTT_User.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MQTT_User.Name = "textBox_MQTT_User";
            this.textBox_MQTT_User.Size = new System.Drawing.Size(152, 21);
            this.textBox_MQTT_User.TabIndex = 8;
            // 
            // comboBox_MQTT_Ver
            // 
            this.comboBox_MQTT_Ver.FormattingEnabled = true;
            this.comboBox_MQTT_Ver.Location = new System.Drawing.Point(92, 198);
            this.comboBox_MQTT_Ver.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_MQTT_Ver.Name = "comboBox_MQTT_Ver";
            this.comboBox_MQTT_Ver.Size = new System.Drawing.Size(92, 20);
            this.comboBox_MQTT_Ver.TabIndex = 12;
            // 
            // checkBox_MQTT_CleanSession
            // 
            this.checkBox_MQTT_CleanSession.AutoSize = true;
            this.checkBox_MQTT_CleanSession.Location = new System.Drawing.Point(92, 257);
            this.checkBox_MQTT_CleanSession.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_MQTT_CleanSession.Name = "checkBox_MQTT_CleanSession";
            this.checkBox_MQTT_CleanSession.Size = new System.Drawing.Size(96, 16);
            this.checkBox_MQTT_CleanSession.TabIndex = 15;
            this.checkBox_MQTT_CleanSession.Text = "CleanSession";
            this.checkBox_MQTT_CleanSession.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "User:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "MQTT Version:";
            // 
            // textBox_MQTT_ClientID
            // 
            this.textBox_MQTT_ClientID.Location = new System.Drawing.Point(92, 108);
            this.textBox_MQTT_ClientID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MQTT_ClientID.Name = "textBox_MQTT_ClientID";
            this.textBox_MQTT_ClientID.Size = new System.Drawing.Size(307, 21);
            this.textBox_MQTT_ClientID.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Client ID:";
            // 
            // textBox_MQTT_Port
            // 
            this.textBox_MQTT_Port.Location = new System.Drawing.Point(92, 78);
            this.textBox_MQTT_Port.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MQTT_Port.Name = "textBox_MQTT_Port";
            this.textBox_MQTT_Port.Size = new System.Drawing.Size(76, 21);
            this.textBox_MQTT_Port.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Port:";
            // 
            // textBox_MQTT_DomainIP
            // 
            this.textBox_MQTT_DomainIP.Location = new System.Drawing.Point(92, 48);
            this.textBox_MQTT_DomainIP.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MQTT_DomainIP.Name = "textBox_MQTT_DomainIP";
            this.textBox_MQTT_DomainIP.Size = new System.Drawing.Size(307, 21);
            this.textBox_MQTT_DomainIP.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Domain/IP:";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(493, 29);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(63, 23);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "发送数据";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox_TOPIC_Publish_Interval);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.comboBox_TOPIC_Publish_Qos);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.textBox_TOPIC_Publish_TopicName);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Location = new System.Drawing.Point(425, 71);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(375, 80);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "发布";
            // 
            // textBox_TOPIC_Publish_Interval
            // 
            this.textBox_TOPIC_Publish_Interval.Location = new System.Drawing.Point(268, 45);
            this.textBox_TOPIC_Publish_Interval.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TOPIC_Publish_Interval.Name = "textBox_TOPIC_Publish_Interval";
            this.textBox_TOPIC_Publish_Interval.Size = new System.Drawing.Size(76, 21);
            this.textBox_TOPIC_Publish_Interval.TabIndex = 5;
            this.textBox_TOPIC_Publish_Interval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TOPIC_Publish_Interval_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(204, 53);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "Interval:";
            // 
            // comboBox_TOPIC_Publish_Qos
            // 
            this.comboBox_TOPIC_Publish_Qos.FormattingEnabled = true;
            this.comboBox_TOPIC_Publish_Qos.Location = new System.Drawing.Point(86, 47);
            this.comboBox_TOPIC_Publish_Qos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_TOPIC_Publish_Qos.Name = "comboBox_TOPIC_Publish_Qos";
            this.comboBox_TOPIC_Publish_Qos.Size = new System.Drawing.Size(92, 20);
            this.comboBox_TOPIC_Publish_Qos.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 54);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "Qos:";
            // 
            // textBox_TOPIC_Publish_TopicName
            // 
            this.textBox_TOPIC_Publish_TopicName.Location = new System.Drawing.Point(86, 19);
            this.textBox_TOPIC_Publish_TopicName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TOPIC_Publish_TopicName.Name = "textBox_TOPIC_Publish_TopicName";
            this.textBox_TOPIC_Publish_TopicName.Size = new System.Drawing.Size(268, 21);
            this.textBox_TOPIC_Publish_TopicName.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "TopicName:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnDelete);
            this.groupBox10.Controls.Add(this.btnAdd);
            this.groupBox10.Controls.Add(this.lvSub);
            this.groupBox10.Controls.Add(this.comboBox_TOPIC_Subscribe_Qos);
            this.groupBox10.Controls.Add(this.label22);
            this.groupBox10.Controls.Add(this.textBox_TOPIC_Subscribe_TopicName);
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Location = new System.Drawing.Point(425, 155);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(372, 200);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "订阅";
            // 
            // comboBox_TOPIC_Subscribe_Qos
            // 
            this.comboBox_TOPIC_Subscribe_Qos.FormattingEnabled = true;
            this.comboBox_TOPIC_Subscribe_Qos.Location = new System.Drawing.Point(86, 47);
            this.comboBox_TOPIC_Subscribe_Qos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_TOPIC_Subscribe_Qos.Name = "comboBox_TOPIC_Subscribe_Qos";
            this.comboBox_TOPIC_Subscribe_Qos.Size = new System.Drawing.Size(92, 20);
            this.comboBox_TOPIC_Subscribe_Qos.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(51, 54);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "Qos:";
            // 
            // textBox_TOPIC_Subscribe_TopicName
            // 
            this.textBox_TOPIC_Subscribe_TopicName.Location = new System.Drawing.Point(86, 19);
            this.textBox_TOPIC_Subscribe_TopicName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TOPIC_Subscribe_TopicName.Name = "textBox_TOPIC_Subscribe_TopicName";
            this.textBox_TOPIC_Subscribe_TopicName.Size = new System.Drawing.Size(263, 21);
            this.textBox_TOPIC_Subscribe_TopicName.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 28);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "TopicName:";
            // 
            // gbNet
            // 
            this.gbNet.Controls.Add(this.txtGw);
            this.gbNet.Controls.Add(this.txtMask);
            this.gbNet.Controls.Add(this.txtIp);
            this.gbNet.Controls.Add(this.txtMac);
            this.gbNet.Controls.Add(this.label40);
            this.gbNet.Controls.Add(this.label39);
            this.gbNet.Controls.Add(this.label38);
            this.gbNet.Location = new System.Drawing.Point(12, 360);
            this.gbNet.Name = "gbNet";
            this.gbNet.Size = new System.Drawing.Size(408, 122);
            this.gbNet.TabIndex = 8;
            this.gbNet.TabStop = false;
            this.gbNet.Text = "网络";
            // 
            // txtGw
            // 
            this.txtGw.Location = new System.Drawing.Point(83, 84);
            this.txtGw.Name = "txtGw";
            this.txtGw.Size = new System.Drawing.Size(180, 26);
            this.txtGw.TabIndex = 4;
            this.txtGw.Value = ((System.Net.IPAddress)(resources.GetObject("txtGw.Value")));
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(83, 47);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(180, 26);
            this.txtMask.TabIndex = 3;
            this.txtMask.Value = ((System.Net.IPAddress)(resources.GetObject("txtMask.Value")));
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(83, 9);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(180, 26);
            this.txtIp.TabIndex = 2;
            this.txtIp.Value = ((System.Net.IPAddress)(resources.GetObject("txtIp.Value")));
            // 
            // txtMac
            // 
            this.txtMac.Location = new System.Drawing.Point(284, 98);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(180, 21);
            this.txtMac.TabIndex = 1;
            this.txtMac.Text = "72.81.81.81.85.103";
            this.txtMac.Visible = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(16, 86);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 12);
            this.label40.TabIndex = 0;
            this.label40.Text = "默认网关：";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(16, 51);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(65, 12);
            this.label39.TabIndex = 0;
            this.label39.Text = "子网掩码：";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(28, 17);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(53, 12);
            this.label38.TabIndex = 0;
            this.label38.Text = "IP地址：";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox_TOPIC_Will_Content);
            this.groupBox17.Controls.Add(this.label32);
            this.groupBox17.Controls.Add(this.comboBox_TOPIC_Will_Qos);
            this.groupBox17.Controls.Add(this.label33);
            this.groupBox17.Controls.Add(this.textBox_TOPIC_Will_TopicName);
            this.groupBox17.Controls.Add(this.label34);
            this.groupBox17.Location = new System.Drawing.Point(425, 360);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox17.Size = new System.Drawing.Size(372, 125);
            this.groupBox17.TabIndex = 9;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "遗言";
            // 
            // textBox_TOPIC_Will_Content
            // 
            this.textBox_TOPIC_Will_Content.Location = new System.Drawing.Point(85, 74);
            this.textBox_TOPIC_Will_Content.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TOPIC_Will_Content.Multiline = true;
            this.textBox_TOPIC_Will_Content.Name = "textBox_TOPIC_Will_Content";
            this.textBox_TOPIC_Will_Content.Size = new System.Drawing.Size(259, 38);
            this.textBox_TOPIC_Will_Content.TabIndex = 5;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(28, 83);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 12);
            this.label32.TabIndex = 4;
            this.label32.Text = "Content:";
            // 
            // comboBox_TOPIC_Will_Qos
            // 
            this.comboBox_TOPIC_Will_Qos.FormattingEnabled = true;
            this.comboBox_TOPIC_Will_Qos.Location = new System.Drawing.Point(86, 47);
            this.comboBox_TOPIC_Will_Qos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_TOPIC_Will_Qos.Name = "comboBox_TOPIC_Will_Qos";
            this.comboBox_TOPIC_Will_Qos.Size = new System.Drawing.Size(92, 20);
            this.comboBox_TOPIC_Will_Qos.TabIndex = 3;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(51, 54);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(29, 12);
            this.label33.TabIndex = 2;
            this.label33.Text = "Qos:";
            // 
            // textBox_TOPIC_Will_TopicName
            // 
            this.textBox_TOPIC_Will_TopicName.Location = new System.Drawing.Point(86, 19);
            this.textBox_TOPIC_Will_TopicName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TOPIC_Will_TopicName.Name = "textBox_TOPIC_Will_TopicName";
            this.textBox_TOPIC_Will_TopicName.Size = new System.Drawing.Size(258, 21);
            this.textBox_TOPIC_Will_TopicName.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 28);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 12);
            this.label34.TabIndex = 0;
            this.label34.Text = "TopicName:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(572, 29);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(63, 23);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "读取数据";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // textbox_IpAddress
            // 
            this.textbox_IpAddress.Location = new System.Drawing.Point(123, 27);
            this.textbox_IpAddress.Name = "textbox_IpAddress";
            this.textbox_IpAddress.Size = new System.Drawing.Size(167, 26);
            this.textbox_IpAddress.TabIndex = 21;
            this.textbox_IpAddress.Value = ((System.Net.IPAddress)(resources.GetObject("textbox_IpAddress.Value")));
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(414, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "关闭连接";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(810, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // readStatus
            // 
            this.readStatus.Name = "readStatus";
            this.readStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(651, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存配置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Location = new System.Drawing.Point(730, 29);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(63, 23);
            this.btnReadConfig.TabIndex = 10;
            this.btnReadConfig.Text = "读取配置";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // lvSub
            // 
            this.lvSub.BackColor = System.Drawing.SystemColors.Window;
            this.lvSub.CheckBoxes = true;
            this.lvSub.FullRowSelect = true;
            this.lvSub.GridLines = true;
            this.lvSub.HideSelection = false;
            this.lvSub.Location = new System.Drawing.Point(5, 73);
            this.lvSub.Name = "lvSub";
            this.lvSub.Size = new System.Drawing.Size(363, 117);
            this.lvSub.TabIndex = 4;
            this.lvSub.UseCompatibleStateImageBehavior = false;
            this.lvSub.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加订阅";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(274, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "取消订阅";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmNetConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textbox_IpAddress);
            this.Controls.Add(this.btnReadConfig);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.gbNet);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNetConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H1Pro配置软件  V1.0.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNetConfig_FormClosed);
            this.Load += new System.EventHandler(this.FrmNetConfig_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.gbNet.ResumeLayout(false);
            this.gbNet.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_SYS_uuid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MQTT_KeepAliveTime;
        private System.Windows.Forms.TextBox textBox_MQTT_Password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_MQTT_User;
        private System.Windows.Forms.ComboBox comboBox_MQTT_Ver;
        private System.Windows.Forms.CheckBox checkBox_MQTT_CleanSession;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_MQTT_ClientID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_MQTT_Port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MQTT_DomainIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox_TOPIC_Publish_Interval;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox_TOPIC_Publish_Qos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_TOPIC_Publish_TopicName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox comboBox_TOPIC_Subscribe_Qos;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_TOPIC_Subscribe_TopicName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox gbNet;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox textBox_TOPIC_Will_Content;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboBox_TOPIC_Will_Qos;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox_TOPIC_Will_TopicName;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnRead;
        private ControlLibrary.IPControl.IPAddressControl textbox_IpAddress;
        private ControlLibrary.IPControl.IPAddressControl txtGw;
        private ControlLibrary.IPControl.IPAddressControl txtMask;
        private ControlLibrary.IPControl.IPAddressControl txtIp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel readStatus;
        private System.Windows.Forms.ComboBox comboBox_MQTT_Index;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReadConfig;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvSub;
        private System.Windows.Forms.Button btnDelete;
    }
}


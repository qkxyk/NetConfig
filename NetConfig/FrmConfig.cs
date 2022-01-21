using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cowboy.Sockets;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Converters;

namespace NetConfig
{
    public partial class FrmNetConfig : Form
    {
        public FrmNetConfig()
        {
            InitializeComponent();
        }
        TcpSocketClient _client;

        public void InitData()
        {
            comboBox_MQTT_Index.Items.AddRange(new string[] { "0", "1" });
            comboBox_MQTT_Index.SelectedIndex = 1;
            comboBox_MQTT_Ver.Items.Add("3.1");
            comboBox_MQTT_Ver.Items.Add("3.1.1");
            comboBox_MQTT_Ver.SelectedIndex = 1;
            //comboBox_MQTT_Broker.Items.Add("Hexu Broker");
            //comboBox_MQTT_Broker.Items.Add("Googol Broker");
            //comboBox_MQTT_Broker.SelectedIndex = 0;
            //textBox_SYS_uuid.Text = "UIG00112127V0001";
            //textBox_MQTT_DomainIP.Text = "www.hexucloud.com";
            //textBox_MQTT_Port.Text = "18831";
            //textBox_MQTT_ClientID.Text = "UIC0011852Z0155";
            //textBox_MQTT_User.Text = "admin";
            //textBox_MQTT_Password.Text = "password";
            checkBox_MQTT_CleanSession.Checked = true;

            textBox_MQTT_KeepAliveTime.Text = "200";

            comboBox_TOPIC_Publish_Qos.Items.Add("0");
            comboBox_TOPIC_Publish_Qos.Items.Add("1");
            comboBox_TOPIC_Publish_Qos.Items.Add("2");
            comboBox_TOPIC_Publish_Qos.SelectedIndex = 2;

            comboBox_TOPIC_Subscribe_Qos.Items.Add("0");
            comboBox_TOPIC_Subscribe_Qos.Items.Add("1");
            comboBox_TOPIC_Subscribe_Qos.Items.Add("2");
            comboBox_TOPIC_Subscribe_Qos.SelectedIndex = 2;

            comboBox_TOPIC_Will_Qos.Items.Add("0");
            comboBox_TOPIC_Will_Qos.Items.Add("1");
            comboBox_TOPIC_Will_Qos.Items.Add("2");
            comboBox_TOPIC_Will_Qos.SelectedIndex = 2;

            textBox_TOPIC_Publish_Interval.Text = "15";

            //string name = Dns.GetHostName();
            //IPAddress[] ipadrlist = Dns.GetHostAddresses(name);
            //string ipadd = "";
            //var ipv4 = ipadrlist.Where(a => a.AddressFamily == AddressFamily.InterNetwork);
            //comboAddress.DataSource = ipv4.ToList();
            btnClient.Enabled = true;
            btnSendMessage.Enabled = false;
            btnRead.Enabled = false;
            btnClose.Enabled = false;
            //textBox_MQTT_ClientID.Text
            textbox_IpAddress.Text = "192.168.10.20";
            txtMac.AutoSize = false;
            txtMac.Height = 20;
            // txtMac.TextAlign = HorizontalAlignment.Center;

        }
        private void InitSubView()
        {
            lvSub.GridLines = true;
            lvSub.View = View.Details;
            lvSub.FullRowSelect = true;
            //lvSub.Columns.Add("test");
            lvSub.Columns.Add(new ColumnHeader { Text = "主题", Width = 329, TextAlign = HorizontalAlignment.Left });
            lvSub.Columns.Add(new ColumnHeader { Text = "Qos", Width = 30 });
            //lvSub.Columns.Add("客户端", 125, HorizontalAlignment.Left);
            //lvSub.Columns.Add("消息内容", 350, HorizontalAlignment.Left);
            //lvSub.Columns.Add("时间", 140, HorizontalAlignment.Left);
            //for (int i = 0; i < 4; i++)   //添加10行数据  
            //{
            //    ListViewItem lvi = new ListViewItem();

            //                lvi.Text = "subitem" + i;

            //    lvi.SubItems.Add(  i.ToString());


            //    this.lvSub.Items.Add(lvi);
            //}


        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            // DateTime dt = DateTime.Now;
            // IsoDateTimeConverter timeFormat = new IsoDateTimeConverter();
            // timeFormat.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:sszzz";

            // //string strDate = dt.ToString();
            // string strDate =   JsonConvert.SerializeObject(dt,Formatting.Indented,timeFormat);
            ////strDate = dt.ToString("yyyy-MM-dd'T'HH:mm:sszzz");
            // //SimpleDateFormat sf = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss.SSS'Z'");
            // MessageBox.Show(strDate);
            // return;
            var config = new TcpSocketClientConfiguration();
            //config.NoDelay = true;
            config.FrameBuilder = new RawBufferFrameBuilder();
            config.ConnectTimeout = new TimeSpan(0, 0, 2);

            //string ipAddress = comboAddress.SelectedItem.ToString();
            string ipAddress = textbox_IpAddress.Text.Trim();
            int port = int.Parse(txtPort.Text);
            //IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("192.168.9.44"), 6800);
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            _client = new TcpSocketClient(remoteEP, config);
            _client.ServerConnected += client_ServerConnected;
            _client.ServerDisconnected += client_ServerDisconnected;
            _client.ServerDataReceived += client_ServerDataReceived;
            try
            {
                _client.Connect();
            }
            catch (Exception)
            {

                MessageBox.Show($"连接超时");
            }

        }
        void client_ServerConnected(object sender, TcpServerConnectedEventArgs e)
        {
            //MessageBox.Show($"TCP server {e.RemoteEndPoint} has connected.");
            //Console.WriteLine(string.Format("TCP server {0} has connected.", e.RemoteEndPoint));
            btnClient.Enabled = false;
            btnSendMessage.Enabled = true;
            btnRead.Enabled = true;
            btnClose.Enabled = true;
        }

        void client_ServerDisconnected(object sender, TcpServerDisconnectedEventArgs e)
        {
            //MessageBox.Show($"TCP server {e.RemoteEndPoint} has disconnected.");
            btnClient.Invoke(new MethodInvoker(() =>
            {
                btnClient.Enabled = true;
                btnSendMessage.Enabled = false;
                btnRead.Enabled = false;
                btnClose.Enabled = false;
            }));

        }

        void client_ServerDataReceived(object sender, TcpServerDataReceivedEventArgs e)
        {
            var text = Encoding.UTF8.GetString(e.Data, e.DataOffset, e.DataLength);
            try
            {
                //接收的数据进行反序列化
                PackageData mess = JsonConvert.DeserializeObject<PackageData>(text);

                //修改界面的值
                if (mess.data == null)
                {
                    return;
                }
                txtIp.Invoke(new MethodInvoker(() =>
                {
                    if (mess.action == "read_ack")
                    {
                        readStatus.Text = "读取数据成功";
                    }
                    else
                    {
                        readStatus.Text = "发送数据成功";
                    }
                    if (mess.data.Lan != null)
                    {
                        var lan = mess.data.Lan;
                        txtIp.Text = String.Join(".", lan.Ip);
                        txtMac.Text = String.Join(".", lan.Mac);
                        txtMask.Text = String.Join(".", lan.Mask);
                        txtGw.Text = string.Join(".", lan.GateWay);
                    }
                    if (mess.data.SubTopic != null)
                    {
                        var sub = mess.data.SubTopic;
                        //textBox_TOPIC_Subscribe_TopicName.Text = sub.Topic;
                        //comboBox_TOPIC_Subscribe_Qos.SelectedItem = sub.Qos;
                        SetLvSub(sub);
                    }
                    if (mess.data.PubTopic != null)
                    {
                        var pub = mess.data.PubTopic;
                        textBox_TOPIC_Publish_TopicName.Text = pub.Topic;
                        textBox_TOPIC_Publish_Interval.Text = pub.Interval.ToString();
                        comboBox_TOPIC_Publish_Qos.SelectedItem = pub.Qos;
                    }
                    if (mess.data.WillTopic != null)
                    {
                        var will = mess.data.WillTopic;
                        textBox_TOPIC_Will_TopicName.Text = will.Topic;
                        textBox_TOPIC_Will_Content.Text = will.Content;
                        comboBox_TOPIC_Will_Qos.SelectedItem = will.Qos;
                    }

                    textBox_MQTT_ClientID.Text = mess.data.ClientId;
                    textBox_MQTT_DomainIP.Text = mess.data.DomainIp;
                    textBox_MQTT_User.Text = mess.data.UserName;
                    textBox_MQTT_Port.Text = mess.data.Port.ToString();
                    textBox_MQTT_KeepAliveTime.Text = mess.data.KeepAliveTime.ToString();
                    comboBox_MQTT_Ver.SelectedItem = mess.data.Version ?? comboBox_MQTT_Ver.SelectedItem;
                    checkBox_MQTT_CleanSession.Checked = Convert.ToBoolean(mess.data.CleanSessionMark);
                    textBox_SYS_uuid.Text = mess.data.UUID;
                    comboBox_MQTT_Index.SelectedItem = mess.clientidx.ToString() ?? comboBox_MQTT_Index.SelectedItem;


                }
                //数据填充到控件中
                    ));

            }
            catch (Exception ex)
            {
                //MessageBox.Show("接收");
                Console.WriteLine(ex.Message);
            }

        }


        private void btnSendMessage_Click(object sender, EventArgs e)
        {

            PackageData md = new PackageData();
            md.action = "writedata";
            int index = 0;
            int.TryParse(comboBox_MQTT_Index.SelectedItem.ToString(), out index);
            md.clientidx = index;
            var mess = new HXSetMessage();
            //对数据进行组包
            var uuid = textBox_SYS_uuid.Text;
            if (string.IsNullOrWhiteSpace(uuid))
            {
                MessageBox.Show("设备的uuid不能为空");
                return;
            }
            mess.UUID = uuid;
            var domainIp = textBox_MQTT_DomainIP.Text;
            if (string.IsNullOrWhiteSpace(domainIp))
            {
                MessageBox.Show("borker地址不能为空");
                return;
            }
            if (domainIp.Length >= 30)
            {
                MessageBox.Show("DomainIp长度不能超过29个字符");
            }
            mess.DomainIp = domainIp;
            string strPort = textBox_MQTT_Port.Text;
            if (string.IsNullOrWhiteSpace(strPort))
            {
                MessageBox.Show("borker端口不能为空");
                return;
            }
            int port = 0;
            bool bRet = int.TryParse(strPort, out port);
            if (bRet)
            {
                if (port > 65535)
                {
                    MessageBox.Show("端口号不能大于65535");
                }
                mess.Port = port;
            }
            else
            {
                MessageBox.Show("请输入正确的端口号");
                return;
            }

            //clientId如果为空，可以设置为随机值
            string clientId = textBox_MQTT_ClientID.Text;
            if (string.IsNullOrWhiteSpace(clientId))
            {
                clientId = Guid.NewGuid().ToString("N");
            }
            if (clientId.Length >= 20)
            {
                MessageBox.Show("Client长度不能超过19个字符");
            }
            mess.ClientId = clientId;
            string User = textBox_MQTT_User.Text;
            if (string.IsNullOrWhiteSpace(User))
            {
                MessageBox.Show("Mqtt登录用户名不能为空");
                return;
            }
            if (User.Length >= 30)
            {
                MessageBox.Show("用户名长度不能超过29个字符");
            }

            mess.UserName = User;

            string password = textBox_MQTT_Password.Text;
            if (password.Length >= 20)
            {
                MessageBox.Show("密码长度不能超过19个字符");
            }
            mess.UserPwd = password;
            if (comboBox_MQTT_Ver.SelectedItem == null)
            {
                MessageBox.Show("请选择正确的MQTT版本号");
                return;
            }

            string MqttVersion = comboBox_MQTT_Ver.SelectedItem.ToString();
            mess.Version = MqttVersion;
            int KeepAlive = int.Parse(textBox_MQTT_KeepAliveTime.Text);
            mess.KeepAliveTime = KeepAlive;
            bool clean = checkBox_MQTT_CleanSession.Checked;
            mess.CleanSessionMark = Convert.ToInt32(clean);
            md.data = mess;
            PublishMessage pm = new PublishMessage();

            string publishTopic = textBox_TOPIC_Publish_TopicName.Text;
            if (string.IsNullOrWhiteSpace(publishTopic))
            {
                MessageBox.Show("发布主题不能为空");
                return;
            }
            string publishInterval = textBox_TOPIC_Publish_Interval.Text;
            string publishQos = comboBox_TOPIC_Publish_Qos.SelectedItem.ToString();
            pm.Topic = publishTopic;
            pm.Qos = int.Parse(publishQos);
            pm.Interval = int.Parse(publishInterval);
            md.data.PubTopic = pm;

            //SubMessage sub = new SubMessage();
            //string subTopic = textBox_TOPIC_Subscribe_TopicName.Text;
            //string subQos = comboBox_TOPIC_Subscribe_Qos.SelectedItem.ToString();
            //sub.Topic = subTopic;
            //sub.Qos = int.Parse(subQos);
            var sub = GetSubMessage();
            md.data.SubTopic = sub;
            WillMessage will = new WillMessage();
            string willTopic = textBox_TOPIC_Will_TopicName.Text;
            string willQos = comboBox_TOPIC_Will_Qos.SelectedItem.ToString();
            string willContent = textBox_TOPIC_Will_Content.Text;
            will.Topic = willTopic;
            will.Qos = int.Parse(willQos);
            will.Content = willContent;
            md.data.WillTopic = will;

            LanMessage lan = new LanMessage();
            string mask = txtMask.Text;
            string ip = txtIp.Text;
            string mac = txtMac.Text;
            string gateway = txtGw.Text;
            try
            {
                int[] arrayMask = Array.ConvertAll<string, int>(mask.Split('.'), s => int.Parse(s));
                lan.Mask = arrayMask;
                int[] arrayIp = Array.ConvertAll<string, int>(ip.Split('.'), s => int.Parse(s));
                lan.Ip = arrayIp;
                int[] arrayMac = Array.ConvertAll<string, int>(mac.Split('.'), s => int.Parse(s));
                lan.Mac = arrayMac;
                int[] arrayGw = Array.ConvertAll<string, int>(gateway.Split('.'), s => int.Parse(s));
                lan.GateWay = arrayGw;
            }
            catch (Exception)
            {
                MessageBox.Show("输入ip、MASK、MAC或者GW数据格式不正确，格式为点号分割的数据字符串");
            }

            md.data.Lan = lan;
            IsoDateTimeConverter timeFormat = new IsoDateTimeConverter();
            timeFormat.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:sszzz";
            string message = JsonConvert.SerializeObject(md, timeFormat);
            if (_client.State == TcpSocketConnectionState.Connected)
            {
                _client.Send(Encoding.UTF8.GetBytes(message));
                readStatus.Text = "下发指令已发送";
            }
        }

        private void FrmNetConfig_Load(object sender, EventArgs e)
        {
            InitData();
            InitSubView();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = 0;
            int.TryParse(comboBox_MQTT_Index.SelectedItem.ToString(), out index);
            SendMessage sm = new SendMessage { action = "readdata", clientidx = index };
            string message = JsonConvert.SerializeObject(sm);
            if (_client.State == TcpSocketConnectionState.Connected)
            {
                _client.Send(Encoding.UTF8.GetBytes(message));
            }
            readStatus.Text = "读取指令已发送";
        }


        #region 测试代码
        public class NuGetPackage
        {
            public string PackageId { get; set; }
            public TestVersion Version { get; set; }
        }

        public class TestVersion
        {
            public int Major { get; set; }
            public int Second { get; set; }
            public int Third { get; set; }
            public TestVersion()
            {

            }
            public TestVersion(int m, int s, int t)
            {
                Major = m;
                Second = s;
                Third = t;
            }
        }
        public class VersionConverter : JsonConverter<TestVersion>
        {
            public override void WriteJson(JsonWriter writer, TestVersion value, JsonSerializer serializer)
            {
                writer.WriteValue(value.ToString());
            }

            public override TestVersion ReadJson(JsonReader reader, Type objectType, TestVersion existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                string s = (string)reader.Value;

                return new TestVersion();
            }
        }
        #endregion

        private void FrmNetConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_client != null && _client.State == TcpSocketConnectionState.Connected)
            {
                _client.Close();
            }
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || int.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out int f)))
            {
                e.Handled = true;
            }
            else
            {
                string data = txtPort.Text;// +e.KeyChar.ToString();
                int start = txtPort.SelectionStart;
                if (e.KeyChar != '\b')
                {
                    data = data.Insert(start, e.KeyChar.ToString());
                }
                else if (e.KeyChar == 0x46)
                {
                    Console.WriteLine("shanchu");
                }
                else
                {
                    if (start != 0)
                    {
                        data = data.Remove(start - 1, 1);
                    }
                }

            }
        }

        private void textBox_TOPIC_Publish_Interval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || int.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out int f)))
            {
                e.Handled = true;
            }
            else
            {
                string data = textBox_TOPIC_Publish_Interval.Text;// +e.KeyChar.ToString();
                int start = textBox_TOPIC_Publish_Interval.SelectionStart;
                if (e.KeyChar != '\b')
                {
                    data = data.Insert(start, e.KeyChar.ToString());
                }
                else if (e.KeyChar == 0x46)
                {
                    Console.WriteLine("shanchu");
                }
                else
                {
                    if (start != 0)
                    {
                        data = data.Remove(start - 1, 1);
                    }
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_client.State == TcpSocketConnectionState.Connected)
            {
                _client.Close();
                btnClient.Enabled = true;
                btnClose.Enabled = false;
                btnSendMessage.Enabled = false;
                btnRead.Enabled = false;
            }
        }

        //保存配置文件
        private void btnSave_Click(object sender, EventArgs e)
        {


            PackageData md = new PackageData();
            md.action = "writedata";
            int index = 0;
            int.TryParse(comboBox_MQTT_Index.SelectedItem.ToString(), out index);
            md.clientidx = index;
            var mess = new HXSetMessage();
            //对数据进行组包
            var uuid = textBox_SYS_uuid.Text;
            if (string.IsNullOrWhiteSpace(uuid))
            {
                MessageBox.Show("设备的uuid不能为空");
                return;
            }
            mess.UUID = uuid;
            var domainIp = textBox_MQTT_DomainIP.Text;
            if (string.IsNullOrWhiteSpace(domainIp))
            {
                MessageBox.Show("borker地址不能为空");
                return;
            }
            if (domainIp.Length >= 30)
            {
                MessageBox.Show("DomainIp长度不能超过29个字符");
            }
            mess.DomainIp = domainIp;
            string strPort = textBox_MQTT_Port.Text;
            if (string.IsNullOrWhiteSpace(strPort))
            {
                MessageBox.Show("borker端口不能为空");
                return;
            }
            int port = 0;
            bool bRet = int.TryParse(strPort, out port);
            if (bRet)
            {
                if (port > 65535)
                {
                    MessageBox.Show("端口号不能大于65535");
                }
                mess.Port = port;
            }
            else
            {
                MessageBox.Show("请输入正确的端口号");
                return;
            }

            //clientId如果为空，可以设置为随机值
            string clientId = textBox_MQTT_ClientID.Text;
            if (string.IsNullOrWhiteSpace(clientId))
            {
                clientId = Guid.NewGuid().ToString("N");
            }
            if (clientId.Length >= 20)
            {
                MessageBox.Show("Client长度不能超过19个字符");
            }
            mess.ClientId = clientId;
            string User = textBox_MQTT_User.Text;
            if (string.IsNullOrWhiteSpace(User))
            {
                MessageBox.Show("Mqtt登录用户名不能为空");
                return;
            }
            if (User.Length >= 30)
            {
                MessageBox.Show("用户名长度不能超过29个字符");
            }

            mess.UserName = User;

            string password = textBox_MQTT_Password.Text;
            if (password.Length >= 10)
            {
                MessageBox.Show("密码长度不能超过9个字符");
            }
            mess.UserPwd = password;
            if (comboBox_MQTT_Ver.SelectedItem == null)
            {
                MessageBox.Show("请选择正确的MQTT版本号");
                return;
            }

            string MqttVersion = comboBox_MQTT_Ver.SelectedItem.ToString();
            mess.Version = MqttVersion;
            int KeepAlive = int.Parse(textBox_MQTT_KeepAliveTime.Text);
            mess.KeepAliveTime = KeepAlive;
            bool clean = checkBox_MQTT_CleanSession.Checked;
            mess.CleanSessionMark = Convert.ToInt32(clean);
            md.data = mess;
            PublishMessage pm = new PublishMessage();

            string publishTopic = textBox_TOPIC_Publish_TopicName.Text;
            if (string.IsNullOrWhiteSpace(publishTopic))
            {
                MessageBox.Show("发布主题不能为空");
                return;
            }
            string publishInterval = textBox_TOPIC_Publish_Interval.Text;
            string publishQos = comboBox_TOPIC_Publish_Qos.SelectedItem.ToString();
            pm.Topic = publishTopic;
            pm.Qos = int.Parse(publishQos);
            pm.Interval = int.Parse(publishInterval);
            md.data.PubTopic = pm;

            //SubMessage sub = new SubMessage();
            //string subTopic = textBox_TOPIC_Subscribe_TopicName.Text;
            //string subQos = comboBox_TOPIC_Subscribe_Qos.SelectedItem.ToString();
            //sub.Topic = subTopic;
            //sub.Qos = int.Parse(subQos);
            var sub = GetSubMessage();
            md.data.SubTopic = sub;
            WillMessage will = new WillMessage();
            string willTopic = textBox_TOPIC_Will_TopicName.Text;
            string willQos = comboBox_TOPIC_Will_Qos.SelectedItem.ToString();
            string willContent = textBox_TOPIC_Will_Content.Text;
            will.Topic = willTopic;
            will.Qos = int.Parse(willQos);
            will.Content = willContent;
            md.data.WillTopic = will;

            LanMessage lan = new LanMessage();
            string mask = txtMask.Text;
            string ip = txtIp.Text;
            string mac = txtMac.Text;
            string gateway = txtGw.Text;
            try
            {
                int[] arrayMask = Array.ConvertAll<string, int>(mask.Split('.'), s => int.Parse(s));
                lan.Mask = arrayMask;
                int[] arrayIp = Array.ConvertAll<string, int>(ip.Split('.'), s => int.Parse(s));
                lan.Ip = arrayIp;
                int[] arrayMac = Array.ConvertAll<string, int>(mac.Split('.'), s => int.Parse(s));
                lan.Mac = arrayMac;
                int[] arrayGw = Array.ConvertAll<string, int>(gateway.Split('.'), s => int.Parse(s));
                lan.GateWay = arrayGw;
            }
            catch (Exception)
            {
                MessageBox.Show("输入ip、MASK、MAC或者GW数据格式不正确，格式为点号分割的数据字符串");
            }

            md.data.Lan = lan;

            List<SavePackage> js;
            SavePackage sp = new SavePackage() { Index = md.clientidx, Data = md };
            //检查文件是否存在
            string str = Environment.CurrentDirectory;//当前的文件路径
            string file = Path.Combine(str, "config.json");
            if (File.Exists(file))
            {
                //修改文件  
                string readText = File.ReadAllText(file);
                js = JsonConvert.DeserializeObject<List<SavePackage>>(readText);
                var pd = js.Find(a => a.Index == index);
                if (pd != null)
                {
                    //替换文件
                    js.Remove(pd);
                }
                js.Add(sp);
            }
            else
            {
                js = new List<SavePackage> { sp };
            }
            try
            {
                string content = JsonConvert.SerializeObject(js);
                File.WriteAllText(file, content);
                MessageBox.Show("文件保存成功");
            }
            catch (Exception)
            {
                MessageBox.Show("保存文件失败");
            }

        }
        //读取配置文件
        private void btnReadConfig_Click(object sender, EventArgs e)
        {
            string str = Environment.CurrentDirectory;//当前的文件路径
            string file = Path.Combine(str, "config.json");
            if (!File.Exists(file))
            {
                MessageBox.Show("没有配置文件");
                return;
            }
            string readText = File.ReadAllText(file);
            try
            {
                int index = 0;
                int.TryParse(comboBox_MQTT_Index.SelectedItem.ToString(), out index);
                var js = JsonConvert.DeserializeObject<List<SavePackage>>(readText);
                var pd = js.Find(a => a.Index == index);
                if (pd == null)
                {
                    MessageBox.Show($"没有序号为{index}的配置文件");
                    return;
                }
                var mess = pd.Data;
                //设置数据
                if (mess.data.Lan != null)
                {
                    var lan = mess.data.Lan;
                    txtIp.Text = String.Join(".", lan.Ip);
                    txtMac.Text = String.Join(".", lan.Mac);
                    txtMask.Text = String.Join(".", lan.Mask);
                    txtGw.Text = string.Join(".", lan.GateWay);
                }
                if (mess.data.SubTopic != null)
                {
                    var sub = mess.data.SubTopic;
                    SetLvSub(sub);
                    //textBox_TOPIC_Subscribe_TopicName.Text = sub.Topic;
                    //comboBox_TOPIC_Subscribe_Qos.SelectedItem = sub.Qos;
                }
                if (mess.data.PubTopic != null)
                {
                    var pub = mess.data.PubTopic;
                    textBox_TOPIC_Publish_TopicName.Text = pub.Topic;
                    textBox_TOPIC_Publish_Interval.Text = pub.Interval.ToString();
                    comboBox_TOPIC_Publish_Qos.SelectedItem = pub.Qos;
                }
                if (mess.data.WillTopic != null)
                {
                    var will = mess.data.WillTopic;
                    textBox_TOPIC_Will_TopicName.Text = will.Topic;
                    textBox_TOPIC_Will_Content.Text = will.Content;
                    comboBox_TOPIC_Will_Qos.SelectedItem = will.Qos;
                }

                textBox_MQTT_ClientID.Text = mess.data.ClientId;
                textBox_MQTT_DomainIP.Text = mess.data.DomainIp;
                textBox_MQTT_User.Text = mess.data.UserName;
                textBox_MQTT_Port.Text = mess.data.Port.ToString();
                textBox_MQTT_KeepAliveTime.Text = mess.data.KeepAliveTime.ToString();
                comboBox_MQTT_Ver.SelectedItem = mess.data.Version ?? comboBox_MQTT_Ver.SelectedItem;
                checkBox_MQTT_CleanSession.Checked = Convert.ToBoolean(mess.data.CleanSessionMark);
                textBox_SYS_uuid.Text = mess.data.UUID;
                comboBox_MQTT_Index.SelectedItem = mess.clientidx.ToString() ?? comboBox_MQTT_Index.SelectedItem;
                MessageBox.Show("读取配置文件成功");
            }
            catch (Exception)
            {
                MessageBox.Show("配置文件不合法，请确认");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lvSub.Items.Count >= 5)
            {
                MessageBox.Show("最多只能添加5个主题");
                return;
            }
            string topic = textBox_TOPIC_Subscribe_TopicName.Text.Trim();
            var qos = comboBox_TOPIC_Subscribe_Qos.SelectedItem.ToString();
            if (string.IsNullOrEmpty(topic))
            {
                MessageBox.Show("订阅主题不能为空");
                return;
            }
            //检测是否有相同的主题
            foreach (ListViewItem item in lvSub.Items)
            {
                if (item.Text==topic)
                {
                    MessageBox.Show("不能添加相同的主题");
                    return;
                }
            }
            
            lvSub.BeginUpdate();
            ListViewItem lv = new ListViewItem();
            lv.Text = topic;
            lv.SubItems.Add(qos);
            //lv.SubItems.Add(Data[1]);
            //lv.SubItems.Add(Data[2]);
            //lv.SubItems.Add(Data[3]);
            //lv.SubItems.Add(Data[4]);
            //lv.SubItems.Add(Data[5]);

            lvSub.Items.Insert(0, lv);
            //lvSub.Items.Add(topic, qos, 0);
            lvSub.EndUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //lvSub.Items.
            //for (int i = lvSub.SelectedItems.Count - 1; i >= 0; i--)
            //{
            //    ListViewItem item = lvSub.SelectedItems[i];
            //    lvSub.Items.Remove(item);
            //}
            //List<ListViewItem> items = new List<ListViewItem>();
            //for (int i = 0; i < lvSub.Items.Count; i++)
            //{
            //    if (lvSub.Items[i].Checked)
            //    {
            //        items.Add(lvSub.Items[i]);
            //        //lvSub.Items.Remove(lvSub.Items[i]);
            //    }
            //}
            foreach (ListViewItem item in lvSub.Items)
            {
                if (item.Checked)
                {
                    item.Remove();
                }
            }
        }
        public List<SubMessage> GetSubMessage()
        {
            List<SubMessage> list = new List<SubMessage>();
            foreach (ListViewItem item in lvSub.Items)
            {
                string Top = item.Text;
                string q = item.SubItems[1].Text;
                list.Add(new SubMessage { Topic = item.Text, Qos = int.Parse(q) });
            }
            return list;
        }
        public void SetLvSub(List<SubMessage> list)
        {
            lvSub.BeginUpdate();
            lvSub.Items.Clear();
            foreach (var item in list)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.Topic;
                lv.SubItems.Add(item.Qos.ToString());
                lvSub.Items.Add(lv);
            }
            lvSub.EndUpdate();
        }
    }
}

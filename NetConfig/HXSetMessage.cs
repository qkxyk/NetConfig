﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NetConfig
{
    /// <summary>
    /// 分辨接收的数据包
    /// </summary>
    public class TestPack
    {
        public string action { get; set; }
    }
    #region 加密解密数据
    public class ReadBid
    {
        public string action { get; set; }//readbid
    }
    public class ReceiveBid
    {
        public string action { get; set; }//readbid_ack
        public EncryptData data { get; set; }
    }
    /// <summary>
    /// 两次加密，加密步骤如下：第二个参数为key，不足16位要补零
    /// 1、Encrypt( SERIAL, IMEI)======>keygen
    /// 2、 Encrypt(keygen , UUID)=======>License
    /// </summary>
    public class EncryptData
    {
        public string UUID { get; set; }
        public string IMEI { get; set; }
        public string SERIAL { get; set; }
    }
    public class SendBid
    {
        public string action { get; set; }//decrypt
        public string License { get; set; }
    }
    #endregion
    #region 解密后返回数据
    public class EncryptRet
    {
        public string action { get; set; }
        public string Result { get; set; }
    }
    #endregion
    public class PackageData
    {
        public string action { get; set; }
        public int clientidx { get; set; } = 0;//标识Mqtt的序号
        public HXSetMessage data { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
    //配置文件
    public class SavePackage
    {
        /// <summary>
        /// 保存Mqtt的序号
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 配置数据
        /// </summary>
        public PackageData Data { get; set; }
    }
    public class HXSetMessage
    {
        public string UUID { get; set; }
        public string ClientId { get; set; }// = "HexuNetGate1";
        public string DomainIp { get; set; }// = "www.hexucloud.com";
        //DomainIp
        public int Port { get; set; } //= 18831;
        public string UserName { get; set; }// = "Admin";
        public string UserPwd { get; set; } //= "password";
        public string Version { get; set; }// = "3.1.1";
        public int CleanSessionMark { get; set; } //= 0;
        public int KeepAliveTime { get; set; } //= 30;
        public PublishMessage PubTopic { get; set; }
        //public SubMessage SubTopic { get; set; }
        public List<SubMessage> SubTopic { get; set; }
        public WillMessage WillTopic { get; set; }
        public LanMessage Lan { get; set; }

    }

    public class PublishMessage
    {
        public string Topic { get; set; } //= "Hexu/UUID/DevicePub";
        public int Qos { get; set; }// = 0;
        public int Interval { get; set; } //= 180;
    }

    public class SubMessage
    {
        public string Topic { get; set; }// = "Hexu/UUID/DeviceSub";
        public int Qos { get; set; }// = 0;
    }

    public class WillMessage
    {
        public string Topic { get; set; }// = "Hexu/UUID/DevicePub";
        public int Qos { get; set; }// = 0;
        public string Content { get; set; } //= "Hello world!";
    }
    public class LanMessage
    {
        public int[] Ip { get; set; }// = { 192, 168, 10, 103 };
        public int[] Mask { get; set; }// = { 255, 255, 255, 0 };
        public int[] GateWay { get; set; }// = { 192, 168, 10, 254 };
        public int[] Mac { get; set; }// = { 72, 83, 82, 87, 85, 103 };

    }

    public class SendMessage
    {
        public string action { get; set; }
        public int clientidx { get; set; } = 0;//标识Mqtt的序号
    }
}

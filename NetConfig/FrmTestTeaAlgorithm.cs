using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;

namespace NetConfig
{
    public partial class FrmTestTeaAlgorithm : Form
    {
        public FrmTestTeaAlgorithm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //var cryptor = new TeaCryptor();
            string strHello = txtEncrypt.Text;//长度必须是8的倍数，如果不够需要补齐
            int len = strHello.Length;
            byte[] byContent;
            //var h = StringToHexByte(strHello, Encoding.UTF8);
            var h = Encoding.UTF8.GetBytes(strHello);
            //内容长度必须是8的倍数，不够需要补齐，填充0
            if (len % 8 == 0)
            {
                byContent = new byte[len];
            }
            else
            {
                byContent = new byte[(len / 8) * 8 + 8];
            }
            Array.Copy(h, byContent, len);
            string strKey = "0123456789ABCDEF";
            byte[] byKey = Encoding.UTF8.GetBytes(strKey);
            //byte数组转换位uint数组
            var uintContent = ConvertBytesToUint(byContent);

            var uintKey = ConvertBytesToUint(byKey);
            TeaAlgorithm.Code(uintContent, uintKey);
            var tt = ConvertUintsToBytes(uintContent);
            MessageBox.Show(byteToHexStr(tt));
            var uin = ConvertBytesToUint(tt);
            TeaAlgorithm.Decode(uintContent, uintKey);
            var ttt = ConvertUintsToBytes(uintContent);
            txtDecrypt.Text = Encoding.UTF8.GetString(ttt);

            //封装的数据测试
            NewTea nt = new NewTea();
            var bret = nt.EncrypString(strHello, strKey, Encoding.UTF8);
            string strRet = nt.byteToHexStr(bret);
            MessageBox.Show(strRet);
            //解密
            var byteEn = nt.DecryptByte(bret, byKey, true);
            string strEn = Encoding.UTF8.GetString(byteEn);
            MessageBox.Show(strEn);

            //通过字符串解密
            var byStringByte = nt.DecryptString(strRet, strKey, Encoding.UTF8, true);
            string strStrEn = Encoding.UTF8.GetString(byStringByte);
            MessageBox.Show(strStrEn);

            //var dd = byteToHexStr(d);
            //MessageBox.Show(dd);
        }
        /// <summary>
        /// byte数组转换位uint数组,每4个字节转换位一个uint,by长度必须是4的倍数，结合上下文必须是8的倍数
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        private uint[] ConvertBytesToUint(byte[] by)
        {
            uint[] ret = new uint[by.Length / 4];
            for (int i = 0; i < by.Length; i += 4)
            {
                uint temp = (uint)(by[i] | by[i + 1] << 8 | by[i + 2] << 16 | by[i + 3] << 24);
                ret[i / 4] = temp;
            }
            return ret;
        }
        private byte[] ConvertUintsToBytes(uint[] u)
        {
            byte[] by = new byte[u.Length * 4];
            for (int i = 0; i < u.Length; i++)
            {
                by[i * 4] = (byte)u[i];
                by[i * 4 + 1] = (byte)(u[i] >> 8);
                by[i * 4 + 2] = (byte)(u[i] >> 16);
                by[i * 4 + 3] = (byte)(u[i] >> 24);
            }
            return by;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string txt = txtDecrypt.Text.Trim();
            byte[] by = Encoding.UTF8.GetBytes(txt);
            string key = "123";
            byte[] byKey = Encoding.UTF8.GetBytes(key);
            var ret = TeaAlgorithm.Decrypt(by, byKey);
            string strRet = Encoding.UTF8.GetString(ret);
            MessageBox.Show(strRet);
        }

        /** 
            * byte数组中取int数值，本方法适用于(低位在前，高位在后)的顺序，和和intToBytes（）配套使用
            *  
            * @param src 
            *            byte数组 
            * @param offset 
            *            从数组的第offset位开始 
            * @return int数值 
            */
        public static int bytesToInt(byte[] src, int offset)
        {
            int value;
            value = (int)((src[offset] & 0xFF)
                    | ((src[offset + 1] & 0xFF) << 8)
                    | ((src[offset + 2] & 0xFF) << 16)
                    | ((src[offset + 3] & 0xFF) << 24));
            return value;
        }

        /** 
        * byte数组中取int数值，本方法适用于(低位在后，高位在前)的顺序。和intToBytes2（）配套使用
        */
        public static int bytesToInt2(byte[] src, int offset)
        {
            int value;
            value = (int)(((src[offset] & 0xFF) << 24)
                    | ((src[offset + 1] & 0xFF) << 16)
                    | ((src[offset + 2] & 0xFF) << 8)
                    | (src[offset + 3] & 0xFF));
            return value;
        }
        /**
    * 将int数值转换为占四个字节的byte数组，本方法适用于(低位在前，高位在后)的顺序。 和bytesToInt（）配套使用
    * @param value
    *            要转换的int值
    * @return byte数组
    */
        public static byte[] intToBytes(int value)
        {
            byte[] src = new byte[4];
            src[3] = (byte)((value >> 24) & 0xFF);
            src[2] = (byte)((value >> 16) & 0xFF);
            src[1] = (byte)((value >> 8) & 0xFF);
            src[0] = (byte)(value & 0xFF);
            return src;
        }
        /**
        * 将int数值转换为占四个字节的byte数组，本方法适用于(高位在前，低位在后)的顺序。  和bytesToInt2（）配套使用
        */
        public static byte[] intToBytes2(int value)
        {
            byte[] src = new byte[4];
            src[0] = (byte)((value >> 24) & 0xFF);
            src[1] = (byte)((value >> 16) & 0xFF);
            src[2] = (byte)((value >> 8) & 0xFF);
            src[3] = (byte)(value & 0xFF);
            return src;
        }

        // <summary>
        /// 字节数组转16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }
        /// <summary>
        /// 字符串转16进制字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }
        private string StringToHexString(string s, Encoding encode)
        {
            byte[] b = encode.GetBytes(s);//按照指定编码将string编程字节数组
            string result = string.Empty;
            for (int i = 0; i < b.Length; i++)//逐字节变为16进制字符，以%隔开
            {
                result += "%" + Convert.ToString(b[i], 16);
            }
            return result;
        }
        private byte[] StringToHexByte(string s, Encoding encode)
        {
            var d = encode.GetBytes(s);
            return d;
        }

        private void btnOverFlow_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.MaxValue;
                checked
                {
                    a++;
                    MessageBox.Show("程序不会执行");
                }
            }
            catch (OverflowException ex)
            {

                MessageBox.Show($"溢出了，{ex.Message}->{ex.StackTrace}->{ex.InnerException}");
            }
        }

        private void btnUnOverFlow_Click(object sender, EventArgs e)
        {
            try
            {
                uint a = uint.MaxValue;
                unchecked
                {
                    a++;
                    MessageBox.Show("程序执行到这里了");
                }

            }
            catch (OverflowException ex)
            {

                MessageBox.Show($"溢出了，{ex.Message}->{ex.StackTrace}->{ex.InnerException}");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int round = 32;
            uint Delta = 0x9e3779b9;
            uint sum = unchecked((uint)(round * Delta));
            uint a = (uint)round;
            byte by = 0x90;
            int r = by;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int len = 0;
            var b = int.TryParse(txtNum.Text, out len);
            len = GetFixedDataLength(len);
            if (b)
            {
                MessageBox.Show(len.ToString());
            }
        }
        public virtual int GetFixedDataLength(int length)
        {
            if (length % 8 == 4)
            {
                return length + 4;
            }
            else
            {
                int len = ((length + 4) / 8 + 1) * 8;
                //return ((length + 4) / 8 + 1) * 8;
                return len;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int num;
            var ret = int.TryParse(txtNum.Text, out num);
            num = num << 4;
            txtNum.Text = num.ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int num;
            var ret = int.TryParse(txtNum.Text, out num);
            num = num >> 1;
            txtNum.Text = num.ToString();
        }

        private void btnHxEn_Click(object sender, EventArgs e)
        {
            NewTea tea = new NewTea();
            string strContent = txtContent.Text;//16进制字符串
            byte[] byContent = tea.strToToHexByte(strContent);
            string strKey = txtKey.Text;
            var ByKey = GetKeyBytes(strKey);
            var byFirstResult = tea.EncryptByte(byContent, ByKey, true);
            //string strFirst = Encoding.UTF8.GetString(byFirstResult);
            string strFirst = tea.byteToHexStr(byFirstResult);
            txtFirst.Text = strFirst;
            string strSecondKey = txtSecondKey.Text;
            byte[] bySecondKey = GetKeyBytes(strSecondKey);
            var bySecondResult = tea.EncryptByte(byFirstResult, bySecondKey, true);
            string strSecondResult = tea.byteToHexStr(bySecondResult);
            txtSecond.Text = strSecondResult;
        }
        /// <summary>
        /// 返回16位长度的key
        /// </summary>
        /// <param name="strKey">key字符串</param>
        /// <returns></returns>
        byte[] GetKeyBytes(string strKey)
        {
            byte[] byKey = new byte[16];
            int length = strKey.Length;
            byte[] by = Encoding.UTF8.GetBytes(strKey);
            if (length < 15)
            {
                return null;
            }
            else if (length == 15)
            {
                //按位异或
                int cal = 0;
                for (int i = 0; i < 15; i++)
                {
                    cal ^= by[i];
                }
                Array.Copy(by, 0, byKey, 0, 15);
                byKey[15] = (byte)cal;
            }
            else
            {
                Array.Copy(by, 0, byKey, 0, 16);
            }
            return byKey;
        }
        private void btnOr_Click(object sender, EventArgs e)
        {
            string strT = txtKey.Text;
            byte[] by = Encoding.UTF8.GetBytes(strT);
            int cal = 0;
            for (int i = 0; i < 15; i++)
            {
                cal ^= by[i];
            }
            byte[] byKey = new byte[16];
            Array.Copy(by, 0, byKey, 0, 15);
            byKey[15] = (byte)cal;
            string str = Encoding.UTF8.GetString(byKey);
            MessageBox.Show(str);
        }
    }
}

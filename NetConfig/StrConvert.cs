﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetConfig
{
    public sealed class StrConvert
    {
        public static byte HexToByte(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return (byte)(ch - '0');
            else if (ch >= 'a' && ch <= 'f')
                return (byte)(ch - 'a' + 10);
            else if (ch >= 'A' && ch <= 'F')
                return (byte)(ch - 'A' + 10);
            return 0;
        }

        public static byte HexToByte(char hch, char lch)
        {
            return (byte)(HexToByte(hch) << 4 | HexToByte(lch));
        }

        public static byte[] HexToByteArray(string hexString)
        {
            if (hexString == null) return null;

            int byteLen = hexString.Length / 2;
            int modLen = hexString.Length % 2;
            byte[] retval = new byte[byteLen + modLen];
            char[] srcChars = hexString.ToCharArray();
            if (modLen > 0)
                retval[0] = HexToByte(srcChars[0]);
            for (int i = 0; i < byteLen; i++)
                retval[modLen + i] = HexToByte(srcChars[modLen + i * 2], srcChars[modLen + i * 2 + 1]);

            return retval;
        }

        public static string ByteArrayToHex(byte[] byteArray)
        {
            if (byteArray == null) return null;

            StringBuilder sb = new StringBuilder(byteArray.Length * 2);
            const string HexLit = "0123456789abcdef";

            foreach (byte b in byteArray)
            {
                sb.Append(HexLit[(int)(b >> 4)]);
                sb.Append(HexLit[(int)(b & 0xF)]);
            }

            return sb.ToString();
        }

        public static uint[] StrToLongs(byte[] s, int startIdx, int length)
        {
            if (s == null) return null;
            if (length <= 0) length = s.Length;

            int fs = length / 4;
            int ls = length % 4;
            uint[] l = new uint[fs + ((ls > 0) ? 1 : 0)];
            int idx = startIdx;
            for (var i = 0; i < fs; i++)
            {
                l[i] = (uint)s[idx++] |
                      ((uint)s[idx++] << 8) |
                      ((uint)s[idx++] << 16) |
                      ((uint)s[idx++] << 24);
            }
            if (ls > 0)
            {
                // note running off the end of the string generates nulls since 
                // bitwise operators treat NaN as 0
                byte[] v = new byte[4] { 0, 0, 0, 0 };
                for (var i = 0; i < ls; i++)
                {
                    v[i] = s[fs * 4 + i];
                }
                l[fs] = BitConverter.ToUInt32(v, 0);
            }

            return l;
        }

        public static byte[] LongsToStr(uint[] l)
        {
            if (l == null || l.Length <= 0) return null;

            byte[] a = new byte[l.Length * 4];

            int idx = 0;
            for (var i = 0; i < l.Length; i++)
            {
                a[idx++] = (byte)(l[i] & 0xFF);
                a[idx++] = (byte)(l[i] >> 8 & 0xFF);
                a[idx++] = (byte)(l[i] >> 16 & 0xFF);
                a[idx++] = (byte)(l[i] >> 24 & 0xFF);
            }

            return a;
        }

    }
}

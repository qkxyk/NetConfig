using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetConfig
{
    public static class TeaAlgorithm
    {
        public static uint[] FormatKey(byte[] key)
        {
            if (key.Length == 0)
            {
                throw new ArgumentException("Key must be between 1 and 16 character in length");
            }
            byte[] refineKey = new byte[16];
            if (key.Length < 16)
            {
                Array.Copy(key, 0, refineKey, 0, key.Length);
                for (int k = key.Length; k < 16; k++)
                {
                    refineKey[k] = 0x20;
                }
            }
            else
            {
                Array.Copy(key, 0, refineKey, 0, 16);
            }
            uint[] formattedKey = new uint[4];
            int j = 0;
            for (int i = 0; i < refineKey.Length; i += 4)
            {
                formattedKey[j++] = ConvertByteArrayToUInt(refineKey, i);
            }
            return formattedKey;
        }
        private static byte[] ConvertUIntToByteArray(uint v)
        {
            byte[] res = new byte[4];
            res[0] = (byte)(v & 0xFF);
            res[1] = (byte)((v >> 8) & 0xFF);
            res[2] = (byte)((v >> 16) & 0xFF);
            res[3] = (byte)((v >> 24) & 0xFF);
            return res;
        }
        /*  private static byte[] ConvertUIntToByteArray(uint v)
          {
              byte[] result = new byte[4];
              result[0] = (byte)((v >> 24) & 0xFF);
              result[1] = (byte)((v >> 16) & 0xFF);
              result[2] = (byte)((v >> 8) & 0xFF);
              result[3] = (byte)((v >> 0) & 0xFF);
              return result;
          }*/
        private static uint ConvertByteArrayToUInt(byte[] v, int offset)
        {
            if (offset + 4 > v.Length)
            {
                return 0;
            }
            uint output;
            output = (uint)v[offset];
            output |= (uint)(v[offset + 1] << 8);
            output |= (uint)(v[offset + 2] << 16);
            output |= (uint)(v[offset + 3] << 24);
            return output;
        }

        /*   private static uint ConvertByteArrayToUInt(byte[] v, int offset)
           {
               if (offset + 4 > v.Length)
               {
                   return 0;
               }
               uint output;
               output = (uint)(v[offset] << 24);
               output |= (uint)(v[offset + 1] << 16);
               output |= (uint)(v[offset + 2] << 8);
               output |= (uint)(v[offset + 3] << 0);
               return output;
           }*/

        /*  static void Code(uint[] v, uint[] k)
          {
              uint y = v[0];
              uint z = v[1];
              uint sum = 0;
              uint delta = 0x9e3779b9;
              //uint n = 16;
              uint n = 32;
              while (n-- > 0)
              {
                  sum += delta;
                  y += ((z << 4) + k[0]) ^ (z + sum) ^ ((z >> 5) + k[1]);
                  z += ((y << 4) + k[2]) ^ (y + sum) ^ ((y >> 5) + k[3]);
              }
              v[0] = y;
              v[1] = z;
          }*/
       public static void Code(uint[] v, uint[] k)
        {
            if (v == null || k == null) return;
            uint v0 = v[0], v1 = v[1];
            uint k0 = k[0], k1 = k[1], k2 = k[2], k3 = k[3];
            uint sum = 0;
            uint delta = 0x9e3779b9;
            for (int i = 0; i < 32; i++)
            {
                sum += delta;
                v0 += ((v1 << 4) + k0) ^ (v1 + sum) ^ ((v1 >> 5) + k1);
                v1 += ((v0 << 4) + k2) ^ (v0 + sum) ^ ((v0 >> 5) + k3);
            }
            v[0] = v0; v[1] = v1;
            return;
        }

       public static void Decode(uint[] v, uint[] k)
        {
            uint n = 32;
            uint sum= 0xC6EF3720;
            uint y = v[0];
            uint z = v[1];
            uint delta = 0x9e3779b9;

            //sum = delta << 4;
            while (n-- > 0)
            {
                z -= ((y << 4) + k[2]) ^ (y + sum) ^ ((y >> 5) + k[3]);
                y -= ((z << 4) + k[0]) ^ (z + sum) ^ ((z >> 5) + k[1]);
                sum -= delta;
            }
            v[0] = y;
            v[1] = z;
        }
        public static byte[] Encrypt(byte[] data, byte[] key)
        {

            byte[] dataBytes;
            if (data.Length % 2 == 0)
            {
                dataBytes = data;
            }
            else
            {
                dataBytes = new byte[data.Length + 1];
                Array.Copy(data, 0, dataBytes, 0, data.Length);
                dataBytes[data.Length] = 0x0;
            }
            byte[] result = new byte[dataBytes.Length * 4];
            uint[] formattedKey = FormatKey(key);
            uint[] tempData = new uint[2];
            for (int i = 0; i < dataBytes.Length; i += 2)
            {
                tempData[0] = dataBytes[i];
                tempData[1] = dataBytes[i + 1];
                Code(tempData, formattedKey);
                Array.Copy(ConvertUIntToByteArray(tempData[0]), 0, result, i * 4, 4);
                Array.Copy(ConvertUIntToByteArray(tempData[1]), 0, result, i * 4 + 4, 4);
            }
            return result;
        }
        public static byte[] Decrypt(byte[] data, byte[] key)
        {
            uint[] formattedKey = FormatKey(key);
            int x = 0;
            uint[] tempData = new uint[2];
            byte[] dataBytes = new byte[data.Length / 8 * 2];
            for (int i = 0; i < data.Length; i += 8)
            {
                tempData[0] = ConvertByteArrayToUInt(data, i);
                tempData[2] = ConvertByteArrayToUInt(data, i + 4);
                Decode(tempData, formattedKey);
                dataBytes[x++] = (byte)tempData[0];
                dataBytes[x++] = (byte)tempData[1];
            }
            if (dataBytes[dataBytes.Length - 1] == 0x0)
            {
                byte[] res = new byte[dataBytes.Length - 1];
                Array.Copy(dataBytes, 0, res, 0, dataBytes.Length - 1);
            }
            return dataBytes;
        }
    }
}

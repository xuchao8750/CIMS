using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    public class SerializeObject
    {
        public void eotl(string fileName, object obj)
        {
            //创建文件流
            FileStream fs = new FileStream(fileName, FileMode.Create);
            //创建二进制格式化器
            BinaryFormatter formatter = new BinaryFormatter();
            //调用系列化方法
            formatter.Serialize(fs, obj);
            //关闭文件流
            fs.Close();
        }

        public Object Dsofl(string fileName)
        {
            //创建文件流
            FileStream fs = new FileStream(fileName, FileMode.Open);
            //创建二进制格式化器
            BinaryFormatter formatter = new BinaryFormatter();
            //调用反序列化方法
            object obj = formatter.Deserialize(fs);
            //关闭文件流
            fs.Close();
            return obj;
        }

        public string Sots(object obj)
        {
            IFormatter formatter = new BinaryFormatter();
            string result = string.Empty;
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                byte[] byt = new byte[stream.Length];
                byt = stream.ToArray();
                result = Convert.ToBase64String(byt);
                stream.Flush();
            }
            return result;
        }

        public Object Sofs(string str)
        {
            IFormatter formatter = new BinaryFormatter();
            byte[] byt = Convert.FromBase64String(str);
            object obj = null;
            using (Stream stream = new MemoryStream(byt, 0, byt.Length))
            {
                obj = formatter.Deserialize(stream);
            }
            return obj;
        }
    }
}

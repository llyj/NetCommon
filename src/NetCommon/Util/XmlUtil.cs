using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NetCommon.Util
{
    public static class XmlUtil
    {
        /// <summary>
        /// 读取xml文件，将xml反序列化成对象
        /// </summary>
        /// <typeparam name="T">XML序列化类根结点类型</typeparam>
        /// <param name="filePath">XML路径</param>
        /// <returns>Root Nodes</returns>
        public static T ReadXmlDeserializeToEntity<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = XmlReader.Create(fs))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        /// <summary>
        /// 将实体对象序列化成xml字符串并存储
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="value"></param>
        public static void SerializeEntitySaveToXml<T>(string filePath, T value)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                using (var writer = XmlWriter.Create(fs))
                {
                    XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                    serializer.Serialize(writer, value, namespaces);
                }
            }
        }

        /// <summary>
        /// 实体对象转xml字符串（序列化）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializerEntityToXmlStr<T>(T obj)
        {
            using (StringWriter sw = new StringWriter())
            {
                Type t = obj.GetType();
                XmlSerializer serializer = new XmlSerializer(t);
                serializer.Serialize(sw, obj);
                sw.Close();
                return sw.ToString();
            }
        }

        /// <summary>
        /// xml字符串转成XML对象再转成文件流
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static byte[] GetXmlBuffer(string xml)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            MemoryStream ms = new MemoryStream();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = new UTF8Encoding(false);
            XmlWriter writer = XmlWriter.Create(ms, settings);
            xdoc.Save(writer);
            int length = (int)ms.Length;
            var buffer = new byte[ms.Length];
            ms.Seek(0, SeekOrigin.Begin);
            ms.Read(buffer, 0, length);
            writer.Close();
            ms.Close();
            return buffer;
        }

        /// <summary>
        /// 将对象序列化为XML字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToXmlStr(object obj)
        {
            return ToXmlStr(obj, Encoding.UTF8);
        }

        /// <summary>
        /// 将对象序列化为XML字符串
        /// </summary>
        public static string ToXmlStr(object obj, Encoding encoding)
        {
            XmlSerializer xml = new XmlSerializer(obj.GetType());
            MemoryStream ms = new MemoryStream();
            var xmlSerializerNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            xml.Serialize(ms, obj, xmlSerializerNamespaces);
            return encoding.GetString(ms.ToArray());
        }

        /// <summary>
        /// 从XML代码反序列化为对象
        /// </summary>
        public static T ToObject<T>(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml))
                return default(T);

            using (StringReader reader = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                var obj = serializer.Deserialize(reader);
                if (obj is T) return (T)obj;
                return default(T);
            }
        }

        /// <summary>
        /// 反序列化xml压缩包为对象实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static T DeCompressXmlToEntity<T>(string filePath) where T : class, new()
        {
            using (var existFile = File.Open(filePath, FileMode.OpenOrCreate))
            using (var zipStream = new GZipStream(existFile, CompressionMode.Decompress))
            using (var streamReader = new StreamReader(zipStream))
            {
                var xmlStr = streamReader.ReadToEnd();
                return ToObject<T>(xmlStr) ?? new T();
            }
        }

        /// <summary>
        /// 序列化对象实例为xml压缩包
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="filePath"></param>
        public static void CompressToXmlZip<T>(this T t, string filePath) where T : class, new()
        {
            using (var newFileStream = File.Create(filePath))
            using (var zipStream = new GZipStream(newFileStream, CompressionMode.Compress))
            using (var streamWriter = new StreamWriter(zipStream))
            {
                var xmlStr = ToXmlStr(t);
                streamWriter.Write(xmlStr);
            }
        }
    }
}
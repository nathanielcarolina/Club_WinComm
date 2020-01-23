using System;
using System.IO;
using System.Xml.Serialization;

namespace Club_WinComm
{
    internal class MyStorage
    {
        public static void WriteXml<T>(T data, string file)
        {
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				FileStream stream;
				stream = new FileStream(file, FileMode.Create);
				serializer.Serialize(stream, data);
				stream.Close();
			}
			catch (Exception)
			{

				throw;
			}
        }

		public static T ReadXml<T>(string file)
		{
			try
			{
				using (StreamReader sr = new StreamReader(file))
				{
					XmlSerializer xmlSer = new XmlSerializer(typeof(T));
					return (T)xmlSer.Deserialize(sr);
				}
			}
			catch //(Exception)
			{
				return default(T);
			}
		}
	}
}
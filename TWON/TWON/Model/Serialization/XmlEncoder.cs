using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TWON
{
	public static class XmlEncoder
	{
		public static string XmlSerializeToString(this object obj)
		{
			var serializer = new XmlSerializer(obj.GetType());
			var sb = new StringBuilder();

			using (var writer = new StringWriter(sb))
			{
				serializer.Serialize(writer, obj);
			}

			return sb.ToString();
		}

		public static T XmlDeserializeFromString<T>(this string objectData)
		{
			return (T)XmlDeserializeFromString(objectData, typeof(T));
		}

		public static object XmlDeserializeFromString(this string objectData, Type type)
		{
			var serializer = new XmlSerializer(type);
			object result;

			using (var reader = new StringReader(objectData))
			{
				result = serializer.Deserialize(reader);
			}

			return result;
		}
	}
}

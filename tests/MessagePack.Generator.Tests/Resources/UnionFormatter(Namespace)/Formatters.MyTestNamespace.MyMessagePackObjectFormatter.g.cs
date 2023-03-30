﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

namespace Formatters.MyTestNamespace
{
	using MsgPack = global::MessagePack;

	internal sealed class MyMessagePackObjectFormatter : MsgPack::Formatters.IMessagePackFormatter<global::MyTestNamespace.MyMessagePackObject>
	{

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::MyTestNamespace.MyMessagePackObject value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			writer.WriteArrayHeader(1);
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::MyTestNamespace.IMyType>(formatterResolver).Serialize(ref writer, value.UnionValue, options);
		}

		public global::MyTestNamespace.MyMessagePackObject Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			options.Security.DepthStep(ref reader);
			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			var length = reader.ReadArrayHeader();
			var ____result = new global::MyTestNamespace.MyMessagePackObject();

			for (int i = 0; i < length; i++)
			{
				switch (i)
				{
					case 0:
						____result.UnionValue = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::MyTestNamespace.IMyType>(formatterResolver).Deserialize(ref reader, options);
						break;
					default:
						reader.Skip();
						break;
				}
			}

			reader.Depth--;
			return ____result;
		}
	}
}

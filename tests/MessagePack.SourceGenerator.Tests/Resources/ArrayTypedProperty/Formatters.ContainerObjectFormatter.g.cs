﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

#pragma warning disable CS8669 // We may leak nullable annotations into generated code.

namespace Formatters
{
	using MsgPack = global::MessagePack;

	internal sealed class ContainerObjectFormatter : MsgPack::Formatters.IMessagePackFormatter<global::ContainerObject>
	{

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::ContainerObject value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			writer.WriteArrayHeader(1);
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::SubObject[]>(formatterResolver).Serialize(ref writer, value.ArrayOfCustomObjects, options);
		}

		public global::ContainerObject Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			options.Security.DepthStep(ref reader);
			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			var length = reader.ReadArrayHeader();
			var ____result = new global::ContainerObject();

			for (int i = 0; i < length; i++)
			{
				switch (i)
				{
					case 0:
						____result.ArrayOfCustomObjects = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::SubObject[]>(formatterResolver).Deserialize(ref reader, options);
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

﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

namespace Formatters
{
	using MsgPack = global::MessagePack;

	internal sealed class FooFormatter : MsgPack::Formatters.IMessagePackFormatter<global::Foo>
	{

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::Foo value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			writer.WriteArrayHeader(0);
		}

		public global::Foo Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			reader.Skip();
			return new global::Foo();
		}
	}
}

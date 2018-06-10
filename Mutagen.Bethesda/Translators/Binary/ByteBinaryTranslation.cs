﻿using Noggog;
using System;
using System.IO;

namespace Mutagen.Bethesda.Binary
{
    public class ByteBinaryTranslation : PrimitiveBinaryTranslation<byte>
    {
        public readonly static ByteBinaryTranslation Instance = new ByteBinaryTranslation();
        public override int? ExpectedLength => 1;

        protected override byte ParseValue(MutagenFrame reader)
        {
            return reader.Reader.ReadUInt8();
        }

        protected override void WriteValue(MutagenWriter writer, byte item)
        {
            writer.Write(item);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Loqui;
using Loqui.Generation;
using Noggog;

namespace Mutagen.Bethesda.Generation
{
    public class ColorBinaryTranslationGeneration : PrimitiveBinaryTranslationGeneration<Color>
    {
        public ColorBinaryTranslationGeneration()
        {
            this.AdditionalWriteParams.Add(AdditionalParam);
            this.AdditionalCopyInParams.Add(AdditionalParam);
            this.AdditionalCopyInRetParams.Add(AdditionalParam);
        }

        private static TryGet<string> AdditionalParam(
           ObjectGeneration objGen,
           TypeGeneration typeGen,
           Accessor accessor,
           Accessor itemAccessor,
           Accessor errorMaskAccessor,
           Accessor translationMaskAccessor)
        {
            return TryGet<string>.Create(successful: ExtraByte(typeGen), val: "extraByte: true");
        }

        protected static bool ExtraByte(TypeGeneration typeGen)
        {
            if (!typeGen.CustomData.TryGetValue("ColorExtraByte", out var obj)) return false;
            return (bool)obj;
        }
    }
}

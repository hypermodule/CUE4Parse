﻿using CUE4Parse.UE4.Assets.Readers;

namespace CUE4Parse.UE4.Assets.Objects
{
    public class ArrayProperty : FPropertyTagType<UScriptArray>
    {
        public ArrayProperty(FAssetArchive Ar, FPropertyTagData? tagData, ReadType type)
        {
            Value = type switch
            {
                ReadType.ZERO => new UScriptArray(tagData?.InnerType ?? "ZeroUnknown"),
                _ => new UScriptArray(Ar, tagData)
            };
        }
    }
}
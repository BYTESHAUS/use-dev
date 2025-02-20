﻿using AbcRefl.Metadata;

namespace AbcStuff.Test.Metadata;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Class | AttributeTargets.Property,
    AllowMultiple = false)]
public class NotForTestAttribute(string reason = "") : ExtendedAttribute<NotForTestAttribute>
{
    public string Reason { get; init; } = reason;
}

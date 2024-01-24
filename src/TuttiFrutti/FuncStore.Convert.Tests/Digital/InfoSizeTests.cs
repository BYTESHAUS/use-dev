﻿using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Conversion.RatioScale;
using FuncStore.Conversion.Tests.Setup.Metadata;
using FuncStore.Conversion.Tests.Setup.Steps;
using Meas.Data.Digital;
using Meas.Units.Digital;

namespace FuncStore.Conversion.Tests.Digital;

[TestBy<Multiplication<In>>]
public class InfoSizeTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<Size>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}
using FuncStore.Conversion.RatioScale;
using MeasData.Calibration.Metric;
using Metric = MeasUnits.Prefixes.Metric;

namespace FuncStore.Conversion.Tests.RatioScale;

[TestBy<Factoring<Metric.In>>()]
[TestBy<Exponentiation<Metric.Exponent.In>>()]
public class Accu_MetricTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<MathIntegral>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) {
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
    }

    // ToDo: mismatch tests

    // ToDo: overflow tests

}
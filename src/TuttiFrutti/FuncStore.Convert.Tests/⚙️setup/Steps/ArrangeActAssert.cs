﻿using AbcExt.Glyphs;

namespace FuncStore.Convers.Tests.Setup.Steps;
public abstract class ArrangeActAssert<TStore, TUnit> : ArrangeAct<TStore, TUnit>
     where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    protected static readonly string NotAvailable = $"{'\u207F'}{'\u002F'}{'\u2090'}!";

    public virtual void Match<N>(N value, TUnit unit, N expected, TUnit expectedUnit,
        string title, string cat, double? delta) where N : INumber<N> {

        var func = _funcware.For<N>(unit, expectedUnit);
        if (func is null)
            Assert.Ignore($"{NotAvailable} {unit}->{expectedUnit} ({_funcware})");

        N result = N.Zero;
        try {
            result = func(value);
        } catch (Exception exception) {
            // ToKnow.: math throws System.Exception - no way to sort
            Assert.Fail($"{Nature.HighVoltage} {exception.Message}");
        }

        var tolerance = delta ?? DefaultDelta;
        var diff = result > expected ? result - expected : expected - result;

        // ToDefine: whether Within works for INumber (if not - make workaround)
        Assert.That(result, Is.EqualTo(expected).Within(tolerance), $"{MarkDiff(tolerance, diff)}");
        Assert.Pass(ScaleAssess(diff, tolerance));
    }

    public virtual void Mismatch<N>() {
        // ToDesign: on demand when mismatch logic required 
    }

    public virtual void MissFunc<N>(TUnit from, TUnit to) where N : INumber<N> {
        var func = _funcware.For<N>(from, to);

        Assert.That(func, Is.Null, $"{from}->{to} must be NOT available BUT found");
    }

    public virtual void ResultException<T>() where T : Exception {
        // ToDo: Assert.Throws<T>() { }
    }

    private static string ScaleAssess<N1, N2>(N1 diff, N2 range) where N1 : INumber<N1> where N2 : INumber<N2> {
        const int scaleLen = 12;
        var absDiff = N1.Zero > diff ? -diff : diff;

        var precision = diff == N1.Zero ? 1 :
            1 - Math.Round(double.CreateChecked(absDiff) / double.CreateChecked(range), 2);
        var filledLen = Convert.ToInt32(precision * scaleLen);
        var extraInfo = 1 == precision ? string.Empty : $" ({absDiff} within {range})";
        return $"Precision: {precision * 100}%{extraInfo}\n{new string(Stars.Filled, filledLen)}{new string(Stars.Hollow, scaleLen - filledLen)}";
    }

    private static char MarkDiff<N1, N2>(N1 delta, N2 diff) where N1 : INumber<N1> where N2 : INumber<N2> {
        if (N1.Zero == delta)
            return Greek.Capital.O_middleTilde;

        var tolerance = double.CreateChecked(N1.Abs(delta));
        var offset = double.CreateChecked(N2.Abs(diff)) - tolerance;

        if (0 > offset)
            return Marks.Question;

        if (offset <= 2 * tolerance)
            return Algebra.PlusMinus;

        return 10 > offset / tolerance ? Marks.Alert : Marks.Radioactive;
    }
}
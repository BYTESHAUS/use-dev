﻿using ISie.Number.Is;
using System.Numerics;
namespace ISie_Eval.BuiltinType.Number;
public class Demo_Integral_Is : ArrangeWithNumbers
{

#if DEBUG
    [Test]
#endif
    public void Integral() {
        var bob = 0;
        True = bob.Is.NaturalOr0;
        False = bob.Not.NaturalOr0;

        False = (--bob).Is.NaturalOr0;
        bob = 9;
        True = bob.Is.Odd;
        True = bob--.Not.Even;

        True = bob.Is.NaturalOr0.PowOf2;
        False = (++bob).Is.NaturalOr0.PowOf2;
    }


#if DEBUG
    [Test]
#endif
    public void NaturalNumbers() {

        False = bitsInByte.Is.Odd;
        True = bitsInByte.Is.Even;
        True = bitsInByte.Is.PowOf2;

        False = (1 + bitsInByte).Is.NaturalOr0.PowOf2;

        INumber<double> dbl = 23.2;

        _ = int100.Is.NaturalOr0;
        False = int100.Is.NaturalOr0.PowOf2;
    }

    [SyntaxDraft]
    public void Floating() {
        //True = (1 / 0.00).Is.Finite;
        //_ = 0.1.Is.NaN;
        //True = negativeDbl.Is.Normal;
        //False = negativeDbl.Is.Subnormal;
    }

    [SyntaxDraft]
    public void FloatingAsIntegral() {
        //_ = (10 / 2.0).Is.Integer;
        //_ = (2.0 / 5.0).Is.Integer;

    }

    [SyntaxDraft]
    public void Naturalization() {
        sbyte signed = 9;
        True = signed.Is.NaturalOr0;

        //False = gdpEU.Is.NaturalOr0.PowOf2;

        _ = intNegative.Is.NaturalOr0;

        //_ = gdpEU.Is.NaturalOr0;
        //True = gdpEU.Is.NaturalOr0.Odd;

        //_ = samplePositiveFloat.Is.NaturalOr0;

        //_ = negativeDbl.Is.Integer;
        //False = int100.Is.NaturalOr0.PowOf2;
    }

    /// <summary>
    /// Uncomment before release to prove that no line can be compiled
    /// </summary>
    [SyntaxDraft]
    public void InvalidSyntax() {
        // _ = bitsInByte.Is.NaturalOr0; 🚫
        _ = ((sbyte)bitsInByte).Is.NaturalOr0; // 🆗

        //_ = ulong.MaxValue.Is.NaturalOr0; 🚫

        // _ = -16.Is.PowOf2; // 🚫
        // _ = 16.Is.PowOf2; // 🚫
        True = ((uint)16).Is.PowOf2; // 🆗

    }
}

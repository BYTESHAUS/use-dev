using System.Numerics;
using AbcExtNUnit.AssertOnAssign;
using UValSyntaxDrafts.Length;
using UValSyntaxDrafts.Temperature;

namespace UValSyntaxDrafts
{
    public class Tests : Defined_Errors_Vars
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Test() {
            const int five = 5;
            var unival = five.meter;

            False = five.kilometer == 5_000.meter;
            True = five.kilometer == 4_999.99.meter;

            var boilsAt = 97.86.Celsius;

           // var DUBIOUS = 2.m; // no easy distinciton
        }

    }
}

namespace UValSyntaxDrafts.Length
{
    public static partial class Length
    {
        // ToDo: shorcut namespace
        extension<N>(INumber<N> seed) where N : INumber<N>
        {
            public object m => null;
            public object meter => null;
            public object kilometer => null;
        }
    }
}

namespace UValSyntaxDrafts.Temperature
{
    public static partial class Temperature
    {
        extension<N>(INumber<N> seed) where N : INumber<N>
        {
            public object m => null;
            public object Kelvin => null;
            public object K => null;
            public object Celsius => null;
            public object C => null;
            public object Fahrenheit => null;
            public object F => null;
        }
    }
}
﻿using Mk.N_Val.Phys.Temperature.Build;
using N_Val.Phys.Temperature;
using System.Numerics;
using TD.N_Val;

namespace N_Val.Test_Learn.Basics;

public static class Providers
{
    public readonly static object[] MutitypeNumerics = {
        Temperature.Celsius(TestArgs.Temperatures.WaterBoiling.C),
        Temperature.Fahrenheit(TestArgs.Temperatures.WaterBoiling.F),
        Temperature.Fahrenheit(TestArgs.Temperatures.SunSurface.K),
    };
}
public class IndexerTests
{
    [TestCaseSource(typeof(Providers), nameof(Providers.MutitypeNumerics))]
    public void AccessByIndex<N>(ITempEdit<N> temperature) where N : INumber<N> {
        var absolute = temperature[In.Kelvin];
        Assert.That(absolute, Is.GreaterThan(N.Zero));
        temperature[In.Kelvin] = absolute;
        temperature[In.Kelvin]++;

        var closed = (ITemp<N>)temperature;
#if FALSE // COULD_COMPILE
        closed[In.Kelvin] = absolute;
#endif
        Assert.That(closed[In.Kelvin], Is.EqualTo(temperature[In.Kelvin]));
    }

    [TestCase(In.Celsius, -20.2), TestCase(In.Fahrenheit, 451), TestCase(In.Kelvin, 123_500_700_999)]
    public void IndexByVariable<N>(In unit, N val) where N : INumber<N> {
        var holder = Temperature.Kelvin(N.Zero);
        holder[unit] = val;
        Assert.That(holder[unit], Is.Not.EqualTo(N.Zero));
    }

    // ToDo: FOR !

    [Test]
    public void ShortcutIndex() {
        var temperature = Temperature.Celsius(961.8);
        var absoluteValue = temperature[K];
        temperature[C]++;
        Assert.That(temperature, Has.Property(nameof(Temperature.Kelvin)));
    }

    private readonly In K = In.Kelvin;
    private readonly In C = In.Celsius;
    private readonly In F = In.Fahrenheit;
}
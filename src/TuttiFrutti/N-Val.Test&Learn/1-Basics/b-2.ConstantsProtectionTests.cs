﻿using Mk.N_Val.Phys.Temperature.Build;
using Mk.N_Val.Phys.Temperature.Const;
using N_Val.Phys.Temperature;

namespace N_Val.Test_Learn.Basics;
public class PredefinedProtectionTests
{
    [Test]
    public void TryDowncast() {
        Assert.Throws<InvalidCastException>(() => {
            var unlocked = (ITempEdit<double>)Univ.AbsZero; unlocked.Kelvin = 100;
        });

        var ironFlame = Autoignition.Iron;
        Assert.Throws<InvalidCastException>(() => {
            var unlocked = (ITempEdit<double>)ironFlame; unlocked.Kelvin = 100;
        });
    }

    [Test]
    public void TryRewrite() {
        var absZero = Univ.AbsZero;
        Assert.That(absZero.Kelvin, Is.Zero);

        absZero = Temperature.Kelvin(737.03);
        Assert.That(absZero.Kelvin, Is.Not.Zero);

        var newZero = Univ.AbsZero;
        Assert.That(newZero.Kelvin, Is.Zero);
    }
}

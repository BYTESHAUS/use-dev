﻿using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Melting
{
    public static ITemp<double> Iron => Build.Temperature.Const.KeCeFa(1811.15, 1_538, 2_800.4);
    public static ITemp<double> Quicksilver => Build.Temperature.Const.KeCeFa(234.32, -38.83, -37.894);
    public static ITemp<double> Silver => Build.Temperature.Const.KeCeFa(1_234.93, 961.78, 1_763.204);
    public static ITemp<double> Gold => Build.Temperature.Const.KeCeFa(1_337.33, 1_064.18, 1_947.52);
    public static ITemp<double> Platinum => Build.Temperature.Const.KeCeFa(Pt_C + Univ.KminusC, Pt_C, 3_214.94);
    public static ITemp<double> Tungsten => Build.Temperature.Const.KeCeFa(Pt_W + Univ.KminusC, Pt_W, 6_191.6);

    private const double Pt_C = 1_768.3;
    private const double Pt_W = 3_422.00;
}


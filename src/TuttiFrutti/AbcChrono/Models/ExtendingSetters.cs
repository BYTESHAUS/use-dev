﻿using AbcExt.Errors.Sys;

namespace AbcChrono.Models;
static class ExtendingSetters
{
    public static IHap Day(this IHap hap, byte val) {
        hap.DayNr = val;
        return hap;
    }

    public static IHap Month(this IHap hap, Month val) {
        hap.MonthName = val;
        return hap;
    }

    public static IHap Ago(this IHap hap) {
        hap.IsCounterClock = true;
        return hap;
    }

    public static IHap Set<N>(this IHap hap, N val, In unit) where N : INumber<N> {
        hap.Unit = unit;
        hap.UnixYear = NotImplemented.Throw("in next commit: CONVERT TO UNIX DATE");
        return hap;
    }

    public static IHap circa<N>(this IHap hap, N delta) where N : INumber<N> {
        hap.Delta = uint.CreateChecked(delta);
        return hap;
    }

    public static IHap Set(this IHap hap, DateTime dt) {
        hap.DayNr = (byte?)dt.Day;
        hap.MonthName = (Month)dt.Month;
        return Set(hap, dt.Year, In.Year);
    }

    public static IHap Set(this IHap hap, MonthYear my) {
        hap.MonthName = (Month)my.Month;
        return Set(hap, my.Year, In.Year);
    }
}

readonly struct MonthYear(int year, byte month)
{
    public static MonthYear From(DateTime dt) => new MonthYear(dt.Year, (byte)dt.Month);

    public MonthYear AddMonths(int shift) {
        return new MonthYear(Year + (shift / 12), (byte)(Month + (shift % 12)));
    }

    public readonly int Year = year;
    public readonly byte Month = month;
}

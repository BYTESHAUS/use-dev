﻿namespace ISie.String;
public static class Go
{
    public static ICultureNeutral Is(this string value) => new Is.CultureNeutralMenu(value);
    //public static ILingua Is<T>(this string value) where T : INumber<T> => Encoding, Extended ASCIIs, ?Unicode;
    public static ILingua Is<T>(this string value) where T : IScript, ISupported => null;
}


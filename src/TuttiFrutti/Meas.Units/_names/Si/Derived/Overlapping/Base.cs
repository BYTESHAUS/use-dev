﻿namespace Meas.Units._names.Si.Derived.Overlapping;
public static class Base
{
    public static readonly Dictionary<string, string> NameAbbr = new(StringComparer.InvariantCultureIgnoreCase) {
        // tonns "override" grams
        { "tonne", "t" },
        { "ton", "t" },
    };
}

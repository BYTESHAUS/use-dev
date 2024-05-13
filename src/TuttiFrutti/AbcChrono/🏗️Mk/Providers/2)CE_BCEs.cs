﻿using AbcChrono.Sol3.Calendar;

namespace AbcChrono.Mk.Providers;
class YearCentiEra : Full, ITimes
{
    new public ICalendar_wShortcuts_wCa At => At;

    new public IYearCenti circa() => (IYearCenti)base.circa();
    new public IYearCenti circa(ushort delta = 1) => (IYearCenti)base.circa(delta);
}

class YearCentiMilleEra : Full, IEra
{
    new public ICalendar_wCa<ICalendar> At => At;

    new public IYearCentiMille circa() => (IYearCentiMille)base.circa();
    new public IYearCentiMille circa(ushort delta = 1) => (IYearCentiMille)base.circa(delta);
}

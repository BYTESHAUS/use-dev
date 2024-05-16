﻿using AbcChrono.Sol3.Era;

namespace AbcChrono.Mk.Providers;
class ShortEra : Full, IEpochRuler
{
    public IAnnual circa() => base.circa();
    public IAnnual circa(byte delta) => base.circa(delta);

}

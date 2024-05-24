﻿namespace AbcChrono.Models;
class Universal : IBasal
{
    public required At Epoch { get; init; }

    public bool IsCounterClock { get; set; } = false;
    public In Unit { get; set; }

    // ToDo: CONST for long !
}

﻿namespace Abc;
public interface ISelected
{
    int Index { get; }
}

public interface ISelectable : ISelected
{
    new int Index { get; set; }
}
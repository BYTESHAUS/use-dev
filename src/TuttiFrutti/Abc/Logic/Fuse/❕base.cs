﻿namespace Abc.Logic.Fuse;
public interface IBase<T>
{
    T Join(T left, T right) => throw new NotImplementedException();
}
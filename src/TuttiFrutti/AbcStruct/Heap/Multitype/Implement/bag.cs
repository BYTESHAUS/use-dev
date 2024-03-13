﻿using AbcStruct.Ops.Keyed.Multitype;

namespace AbcStruct.Heap.Multitype.Implement;
internal class bag<TId> : IDirectOps<TId> where TId : notnull
{
    protected ITryOps<TId> _could = new bagTry<TId> { };

    public void Put<T>(TId id, T? val) => _ = _could.Put(id, val) ? true : UniqueConstraint.Throw(id);

    public T? Read<T>(TId id) => _could.Read(id, out T? val) ? val : EntityNotFound.Throw(id);

    public T? Take<T>(TId id) => _could.Take(id, out T? val) ? val : EntityNotFound.Throw(id);


}

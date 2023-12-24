﻿using Abc.Ext.Errors.Sys;
using Abc.Ext.Setup;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Abc.Ext.Boxes.Mixed;
public class Bag : IHeap
{
    private readonly IDictionary<string, IEnumerable> _coll = new Dictionary<string, IEnumerable>();

    public void Put<TId, TVal>(TId id, TVal? value) {
        var pointer = Qualify<TVal>();

        if (_coll.ContainsKey(pointer))
            ((IDictionary<TId, TVal?>)_coll[pointer])[id] = value;
        else
            _coll[pointer] = new Dictionary<TId, TVal?>() { [id] = value };
    }

    public bool Pick<TId, TVal>(TId id, out TVal? value) {
        var pointer = Qualify<TVal>();

        if (_coll.ContainsKey(pointer)) {
            var dict = (IDictionary<TId, TVal>)_coll[pointer];
            if (dict.TryGetValue(id, out value))
                return true;
        }

        value = default; return false;
    }

    public void EnsureNone<TId, TVal>(TId id) {
        var pointer = Qualify<TVal>();

        if (_coll.ContainsKey(pointer)) {
            var dict = (IDictionary<TId, TVal>)_coll[pointer];
            _ = dict.Remove(id);
        }
    }

    private string Qualify<TVal>([CallerMemberName] string caller = Arg.NotSubmitted) {
        var pointer = typeof(TVal).FullName ?? Argument<TVal>.Throw($"{caller}(): {nameof(TVal)} has no name");
        return pointer;
    }
}

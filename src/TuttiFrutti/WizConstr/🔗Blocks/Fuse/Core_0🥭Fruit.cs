﻿namespace WizConstr.Blocks.Fuse;

public abstract class Core<TSrc, TRes> : basal.rightVoid<TSrc, TRes>, INoLnkLeft;

public abstract class Fruit<TSrc, TRes> : Core<TSrc, TRes>
{
    public static implicit operator TRes(Fruit<TSrc, TRes> source) => source.Yield();
}
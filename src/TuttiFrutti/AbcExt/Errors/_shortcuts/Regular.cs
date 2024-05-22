﻿using AbcExt.Errors.Utils;
namespace AbcExt.Errors.Shortcuts;
public abstract class Regular<TExc>(string? message = "", Exception? inner = null)
    : Exception(message, inner)
    where TExc : Exception
{
    public static dynamic Throw(string message, Exception? inner = null, [ArgExpr(nameof(message))] string _ = argEx)
        => throw New(message, inner);

    public static dynamic Throw<T>(T subject, Exception? inner = null, [ArgExpr(nameof(subject))] string argCall = argEx)
        => Throw($"*{argCall}*={subject}", inner);

    public static TExc New(string message, Exception? inner = null, [ArgExpr(nameof(message))] string _ = argEx)
        => Builder.Make<TExc>(message, inner);

    public static TExc New<T>(T subject, Exception? inner = null, [ArgExpr(nameof(subject))] string argCall = argEx)
        => New($"*{argCall}*={subject}", inner);

    private const string argEx = "[<*unknown*>]";
}

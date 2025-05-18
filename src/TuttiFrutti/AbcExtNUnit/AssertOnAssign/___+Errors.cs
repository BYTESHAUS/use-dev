﻿namespace AbcExtNUnit.AssertOnAssign;
public abstract class Defined_Errors : Defined
{
    public virtual Func<object, object> ErrTemp { // ToDelete: Temp test 
        get => ERR_STUB;
        set {
            _ = value("df");
            _ = value;
        }
    }

    public virtual Expression<Func<object, object>> Error {
        get => ERR_STUB;
        set => Check(value.Compile(), value);
    }

    public virtual Expression<Action<object>> Err {
        get => ERR_STUB;
        set => Check(_ => { value.Compile()(""); return true; }, value);
    }

    public virtual Expression<Func<object, object>> OkOrError {
        get => ERR_STUB;
        set => Check(value.Compile(), value, true);
    }

    public virtual Expression<Action<object>> OkOrErr {
        get => ERR_STUB;
        set => Check(_ => { value.Compile()(""); return true; }, value, true);
    }

    private static void Check(Func<object, object> method, LambdaExpression expression, bool canSucceed = false) {
        var report = Parse(expression);

        var matches = NormalizeParameters(expression, report.digest);
        var success = false;

        try {
            _ = method("");
            success = true;
        } catch (Exception exception) {
            if (Match.ObjectType<object>(exception, matches) is null) {
                Console.WriteLine($"{report.digest} threw unexpected \"{exception.GetType().FullName}\"");
                throw;
            }
        }
        if (success && !canSucceed)
            Assertion.Throw($"{report.digest} threw no exception at all");
    }

    private static IEnumerable<string> NormalizeParameters(LambdaExpression expression, string callerArg) {
        var parameters = expression.Parameters.Select(x => x.ToString().Trim()).ToList();

        var wsCount = parameters.Count(param => param.Is.NullEmptyOr.Whitespace);
        if (wsCount is not 0) // NOTE: don't throw empty / argument exception, which may be expected ...
            FixtureError.Throw($"\"{callerArg}\" submitted whitespace parameters: " + wsCount); // ... but testbed specific

        parameters = [.. parameters.Select(x => x.Replace("__", "."))];
        EnsureExceptionSuffixOption(parameters);

        var duplicates = parameters.GroupBy(x => x).Where(g => g.Count() > 1).ToList();
        if (duplicates.Any())
            FixtureError.Throw($"Duplicated arguments: {string.Join(',', duplicates.Select(y => y.Key).ToList())}");

        return parameters;
    }

    private static void EnsureExceptionSuffixOption(List<string> source) {
        const string option = "Exception";

        var nonSuffixed = source.Where(x => x.Right() != option).ToList();
        source.AddRange(nonSuffixed.Select(x => x + option));
    }
}
﻿using ISie.String.Traits;

namespace ISie.Mk.blocks;
public interface ITextual<LTR, TXT>
{
    LTR Letters { get; }
    LTR Alphanumeric { get; }

    /// <summary>
    /// Includes punctuation
    /// </summary>
    TXT Text { get; }
}

public interface IExtraSpace
{
    /// <summary>
    /// <seealso href="https://learn.microsoft.com/en-us/dotnet/api/system.char.iswhitespace#remarks">Whitespaces list</seealso> 
    /// </summary>
    bool AllowWhitespace { get; }
}

public interface IExtraText : ITextCheck
{
    /// <summary>
    /// Misc. brackets and quotes, «..»» „..” °  _ / \ * + % №  Nº  
    /// </summary>
    ITextCheck AllowMiscSymbols { get; }
}

public interface ITextCheck
{
    /// <summary>
    /// E.g. "it is123inlay"
    /// </summary>
    bool WithoutNumberInlays { get; }
}

public class Encoding : Fruit<string>, IEncodingChecks // ToDo: enhance for Extended ASCII
{
    // ToDesign: override xForm
    //protected override bool Eval() => Seed is "" ?
    //    Empty.Throw("Value checked for encoding can't be empty") :
    //    Seed.ToCharArray().All(char.IsAscii);

    public bool NoControls => And(HasNo.Controls); // ToDesign: Empty.Throw

}
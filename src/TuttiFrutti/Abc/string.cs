namespace Abc;
public class @string
{
    public const string Space = " ";
    public static string Spaces(ushort num) => 0 == num ? string.Empty : new(' ', num);
}

public class Spaces { 
    public const string Two = @string.Space + @string.Space;
    public string Three => Two + @string.Space;
    public string Four => Three + @string.Space;
    public string Five => Four + @string.Space;
    public string Six => Five + @string.Space;
    public string Seven => Six + @string.Space;
    public string Eight => Seven + @string.Space;
    public string Nine => Eight + @string.Space;
    public string Ten => Nine + @string.Space;
    public string Eleven => Ten + @string.Space;
    public string Twelve => Eleven + @string.Space;
}

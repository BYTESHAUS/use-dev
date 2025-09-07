using Abc.Num.Groups;
using Abc.Num.Roman;

namespace AbcDataOps.Num;
public class Roman
{
    public const string Max = "MMMCMXLIX";
    public const ulong MaxAsDecimal = 3_999;
    public const string Pangram = "MCDXLIV";

    public static bool TryPresent<N>(N value, out string result) where N : INumber<N> {
        const string CantBe_ = "Roman number can't be ";
        var success = false;

        if (N.IsNegative(value))
            result = $"{CantBe_}negative";
        else if (N.Zero == value)
            result = $"{CantBe_}zero";
        else {
            var num = ulong.CreateChecked(value);
            if (MaxAsDecimal < num)
                result = $"{CantBe_}bigger than {MaxAsDecimal}";
            else {
                result = "NotImplemented"; // Present(OneToNine.One);
                success = true;
            }
        }
        return success;
    }

    public static string Present(ZeroToNine num, Digits unus, Digits quinque, Digits decem) {
        switch (num) {
            case ZeroToNine.One:
                return string.Empty;
            case ZeroToNine.Two:
                return $"{unus}{unus}";
            case ZeroToNine.Three:
                return $"{unus}{unus}{unus}";
            case ZeroToNine.Four:
                return $"{unus}{quinque}";
            case ZeroToNine.Five:
                return $"{quinque}";
            case ZeroToNine.Six:
                return $"{quinque}{unus}";
            case ZeroToNine.Seven:
                return $"{quinque}{unus}{unus}";
            case ZeroToNine.Eight:
                return $"{quinque}{unus}{unus}{unus}";
            case ZeroToNine.Nine:
                return $"{unus}{decem}";
        }

        throw new InvalidOperationException($"unexpected value: {num}");

    }
}


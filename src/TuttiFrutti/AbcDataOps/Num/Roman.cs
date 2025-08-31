namespace AbcDataOps.Num;
public class Roman
{
    public const string Max = "MMMCMXLIX";
    public const ulong MaxAsDecimal = 3_999;
    public const string Pangram = "MCDXLIV";
    public class Units
    {
        public const ulong I = 1;
        public const ulong V = 5;
        public const ulong X = 10;
        public const ulong L = 50;
        public const ulong C = 100;
        public const ulong D = 500;
        public const ulong M = 1_000;
    }

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
                result = Present(num);
                success = true;
            }
        }
        return success;
    }

    private static string Present(ulong num) {
        var divider = Units.V;
        var div = num / divider;


    }
}

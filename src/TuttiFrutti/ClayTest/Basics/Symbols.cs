namespace ClayTest.Basic.Stuffing;

public class Symbols : Defined
{
    [Test]
    public void Invisible() {
        True = @char.Space == @string.Space[0];

        True = "   " == @string.Spaces(3);
        False = @string.Spaces(ushort.MaxValue) == "";
    }
}

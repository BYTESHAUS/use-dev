using System.IO;
using System.Text;

namespace ClayTest.Basic.Stuffing;

public class Symbols : Defined
{
    [Test]
    public void Invisible() {
        True = @char.Space == @string.Space[0];

        True = "   " == @string.Spaces(3);
        False = @string.Spaces(ushort.MaxValue) == "";
    }


    [Test]
    public void Encode() {
        // Windows-1250
        // ISO-8859-2
        // ISO 8859-10 (Latin-6) 

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        string diactrics = "Háček (č, š, ž, ř) Čárka (á, é, í) Kroužek (ů), Škoda Ť : ť";
        Encoding latin2 = Encoding.GetEncoding("ISO-8859-2");
        byte[] isoBytes = latin2.GetBytes(diactrics);
        File.WriteAllBytes("C:\\_eadme+\\CZ_FAIL.txt", isoBytes);

        using (FileStream stream = new("C:\\_eadme+\\CZ_FAIL.txt", FileMode.OpenOrCreate)) {
            stream.Write(isoBytes);
        }
    }
}
namespace ISie.Number.As.Mk;
public class Root<N>(N seed) where N : INumber<N>
{
    private N _seed = seed;

    /// <summary>
    /// Represents numbers 1-3999 as Roman or throws OutOfRange 
    /// </summary>
    public string Roman => NotImplemented.Throw("XXI");

    /// <summary>
    /// Represents numbers 1-3999 as Roman or formats them according to a standard specifier
    /// </summary>
    public string RomanOrFormat(string specifier = "") => NotImplemented.Throw("XXI");

    public string Greek => NotImplemented.Throw("ΔΔΙ");

    public bool Ancient => false; // Aegean
    public string Other<T>() => "TO DO";


}
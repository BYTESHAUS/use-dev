﻿namespace MeasData.Temperature.Setup;
public abstract class Synonyms : MeasOrg.Tables.Chem.Synonyms
{
    protected const string Celsius = "celsius";
    protected const string C = Celsius;

    protected const string Kelvin = "kelvin";
    protected const string K = Kelvin;

    protected const string Fahrenheit = "fahrenheit";
    protected new const string F = Fahrenheit; // NOTE: hides Fluorine!

    public const double KelvinOffset = 273.15;
}

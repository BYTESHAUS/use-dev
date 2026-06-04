<h1 align="center">Tests<sub>🧪</sub> <samp><i>featuring</i></samp> ... tests<sup>🧪</sup></h1>

> ### `NUnit` is a conventional, reliable, and universal test framework, but like most FOSS, it has limited resources, and its contributors aren't obliged to any delivery.

### This project presents _prêt-à-porter_ testing goodies already running in test/demo projects of this _Tutti&nbsp;Frutti_ solution.


## Attribute shortcuts

<samp><b>RECOMMENDED:</b><samp> It doesn't introduce new functionality but cleanses existing NUnit calls/references off formalities peel.

-> [Try without further ado](Shortcuts/Attributes)

## Variable-like data sources

Because of `C#` limitations, NUnit may specify only constants and literals in attributes. 
The boilerplate and verbosity of variable/dynamic (run-time) datasources may be annoying and involve much _Repeat Yourself_.

The alternative in [DataOutsourcing](DataOutsourcing) must be shorter, more explicit, and with some auto-discovery. 

👆 You may extend the technique for less or more specific custom formats, deriving from `IDataSource`, or even implement sophisticated cases like [convert 🧪tests](../FuncStore.Convers.Tests) of 
<sub><picture><img alt="&nbsp;Funcware" src="../../../README+/_rsc/img/symb/funcware/funcware-bar_16px.jpg" title="Conversion functions"/></picture></sub>.

## Assert-by-assign <a id="assert-by-assign" />

The intention was not only to shorten the syntax but to release the subject of the test from the parentheses (to emphasize).

```csharp
True = yourObject.AnyTruthValuingFunction();
Eq[1968] = CE.YearOf("Algol68");
Within[3.14, 3.15] = CustomPiCalculation();
Error = DivideByZero => MyMath.DivideBy(0.00);
```
-> [More demos](AssertByAssign)

> [!WARNING]
> <samp>EXPERIMENTAL</samp> syntax on questionable premises.
> 
> It's not a replacement for NUnit but some sugar for rapid prototyping and demos.

___________\
🔚 2025-2026 ..

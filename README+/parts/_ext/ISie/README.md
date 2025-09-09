<h1 align="center">⭐&thinsp;I&thinsp;S&thinsp;i&thinsp;e&thinsp;⭐ &nbsp;&mdash;&nbsp; <code>.Is.</code><sup>➕</sup> <samp>extensions</samp></h1>

<table align="center"><tr valign="top"><td><picture><img src="../../../_rsc/img/ISie.png" alt="&nbsp; I&thinsp;S&thinsp;i&thinsp;e&nbsp;&nbsp;extensions"/></picture></td><td>

**The crossover of the next two `C#` discoveries**

<div>&nbsp; &nbsp; ✔️ &thinsp;legit <a href="../../../frames/README+/calls_on_null.md">calls on null</a>&thinsp;,</div>
<p>&nbsp; &nbsp; ✔️ &thinsp;<a href="https://github.com/dotnet/roslyn/issues/11159">proposal</a>&thinsp;<sup>⏳</sup> of extension properties</p>
<div>suggested me to shortcut ubiquitous </div>
  <div align="center"><code>string.IsNullOrWhiteSpace(<i>abracadabra</i>)</code><br />into<br /><code><i><b>abracadabra</b></i>.IsNullOrWhitespace</code>,<br />
  which finally became<br /><code><i><b>abracadabra</b></i>.Is.NullEmptyOr.Whitespace</code>&thinsp;.</div>
</td><td><picture><img src="../../../_rsc/img/_nav/tiles/ISieCircuitry_200px.png" alt="&nbsp;&nbsp;I&thinsp;S&thinsp;i&thinsp;e&nbsp;&nbsp;extensions"/></picture><br />
  <div align="center"><samp>use circuitry</samp></div></td></tr></table>

<div align="right"><sup>⏳</sup>&thinsp;<sub>This ever-pending feature must be C#13 "what's new",<br />but finally appeared only as a C#14 preview (April/2025).</sub></div>

#### This wasn't a revolutionary hack to announce, won't it be a groundstone idea for:

+ Reconsideration of all available **`Is`**, **`To`**, **`Equal`**, ... methods of built-in types.
+ **Better syntax**: shorter, intuitive, and grouped,
+ **New functionality** beyond shortcuts (theoretically to port them to other languages),
+ **Domain**-telling code,
+ more goodies, ** but ...

<h3 align="center">... let's not beat around the bush and first show what's pret-a-porter:</h3>

<table align="center"><tr></tr><tr><td>🧪<b>By guidance</b> (recommended)</td><td>⚡<b>Direct</b> (if you want)</td></tr>
  <tr valign="top"><td>
  <div>Here is the entry point:</div>
  <h3 align="center"><a href="../../../../src/TuttiFrutti/ISie_Eval/BuiltinTypes">D<samp>&thinsp;E&thinsp;M&thinsp;O&thinsp;S</samp>&nbsp;&nbsp;&nbsp;<samp>a&thinsp;n&thinsp;d</samp>&nbsp;&nbsp;&nbsp;T<samp>&thinsp;E&thinsp;S&thinsp;T&thinsp;S</samp></a></h2>
  <p>For a quick example: <a href="../../../../src/TuttiFrutti/ISie_Eval/BuiltinTypes/📃String/Blanks/✨Demo.cs"><code>string.<b>Is</b>...</code></a></p>
  </td><td>
    
  When you prefer to explore without guidance, just add
    
   [<ode>using ISie</code>](../../../../src/TuttiFrutti/ISie),
  
  and let IntelliSense help you!</p>

  </td></tr><tr><td colspan="2" align="center">It's better to explore in Visual Studio 2022 or another compatible IDE.</td></tr></table>

<h3 align="center">... narattive resumed ...</h3>

## Why `.Not.`?

If it's just <code>❗subj.Is...</code>. The answer is "**to discern**" &thinsp;&mdash;&thinsp; surrounding symbols may shade subtle `!`. 
(**C#** itself offers `is not`.)

It's up to you which lexis to pick in **each** case.

<table><tr><td align="center"><b>algebraic language</b></td><td align="center"><b>perceptible tongue</b></td></tr><tr><td>
<p><code>if(<mark><b>!</b></mark>longStringVarName.Is.NullOr.Empty())</code></p>
<p><code>x => <mark><b>!</b></mark>x.Is.EmptyOr.Whitespace()</code></td></p>
<td>
<p><code>if(longStringVarName.<b>Not</b>.NullOr.Empty())</code></p>
<p><code>x => x.<b>Not</b>.EmptyOr.Whitespace()</code></p>
</td></tr></table>

## Not only `Is/Not`

It wasn't a big deal to add some other evident shortcuts: 

+ for ✨[`.To` for chars](../../../../src/TuttiFrutti/ISie_Eval/BuiltinTypes/🔣Char/✨Demo_To.cs)
+ for ✨[numeric operations](../../../../src/TuttiFrutti/ISie_Eval/BuiltinTypes/🔢Number/✨Demo🔢Calc🧮.cs) as `Abs`

## What's next

**IS<samp>IE</samp>** is a subject of expansion (Unicode alone is a [big candidate](https://www.unicode.org/glossary/)<sup>🔗</sup>) and a platform for kin features:

+ `.Equal` for strings needs better syntax than the onerous comparison options. 
+ detecting tongues used in text (`Has<Greek>`),
+ micecllaneoud `All.`, `Can.`, `None...`,
+ _many more_ but which will find its users.

## Spin-Offs

⭐<b>I&thinsp;S&thinsp;<samp>I&thinsp;E</samp></b>⭐ is a remarkable centerfold for miscellaneous concepts and other parts/features.

[TDD watershed](https://github.com/BYTESHAUS/read-write/blob/main/README+/software/tests/asDrive/README+/TDD-Watershed/README.md#TDD-ISie) refers ⭐ISie⭐ for explanation.

This feature launched 

+ 🗣️&thinsp;tongues categorization in [Abc Lingua](../../../../src/TuttiFrutti/AbcLingua),
+ 🪫&thinsp;[Circuitry](../../../techniques/README+/circuitry) (as a pattern via techniques),
+ 🏗️&thinsp;[Code wizards](../../../../src/TuttiFrutti/WizConstr/README.md),
+ 🧪&thinsp;[Assert shortcuted to assign](../../../../src/TuttiFrutti/FeatTest/AssertByAssign)

\___________\
🔚 .. <samp>🐝🐝 <code>OR</code> ❗too 🐝</samp> ... 🌘 **2025** ... <sub>[![C#](https://custom-icon-badges.demolab.com/badge/C%23-but_for_all-orangered.svg?logo=cshrp&logoColor=white&color=turquose)](#)</sub>

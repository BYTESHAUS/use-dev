<h1 align="center">Wizards&thinsp;/&thinsp;Builders&thinsp;/&thinsp;Factories &nbsp;&mdash;&nbsp; <i>"Constructive"discussion</i></h1>

> ### Genuine **`builders`/`wizards`** are not only for chained calls, coding convenience, and mistake-proof input. And not only far advanced Intellisense but ...
> <h3 align="center">Scripting meta-language as an alternative design paradigm (not simple patterns).</h3>
> &nbsp;

Only the theoretical overcomplexity of being an uncompromising language feature or library, and the heavy practical overhead of endeavors, made them exotic in our projects.

<blockquote align="center"><ins>&thinsp;«&thinsp;<b>BUILDERS</b>&thinsp;»&thinsp;</ins> are both <samp>GRAPH COMPLEXITY</samp> and <samp>EXPONENTIAL <b>DISASTER</samp></b>&thinsp; in less or strongly-typed languages.</blockquote>

<table><tr valign="top"><td width="40%"><picture><img alt="&nbsp;Construction crane collapse" src="https://github.com/BYTESHAUS/read-write/blob/main/README%2B/_rsc/_img/illus/crane_collapse-CA-2024(globalnews.ca).jpg" /></picture></td><td>
<div>We talk about multi-variant branching menus with intuitive context-sensitive options, like:</div>
 <p align="center"><code>var stack = UndoRedo.Buffer(3).Depth(5).Zip().Of("start");</code></p>
<div>What's often sold as builders is a counter-intuitive syntax tape of setters and operations,</div>
  <p align="center"><code>var product = Builder.Add(...).Set(...).Add(...).Set(...) ... Make();</code></p>
  <p>which doesn't prevent redundancies, dubious repetitions, and wrong calls.</p>
<p align="center"><b>The challenge is the <ins>combinatorial explosion</ins>.</b></p>
</td></tr></table>

> We are here not to yammer but to collect techniques and ideas that mitigate the complexities and still render intuitive builders (to some extent).

First of all, creating unlimited context constructors is possible with

+ auto-generating templates under defined scenarios,
+ dynamic code generation to stuff the selected interface.

However, are there custom applications for which it wouldn't be a "mega-engineering" and overkill? Let's consider other possibilities:

<table><tr><td><picture><img alt="&nbsp;🚧  W&thinsp;O&thinsp;R&thinsp;K  i&thinsp;n  P&thinsp;R&thinsp;O&thinsp;G&thinsp;R&thinsp;E&thinsp;S&thinsp;S&thinsp; 🐝" src="https://github.com/BYTESHAUS/read-write/blob/main/README%2B/_rsc/_img/_nav/tiles/_WorkInProgress_200px.jpg" /></picture></td><td>
<p>GENERIC PARAMETRIZAION</p>
<p>PARAMETER OBJECT</p>
<p>DYNAMIC FILL OUT</p>
</td></tr></table>

## Theory

|- Builder for side effects // with open subscriptions for specified steps \
|- Undo/Redo as a builder

## Realization

Meanwhile, some construction techniques are there:\
|- [<b>Code Wizard blocks</b>](../../../../src/TuttiFrutti/WizConstr/README.md)\
|- [ISie extensions](../../../parts/_ext/ISie/README.md), which rest on these blocks\
|- [AbcChrono](../../../parts/AbcChrono) // is made up of building scripts


The following topics contemplate object building:\
|- [Circuitry](../circuitry)

## Conclusion

Nevertheless, the best technique when hit against the wall is to cut constructors and make other bulky but easy initializations.

\___________\
🔚 ... 2024-2025 .. image credit: https://globalnews.ca (2024)

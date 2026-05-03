<h1 align="center">P<samp>rog Tests</samp> &nbsp;&mdash;&nbsp; &Lscr;oosing the <code>Assert</code>s</h1>

> ## We are accustomed to thinking of proofs (not only software tests) in categorical conditions that a subject either meets<sup>✔️</sup> or misses<sup>❌</sup>. 
 
## Such _truth telling_ is based, at first sight&nbsp;...<br />&nbsp; <sup><samp>...&nbsp; but life scenarios will defy the "black-and-white" postulate.</samp></sub>

### ✔️ $5*5$ must be $25$ and not $25.000'000'000'001$ but&nbsp;...

&hellip;&nbsp;not excact for infinite fractions as $1/9$, fundamental problems of [floating-point calc](https://en.wikipedia.org/wiki/Floating-point_arithmetic#Accuracy_problems)<sup><b>W</b></sup>. Or, metaphorically, $3.14$ is enough for your **$π$** without further overcalculations.

### ✔️ the longest <kbd>password</kbd> must exactly match alphabets, upper/lower, and <span title="&nbsp;ä à ō ỏ ç ș εͅ, ⟨š">_diactrics_</span> in every char, but&nbsp;...

&hellip;&nbsp;CAPTCHAs and grammar checkers aren't that strict.
 
### ✔️ a UI element can be either **visible** or not but&nbsp;...

&hellip;&nbsp;elements can be faded, hidden, or unloaded.

<h2 align="center">🏀Let's take a sports break to 💡spark the imagination:🎯</h2>

### 🏀 points[^1] are added when the basketball's center crosses the hoop from above &thinsp;&mdash;&thinsp; a&nbsp;definite `true` or `false` but&nbsp;&hellip;

[^1]: One, two, or three, depending on the distance of the throw and the game situation.

<table><tr valign="top"><td>
<picture><img alt="&nbsp; Archery target with arrors" src="https://github.com/BYTESHAUS/read-write/blob/main/README%2B/_rsc/_img/illus/_sports/archery_pixabay.com_christianplass.png" /></picture>
</td><td>

## Archery may serve as the best slack example.

### Except for the _golden 10_<sup>✔️</sup> and _out_<sup>❌</sup>, everything else is relative.

To make things more tangled, there could be different bows, distances, and even winds and illumination in open-air tournaments, impacting the result. 

### Besides precision, there's [accuracy](https://en.wikipedia.org/wiki/Accuracy_and_precision)<sup>W</sup>. 

### In our test patchwork it translates to:

+ ### [**Graduality**](tests-gradual_assert.md)
+ ### [**Tolerance**](tests-value_tolerance.md)

</td></tr></table>

🔚 <samp>.. 2025-2026.. (image credit: christianplass on pixabay.com)</samp>

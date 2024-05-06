# Chronology - Timelines - Events

Time is the _driver_ for all and the "solvent" of everything. The former is for software and the latter for its hardware.

Exact time measurement<sup>🔬</sup> and timestamping aren't an issue for regular solutions but chronology. Software of the previous millennium gave literally bits for dates, thus nurturing the giant Y2K bug. Contemporary languages can support a vast range of past and future dates<sup>📆</sup>, but badly organize them.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>🔬</sup> <sub>Unless you need accuracy close to [physics on steroids](https://www.nobelprize.org/prizes/physics/2023/summary/).<sup>🔗</sup></sub>\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>📆</sup> <sub>Contrary to Java and astonishly C# `DateTime`supports only Common Era.</sub>

## Framework - Demands

### Initial requirements

+ Intuitive syntax
+ Approximation
+ Guards: range limit (e.g. 1-28/29/30/31 for months) compile- and run-time ()

<details>
  <summary><ins>&nbsp;<b>Overall Wizard-Model look</b>&nbsp;</ins></summary>
&nbsp;
  
  [![Wizard (date, year, ca., ago) - Mode (output) diagram](../../../README+/_rsc/images/bigmessowires.com_wired-circuit.jpg)](https://github.com/Kyriosity/read-write/tree/main/README+/pencraft/README+/_rsc)
  
</details>

### Demands - Next Gen demands

+ Fuzzy comparisson
+ Glossary 
+ Casting


### C# solution <- LINK HERE from R/W

Disclaimer! Version&nbsp;**1** this is a functional sketch. A foundation to try and release all-around solution. 

#### Remarks 


##### Alternatives

One-page (single-class) wizard

#### Implementation blog

1) Layout basic simplified logic and syntax over it. TDD tests to prove and demo.
2) Shortcuts for eras with interfaces to mask methods
3) Parametrize with number type as possible
4) Timeline Model
5) Guards
6) 

# "Lurking" initialization in 🎼C#

<table align="center"><tr></tr><tr><td><b>Initializing objects isn't an issue ... when it's simple.<br />Particular wishes are met or limits are hit.<br />And these can be essential (as CLEAN INIT - 🚧 LINK REQUIRED).</b></td></tr></table>

## Reminder and setup

`C#` offers two "mainstream" ways of parameterizing objects on creation (with or without `required` fields).

### ▪️Constructors // <code>&thinsp;<i>new</i> <mark>(&thinsp;</mark>..<mark>&thinsp;)</mark></code>

Many techniques and frameworks (let alone serialization) disregard "parameter-ful" constructors; however, they have one distinct and great advantage:

> **Certain parameters can be exposed only once in the construction call that corresponds to the term "_initialization_".**

Other things as `params` are syntax excellence.

### ▪️Initializers // <code>&thinsp;<i>new</i> <mark>{&thinsp;</mark>..<mark>&thinsp;}</mark></code>

[Object initializers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers)<sup>🪟</sup> are error-proof and more flexible (can set even readonly fields through `init` props). 

> The disadvantage &ndash; properties remain exposed in the object (even as read-only) when not required.

## Posers

### Construction from type argument

The [`new`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-constraint)<sup>🪟</sup> constraint allows to instantiate `<T>`.

Constructor parameters and `required` modifier will **not** compile with that.

## Answers

There are no perfect workarounds, but ...

### "Generic" parametrization

You can't supply parameters to `<T>, new`, but you can supply another generic, which can wrap the parameter. Awkward, but it works.

### Building

Hiding `new` from public access and yielding objects through a chain of methods renders all advantages and removes all disadvantages of parameters (..)`, and initializers `{..}`. 

Not only for `C#` &ndash; the only problem is complexity. So huge that it's a big survey on its own &ndash; [**Builders**](builders/README.md).

 🚧 🏗️ 🚧 ... to be continued ... 🚧🐝🚧

___________\
🌘 2025-2026..

# "Lurking" initialization in 🎼C#

> **Initializing objects isn't an issue until particular wishes are met or limits are hit.**

## Reminder and setup

C# offers two "mainstream" ways of parametrization objects on creation:

WE MEAN here set only there and optionally required 

* **C&thinsp;o&thinsp;n&thinsp;s&thinsp;t&thinsp;r&thinsp;u&thinsp;c&thinsp;t&thinsp;o&thinsp;r&thinsp;s**

Many techniques and frameworks (let alone serialization) disregard "parameterful" constructors however they have one distinct and great advantage:

> Certain parameters can be exposed only once in the construction call that corresponds to the word "initialization".

Other things as `params` are syntax excellence.

* **I&thinsp;n&thinsp;i&thinsp;t&thinsp;i&thinsp;a&thinsp;l&thinsp;i&thinsp;z&thinsp;e&thinsp;r&thinsp;s**

[Object initializers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers)<sup>🪟</sup> are error-proof and more flexible (can set even readonly fields through `init` props). 

The disadvantage - properties remain exposed in the object (even as read-only) when not required.

## Posers

## Construction from type argument

The [`new`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-constraint)<sup>🪟</sup> constraint allows to instantiate `<T>`.

Constructor patameters and required modifier won't compike with that.

## Builders 

Rendering objects through methods encapsulating new() exclude further parameters () or initializers {}.

Constructors

## Solutions

### Generic parametrization of generics !


 🚧 🏗️ 🚧 ... to be continued ... 🚧🐝🚧

\___________\
🌘 2025

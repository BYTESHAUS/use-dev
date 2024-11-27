# Tests &mdash; Cutting the Feed Expansion

<table><tr><td><img alt="&nbsp;READ-WRITE meets USE-DEV" width="100px" src="https://github.com/Kyriosity/read-write/blob/main/README%2B/_rsc/_img/_nav/read-write_use-dev.jpg" /></td><td>
   <p>Let's show how we could meet <a href="https://github.com/Kyriosity/read-write/blob/main/README+/software/tests/asQA/README+/tests-damp_vs_dry.md#Feed-expansion"><b>Feed expansion</b></a> with practical decisions.</p>
</td></tr></table>

## DRY it - Multifeed

### Dimensional growth

Mostly accepted test frameworks support test methods with a multi-feed of arguments. They are known as data rows, data sources, or meta-attributes. _Acts_ can be multi-fed the same way as data sources.

Attributes can be applied to arguments to specify all their possible combinations.

It's not a big deal to write a custom wrapper for missing or improved parameter "funnels".

### Combinatorial explosion


"Multidimensional" combinations will
make a mess of tests mass and  deteriorate its quality: negligence, scrappy coverage, impeded navigation, and badly exorbitant maintenance.

we may live with this, since tests are not the product, .

or apply **D**_on't_ **R**_epeat_ **Y**_ourself_ (aka <mark><b>DRY</b></mark>) to our tests ...

Most frameworks will support one-dimensional scaling.

AUTO-COMBINATION

MULTITYPE


## Workarounding

The best thing would be if 

LINK TO ASSERT-ACT breakup

### Parametrization

```csharp
[Test, SOURCE(A, B2, C30, D04, ...)]
MeaninglessMethodName()
{
    var result = FACTORY.FuncOfTest(Arrange());
    ASSERT(result); // fail or success
}
```

#### SPOILERS

### Functions

### 



Unless we ...


routine for a particular run. Let's illustrate with a primitive:\
`Asserts: Root.Square(4) == 2`

The next step is to supply various data and expectations - something that a ripe framework will provide out of the box:\
`DataRows[]`\
or you may 


// Many frameworks support keywords for the data combinations

MULTI-FUNC and VARIOUS TYPES

Just take an entity (unit) of an application as a `class` or `function` and cover it with proofs.


An [example test](../../../src/TuttiFrutti/FuncStore.Convers.Tests/PhysMath/Dims/LengthsTests.cs) with two feeds

Stubdd

Let's put 3D glasses on 
3D exploded view

+ win-win: data <-> test
* ?? false true (by coincidental match)
* ?? accumulated warnings/errors/info (e.g. unparsed)

## Wrap up

Was it all about unit tests? Yes, but can work for others in the pyramid.

Related topics\
GRADUAL ASSERT
HOW MANY ASSERTS
|- Elusive unit of test

🔚

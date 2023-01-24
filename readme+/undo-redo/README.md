# Reversible on .NET - Intro

<p dir="rtl";><span style="font-variant:small-caps;"><b>r&nbsp;e v e r s i b l e&nbsp;&nbsp;&nbsp;</b></span><br><b>a:</b>&nbsp;capable of going through a series of actions<br/>such as changes) either backward or forward)</p>
<p dir="rtl";><i>Merriam-Webster dictionary</i></p>

&nbsp;\
Ability to __undo__ and then, likely, __redo__ actions is constituent and multi-plugged for most applications. Besides traditional usage Undo-Redo may replace tedious confirmation ("are you sure"), run wizards, explore tree structures. 

Let's knock ourselves out to implement _reversible_ in a project, deserving just two words of others:&nbsp;`using Reversible;`.

We'll serve first the following *antipasto* of a very basic feature:

&nbsp;&nbsp;&nbsp;&nbsp;>&nbsp;&nbsp;&nbsp;&nbsp;:exclamation: __C# is degraded here for emphasis__&nbsp;:exclamation:
<details>
<summary>:chess_pawn:&nbsp;<ins>&nbsp;Take a dummy class of an obvious domain&nbsp;</ins></summary>

```csharp
class Chess<T>
{
    bool _blackOn;
    virtual T _move { get; set; }

    T Move {
        get => _move;
        set {
            Validate(value);
            _move = value; _blackOn ^= true;
            Notify();
        }
    }

    virtual void Validate(T value) { ... } // check notation and validate move here
    virtual void Notify() => Console.WriteLine($"{(_blackOn ? "black" : "white")}: {Move}");
}
```

</details>

<details>
    <summary>:previous_track_button:&nbsp;<ins>&nbsp;Upgrade it with Undo()&nbsp;</ins></summary>

```csharp
using Reversible;

public class IndulgentChess<T> : Chess<T>, IUndoable
{
    IUndoable<T> _backup = UndoOnly.Empty<T>();
    override T _move { get => _backup.Value; set => _backup.Value = value; }

    void Undo(int steps = 1) => _backup.Undo(steps);
}
```

</details>

<details>
<summary>:popcorn:&nbsp;<ins>&nbsp;Show the usage&nbsp;</ins></summary>

```csharp
var game = new IndulgentChess<string> { Move = "d4" }; // white begin ...
game.Move = "Nf6"; // Indian Defence
game.Move = "c4"; 
game.Move = "0-1"; // a world champion would resign the game ...
game.Undo(); // ... but not you
game.Move("e6");
// ...
```

&nbsp;&nbsp;&nbsp;&nbsp;<sup>:information_source:</sup>&nbsp;<sub>Game sample inspired by [Champions Chess Tour 2022](https://en.wikipedia.org/wiki/Carlsen%E2%80%93Niemann_controversy)</sub>
</details>  

&nbsp;\
If this has whetted your appetite, the __[Handbook](readme+/handbook)__ will share recipies of further features and use cases backed by [Q&A](readme+/reversible_q-a.md).

However ... __isn't that all an over-engineering of indexed element?__ <sup>:hammer:</sup>&nbsp; You decide, while [Rationale](readme+/reversible_reason.md) along with [Posers & Decisions](readme+/reversible_posers.md) tries to advocate our efforts.\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>:hammer:</sup><sub>For instance, `Moves[i]` for current value, `i--` for undo and `i++` for redo.</sub>

`UndoOnly` for the snippet above is too trivial to deserve your look into the repository but not the whole project, which you may follow in [Developer book](readme+/devbook), contribute to it or rework for own purposes.

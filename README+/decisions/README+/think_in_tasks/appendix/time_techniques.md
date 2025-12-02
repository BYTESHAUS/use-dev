# Thinking in time and tasks &thinsp;&mdash;&thinsp; Techniques

Established techniques and tricks can contribute to task and time thinking, **or** patch deficiencies, **or** spoil the vision (since any pattern may conditionally become an antipattern).

## Caching

The most obvious and simplest technique to add. Only the growing cache may be a concern, but its size can be dramatically reduced when big parts are "hashed" and stored only once (the floating window method to help).
Along with easy-to-apply <samp><b>FIFO</b></samp>.

## Laziness (not of developers only)

Since the olden days, programmers have deferred the initialization/calculation of fewer or more "heavy" entities. This allows to **a)**&nbsp;load the stuff on&nbsp;demand only (eco-friendly), **b)**&nbsp;spread resource peaks, **c)**&nbsp;split suspense (<ins>which nevertheless remains</ins>).

<details><summary><ins>&nbsp;In <b>C#</b> you can do it either with <code>Lazy<...></code> or custom snippet like this:&nbsp;</ins></summary>
&nbsp;
  
  ```csharp
public BigAndHeavy Ram => _ram ?? LoadAndHit();
private BigAndHeavy? _ram;
  ```
\_______________
</details>

This technique looks attractive when <mark>$`(performance/hit)*probability`$</mark> is too low. Being advanced, we may think of making an on-the-fly reevaluation of this formula to unleash the lazy, which implies a smart realization of the next technique - _preloading_.

### Examples?

Consider custom number sequences (relying on previous values). The first must be easy to calculate unconditionally, while attributing as lazy the next ones when it gets harder to compute. 
When the computer is idle, the next _lazy_ number gets calculated to have a reasonable supply (say, of a hundred in sequence).

## Preloading: praise and critique

The power and storage even of home tablets are multiprocessor<sup>⚛️</sup>, multicore, excessive, and mostly idle<sup>:video_game:</sup>, while platforms like .NET, JVM, or browser engines, and any OS ensure the smooth background running of countless processes and threads.

The story has much reverted the _Lazy Loading_ - it's not crucial to delay tasks but to complete them as much as possible earlier and in the background, and then smoothly render results on demand.

It doesn't matter if you "pre-load" a dozen things, of which only one will be selected by the user (e.g., a next wizard page dependent on differing paths). 
Compare this to maintaining gross warehouses for a single well-founded purpose: to deliver goods within a day on customer orders.

&nbsp; &nbsp; <sup>⚛️</sup> <sub> There are at least three: main, math, and video.</sub>\
&nbsp; &nbsp; <sup>:video_game:</sup> <sub>Assumed: usual office, browsers, business applications, and dev environments (not high-performance servers, top games, video processing, or mining).</sub>

**Eco-harmful?** Let's consider it when most blockchain mining farms are shut down.

## Streaming

Processing sync/async streams is still a fresh technique. Here, it's enough to refer to its [foundation](https://github.com/ReactiveX)<sup>:octocat:</sup>.

___________\
🌖 2024 .. 2025 .. <b>&Beta;</b>ytesHausMeister 🎼D♭

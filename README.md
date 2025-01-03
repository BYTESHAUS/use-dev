<table><tr valign="top"><td>
<!--      O R G    --!>
◾ <b>O&thinsp;R&thinsp;G</b><br />
|- <b>Frames, guidelines</b>&nbsp;📖&thinsp;<a href="README+/frames"><i>Intro</i></a><br />
|-- <a href="README+/frames/README+/reinforced_inheretance.md">Reinforced inheritance</a><br />
|-- <a href="README+/frames/README+/calls_on_null.md">Calls on null</a><br />
|- <b>Patterns</b><br />
|-- <a href="/README+/techniques/README+/circuitry/README.md">Circuitry</a><br />
|-- <a href="/README+/techniques/README+/builders/README.md">Builders</a><br />
|-- M&thinsp;V&thinsp;V&thinsp;M<br />
|--- <a href="README+/decisions/README+/mvvm/mvvm-notification_orchestration.md">Notificaton orchestration</a><br />
|--- <a href="README+/decisions/README+/mvvm/mvvm-vmodel_cohesion.md">Model-ViewModel cohesion</a><br />
|- <b>Templates</b><br />
|-- <a href="README+/decisions/README+/thins_in_tasks/README.md">Tasks as models</a><br />
<br /><!--      C L A Y    --!>
◾ <b>C&thinsp;L&thinsp;A&thinsp;Y</b><br />
|- Exception wrappers &nbsp;<a href="src/TuttiFrutti/ExtensionsTests/Exceptions"><i>tests</i></a>🧪<br />
|- Extensions/shortcuts<br />
|- 🚧Models<br />
|- Motley heap <a href="src/TuttiFrutti/AbcStructTests/Heaps"><i>tests</i></a>🧪<br />
|- <b>WPF</b><br />
|-- <a href="README+/snippets/wpf/bool2viz_improved.md">Bool-Vis. converter</a><sup>improved</sup><br />
<br /><!--               T E S T I N G -->
◾ <b>T<samp>ESTING</samp></b>&nbsp;📖&thinsp;<a href="README+/tests"><i>Intro</i></a><br />
|--- <a href="README+/tests/README+/prog_tests-cut_feeds.md">Cutting the feed expansion</a><br />
|--- <a href="README+/tests/README+/unit_test-gradual_assert.md">Gradual assert</a><br />
|--- <a href="README+/tests/README+/val_tests-tolerance.md">Finer tolerance</a><br />
<br/><!--           PARTS -->
◾ <b>P&thinsp;A&thinsp;R&thinsp;T&thinsp;S</b>&thinsp;📦<br />
|- <a href="arts/_ext/README+/ISie.md"><b>I&thinsp;S&thinsp;i&thinsp;e</b></a> extensions<br />
|- <a href="README+/parts/AbcChrono">Chrono ABC</a><br />
|- <b>Funcware</b><br />
|-- Conversion&nbsp;<a href="src/TuttiFrutti/ExtensionsTests/Exceptions"><i>tests</i></a>🧪</br />
|- 🐝<a name="UVal" href="README+/parts/MultifacetVal"><b>Multifacet value</b></a> (Π-Val)<br />
|- 🚧<a href="README+/parts/Rvrs">Undo/Redo</a> (Reversible)<br />
</td><td> 
  <table><tr>
    <td>
      <a href="README+/parts/_ext/README+/ISie.md"><img src="README+/_rsc/img/_nav/tiles/ISieCircuitry_bw-200px.jpg" alt="&nbsp;&nbsp;I&thinsp;S&thinsp;i&thinsp;e&nbsp;&nbsp;extenstions"/></a>
      <br /><div align="center"><h4><a href="README+/parts/_ext/README+/ISie.md">EXTENSIONS</a></h4></div>
     </td><td>
      <a href="README+/parts/AbcChrono/README.md"><img src="README+/_rsc/img/_nav/tiles/Chrono_bw-200px.jpg" alt="&nbsp;Chronology lib"/></a>
      <br /><div align="center"><h4><a href="README+/parts/AbcChrono/README.md">CHRONO ABC</a></h4></div>
    </td><td>
      <a href="README+/parts/MultifacetVal/README.md"><img src="README+/_rsc/img/_nav/tiles/U-Val_200px.jpg" alt="&nbsp;Multifacet value"/></a>
      <br /><div align="center"><h4>✒️&thinsp;<a href="README+/parts/MultifacetVal/README.md">MULTIFACET VALUE</a>&thinsp;🐝</h4></div>
    </td>
                                                      </tr><tr></tr><tr>
    <td>
      <a href="README+/parts/Rvrs/README.md"><img src="README+/_rsc/img/_nav/tiles/UndoRedo_bw_200px.jpg" alt="&nbsp;Undo-Redo"/></a>
      <br /><div align="center"><h4>🚧&thinsp;<a href="README+/parts/Rvrs/README.md">REVERSIBLE</a>&thinsp;🚧</h4></div>
    </td><td>
      <a href="README+/decisions/README+/think_in_tasks/README.md"><img src="README+/_rsc/img/_nav/tiles/TaskAsModel_bw-200px.jpg" alt="&nbsp;Value as promise"/></a>
        <br /><div align="center"><h4>🐝&thinsp;<a href="/README+/decisions/README+/think_in_tasks/README.md">THINKING in TASKS</a>&thinsp;⏰</h4></div>
    </td>
    <td>
      <a href="https://github.com/Kyriosity/read-write/blob/main/README+/pencraft/README+/essays/README.md"><img src="README+/_rsc/img/_nav/tiles/read-write_200px.jpg" alt="&nbsp;READ-WRITE repo" title="&nbsp;Collection in the read-write repository"/></a>
        <br /><div align="center"><h4>⬅️&thinsp;<a href="https://github.com/Kyriosity/read-write/blob/main/README+/pencraft/README+/essays/README.md">E&thinsp;S&thinsp;S&thinsp;A&thinsp;Y&thinsp;S</a></h4></div>
    </td>
  </tr></table>
  
```mermaid
graph TB
    sq[Funcware] --> MFC{<b>Multi<br />Facet<br />Value</b>}

    e --> od3>Undo-Redo<br>Reversible]

    e((Clay / Patterns)) --> f(<mg src="README+/_rsc/img/_nav/tiles/Chrono_bw-200px.jpg"></img>)

     classDef subst fill:#9f6,stroke:#fff,stroke-width:2px;
     classDef parts fill:#f96,stroke:#333,stroke-width:4px;
     class sq,e subst
     class MFC,Rvrs parts

```

</td></tr></table>

\___________\
<samp>INSTALLATION</samp>: Clone, copy, download `src`, and open the solution in Microsoft Visual Studio

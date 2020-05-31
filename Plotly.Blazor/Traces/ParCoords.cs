/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.ParCoordsLib;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The ParCoords class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class ParCoords : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum Type { get; } = TraceTypeEnum.ParCoords;

        /// <summary>
        ///     Determines whether or not this trace is visible. If *legendonly*, the trace
        ///     is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.ParCoordsLib.VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string UId { get; set;} 

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public IList<object> Ids { get; set;} 

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, *scatter* traces also appends customdata
        ///     items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public IList<object> CustomData { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace `name`, graph, axis
        ///     and colorbar `title.text`, annotation `text` `rangeselector`, `updatemenues`
        ///     and `sliders` `label` text all support `meta`. To access the trace `meta`
        ///     values in an attribute in the same trace, simply use `%{meta[i]}` where
        ///     `i` is the index or key of the `meta` item in question. To access trace
        ///     `meta` in layout attributes, use `%{data[n[.meta[i]}` where `i` is the index
        ///     or key of the `meta` and `n` is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object Meta { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.ParCoordsLib.Stream Stream { get; set;} 

        /// <summary>
        ///     Gets or sets the Transforms.
        /// </summary>
        [JsonPropertyName(@"transforms")]
        [JsonConverter(typeof(PolymorphicConverter))]
        public ITransform Transforms { get; set;} 

        /// <summary>
        ///     Controls persistence of some user-driven changes to the trace: `constraintrange`
        ///     in `parcoords` traces, as well as some `editable: true` modifications such
        ///     as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that
        ///     other user-driven trace attribute changes are controlled by `layout` attributes:
        ///     `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints`
        ///     is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible
        ///     with `config: {editable: true}`) is controlled by `layout.editrevision`.
        ///     Trace changes are tracked by `uid`, which only falls back on trace index
        ///     if no `uid` is provided. So if your app can add/remove traces before the
        ///     end of the `data` array, such that the same trace has a different index,
        ///     you can still preserve user-driven changes if you give each trace a `uid`
        ///     that stays with it as it moves.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Plotly.Blazor.Traces.ParCoordsLib.Domain Domain { get; set;} 

        /// <summary>
        ///     Sets the angle of the labels with respect to the horizontal. For example,
        ///     a `tickangle` of -90 draws the labels vertically. Tilted labels with *labelangle*
        ///     may be positioned better inside margins when `labelposition` is set to *bottom*.
        /// </summary>
        [JsonPropertyName(@"labelangle")]
        public float? LabelAngle { get; set;} 

        /// <summary>
        ///     Specifies the location of the `label`. *top* positions labels above, next
        ///     to the title *bottom* positions labels below the graph Tilted labels with
        ///     *labelangle* may be positioned better inside margins when `labelposition`
        ///     is set to *bottom*.
        /// </summary>
        [JsonPropertyName(@"labelside")]
        public Plotly.Blazor.Traces.ParCoordsLib.LabelSideEnum? LabelSide { get; set;} 

        /// <summary>
        ///     Sets the font for the `dimension` labels.
        /// </summary>
        [JsonPropertyName(@"labelfont")]
        public Plotly.Blazor.Traces.ParCoordsLib.LabelFont LabelFont { get; set;} 

        /// <summary>
        ///     Sets the font for the `dimension` tick values.
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public Plotly.Blazor.Traces.ParCoordsLib.TickFont TickFont { get; set;} 

        /// <summary>
        ///     Sets the font for the `dimension` range values.
        /// </summary>
        [JsonPropertyName(@"rangefont")]
        public Plotly.Blazor.Traces.ParCoordsLib.RangeFont RangeFont { get; set;} 

        /// <summary>
        ///     Gets or sets the Dimensions.
        /// </summary>
        [JsonPropertyName(@"dimensions")]
        public IList<Plotly.Blazor.Traces.ParCoordsLib.Dimension> Dimensions { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.ParCoordsLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ids .
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string IdsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set;} 

    }
}
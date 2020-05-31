/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.TreeMapLib;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The TreeMap class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class TreeMap : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum Type { get; } = TraceTypeEnum.TreeMap;

        /// <summary>
        ///     Determines whether or not this trace is visible. If *legendonly*, the trace
        ///     is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.TreeMapLib.VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

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
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.TreeMapLib.HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.TreeMapLib.Stream Stream { get; set;} 

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
        ///     Sets the labels of each of the sectors.
        /// </summary>
        [JsonPropertyName(@"labels")]
        public IList<object> Labels { get; set;} 

        /// <summary>
        ///     Sets the parent sectors for each of the sectors. Empty string items '' are
        ///     understood to reference the root node in the hierarchy. If `ids` is filled,
        ///     `parents` items are understood to be "ids" themselves. When `ids` is not
        ///     set, plotly attempts to find matching items in `labels`, but beware they
        ///     must be unique.
        /// </summary>
        [JsonPropertyName(@"parents")]
        public IList<object> Parents { get; set;} 

        /// <summary>
        ///     Sets the values associated with each of the sectors. Use with `branchvalues`
        ///     to determine how the values are summed.
        /// </summary>
        [JsonPropertyName(@"values")]
        public IList<object> Values { get; set;} 

        /// <summary>
        ///     Determines how the items in `values` are summed. When set to *total*, items
        ///     in `values` are taken to be value of all its descendants. When set to *remainder*,
        ///     items in `values` corresponding to the root and the branches sectors are
        ///     taken to be the extra part not part of the sum of the values at their leaves.
        /// </summary>
        [JsonPropertyName(@"branchvalues")]
        public Plotly.Blazor.Traces.TreeMapLib.BranchValuesEnum? BranchValues { get; set;} 

        /// <summary>
        ///     Determines default for `values` when it is not provided, by inferring a
        ///     1 for each of the *leaves* and/or *branches*, otherwise 0.
        /// </summary>
        [JsonPropertyName(@"count")]
        public Plotly.Blazor.Traces.TreeMapLib.CountFlag? Count { get; set;} 

        /// <summary>
        ///     Sets the level from which this trace hierarchy is rendered. Set `level`
        ///     to `''` to start from the root node in the hierarchy. Must be an "id" if
        ///     `ids` is filled in, otherwise plotly attempts to find a matching item in
        ///     `labels`.
        /// </summary>
        [JsonPropertyName(@"level")]
        public object Level { get; set;} 

        /// <summary>
        ///     Sets the number of rendered sectors from any given `level`. Set `maxdepth`
        ///     to *-1* to render all the levels in the hierarchy.
        /// </summary>
        [JsonPropertyName(@"maxdepth")]
        public int? MaxDepth { get; set;} 

        /// <summary>
        ///     Gets or sets the Tiling.
        /// </summary>
        [JsonPropertyName(@"tiling")]
        public Plotly.Blazor.Traces.TreeMapLib.Tiling Tiling { get; set;} 

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Plotly.Blazor.Traces.TreeMapLib.Marker Marker { get; set;} 

        /// <summary>
        ///     Gets or sets the PathBar.
        /// </summary>
        [JsonPropertyName(@"pathbar")]
        public Plotly.Blazor.Traces.TreeMapLib.PathBar PathBar { get; set;} 

        /// <summary>
        ///     Sets text elements associated with each sector. If trace `textinfo` contains
        ///     a *text* flag, these elements will be seen on the chart. If trace `hoverinfo`
        ///     contains a *text* flag and *hovertext* is not set, these elements will be
        ///     seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public IList<object> Text { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on the graph.
        /// </summary>
        [JsonPropertyName(@"textinfo")]
        public Plotly.Blazor.Traces.TreeMapLib.TextInfoFlag? TextInfo { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information text that appear on points.
        ///     Note that this will override `textinfo`. Variables are inserted using %{variable},
        ///     for example "y: %{y}". Numbers are formatted using d3-format's syntax %{variable:d3-format},
        ///     for example "Price: %{y:$.2f}". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format's
        ///     syntax %{variable|d3-time-format}, for example "Day: %{2019-01-01|%A}".
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. Every attributes that can be
        ///     specified per-point (the ones that are `arrayOk: true`) are available. variables
        ///     `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`,
        ///     `label` and `value`.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        public string TextTemplate { get; set;} 

        /// <summary>
        ///     Sets hover text elements associated with each sector. If a single string,
        ///     the same string appears for all data points. If an array of string, the
        ///     items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo`
        ///     must contain a *text* flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If `none` or `skip`
        ///     are set, no information is displayed upon hovering. But, if `none` is set,
        ///     click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.TreeMapLib.HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override `hoverinfo`. Variables are inserted using
        ///     %{variable}, for example "y: %{y}". Numbers are formatted using d3-format's
        ///     syntax %{variable:d3-format}, for example "Price: %{y:$.2f}". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format's
        ///     syntax %{variable|d3-time-format}, for example "Day: %{2019-01-01|%A}".
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in `hovertemplate`
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are `arrayOk: true`) are available. variables `currentPath`, `root`,
        ///     `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained
        ///     in tag `<extra>` is displayed in the secondary box, for example "<extra>{fullData.name}</extra>".
        ///     To hide the secondary box completely, use an empty tag `<extra></extra>`.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

        /// <summary>
        ///     Sets the font used for `textinfo`.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public Plotly.Blazor.Traces.TreeMapLib.TextFont TextFont { get; set;} 

        /// <summary>
        ///     Sets the font used for `textinfo` lying inside the sector.
        /// </summary>
        [JsonPropertyName(@"insidetextfont")]
        public Plotly.Blazor.Traces.TreeMapLib.InsideTextFont InsideTextFont { get; set;} 

        /// <summary>
        ///     Sets the font used for `textinfo` lying outside the sector. This option
        ///     refers to the root of the hierarchy presented on top left corner of a treemap
        ///     graph. Please note that if a hierarchy has multiple root nodes, this option
        ///     won't have any effect and `insidetextfont` would be used.
        /// </summary>
        [JsonPropertyName(@"outsidetextfont")]
        public Plotly.Blazor.Traces.TreeMapLib.OutsideTextFont OutsideTextFont { get; set;} 

        /// <summary>
        ///     Sets the positions of the `text` elements.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public Plotly.Blazor.Traces.TreeMapLib.TextPositionEnum? TextPosition { get; set;} 

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Plotly.Blazor.Traces.TreeMapLib.Domain Domain { get; set;} 

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

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  labels .
        /// </summary>
        [JsonPropertyName(@"labelssrc")]
        public string LabelsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  parents .
        /// </summary>
        [JsonPropertyName(@"parentssrc")]
        public string ParentsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  values .
        /// </summary>
        [JsonPropertyName(@"valuessrc")]
        public string ValuesSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  texttemplate .
        /// </summary>
        [JsonPropertyName(@"texttemplatesrc")]
        public string TextTemplateSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

    }
}
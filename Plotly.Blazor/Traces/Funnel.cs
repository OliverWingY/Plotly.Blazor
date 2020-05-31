/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.FunnelLib;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The Funnel class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Funnel : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum Type { get; } = TraceTypeEnum.Funnel;

        /// <summary>
        ///     Determines whether or not this trace is visible. If *legendonly*, the trace
        ///     is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.FunnelLib.VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set;} 

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
        ///     Array containing integer indices of selected points. Has an effect only
        ///     for traces that support selections. Note that an empty array means an empty
        ///     selection where the `unselected` are turned on for all points, whereas,
        ///     any other non-array values means no selection all where the `selected` and
        ///     `unselected` styles have no effect.
        /// </summary>
        [JsonPropertyName(@"selectedpoints")]
        public object SelectedPoints { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.FunnelLib.HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.FunnelLib.Stream Stream { get; set;} 

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
        ///     Sets the x coordinates.
        /// </summary>
        [JsonPropertyName(@"x")]
        public IList<object> X { get; set;} 

        /// <summary>
        ///     Alternate to `x`. Builds a linear space of x coordinates. Use with `dx`
        ///     where `x0` is the starting coordinate and `dx` the step.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set;} 

        /// <summary>
        ///     Sets the x coordinate step. See `x0` for more info.
        /// </summary>
        [JsonPropertyName(@"dx")]
        public float? DX { get; set;} 

        /// <summary>
        ///     Sets the y coordinates.
        /// </summary>
        [JsonPropertyName(@"y")]
        public IList<object> Y { get; set;} 

        /// <summary>
        ///     Alternate to `y`. Builds a linear space of y coordinates. Use with `dy`
        ///     where `y0` is the starting coordinate and `dy` the step.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set;} 

        /// <summary>
        ///     Sets the y coordinate step. See `y0` for more info.
        /// </summary>
        [JsonPropertyName(@"dy")]
        public float? Dy { get; set;} 

        /// <summary>
        ///     Sets hover text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace's (x,y) coordinates. To
        ///     be seen, trace `hoverinfo` must contain a *text* flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

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
        ///     that are `arrayOk: true`) are available. variables `percentInitial`, `percentPrevious`
        ///     and `percentTotal`. Anything contained in tag `<extra>` is displayed in
        ///     the secondary box, for example "<extra>{fullData.name}</extra>". To hide
        ///     the secondary box completely, use an empty tag `<extra></extra>`.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If `none` or `skip`
        ///     are set, no information is displayed upon hovering. But, if `none` is set,
        ///     click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.FunnelLib.HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on the graph. In the case of having
        ///     multiple funnels, percentages & totals are computed separately (per trace).
        /// </summary>
        [JsonPropertyName(@"textinfo")]
        public Plotly.Blazor.Traces.FunnelLib.TextInfoFlag? TextInfo { get; set;} 

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
        ///     `percentInitial`, `percentPrevious`, `percentTotal`, `label` and `value`.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        public string TextTemplate { get; set;} 

        /// <summary>
        ///     Sets text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace's (x,y) coordinates. If
        ///     trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these
        ///     elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Specifies the location of the `text`. *inside* positions `text` inside,
        ///     next to the bar end (rotated and scaled if needed). *outside* positions
        ///     `text` outside, next to the bar end (scaled if needed), unless there is
        ///     another bar stacked on this one, then the text gets pushed inside. *auto*
        ///     tries to position `text` inside the bar, but if the bar is too small and
        ///     no bar is stacked on this one the text is moved outside.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public Plotly.Blazor.Traces.FunnelLib.TextPositionEnum? TextPosition { get; set;} 

        /// <summary>
        ///     Determines if texts are kept at center or start/end points in `textposition`
        ///     *inside* mode.
        /// </summary>
        [JsonPropertyName(@"insidetextanchor")]
        public Plotly.Blazor.Traces.FunnelLib.InsideTextAnchorEnum? InsideTextAnchor { get; set;} 

        /// <summary>
        ///     Sets the angle of the tick labels with respect to the bar. For example,
        ///     a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts
        ///     may automatically be rotated to fit with the maximum size in bars.
        /// </summary>
        [JsonPropertyName(@"textangle")]
        public float? TextAngle { get; set;} 

        /// <summary>
        ///     Sets the font used for `text`.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public Plotly.Blazor.Traces.FunnelLib.TextFont TextFont { get; set;} 

        /// <summary>
        ///     Sets the font used for `text` lying inside the bar.
        /// </summary>
        [JsonPropertyName(@"insidetextfont")]
        public Plotly.Blazor.Traces.FunnelLib.InsideTextFont InsideTextFont { get; set;} 

        /// <summary>
        ///     Sets the font used for `text` lying outside the bar.
        /// </summary>
        [JsonPropertyName(@"outsidetextfont")]
        public Plotly.Blazor.Traces.FunnelLib.OutsideTextFont OutsideTextFont { get; set;} 

        /// <summary>
        ///     Constrain the size of text inside or outside a bar to be no larger than
        ///     the bar itself.
        /// </summary>
        [JsonPropertyName(@"constraintext")]
        public Plotly.Blazor.Traces.FunnelLib.ConstrainTextEnum? ConstrainText { get; set;} 

        /// <summary>
        ///     Determines whether the text nodes are clipped about the subplot axes. To
        ///     show the text nodes above axis lines and tick labels, make sure to set `xaxis.layer`
        ///     and `yaxis.layer` to *below traces*.
        /// </summary>
        [JsonPropertyName(@"cliponaxis")]
        public bool? ClipOnAxis { get; set;} 

        /// <summary>
        ///     Sets the orientation of the funnels. With *v* (*h*), the value of the each
        ///     bar spans along the vertical (horizontal). By default funnels are tend to
        ///     be oriented horizontally; unless only *y* array is presented or orientation
        ///     is set to *v*. Also regarding graphs including only 'horizontal' funnels,
        ///     *autorange* on the *y-axis* are set to *reversed*.
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public Plotly.Blazor.Traces.FunnelLib.OrientationEnum? Orientation { get; set;} 

        /// <summary>
        ///     Shifts the position where the bar is drawn (in position axis units). In
        ///     *group* barmode, traces that set *offset* will be excluded and drawn in
        ///     *overlay* mode instead.
        /// </summary>
        [JsonPropertyName(@"offset")]
        public float? Offset { get; set;} 

        /// <summary>
        ///     Sets the bar width (in position axis units).
        /// </summary>
        [JsonPropertyName(@"width")]
        public float? Width { get; set;} 

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Plotly.Blazor.Traces.FunnelLib.Marker Marker { get; set;} 

        /// <summary>
        ///     Gets or sets the Connector.
        /// </summary>
        [JsonPropertyName(@"connector")]
        public Plotly.Blazor.Traces.FunnelLib.Connector Connector { get; set;} 

        /// <summary>
        ///     Set several traces linked to the same position axis or matching axes to
        ///     the same offsetgroup where bars of the same position coordinate will line
        ///     up.
        /// </summary>
        [JsonPropertyName(@"offsetgroup")]
        public string OffsetGroup { get; set;} 

        /// <summary>
        ///     Set several traces linked to the same position axis or matching axes to
        ///     the same alignmentgroup. This controls whether bars compute their positional
        ///     range dependently or independently.
        /// </summary>
        [JsonPropertyName(@"alignmentgroup")]
        public string AlignmentGroup { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace's x coordinates and a 2D cartesian x
        ///     axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`.
        ///     If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public string XAxis { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace's y coordinates and a 2D cartesian y
        ///     axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`.
        ///     If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public string YAxis { get; set;} 

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
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  texttemplate .
        /// </summary>
        [JsonPropertyName(@"texttemplatesrc")]
        public string TextTemplateSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  textposition .
        /// </summary>
        [JsonPropertyName(@"textpositionsrc")]
        public string TextPositionSrc { get; set;} 

    }
}
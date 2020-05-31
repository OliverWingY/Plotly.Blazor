/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The Sunburst class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Sunburst : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum Type { get; } = TraceTypeEnum.Sunburst;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.SunburstLib.VisibleEnum? Visible { get; set;} 

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
        ///     click and selection events. Note that, <c>scatter</c> traces also appends
        ///     customdata items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public IList<object> CustomData { get; set;} 

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object Meta { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.SunburstLib.HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.SunburstLib.Stream Stream { get; set;} 

        /// <summary>
        ///     Gets or sets the Transforms.
        /// </summary>
        [JsonPropertyName(@"transforms")]
        public ITransform Transforms { get; set;} 

        /// <summary>
        ///     Controls persistence of some user-driven changes to the trace: <c>constraintrange</c>
        ///     in <c>parcoords</c> traces, as well as some &#39;editable: true&#39; modifications
        ///     such as <c>name</c> and <c>colorbar.title</c>. Defaults to <c>layout.uirevision</c>.
        ///     Note that other user-driven trace attribute changes are controlled by <c>layout</c>
        ///     attributes: <c>trace.visible</c> is controlled by <c>layout.legend.uirevision</c>,
        ///     <c>selectedpoints</c> is controlled by <c>layout.selectionrevision</c>,
        ///     and <c>colorbar.(x|y)</c> (accessible with &#39;config: {editable: true}&#39;)
        ///     is controlled by <c>layout.editrevision</c>. Trace changes are tracked by
        ///     <c>uid</c>, which only falls back on trace index if no <c>uid</c> is provided.
        ///     So if your app can add/remove traces before the end of the <c>data</c> array,
        ///     such that the same trace has a different index, you can still preserve user-driven
        ///     changes if you give each trace a <c>uid</c> that stays with it as it moves.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Sets the labels of each of the sectors.
        /// </summary>
        [JsonPropertyName(@"labels")]
        public IList<object> Labels { get; set;} 

        /// <summary>
        ///     Sets the parent sectors for each of the sectors. Empty string items &#39;&#39;
        ///     are understood to reference the root node in the hierarchy. If <c>ids</c>
        ///     is filled, <c>parents</c> items are understood to be <c>ids</c> themselves.
        ///     When <c>ids</c> is not set, plotly attempts to find matching items in <c>labels</c>,
        ///     but beware they must be unique.
        /// </summary>
        [JsonPropertyName(@"parents")]
        public IList<object> Parents { get; set;} 

        /// <summary>
        ///     Sets the values associated with each of the sectors. Use with <c>branchvalues</c>
        ///     to determine how the values are summed.
        /// </summary>
        [JsonPropertyName(@"values")]
        public IList<object> Values { get; set;} 

        /// <summary>
        ///     Determines how the items in <c>values</c> are summed. When set to <c>total</c>,
        ///     items in <c>values</c> are taken to be value of all its descendants. When
        ///     set to <c>remainder</c>, items in <c>values</c> corresponding to the root
        ///     and the branches sectors are taken to be the extra part not part of the
        ///     sum of the values at their leaves.
        /// </summary>
        [JsonPropertyName(@"branchvalues")]
        public Plotly.Blazor.Traces.SunburstLib.BranchValuesEnum? BranchValues { get; set;} 

        /// <summary>
        ///     Determines default for <c>values</c> when it is not provided, by inferring
        ///     a 1 for each of the <c>leaves</c> and/or <c>branches</c>, otherwise 0.
        /// </summary>
        [JsonPropertyName(@"count")]
        public Plotly.Blazor.Traces.SunburstLib.CountFlag? Count { get; set;} 

        /// <summary>
        ///     Sets the level from which this trace hierarchy is rendered. Set <c>level</c>
        ///     to <c>&#39;&#39;</c> to start from the root node in the hierarchy. Must
        ///     be an <c>id</c> if <c>ids</c> is filled in, otherwise plotly attempts to
        ///     find a matching item in <c>labels</c>.
        /// </summary>
        [JsonPropertyName(@"level")]
        public object Level { get; set;} 

        /// <summary>
        ///     Sets the number of rendered sectors from any given <c>level</c>. Set <c>maxdepth</c>
        ///     to <c>-1</c> to render all the levels in the hierarchy.
        /// </summary>
        [JsonPropertyName(@"maxdepth")]
        public int? MaxDepth { get; set;} 

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Plotly.Blazor.Traces.SunburstLib.Marker Marker { get; set;} 

        /// <summary>
        ///     Gets or sets the Leaf.
        /// </summary>
        [JsonPropertyName(@"leaf")]
        public Plotly.Blazor.Traces.SunburstLib.Leaf Leaf { get; set;} 

        /// <summary>
        ///     Sets text elements associated with each sector. If trace <c>textinfo</c>
        ///     contains a <c>text</c> flag, these elements will be seen on the chart. If
        ///     trace <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c>
        ///     is not set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public IList<object> Text { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on the graph.
        /// </summary>
        [JsonPropertyName(@"textinfo")]
        public Plotly.Blazor.Traces.SunburstLib.TextInfoFlag? TextInfo { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information text that appear on points.
        ///     Note that this will override <c>textinfo</c>. Variables are inserted using
        ///     %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted using
        ///     d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price: %{y:$.2f}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. Every attributes that can be
        ///     specified per-point (the ones that are &#39;arrayOk: true&#39;) are available.
        ///     variables <c>currentPath</c>, <c>root</c>, <c>entry</c>, <c>percentRoot</c>,
        ///     <c>percentEntry</c>, <c>percentParent</c>, <c>label</c> and <c>value</c>.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        public string TextTemplate { get; set;} 

        /// <summary>
        ///     Sets hover text elements associated with each sector. If a single string,
        ///     the same string appears for all data points. If an array of string, the
        ///     items are mapped in order of this trace&#39;s sectors. To be seen, trace
        ///     <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.SunburstLib.HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override <c>hoverinfo</c>. Variables are inserted
        ///     using %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted
        ///     using d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price:
        ///     %{y:$.2f}&quot;. https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in <c>hovertemplate</c>
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>currentPath</c>,
        ///     <c>root</c>, <c>entry</c>, <c>percentRoot</c>, <c>percentEntry</c> and <c>percentParent</c>.
        ///     Anything contained in tag <c>&lt;extra&gt;</c> is displayed in the secondary
        ///     box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide
        ///     the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

        /// <summary>
        ///     Sets the font used for <c>textinfo</c>.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public Plotly.Blazor.Traces.SunburstLib.TextFont TextFont { get; set;} 

        /// <summary>
        ///     Controls the orientation of the text inside chart sectors. When set to <c>auto</c>,
        ///     text may be oriented in any direction in order to be as big as possible
        ///     in the middle of a sector. The <c>horizontal</c> option orients text to
        ///     be parallel with the bottom of the chart, and may make text smaller in order
        ///     to achieve that goal. The <c>radial</c> option orients text along the radius
        ///     of the sector. The <c>tangential</c> option orients text perpendicular to
        ///     the radius of the sector.
        /// </summary>
        [JsonPropertyName(@"insidetextorientation")]
        public Plotly.Blazor.Traces.SunburstLib.InsideTextOrientationEnum? InsideTextOrientation { get; set;} 

        /// <summary>
        ///     Sets the font used for <c>textinfo</c> lying inside the sector.
        /// </summary>
        [JsonPropertyName(@"insidetextfont")]
        public Plotly.Blazor.Traces.SunburstLib.InsideTextFont InsideTextFont { get; set;} 

        /// <summary>
        ///     Sets the font used for <c>textinfo</c> lying outside the sector. This option
        ///     refers to the root of the hierarchy presented at the center of a sunburst
        ///     graph. Please note that if a hierarchy has multiple root nodes, this option
        ///     won&#39;t have any effect and <c>insidetextfont</c> would be used.
        /// </summary>
        [JsonPropertyName(@"outsidetextfont")]
        public Plotly.Blazor.Traces.SunburstLib.OutsideTextFont OutsideTextFont { get; set;} 

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Plotly.Blazor.Traces.SunburstLib.Domain Domain { get; set;} 

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
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces.SankeyLib
{
    /// <summary>
    ///     The Link class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Link 
    {
        /// <summary>
        ///     The shown name of the link.
        /// </summary>
        [JsonPropertyName(@"label")]
        public IList<object> Label { get; set;} 

        /// <summary>
        ///     Sets the <c>link</c> color. It can be a single value, or an array for specifying
        ///     color for each <c>link</c>. If <c>link.color</c> is omitted, then by default,
        ///     a translucent grey link will be used.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Assigns extra data to each link.
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public IList<object> CustomData { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.SankeyLib.LinkLib.Line Line { get; set;} 

        /// <summary>
        ///     An integer number &#39;[0..nodes.length - 1]&#39; that represents the source
        ///     node.
        /// </summary>
        [JsonPropertyName(@"source")]
        public IList<object> Source { get; set;} 

        /// <summary>
        ///     An integer number &#39;[0..nodes.length - 1]&#39; that represents the target
        ///     node.
        /// </summary>
        [JsonPropertyName(@"target")]
        public IList<object> Target { get; set;} 

        /// <summary>
        ///     A numeric value representing the flow volume value.
        /// </summary>
        [JsonPropertyName(@"value")]
        public IList<object> Value { get; set;} 

        /// <summary>
        ///     Determines which trace information appear when hovering links. If <c>none</c>
        ///     or <c>skip</c> are set, no information is displayed upon hovering. But,
        ///     if <c>none</c> is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.SankeyLib.LinkLib.HoverInfoEnum? HoverInfo { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.SankeyLib.LinkLib.HoverLabel HoverLabel { get; set;} 

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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>value</c>
        ///     and <c>label</c>. Anything contained in tag <c>&lt;extra&gt;</c> is displayed
        ///     in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
        ///     To hide the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorScales.
        /// </summary>
        [JsonPropertyName(@"colorscales")]
        public IList<Plotly.Blazor.Traces.SankeyLib.LinkLib.ConcentrationScales> ColorScales { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  label .
        /// </summary>
        [JsonPropertyName(@"labelsrc")]
        public string LabelSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  source .
        /// </summary>
        [JsonPropertyName(@"sourcesrc")]
        public string SourceSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  target .
        /// </summary>
        [JsonPropertyName(@"targetsrc")]
        public string TargetSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  value .
        /// </summary>
        [JsonPropertyName(@"valuesrc")]
        public string ValueSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

    }
}
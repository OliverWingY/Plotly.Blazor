/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor.Traces
{
    /// <summary>
    ///     The HeatMapGl class.
    ///     Implements the <see cref="ITrace" />
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class HeatMapGl : ITrace
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum Type { get; } = TraceTypeEnum.HeatMapGl;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public Plotly.Blazor.Traces.HeatMapGlLib.VisibleEnum? Visible { get; set;} 

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
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public Plotly.Blazor.Traces.HeatMapGlLib.HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Plotly.Blazor.Traces.HeatMapGlLib.HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Plotly.Blazor.Traces.HeatMapGlLib.Stream Stream { get; set;} 

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
        ///     Sets the z data.
        /// </summary>
        [JsonPropertyName(@"z")]
        public IList<object> Z { get; set;} 

        /// <summary>
        ///     Sets the x coordinates.
        /// </summary>
        [JsonPropertyName(@"x")]
        public IList<object> X { get; set;} 

        /// <summary>
        ///     Alternate to <c>x</c>. Builds a linear space of x coordinates. Use with
        ///     <c>dx</c> where <c>x0</c> is the starting coordinate and <c>dx</c> the step.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set;} 

        /// <summary>
        ///     Sets the x coordinate step. See <c>x0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dx")]
        public float? DX { get; set;} 

        /// <summary>
        ///     Sets the y coordinates.
        /// </summary>
        [JsonPropertyName(@"y")]
        public IList<object> Y { get; set;} 

        /// <summary>
        ///     Alternate to <c>y</c>. Builds a linear space of y coordinates. Use with
        ///     <c>dy</c> where <c>y0</c> is the starting coordinate and <c>dy</c> the step.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set;} 

        /// <summary>
        ///     Sets the y coordinate step. See <c>y0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dy")]
        public float? Dy { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with each z value.
        /// </summary>
        [JsonPropertyName(@"text")]
        public IList<object> Text { get; set;} 

        /// <summary>
        ///     Transposes the z data.
        /// </summary>
        [JsonPropertyName(@"transpose")]
        public bool? Transpose { get; set;} 

        /// <summary>
        ///     If <c>array</c>, the heatmap&#39;s x coordinates are given by <c>x</c> (the
        ///     default behavior when <c>x</c> is provided). If <c>scaled</c>, the heatmap&#39;s
        ///     x coordinates are given by <c>x0</c> and <c>dx</c> (the default behavior
        ///     when <c>x</c> is not provided).
        /// </summary>
        [JsonPropertyName(@"xtype")]
        public Plotly.Blazor.Traces.HeatMapGlLib.XTypeEnum? XType { get; set;} 

        /// <summary>
        ///     If <c>array</c>, the heatmap&#39;s y coordinates are given by <c>y</c> (the
        ///     default behavior when <c>y</c> is provided) If <c>scaled</c>, the heatmap&#39;s
        ///     y coordinates are given by <c>y0</c> and <c>dy</c> (the default behavior
        ///     when <c>y</c> is not provided)
        /// </summary>
        [JsonPropertyName(@"ytype")]
        public Plotly.Blazor.Traces.HeatMapGlLib.YTypeEnum? YType { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>z</c>) or the bounds set in <c>zmin</c> and <c>zmax</c>
        ///      Defaults to <c>false</c> when <c>zmin</c> and <c>zmax</c> are set by the
        ///     user.
        /// </summary>
        [JsonPropertyName(@"zauto")]
        public bool? ZAuto { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmin")]
        public float? ZMin { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmax")]
        public float? ZMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>zmin</c> and/or <c>zmax</c>
        ///     to be equidistant to this point. Value should have the same units as in
        ///     <c>z</c>. Has no effect when <c>zauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"zmid")]
        public float? ZMid { get; set;} 

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>zmin</c> and
        ///     <c>zmax</c>. Alternatively, <c>colorscale</c> may be a palette name string
        ///     of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>colorscale</c>. In case <c>colorscale</c>
        ///     is unspecified or <c>autocolorscale</c> is true, the default  palette will
        ///     be chosen according to whether numbers in the <c>color</c> array are all
        ///     positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. If true, <c>zmin</c> will correspond
        ///     to the last color in the array and <c>zmax</c> will correspond to the first
        ///     color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public Plotly.Blazor.Traces.HeatMapGlLib.ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s x coordinates and a 2D cartesian
        ///     x axis. If <c>x</c> (the default value), the x coordinates refer to <c>layout.xaxis</c>.
        ///     If <c>x2</c>, the x coordinates refer to <c>layout.xaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public string XAxis { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s y coordinates and a 2D cartesian
        ///     y axis. If <c>y</c> (the default value), the y coordinates refer to <c>layout.yaxis</c>.
        ///     If <c>y2</c>, the y coordinates refer to <c>layout.yaxis2</c>, and so on.
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
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set;} 

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
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set;} 

    }
}
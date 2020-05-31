/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.Scatter3DLib
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Marker 
    {
        /// <summary>
        ///     Sets the marker symbol type.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public Plotly.Blazor.Traces.Scatter3DLib.MarkerLib.SymbolEnum? Symbol { get; set;} 

        /// <summary>
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        public float? Size { get; set;} 

        /// <summary>
        ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
        ///     the scale factor used to determine the rendered size of marker points. Use
        ///     with <c>sizemin</c> and <c>sizemode</c>.
        /// </summary>
        [JsonPropertyName(@"sizeref")]
        public float? SizeRef { get; set;} 

        /// <summary>
        ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
        ///     the minimum size (in px) of the rendered marker points.
        /// </summary>
        [JsonPropertyName(@"sizemin")]
        public float? SizeMin { get; set;} 

        /// <summary>
        ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
        ///     the rule for which the data in <c>size</c> is converted to pixels.
        /// </summary>
        [JsonPropertyName(@"sizemode")]
        public Plotly.Blazor.Traces.Scatter3DLib.MarkerLib.SizeModeEnum? SizeMode { get; set;} 

        /// <summary>
        ///     Sets the marker opacity. Note that the marker opacity for scatter3d traces
        ///     must be a scalar value for performance reasons. To set a blending opacity
        ///     value (i.e. which is not transparent), set <c>marker.color</c> to an rgba
        ///     color and use its alpha channel.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public Plotly.Blazor.Traces.Scatter3DLib.MarkerLib.ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.Scatter3DLib.MarkerLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets themarkercolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>marker.cmin</c> and <c>marker.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>marker.color</c>) or the bounds set in <c>marker.cmin</c>
        ///     and <c>marker.cmax</c>  Has an effect only if in <c>marker.color</c>is set
        ///     to a numerical array. Defaults to <c>false</c> when <c>marker.cmin</c> and
        ///     <c>marker.cmax</c> are set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Has an effect only if in <c>marker.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.color</c>
        ///     and if set, <c>marker.cmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public float? CMin { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Has an effect only if in <c>marker.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.color</c>
        ///     and if set, <c>marker.cmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public float? CMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>marker.cmin</c> and/or
        ///     <c>marker.cmax</c> to be equidistant to this point. Has an effect only if
        ///     in <c>marker.color</c>is set to a numerical array. Value should have the
        ///     same units as in <c>marker.color</c>. Has no effect when <c>marker.cauto</c>
        ///     is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public float? CMid { get; set;} 

        /// <summary>
        ///     Sets the colorscale. Has an effect only if in <c>marker.color</c>is set
        ///     to a numerical array. The colorscale must be an array containing arrays
        ///     mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color
        ///     string. At minimum, a mapping for the lowest (0) and highest (1) values
        ///     are required. For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>marker.cmin</c>
        ///     and <c>marker.cmax</c>. Alternatively, <c>colorscale</c> may be a palette
        ///     name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>marker.colorscale</c>. Has an
        ///     effect only if in <c>marker.color</c>is set to a numerical array. In case
        ///     <c>colorscale</c> is unspecified or <c>autocolorscale</c> is true, the default
        ///      palette will be chosen according to whether numbers in the <c>color</c>
        ///     array are all positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. Has an effect only if in <c>marker.color</c>is
        ///     set to a numerical array. If true, <c>marker.cmin</c> will correspond to
        ///     the last color in the array and <c>marker.cmax</c> will correspond to the
        ///     first color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace. Has an
        ///     effect only if in <c>marker.color</c>is set to a numerical array.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

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
        ///     Sets the source reference on Chart Studio Cloud for  symbol .
        /// </summary>
        [JsonPropertyName(@"symbolsrc")]
        public string SymbolSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  size .
        /// </summary>
        [JsonPropertyName(@"sizesrc")]
        public string SizeSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

    }
}
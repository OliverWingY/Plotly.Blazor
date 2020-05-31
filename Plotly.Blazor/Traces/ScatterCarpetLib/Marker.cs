/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.ScatterCarpetLib.MarkerLib;

namespace Plotly.Blazor.Traces.ScatterCarpetLib
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Marker 
    {
        /// <summary>
        ///     Sets the marker symbol type. Adding 100 is equivalent to appending *-open*
        ///     to a symbol name. Adding 200 is equivalent to appending *-dot* to a symbol
        ///     name. Adding 300 is equivalent to appending *-open-dot* or *dot-open* to
        ///     a symbol name.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public Plotly.Blazor.Traces.ScatterCarpetLib.MarkerLib.SymbolEnum? Symbol { get; set;} 

        /// <summary>
        ///     Sets the marker opacity.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Sets a maximum number of points to be drawn on the graph. *0* corresponds
        ///     to no limit.
        /// </summary>
        [JsonPropertyName(@"maxdisplayed")]
        public float? MaxDisplayed { get; set;} 

        /// <summary>
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        public float? Size { get; set;} 

        /// <summary>
        ///     Has an effect only if `marker.size` is set to a numerical array. Sets the
        ///     scale factor used to determine the rendered size of marker points. Use with
        ///     `sizemin` and `sizemode`.
        /// </summary>
        [JsonPropertyName(@"sizeref")]
        public float? SizeRef { get; set;} 

        /// <summary>
        ///     Has an effect only if `marker.size` is set to a numerical array. Sets the
        ///     minimum size (in px) of the rendered marker points.
        /// </summary>
        [JsonPropertyName(@"sizemin")]
        public float? SizeMin { get; set;} 

        /// <summary>
        ///     Has an effect only if `marker.size` is set to a numerical array. Sets the
        ///     rule for which the data in `size` is converted to pixels.
        /// </summary>
        [JsonPropertyName(@"sizemode")]
        public Plotly.Blazor.Traces.ScatterCarpetLib.MarkerLib.SizeModeEnum? SizeMode { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.ScatterCarpetLib.MarkerLib.Line Line { get; set;} 

        /// <summary>
        ///     Gets or sets the Gradient.
        /// </summary>
        [JsonPropertyName(@"gradient")]
        public Plotly.Blazor.Traces.ScatterCarpetLib.MarkerLib.Gradient Gradient { get; set;} 

        /// <summary>
        ///     Sets themarkercolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to `marker.cmin` and `marker.cmax` if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in `marker.color`) or the bounds set in `marker.cmin` and
        ///     `marker.cmax`  Has an effect only if in `marker.color`is set to a numerical
        ///     array. Defaults to `false` when `marker.cmin` and `marker.cmax` are set
        ///     by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Has an effect only if in `marker.color`is
        ///     set to a numerical array. Value should have the same units as in `marker.color`
        ///     and if set, `marker.cmax` must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public float? CMin { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Has an effect only if in `marker.color`is
        ///     set to a numerical array. Value should have the same units as in `marker.color`
        ///     and if set, `marker.cmin` must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public float? CMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling `marker.cmin` and/or `marker.cmax`
        ///     to be equidistant to this point. Has an effect only if in `marker.color`is
        ///     set to a numerical array. Value should have the same units as in `marker.color`.
        ///     Has no effect when `marker.cauto` is `false`.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public float? CMid { get; set;} 

        /// <summary>
        ///     Sets the colorscale. Has an effect only if in `marker.color`is set to a
        ///     numerical array. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the
        ///     bounds of the colorscale in color space, use`marker.cmin` and `marker.cmax`.
        ///     Alternatively, `colorscale` may be a palette name string of the following
        ///     list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Determines whether the colorscale is a default palette (`autocolorscale:
        ///     true`) or the palette determined by `marker.colorscale`. Has an effect only
        ///     if in `marker.color`is set to a numerical array. In case `colorscale` is
        ///     unspecified or `autocolorscale` is true, the default  palette will be chosen
        ///     according to whether numbers in the `color` array are all positive, all
        ///     negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. Has an effect only if in `marker.color`is
        ///     set to a numerical array. If true, `marker.cmin` will correspond to the
        ///     last color in the array and `marker.cmax` will correspond to the first color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace. Has an
        ///     effect only if in `marker.color`is set to a numerical array.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public Plotly.Blazor.Traces.ScatterCarpetLib.MarkerLib.ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these
        ///     shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`,
        ///     etc. Note that multiple color scales can be linked to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  symbol .
        /// </summary>
        [JsonPropertyName(@"symbolsrc")]
        public string SymbolSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  opacity .
        /// </summary>
        [JsonPropertyName(@"opacitysrc")]
        public string OpacitySrc { get; set;} 

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
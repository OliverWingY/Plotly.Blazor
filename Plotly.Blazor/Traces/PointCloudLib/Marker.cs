/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.PointCloudLib
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Marker 
    {
        /// <summary>
        ///     Sets the marker fill color. It accepts a specific color.If the color is
        ///     not fully opaque and there are hundreds of thousandsof points, it may cause
        ///     slower zooming and panning.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the marker opacity. The default value is <c>1</c> (fully opaque). If
        ///     the markers are not fully opaque and there are hundreds of thousands of
        ///     points, it may cause slower zooming and panning. Opacity fades the color
        ///     even if <c>blend</c> is left on <c>false</c> even if there is no translucency
        ///     effect in that case.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Determines if colors are blended together for a translucency effect in case
        ///     <c>opacity</c> is specified as a value less then <c>1</c>. Setting <c>blend</c>
        ///     to <c>true</c> reduces zoom/pan speed if used with large numbers of points.
        /// </summary>
        [JsonPropertyName(@"blend")]
        public bool? Blend { get; set;} 

        /// <summary>
        ///     Sets the minimum size (in px) of the rendered marker points, effective when
        ///     the <c>pointcloud</c> shows a million or more points.
        /// </summary>
        [JsonPropertyName(@"sizemin")]
        public float? SizeMin { get; set;} 

        /// <summary>
        ///     Sets the maximum size (in px) of the rendered marker points. Effective when
        ///     the <c>pointcloud</c> shows only few points.
        /// </summary>
        [JsonPropertyName(@"sizemax")]
        public float? SizeMax { get; set;} 

        /// <summary>
        ///     Gets or sets the Border.
        /// </summary>
        [JsonPropertyName(@"border")]
        public Plotly.Blazor.Traces.PointCloudLib.MarkerLib.Border Border { get; set;} 

    }
}
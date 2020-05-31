/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ViolinLib
{
    /// <summary>
    ///     The MeanLine class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class MeanLine 
    {
        /// <summary>
        ///     Determines if a line corresponding to the sample&#39;s mean is shown inside
        ///     the violins. If <c>box.visible</c> is turned on, the mean line is drawn
        ///     inside the inner box. Otherwise, the mean line is drawn from one side of
        ///     the violin to other.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the mean line color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the mean line width.
        /// </summary>
        [JsonPropertyName(@"width")]
        public float? Width { get; set;} 

    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The ColorScale class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class ColorScale 
    {
        /// <summary>
        ///     Sets the default sequential colorscale for positive values. Note that <c>autocolorscale</c>
        ///     must be true for this attribute to work.
        /// </summary>
        [JsonPropertyName(@"sequential")]
        public object Sequential { get; set;} 

        /// <summary>
        ///     Sets the default sequential colorscale for negative values. Note that <c>autocolorscale</c>
        ///     must be true for this attribute to work.
        /// </summary>
        [JsonPropertyName(@"sequentialminus")]
        public object SequentialMinus { get; set;} 

        /// <summary>
        ///     Sets the default diverging colorscale. Note that <c>autocolorscale</c> must
        ///     be true for this attribute to work.
        /// </summary>
        [JsonPropertyName(@"diverging")]
        public object Diverging { get; set;} 

    }
}
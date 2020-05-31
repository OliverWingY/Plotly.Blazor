/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.Scatter3DLib.ProjectionLib
{
    /// <summary>
    ///     The Z class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Z 
    {
        /// <summary>
        ///     Sets whether or not projections are shown along the z axis.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Sets the projection color.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public float? Opacity { get; set;} 

        /// <summary>
        ///     Sets the scale factor determining the size of the projection marker points.
        /// </summary>
        [JsonPropertyName(@"scale")]
        public float? Scale { get; set;} 

    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.ScatterTernaryLib
{
    /// <summary>
    ///     The Stream class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Stream 
    {
        /// <summary>
        ///     The stream id number links a data trace on a plot with a stream. See https://chart-studio.plotly.com/settings
        ///     for more details.
        /// </summary>
        [JsonPropertyName(@"token")]
        public string Token { get; set;} 

        /// <summary>
        ///     Sets the maximum number of points to keep on the plots from an incoming
        ///     stream. If <c>maxpoints</c> is set to <c>50</c>, only the newest 50 points
        ///     will be displayed on the plot.
        /// </summary>
        [JsonPropertyName(@"maxpoints")]
        public float? MaxPoints { get; set;} 

    }
}
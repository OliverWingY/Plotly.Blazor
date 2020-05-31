/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.WaterfallLib
{
    /// <summary>
    ///     The Connector class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Connector 
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.WaterfallLib.ConnectorLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets the shape of connector lines.
        /// </summary>
        [JsonPropertyName(@"mode")]
        public Plotly.Blazor.Traces.WaterfallLib.ConnectorLib.ModeEnum? Mode { get; set;} 

        /// <summary>
        ///     Determines if connector lines are drawn. 
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

    }
}
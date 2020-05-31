/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.Histogram2DLib.ColorBarLib
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Title 
    {
        /// <summary>
        ///     Sets the title of the color bar. Note that before the existence of <c>title.text</c>,
        ///     the title&#39;s contents used to be defined as the <c>title</c> attribute
        ///     itself. This behavior has been deprecated.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets this color bar&#39;s title font. Note that the title&#39;s font used
        ///     to be set by the now deprecated <c>titlefont</c> attribute.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.Traces.Histogram2DLib.ColorBarLib.TitleLib.Font Font { get; set;} 

        /// <summary>
        ///     Determines the location of color bar&#39;s title with respect to the color
        ///     bar. Note that the title&#39;s location used to be set by the now deprecated
        ///     <c>titleside</c> attribute.
        /// </summary>
        [JsonPropertyName(@"side")]
        public Plotly.Blazor.Traces.Histogram2DLib.ColorBarLib.TitleLib.SideEnum? Side { get; set;} 

    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.HeatMapLib.ColorBarLib.TitleLib;

namespace Plotly.Blazor.Traces.HeatMapLib.ColorBarLib
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Title 
    {
        /// <summary>
        ///     Sets the title of the color bar. Note that before the existence of `title.text`,
        ///     the title's contents used to be defined as the `title` attribute itself.
        ///     This behavior has been deprecated.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets this color bar's title font. Note that the title's font used to be
        ///     set by the now deprecated `titlefont` attribute.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.Traces.HeatMapLib.ColorBarLib.TitleLib.Font Font { get; set;} 

        /// <summary>
        ///     Determines the location of color bar's title with respect to the color bar.
        ///     Note that the title's location used to be set by the now deprecated `titleside`
        ///     attribute.
        /// </summary>
        [JsonPropertyName(@"side")]
        public Plotly.Blazor.Traces.HeatMapLib.ColorBarLib.TitleLib.SideEnum? Side { get; set;} 

    }
}
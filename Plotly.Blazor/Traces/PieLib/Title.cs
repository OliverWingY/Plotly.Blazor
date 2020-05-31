/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.Traces.PieLib.TitleLib;

namespace Plotly.Blazor.Traces.PieLib
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Title 
    {
        /// <summary>
        ///     Sets the title of the chart. If it is empty, no title is displayed. Note
        ///     that before the existence of `title.text`, the title's contents used to
        ///     be defined as the `title` attribute itself. This behavior has been deprecated.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the font used for `title`. Note that the title's font used to be set
        ///     by the now deprecated `titlefont` attribute.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.Traces.PieLib.TitleLib.Font Font { get; set;} 

        /// <summary>
        ///     Specifies the location of the `title`. Note that the title's position used
        ///     to be set by the now deprecated `titleposition` attribute.
        /// </summary>
        [JsonPropertyName(@"position")]
        public Plotly.Blazor.Traces.PieLib.TitleLib.PositionEnum? Position { get; set;} 

    }
}
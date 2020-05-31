/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;
using Plotly.Blazor.LayoutLib.PolarLib.RadialAxisLib.TitleLib;

namespace Plotly.Blazor.LayoutLib.PolarLib.RadialAxisLib
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    public class Title 
    {
        /// <summary>
        ///     Sets the title of this axis. Note that before the existence of `title.text`,
        ///     the title's contents used to be defined as the `title` attribute itself.
        ///     This behavior has been deprecated.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets this axis' title font. Note that the title's font used to be customized
        ///     by the now deprecated `titlefont` attribute.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.LayoutLib.PolarLib.RadialAxisLib.TitleLib.Font Font { get; set;} 

    }
}
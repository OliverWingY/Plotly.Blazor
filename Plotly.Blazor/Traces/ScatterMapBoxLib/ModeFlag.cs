/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ScatterMapBoxLib
{
    /// <summary>
    ///     Determines the drawing mode for this scatter trace. If the provided `mode`
    ///     includes *text* then the `text` elements appear at the coordinates. Otherwise,
    ///     the `text` elements appear on hover.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum ModeFlag
    {
        [EnumMember(Value=@"none")]
        None = 0,
        [EnumMember(Value=@"lines")]
        Lines = 1,
        [EnumMember(Value=@"markers")]
        Markers = 2,
        [EnumMember(Value=@"text")]
        Text = 4
    }
}
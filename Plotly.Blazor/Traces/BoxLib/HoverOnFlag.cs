/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.BoxLib
{
    /// <summary>
    ///     Do the hover effects highlight individual boxes  or sample points or both?
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverOnFlag
    {
        [EnumMember(Value=@"boxes")]
        Boxes = 1,
        [EnumMember(Value=@"points")]
        Points = 2
    }
}
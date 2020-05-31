/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ScatterPolarGlLib
{
    /// <summary>
    ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
    ///     are set, no information is displayed upon hovering. But, if <c>none</c>
    ///     is set, click and hover events are still fired.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverInfoFlag
    {
        [EnumMember(Value=@"skip")]
        Skip = 0,
        [EnumMember(Value=@"none")]
        None = 1,
        [EnumMember(Value=@"r")]
        R = 2,
        [EnumMember(Value=@"theta")]
        Theta = 4,
        [EnumMember(Value=@"text")]
        Text = 8,
        [EnumMember(Value=@"name")]
        Name = 16,
        [EnumMember(Value=@"all")]
        All = R | Theta | Text | Name
    }
}
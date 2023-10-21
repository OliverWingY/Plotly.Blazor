/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.IcicleLib.TilingLib
{
    /// <summary>
    ///     Determines if the positions obtained from solver are flipped on each axis.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum FlipFlag
    {
        [EnumMember(Value=@"x")]
        X = 1,
        [EnumMember(Value=@"y")]
        Y = 2
    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.VolumeLib.ColorBarLib
{
    /// <summary>
    ///     Determines whether this color bar&#39;s length (i.e. the measure in the
    ///     color variation direction) is set in units of plot *fraction* or in *pixels.
    ///     Use `len` to set the value.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum LenModeEnum
    {
        [EnumMember(Value=@"fraction")]
        Fraction = 0,
        [EnumMember(Value=@"pixels")]
        Pixels
    }
}
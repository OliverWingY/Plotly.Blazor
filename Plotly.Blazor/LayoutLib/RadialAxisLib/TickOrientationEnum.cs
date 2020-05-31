/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.RadialAxisLib
{
    /// <summary>
    ///     Legacy polar charts are deprecated! Please switch to *polar* subplots. Sets
    ///     the orientation (from the paper perspective) of the radial axis tick labels.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TickOrientationEnum
    {
        [EnumMember(Value=@"horizontal")]
        Horizontal,
        [EnumMember(Value=@"vertical")]
        Vertical
    }
}
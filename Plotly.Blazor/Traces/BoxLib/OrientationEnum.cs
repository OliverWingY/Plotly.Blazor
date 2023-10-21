/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.BoxLib
{
    /// <summary>
    ///     Sets the orientation of the box(es). If <c>v</c> (<c>h</c>), the distribution
    ///     is visualized along the vertical (horizontal).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum OrientationEnum
    {
        [EnumMember(Value=@"v")]
        V,
        [EnumMember(Value=@"h")]
        H
    }
}
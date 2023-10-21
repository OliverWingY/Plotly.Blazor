/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ScatterPolarLib
{
    /// <summary>
    ///     Do the hover effects highlight individual points (markers or line points)
    ///     or do they highlight filled regions? If the fill is <c>toself</c> or <c>tonext</c>
    ///     and there are no markers or text, then the default is <c>fills</c>, otherwise
    ///     it is <c>points</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverOnFlag
    {
        [EnumMember(Value=@"points")]
        Points = 1,
        [EnumMember(Value=@"fills")]
        Fills = 2
    }
}
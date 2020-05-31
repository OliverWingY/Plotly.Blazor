/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.TernaryLib.BAxisLib
{
    /// <summary>
    ///     If <c>all</c>, all exponents are shown besides their significands. If <c>first</c>,
    ///     only the exponent of the first tick is shown. If <c>last</c>, only the exponent
    ///     of the last tick is shown. If <c>none</c>, no exponents appear.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ShowExponentEnum
    {
        [EnumMember(Value=@"all")]
        All = 0,
        [EnumMember(Value=@"first")]
        First,
        [EnumMember(Value=@"last")]
        Last,
        [EnumMember(Value=@"none")]
        None
    }
}
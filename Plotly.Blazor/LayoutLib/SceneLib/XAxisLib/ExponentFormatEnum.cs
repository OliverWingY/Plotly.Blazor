/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.SceneLib.XAxisLib
{
    /// <summary>
    ///     Determines a formatting rule for the tick exponents. For example, consider
    ///     the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*,
    ///     1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*,
    ///     1G. If *B*, 1B.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ExponentFormatEnum
    {
        [EnumMember(Value=@"b")]
        B = 0,
        [EnumMember(Value=@"none")]
        None,
        [EnumMember(Value=@"e")]
        e,
        [EnumMember(Value=@"E")]
        E,
        [EnumMember(Value=@"power")]
        Power,
        [EnumMember(Value=@"SI")]
        SI
    }
}
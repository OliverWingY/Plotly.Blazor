/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ScatterLib.ErrorXLib
{
    /// <summary>
    ///     Determines the rule used to generate the error bars. If *constant`, the
    ///     bar lengths are of a constant value. Set this constant in `value`. If *percent*,
    ///     the bar lengths correspond to a percentage of underlying data. Set this
    ///     percentage in `value`. If *sqrt*, the bar lengths correspond to the sqaure
    ///     of the underlying data. If *data*, the bar lengths are set with data set
    ///     `array`.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"percent")]
        Percent,
        [EnumMember(Value=@"constant")]
        Constant,
        [EnumMember(Value=@"sqrt")]
        SqRt,
        [EnumMember(Value=@"data")]
        Data
    }
}
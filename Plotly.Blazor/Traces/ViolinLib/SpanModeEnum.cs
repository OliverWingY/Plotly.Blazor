/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ViolinLib
{
    /// <summary>
    ///     Sets the method by which the span in data space where the density function
    ///     will be computed. <c>soft</c> means the span goes from the sample&#39;s
    ///     minimum value minus two bandwidths to the sample&#39;s maximum value plus
    ///     two bandwidths. <c>hard</c> means the span goes from the sample&#39;s minimum
    ///     to its maximum value. For custom span settings, use mode <c>manual</c> and
    ///     fill in the <c>span</c> attribute.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum SpanModeEnum
    {
        [EnumMember(Value=@"soft")]
        Soft = 0,
        [EnumMember(Value=@"hard")]
        Hard,
        [EnumMember(Value=@"manual")]
        Manual
    }
}
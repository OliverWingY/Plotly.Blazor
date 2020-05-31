/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.BoxLib
{
    /// <summary>
    ///     Sets the method used to compute the sample&#39;s Q1 and Q3 quartiles. The
    ///     *linear* method uses the 25th percentile for Q1 and 75th percentile for
    ///     Q3 as computed using method #10 (listed on http://www.amstat.org/publications/jse/v14n3/langford.html).
    ///     The *exclusive* method uses the median to divide the ordered dataset into
    ///     two halves if the sample is odd, it does not include the median in either
    ///     half - Q1 is then the median of the lower half and Q3 the median of the
    ///     upper half. The *inclusive* method also uses the median to divide the ordered
    ///     dataset into two halves but if the sample is odd, it includes the median
    ///     in both halves - Q1 is then the median of the lower half and Q3 the median
    ///     of the upper half.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum QuartileMethodEnum
    {
        [EnumMember(Value=@"linear")]
        Linear = 0,
        [EnumMember(Value=@"exclusive")]
        Exclusive,
        [EnumMember(Value=@"inclusive")]
        Inclusive
    }
}
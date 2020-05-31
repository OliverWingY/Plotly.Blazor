/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.XAxisLib.RangeSelectorLib.ButtonLib
{
    /// <summary>
    ///     The unit of measurement that the <c>count</c> value will set the range by.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum StepEnum
    {
        [EnumMember(Value=@"month")]
        Month = 0,
        [EnumMember(Value=@"year")]
        Year,
        [EnumMember(Value=@"day")]
        Day,
        [EnumMember(Value=@"hour")]
        Hour,
        [EnumMember(Value=@"minute")]
        Minute,
        [EnumMember(Value=@"second")]
        Second,
        [EnumMember(Value=@"all")]
        All
    }
}
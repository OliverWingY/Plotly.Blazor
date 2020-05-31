/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.BarPolarLib
{
    /// <summary>
    ///     Sets the unit of input *theta* values. Has an effect only when on *linear*
    ///     angular axes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ThetaUnitEnum
    {
        [EnumMember(Value=@"degrees")]
        Degrees = 0,
        [EnumMember(Value=@"radians")]
        Radians,
        [EnumMember(Value=@"gradians")]
        Gradians
    }
}
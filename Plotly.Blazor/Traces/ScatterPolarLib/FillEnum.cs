/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ScatterPolarLib
{
    /// <summary>
    ///     Sets the area to fill with a solid color. Use with <c>fillcolor</c> if not
    ///     <c>none</c>. scatterpolar has a subset of the options available to scatter.
    ///     <c>toself</c> connects the endpoints of the trace (or each segment of the
    ///     trace if it has gaps) into a closed shape. <c>tonext</c> fills the space
    ///     between two traces if one completely encloses the other (eg consecutive
    ///     contour lines), and behaves like <c>toself</c> if there is no trace before
    ///     it. <c>tonext</c> should not be used if one trace does not enclose the other.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum FillEnum
    {
        [EnumMember(Value=@"none")]
        None = 0,
        [EnumMember(Value=@"toself")]
        ToSelf,
        [EnumMember(Value=@"tonext")]
        ToNext
    }
}
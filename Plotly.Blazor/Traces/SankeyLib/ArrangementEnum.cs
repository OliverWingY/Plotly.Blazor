/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.SankeyLib
{
    /// <summary>
    ///     If value is <c>snap</c> (the default), the node arrangement is assisted
    ///     by automatic snapping of elements to preserve space between nodes specified
    ///     via <c>nodepad</c>. If value is <c>perpendicular</c>, the nodes can only
    ///     move along a line perpendicular to the flow. If value is <c>freeform</c>,
    ///     the nodes can freely move on the plane. If value is <c>fixed</c>, the nodes
    ///     are stationary.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ArrangementEnum
    {
        [EnumMember(Value=@"snap")]
        Snap = 0,
        [EnumMember(Value=@"perpendicular")]
        Perpendicular,
        [EnumMember(Value=@"freeform")]
        FreeForm,
        [EnumMember(Value=@"fixed")]
        Fixed
    }
}
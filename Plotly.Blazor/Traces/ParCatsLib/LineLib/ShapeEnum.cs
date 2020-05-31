/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.ParCatsLib.LineLib
{
    /// <summary>
    ///     Sets the shape of the paths. If <c>linear</c>, paths are composed of straight
    ///     lines. If <c>hspline</c>, paths are composed of horizontal curved splines
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum ShapeEnum
    {
        [EnumMember(Value=@"linear")]
        Linear = 0,
        [EnumMember(Value=@"hspline")]
        HSpline
    }
}
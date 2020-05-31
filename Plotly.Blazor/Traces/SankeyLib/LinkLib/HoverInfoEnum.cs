/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.SankeyLib.LinkLib
{
    /// <summary>
    ///     Determines which trace information appear when hovering links. If `none`
    ///     or `skip` are set, no information is displayed upon hovering. But, if `none`
    ///     is set, click and hover events are still fired.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverInfoEnum
    {
        [EnumMember(Value=@"all")]
        All = 0,
        [EnumMember(Value=@"none")]
        None,
        [EnumMember(Value=@"skip")]
        Skip
    }
}
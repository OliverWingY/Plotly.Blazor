/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.Traces.TreeMapLib.PathBarLib
{
    /// <summary>
    ///     Determines on which side of the the treemap the <c>pathbar</c> should be
    ///     presented.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value=@"top")]
        Top = 0,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}
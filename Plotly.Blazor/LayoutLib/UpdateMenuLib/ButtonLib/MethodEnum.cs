/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Plotly.Blazor.LayoutLib.UpdateMenuLib.ButtonLib
{
    /// <summary>
    ///     Sets the Plotly method to be called on click. If the <c>skip</c> method
    ///     is used, the API updatemenu will function as normal but will perform no
    ///     API calls and will not bind automatically to state updates. This may be
    ///     used to create a component interface and attach to updatemenu events manually
    ///     via JavaScript.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum MethodEnum
    {
        [EnumMember(Value=@"restyle")]
        Restyle = 0,
        [EnumMember(Value=@"relayout")]
        ReLayout,
        [EnumMember(Value=@"animate")]
        Animate,
        [EnumMember(Value=@"update")]
        Update,
        [EnumMember(Value=@"skip")]
        Skip
    }
}
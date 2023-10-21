/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The Selection class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [Serializable]
    public class Selection : IEquatable<Selection>
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.LayoutLib.SelectionLib.Line Line { get; set;} 

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with <c>templateitemname</c>
        ///     matching this <c>name</c> alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). Has no effect outside
        ///     of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Sets the opacity of the selection.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <summary>
        ///     For <c>type</c> <c>path</c> - a valid SVG path similar to <c>shapes.path</c>
        ///     in data coordinates. Allowed segments are: M, L and Z.
        /// </summary>
        [JsonPropertyName(@"path")]
        public string Path { get; set;} 

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with <c>templateitemname</c>
        ///     matching its <c>name</c>, alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). If there is no template
        ///     or no matching item, this item will be hidden unless you explicitly show
        ///     it with &#39;visible: true&#39;.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string TemplateItemName { get; set;} 

        /// <summary>
        ///     Specifies the selection type to be drawn. If <c>rect</c>, a rectangle is
        ///     drawn linking (<c>x0</c>,<c>y0</c>), (<c>x1</c>,<c>y0</c>), (<c>x1</c>,<c>y1</c>)
        ///     and (<c>x0</c>,<c>y1</c>). If <c>path</c>, draw a custom SVG path using
        ///     <c>path</c>.
        /// </summary>
        [JsonPropertyName(@"type")]
        public Plotly.Blazor.LayoutLib.SelectionLib.TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Sets the selection&#39;s starting x position.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set;} 

        /// <summary>
        ///     Sets the selection&#39;s end x position.
        /// </summary>
        [JsonPropertyName(@"x1")]
        public object X1 { get; set;} 

        /// <summary>
        ///     Sets the selection&#39;s x coordinate axis. If set to a x axis id (e.g.
        ///     <c>x</c> or <c>x2</c>), the <c>x</c> position refers to a x coordinate.
        ///     If set to <c>paper</c>, the <c>x</c> position refers to the distance from
        ///     the left of the plotting area in normalized coordinates where <c>0</c> (<c>1</c>)
        ///     corresponds to the left (right). If set to a x axis ID followed by <c>domain</c>
        ///     (separated by a space), the position behaves like for <c>paper</c>, but
        ///     refers to the distance in fractions of the domain length from the left of
        ///     the domain of that axis: e.g., &#39;x2 domain&#39; refers to the domain
        ///     of the second x  axis and a x position of 0.5 refers to the point between
        ///     the left and the right of the domain of the second x axis.
        /// </summary>
        [JsonPropertyName(@"xref")]
        public string XRef { get; set;} 

        /// <summary>
        ///     Sets the selection&#39;s starting y position.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set;} 

        /// <summary>
        ///     Sets the selection&#39;s end y position.
        /// </summary>
        [JsonPropertyName(@"y1")]
        public object Y1 { get; set;} 

        /// <summary>
        ///     Sets the selection&#39;s x coordinate axis. If set to a y axis id (e.g.
        ///     <c>y</c> or <c>y2</c>), the <c>y</c> position refers to a y coordinate.
        ///     If set to <c>paper</c>, the <c>y</c> position refers to the distance from
        ///     the bottom of the plotting area in normalized coordinates where <c>0</c>
        ///     (<c>1</c>) corresponds to the bottom (top). If set to a y axis ID followed
        ///     by <c>domain</c> (separated by a space), the position behaves like for <c>paper</c>,
        ///     but refers to the distance in fractions of the domain length from the bottom
        ///     of the domain of that axis: e.g., &#39;y2 domain&#39; refers to the domain
        ///     of the second y  axis and a y position of 0.5 refers to the point between
        ///     the bottom and the top of the domain of the second y axis.
        /// </summary>
        [JsonPropertyName(@"yref")]
        public string YRef { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Selection other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Selection other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Opacity == other.Opacity ||
                    Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    Path == other.Path ||
                    Path != null &&
                    Path.Equals(other.Path)
                ) && 
                (
                    TemplateItemName == other.TemplateItemName ||
                    TemplateItemName != null &&
                    TemplateItemName.Equals(other.TemplateItemName)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    X0 == other.X0 ||
                    X0 != null &&
                    X0.Equals(other.X0)
                ) && 
                (
                    X1 == other.X1 ||
                    X1 != null &&
                    X1.Equals(other.X1)
                ) && 
                (
                    XRef == other.XRef ||
                    XRef != null &&
                    XRef.Equals(other.XRef)
                ) && 
                (
                    Y0 == other.Y0 ||
                    Y0 != null &&
                    Y0.Equals(other.Y0)
                ) && 
                (
                    Y1 == other.Y1 ||
                    Y1 != null &&
                    Y1.Equals(other.Y1)
                ) && 
                (
                    YRef == other.YRef ||
                    YRef != null &&
                    YRef.Equals(other.YRef)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (Path != null) hashCode = hashCode * 59 + Path.GetHashCode();
                if (TemplateItemName != null) hashCode = hashCode * 59 + TemplateItemName.GetHashCode();
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (X0 != null) hashCode = hashCode * 59 + X0.GetHashCode();
                if (X1 != null) hashCode = hashCode * 59 + X1.GetHashCode();
                if (XRef != null) hashCode = hashCode * 59 + XRef.GetHashCode();
                if (Y0 != null) hashCode = hashCode * 59 + Y0.GetHashCode();
                if (Y1 != null) hashCode = hashCode * 59 + Y1.GetHashCode();
                if (YRef != null) hashCode = hashCode * 59 + YRef.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Selection and the right Selection.
        /// </summary>
        /// <param name="left">Left Selection.</param>
        /// <param name="right">Right Selection.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Selection left, Selection right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Selection and the right Selection.
        /// </summary>
        /// <param name="left">Left Selection.</param>
        /// <param name="right">Right Selection.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Selection left, Selection right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Selection</returns>
        public Selection DeepClone()
        {
            return this.Copy();
        }
    }
}
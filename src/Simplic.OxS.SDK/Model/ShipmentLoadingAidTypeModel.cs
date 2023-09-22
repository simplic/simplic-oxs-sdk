/*
 * Simplic.OxS.Logistics
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Simplic.OxS.SDK.Client.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Model
{
    /// <summary>
    /// Shared model of laoding aid type.
    /// </summary>
    [DataContract(Name = "ShipmentLoadingAidTypeModel")]
    public partial class ShipmentLoadingAidTypeModel : IEquatable<ShipmentLoadingAidTypeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentLoadingAidTypeModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the guid.  &lt;br&gt;  Represents the unique identifier of a loading aid type.  .</param>
        /// <param name="number">Gets or sets the number.  &lt;br&gt;  Represents a human readable identifier.  .</param>
        /// <param name="displayName">Gets or sets the display name..</param>
        /// <param name="weight">Gets or sets the weight..</param>
        /// <param name="shortText">Gets or sets the short text..</param>
        /// <param name="width">Gets or sets the width..</param>
        /// <param name="length">Gets or sets the length..</param>
        /// <param name="storagePosition">Gets or sets the storage position..</param>
        public ShipmentLoadingAidTypeModel(Guid id = default(Guid), int number = default(int), string displayName = default(string), double weight = default(double), string shortText = default(string), int width = default(int), int length = default(int), double storagePosition = default(double))
        {
            this.Id = id;
            this.Number = number;
            this.DisplayName = displayName;
            this.Weight = weight;
            this.ShortText = shortText;
            this.Width = width;
            this.Length = length;
            this.StoragePosition = storagePosition;
        }

        /// <summary>
        /// Gets or sets the guid.  &lt;br&gt;  Represents the unique identifier of a loading aid type.  
        /// </summary>
        /// <value>Gets or sets the guid.  &lt;br&gt;  Represents the unique identifier of a loading aid type.  </value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the number.  &lt;br&gt;  Represents a human readable identifier.  
        /// </summary>
        /// <value>Gets or sets the number.  &lt;br&gt;  Represents a human readable identifier.  </value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>Gets or sets the display name.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>Gets or sets the weight.</value>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the short text.
        /// </summary>
        /// <value>Gets or sets the short text.</value>
        [DataMember(Name = "shortText", EmitDefaultValue = true)]
        public string ShortText { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>Gets or sets the width.</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>Gets or sets the length.</value>
        [DataMember(Name = "length", EmitDefaultValue = false)]
        public int Length { get; set; }

        /// <summary>
        /// Gets or sets the storage position.
        /// </summary>
        /// <value>Gets or sets the storage position.</value>
        [DataMember(Name = "storagePosition", EmitDefaultValue = false)]
        public double StoragePosition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentLoadingAidTypeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  ShortText: ").Append(ShortText).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  StoragePosition: ").Append(StoragePosition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShipmentLoadingAidTypeModel);
        }

        /// <summary>
        /// Returns true if ShipmentLoadingAidTypeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentLoadingAidTypeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentLoadingAidTypeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
                ) && 
                (
                    this.ShortText == input.ShortText ||
                    (this.ShortText != null &&
                    this.ShortText.Equals(input.ShortText))
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.StoragePosition == input.StoragePosition ||
                    this.StoragePosition.Equals(input.StoragePosition)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Weight.GetHashCode();
                if (this.ShortText != null)
                {
                    hashCode = (hashCode * 59) + this.ShortText.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.Length.GetHashCode();
                hashCode = (hashCode * 59) + this.StoragePosition.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

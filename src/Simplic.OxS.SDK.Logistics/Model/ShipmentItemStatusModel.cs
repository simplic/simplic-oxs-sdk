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
using OpenAPIDateConverter = Simplic.OxS.SDK.OpenAPIDateConverter;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// Shared model of shipment item status.
    /// </summary>
    [DataContract(Name = "ShipmentItemStatusModel")]
    public partial class ShipmentItemStatusModel : IEquatable<ShipmentItemStatusModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentItemStatusModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id.  &lt;br&gt;  The id is the unique identifier of the status.  .</param>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="number">Gets or sets the number.  &lt;br&gt;  The number is a human readable identifier for the status.  .</param>
        /// <param name="roles">Gets or sets roles.  &lt;br&gt;  These roles will decide whether shipments with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;item&gt;disable_edit&lt;/item&gt;&lt;item&gt;disable_delete&lt;/item&gt;&lt;item&gt;billable&lt;/item&gt;&lt;/list&gt;.</param>
        /// <param name="hexColor">Gets or sets the color as as hexadecimal value..</param>
        public ShipmentItemStatusModel(Guid id = default(Guid), string name = default(string), string number = default(string), List<string> roles = default(List<string>), string hexColor = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.Roles = roles;
            this.HexColor = hexColor;
        }

        /// <summary>
        /// Gets or sets the id.  &lt;br&gt;  The id is the unique identifier of the status.  
        /// </summary>
        /// <value>Gets or sets the id.  &lt;br&gt;  The id is the unique identifier of the status.  </value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number.  &lt;br&gt;  The number is a human readable identifier for the status.  
        /// </summary>
        /// <value>Gets or sets the number.  &lt;br&gt;  The number is a human readable identifier for the status.  </value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets roles.  &lt;br&gt;  These roles will decide whether shipments with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;item&gt;disable_edit&lt;/item&gt;&lt;item&gt;disable_delete&lt;/item&gt;&lt;item&gt;billable&lt;/item&gt;&lt;/list&gt;
        /// </summary>
        /// <value>Gets or sets roles.  &lt;br&gt;  These roles will decide whether shipments with the status can or can not to certain things.    A list of available roles at the moment:  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;is_default&lt;/item&gt;&lt;item&gt;disable_edit&lt;/item&gt;&lt;item&gt;disable_delete&lt;/item&gt;&lt;item&gt;billable&lt;/item&gt;&lt;/list&gt;</value>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Gets or sets the color as as hexadecimal value.
        /// </summary>
        /// <value>Gets or sets the color as as hexadecimal value.</value>
        [DataMember(Name = "hexColor", EmitDefaultValue = true)]
        public string HexColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentItemStatusModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  HexColor: ").Append(HexColor).Append("\n");
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
            return this.Equals(input as ShipmentItemStatusModel);
        }

        /// <summary>
        /// Returns true if ShipmentItemStatusModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentItemStatusModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentItemStatusModel input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.HexColor == input.HexColor ||
                    (this.HexColor != null &&
                    this.HexColor.Equals(input.HexColor))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                if (this.HexColor != null)
                {
                    hashCode = (hashCode * 59) + this.HexColor.GetHashCode();
                }
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

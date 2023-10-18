/*
 * Simplic.OxS.Vehicle
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

namespace Simplic.OxS.SDK.Vehicle
{
    /// <summary>
    /// UpdateVehicleStatusRequest
    /// </summary>
    [DataContract(Name = "UpdateVehicleStatusRequest")]
    public partial class UpdateVehicleStatusRequest : IEquatable<UpdateVehicleStatusRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVehicleStatusRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="isSelectable">isSelectable.</param>
        public UpdateVehicleStatusRequest(string name = default(string), bool? isSelectable = default(bool?))
        {
            this.Name = name;
            this.IsSelectable = isSelectable;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsSelectable
        /// </summary>
        [DataMember(Name = "isSelectable", EmitDefaultValue = true)]
        public bool? IsSelectable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateVehicleStatusRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsSelectable: ").Append(IsSelectable).Append("\n");
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
            return this.Equals(input as UpdateVehicleStatusRequest);
        }

        /// <summary>
        /// Returns true if UpdateVehicleStatusRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateVehicleStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateVehicleStatusRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsSelectable == input.IsSelectable ||
                    (this.IsSelectable != null &&
                    this.IsSelectable.Equals(input.IsSelectable))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.IsSelectable != null)
                {
                    hashCode = (hashCode * 59) + this.IsSelectable.GetHashCode();
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
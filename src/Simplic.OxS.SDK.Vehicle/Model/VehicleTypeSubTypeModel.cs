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
    /// VehicleTypeSubTypeModel
    /// </summary>
    [DataContract(Name = "VehicleTypeSubTypeModel")]
    public partial class VehicleTypeSubTypeModel : IEquatable<VehicleTypeSubTypeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleTypeSubTypeModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="subType">subType.</param>
        /// <param name="subTypeId">subTypeId.</param>
        public VehicleTypeSubTypeModel(Guid id = default(Guid), string name = default(string), string subType = default(string), Guid? subTypeId = default(Guid?))
        {
            this.Id = id;
            this.Name = name;
            this.SubType = subType;
            this.SubTypeId = subTypeId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SubType
        /// </summary>
        [DataMember(Name = "subType", EmitDefaultValue = true)]
        public string SubType { get; set; }

        /// <summary>
        /// Gets or Sets SubTypeId
        /// </summary>
        [DataMember(Name = "subTypeId", EmitDefaultValue = true)]
        public Guid? SubTypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VehicleTypeSubTypeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  SubTypeId: ").Append(SubTypeId).Append("\n");
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
            return this.Equals(input as VehicleTypeSubTypeModel);
        }

        /// <summary>
        /// Returns true if VehicleTypeSubTypeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VehicleTypeSubTypeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleTypeSubTypeModel input)
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
                    this.SubType == input.SubType ||
                    (this.SubType != null &&
                    this.SubType.Equals(input.SubType))
                ) && 
                (
                    this.SubTypeId == input.SubTypeId ||
                    (this.SubTypeId != null &&
                    this.SubTypeId.Equals(input.SubTypeId))
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
                if (this.SubType != null)
                {
                    hashCode = (hashCode * 59) + this.SubType.GetHashCode();
                }
                if (this.SubTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.SubTypeId.GetHashCode();
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

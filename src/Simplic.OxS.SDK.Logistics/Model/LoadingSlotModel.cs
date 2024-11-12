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
    /// Shared model for loading slots.
    /// </summary>
    [DataContract(Name = "LoadingSlotModel")]
    public partial class LoadingSlotModel : IEquatable<LoadingSlotModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadingSlotModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the loading slot..</param>
        /// <param name="name">Gets or sets the name of the loading slot.  &lt;br&gt;  This should be used as a short human readable identifier for the loading slot.  .</param>
        /// <param name="description">Gets or sets the description.  &lt;br&gt;  This could be used to notate the size or exact location of the loading slot.  .</param>
        /// <param name="resourceId">Gets or sets the id of the resource this loading slot is assigned to..</param>
        public LoadingSlotModel(Guid id = default(Guid), string name = default(string), string description = default(string), Guid resourceId = default(Guid))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Gets or sets the id of the loading slot.
        /// </summary>
        /// <value>Gets or sets the id of the loading slot.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the loading slot.  &lt;br&gt;  This should be used as a short human readable identifier for the loading slot.  
        /// </summary>
        /// <value>Gets or sets the name of the loading slot.  &lt;br&gt;  This should be used as a short human readable identifier for the loading slot.  </value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.  &lt;br&gt;  This could be used to notate the size or exact location of the loading slot.  
        /// </summary>
        /// <value>Gets or sets the description.  &lt;br&gt;  This could be used to notate the size or exact location of the loading slot.  </value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the id of the resource this loading slot is assigned to.
        /// </summary>
        /// <value>Gets or sets the id of the resource this loading slot is assigned to.</value>
        [DataMember(Name = "resourceId", EmitDefaultValue = false)]
        public Guid ResourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoadingSlotModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
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
            return this.Equals(input as LoadingSlotModel);
        }

        /// <summary>
        /// Returns true if LoadingSlotModel instances are equal
        /// </summary>
        /// <param name="input">Instance of LoadingSlotModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoadingSlotModel input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceId.GetHashCode();
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

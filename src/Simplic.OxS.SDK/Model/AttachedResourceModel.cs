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
    /// Shared model for attached resources.
    /// </summary>
    [DataContract(Name = "AttachedResourceModel")]
    public partial class AttachedResourceModel : IEquatable<AttachedResourceModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedResourceModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="resource">resource.</param>
        /// <param name="attachAction">attachAction.</param>
        /// <param name="detachAction">detachAction.</param>
        public AttachedResourceModel(Guid id = default(Guid), ResourceModel resource = default(ResourceModel), TourActionModel attachAction = default(TourActionModel), TourActionModel detachAction = default(TourActionModel))
        {
            this.Id = id;
            this.Resource = resource;
            this.AttachAction = attachAction;
            this.DetachAction = detachAction;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public ResourceModel Resource { get; set; }

        /// <summary>
        /// Gets or Sets AttachAction
        /// </summary>
        [DataMember(Name = "attachAction", EmitDefaultValue = false)]
        public TourActionModel AttachAction { get; set; }

        /// <summary>
        /// Gets or Sets DetachAction
        /// </summary>
        [DataMember(Name = "detachAction", EmitDefaultValue = false)]
        public TourActionModel DetachAction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachedResourceModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  AttachAction: ").Append(AttachAction).Append("\n");
            sb.Append("  DetachAction: ").Append(DetachAction).Append("\n");
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
            return this.Equals(input as AttachedResourceModel);
        }

        /// <summary>
        /// Returns true if AttachedResourceModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachedResourceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachedResourceModel input)
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
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.AttachAction == input.AttachAction ||
                    (this.AttachAction != null &&
                    this.AttachAction.Equals(input.AttachAction))
                ) && 
                (
                    this.DetachAction == input.DetachAction ||
                    (this.DetachAction != null &&
                    this.DetachAction.Equals(input.DetachAction))
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
                if (this.Resource != null)
                {
                    hashCode = (hashCode * 59) + this.Resource.GetHashCode();
                }
                if (this.AttachAction != null)
                {
                    hashCode = (hashCode * 59) + this.AttachAction.GetHashCode();
                }
                if (this.DetachAction != null)
                {
                    hashCode = (hashCode * 59) + this.DetachAction.GetHashCode();
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

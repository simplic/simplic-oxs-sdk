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

namespace Simplic.OxS.SDK.Logistics.Model
{
    /// <summary>
    /// Shared model for attached entities.
    /// </summary>
    [DataContract(Name = "AttachedEntityModel")]
    public partial class AttachedEntityModel : IEquatable<AttachedEntityModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedEntityModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the attachment..</param>
        /// <param name="entitiy">entitiy.</param>
        /// <param name="attachingAction">attachingAction.</param>
        /// <param name="detachingAction">detachingAction.</param>
        public AttachedEntityModel(Guid id = default(Guid), TourEntityModel entitiy = default(TourEntityModel), TourActionModel attachingAction = default(TourActionModel), TourActionModel detachingAction = default(TourActionModel))
        {
            this.Id = id;
            this.Entitiy = entitiy;
            this.AttachingAction = attachingAction;
            this.DetachingAction = detachingAction;
        }

        /// <summary>
        /// Gets or sets the attachment.
        /// </summary>
        /// <value>Gets or sets the attachment.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Entitiy
        /// </summary>
        [DataMember(Name = "entitiy", EmitDefaultValue = false)]
        public TourEntityModel Entitiy { get; set; }

        /// <summary>
        /// Gets or Sets AttachingAction
        /// </summary>
        [DataMember(Name = "attachingAction", EmitDefaultValue = false)]
        public TourActionModel AttachingAction { get; set; }

        /// <summary>
        /// Gets or Sets DetachingAction
        /// </summary>
        [DataMember(Name = "detachingAction", EmitDefaultValue = false)]
        public TourActionModel DetachingAction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachedEntityModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Entitiy: ").Append(Entitiy).Append("\n");
            sb.Append("  AttachingAction: ").Append(AttachingAction).Append("\n");
            sb.Append("  DetachingAction: ").Append(DetachingAction).Append("\n");
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
            return this.Equals(input as AttachedEntityModel);
        }

        /// <summary>
        /// Returns true if AttachedEntityModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachedEntityModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachedEntityModel input)
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
                    this.Entitiy == input.Entitiy ||
                    (this.Entitiy != null &&
                    this.Entitiy.Equals(input.Entitiy))
                ) && 
                (
                    this.AttachingAction == input.AttachingAction ||
                    (this.AttachingAction != null &&
                    this.AttachingAction.Equals(input.AttachingAction))
                ) && 
                (
                    this.DetachingAction == input.DetachingAction ||
                    (this.DetachingAction != null &&
                    this.DetachingAction.Equals(input.DetachingAction))
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
                if (this.Entitiy != null)
                {
                    hashCode = (hashCode * 59) + this.Entitiy.GetHashCode();
                }
                if (this.AttachingAction != null)
                {
                    hashCode = (hashCode * 59) + this.AttachingAction.GetHashCode();
                }
                if (this.DetachingAction != null)
                {
                    hashCode = (hashCode * 59) + this.DetachingAction.GetHashCode();
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

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
    /// Request to attach two resources to each other.
    /// </summary>
    [DataContract(Name = "AttachResourcesRequest")]
    public partial class AttachResourcesRequest : IEquatable<AttachResourcesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachResourcesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttachResourcesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachResourcesRequest" /> class.
        /// </summary>
        /// <param name="firstResourceId">Gets or sets the id of the first resource that needs to be attached. (required).</param>
        /// <param name="secondResourceId">Gets or sets the id of the second resource that needs to be attached. (required).</param>
        /// <param name="settings">settings.</param>
        public AttachResourcesRequest(Guid firstResourceId = default(Guid), Guid secondResourceId = default(Guid), AttachResourceRequestSettings settings = default(AttachResourceRequestSettings))
        {
            this.FirstResourceId = firstResourceId;
            this.SecondResourceId = secondResourceId;
            this.Settings = settings;
        }

        /// <summary>
        /// Gets or sets the id of the first resource that needs to be attached.
        /// </summary>
        /// <value>Gets or sets the id of the first resource that needs to be attached.</value>
        [DataMember(Name = "firstResourceId", IsRequired = true, EmitDefaultValue = true)]
        public Guid FirstResourceId { get; set; }

        /// <summary>
        /// Gets or sets the id of the second resource that needs to be attached.
        /// </summary>
        /// <value>Gets or sets the id of the second resource that needs to be attached.</value>
        [DataMember(Name = "secondResourceId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SecondResourceId { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public AttachResourceRequestSettings Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachResourcesRequest {\n");
            sb.Append("  FirstResourceId: ").Append(FirstResourceId).Append("\n");
            sb.Append("  SecondResourceId: ").Append(SecondResourceId).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as AttachResourcesRequest);
        }

        /// <summary>
        /// Returns true if AttachResourcesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachResourcesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachResourcesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirstResourceId == input.FirstResourceId ||
                    (this.FirstResourceId != null &&
                    this.FirstResourceId.Equals(input.FirstResourceId))
                ) && 
                (
                    this.SecondResourceId == input.SecondResourceId ||
                    (this.SecondResourceId != null &&
                    this.SecondResourceId.Equals(input.SecondResourceId))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.FirstResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.FirstResourceId.GetHashCode();
                }
                if (this.SecondResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SecondResourceId.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
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

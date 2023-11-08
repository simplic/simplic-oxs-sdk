/*
 * Simplic.OxS.Auth
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

namespace Simplic.OxS.SDK.Auth
{
    /// <summary>
    /// Request for changing/selecting a specific organization
    /// </summary>
    [DataContract(Name = "SelectOrganizationRequest")]
    public partial class SelectOrganizationRequest : IEquatable<SelectOrganizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectOrganizationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelectOrganizationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectOrganizationRequest" /> class.
        /// </summary>
        /// <param name="organizationId">Gets or sets the organization id to generate a jwt for (required).</param>
        public SelectOrganizationRequest(Guid organizationId = default(Guid))
        {
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Gets or sets the organization id to generate a jwt for
        /// </summary>
        /// <value>Gets or sets the organization id to generate a jwt for</value>
        [DataMember(Name = "organizationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SelectOrganizationRequest {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
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
            return this.Equals(input as SelectOrganizationRequest);
        }

        /// <summary>
        /// Returns true if SelectOrganizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectOrganizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectOrganizationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
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
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
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

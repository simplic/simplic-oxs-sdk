/*
 * Simplic.OxS.TimeSlot
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
using OpenAPIDateConverter = Simplic.OxS.SDK.TimeSlot.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.TimeSlot
{
    /// <summary>
    /// Represents a bookable location
    /// </summary>
    [DataContract(Name = "UpdateSiteRequest")]
    public partial class UpdateSiteRequest : IEquatable<UpdateSiteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSiteRequest" /> class.
        /// </summary>
        /// <param name="organizationSiteId">organizationSiteId.</param>
        /// <param name="name">name.</param>
        /// <param name="assignments">assignments.</param>
        /// <param name="adress">adress.</param>
        /// <param name="logoUrl">logoUrl.</param>
        public UpdateSiteRequest(Guid? organizationSiteId = default(Guid?), string name = default(string), List<SiteAssignment> assignments = default(List<SiteAssignment>), SiteAddressModel adress = default(SiteAddressModel), string logoUrl = default(string))
        {
            this.OrganizationSiteId = organizationSiteId;
            this.Name = name;
            this.Assignments = assignments;
            this.Adress = adress;
            this.LogoUrl = logoUrl;
        }

        /// <summary>
        /// Gets or Sets OrganizationSiteId
        /// </summary>
        [DataMember(Name = "organizationSiteId", EmitDefaultValue = true)]
        public Guid? OrganizationSiteId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Assignments
        /// </summary>
        [DataMember(Name = "assignments", EmitDefaultValue = true)]
        public List<SiteAssignment> Assignments { get; set; }

        /// <summary>
        /// Gets or Sets Adress
        /// </summary>
        [DataMember(Name = "adress", EmitDefaultValue = false)]
        public SiteAddressModel Adress { get; set; }

        /// <summary>
        /// Gets or Sets LogoUrl
        /// </summary>
        [DataMember(Name = "logoUrl", EmitDefaultValue = true)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateSiteRequest {\n");
            sb.Append("  OrganizationSiteId: ").Append(OrganizationSiteId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
            sb.Append("  Adress: ").Append(Adress).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
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
            return this.Equals(input as UpdateSiteRequest);
        }

        /// <summary>
        /// Returns true if UpdateSiteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSiteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSiteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrganizationSiteId == input.OrganizationSiteId ||
                    (this.OrganizationSiteId != null &&
                    this.OrganizationSiteId.Equals(input.OrganizationSiteId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Assignments == input.Assignments ||
                    this.Assignments != null &&
                    input.Assignments != null &&
                    this.Assignments.SequenceEqual(input.Assignments)
                ) && 
                (
                    this.Adress == input.Adress ||
                    (this.Adress != null &&
                    this.Adress.Equals(input.Adress))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
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
                if (this.OrganizationSiteId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationSiteId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Assignments != null)
                {
                    hashCode = (hashCode * 59) + this.Assignments.GetHashCode();
                }
                if (this.Adress != null)
                {
                    hashCode = (hashCode * 59) + this.Adress.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
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

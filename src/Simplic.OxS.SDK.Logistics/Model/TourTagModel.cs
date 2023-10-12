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
using OpenAPIDateConverter = Simplic.OxS.SDK.Logistics.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// Represents the server model of a tag for tours.  &lt;br&gt;  Tags are short texts to add information to a tour without the need to add new properties.    These are e.g. used in the pricing module to add some additional conditions.
    /// </summary>
    [DataContract(Name = "TourTagModel")]
    public partial class TourTagModel : IEquatable<TourTagModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TourTagModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the unique identifier of the tour tag..</param>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="groupName">Gets or sets the group name.  &lt;br&gt;  Group names are a possibillity to group tags.   E.g. when just a single tag from a certain pool should be used.  .</param>
        /// <param name="hexColor">Gets or sets the hex color of the string..</param>
        /// <param name="organizationId">Gets or sets the organization id..</param>
        /// <param name="isDeleted">Gets or sets whether the tour tag is deleted..</param>
        /// <param name="functions">Gets or sets the functions of the tour tag.  &lt;br&gt;  Functions are used to add additional functionalities to a tour tag.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;disable_edit: Disables editing the tour or action the tag is attached to.&lt;/item&gt;&lt;/list&gt;.</param>
        public TourTagModel(Guid id = default(Guid), string name = default(string), string groupName = default(string), string hexColor = default(string), Guid organizationId = default(Guid), bool isDeleted = default(bool), List<string> functions = default(List<string>))
        {
            this.Id = id;
            this.Name = name;
            this.GroupName = groupName;
            this.HexColor = hexColor;
            this.OrganizationId = organizationId;
            this.IsDeleted = isDeleted;
            this.Functions = functions;
        }

        /// <summary>
        /// Gets or sets the unique identifier of the tour tag.
        /// </summary>
        /// <value>Gets or sets the unique identifier of the tour tag.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the group name.  &lt;br&gt;  Group names are a possibillity to group tags.   E.g. when just a single tag from a certain pool should be used.  
        /// </summary>
        /// <value>Gets or sets the group name.  &lt;br&gt;  Group names are a possibillity to group tags.   E.g. when just a single tag from a certain pool should be used.  </value>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the hex color of the string.
        /// </summary>
        /// <value>Gets or sets the hex color of the string.</value>
        [DataMember(Name = "hexColor", EmitDefaultValue = true)]
        public string HexColor { get; set; }

        /// <summary>
        /// Gets or sets the organization id.
        /// </summary>
        /// <value>Gets or sets the organization id.</value>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets whether the tour tag is deleted.
        /// </summary>
        /// <value>Gets or sets whether the tour tag is deleted.</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the functions of the tour tag.  &lt;br&gt;  Functions are used to add additional functionalities to a tour tag.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;disable_edit: Disables editing the tour or action the tag is attached to.&lt;/item&gt;&lt;/list&gt;
        /// </summary>
        /// <value>Gets or sets the functions of the tour tag.  &lt;br&gt;  Functions are used to add additional functionalities to a tour tag.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;disable_edit: Disables editing the tour or action the tag is attached to.&lt;/item&gt;&lt;/list&gt;</value>
        [DataMember(Name = "functions", EmitDefaultValue = true)]
        public List<string> Functions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TourTagModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  HexColor: ").Append(HexColor).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
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
            return this.Equals(input as TourTagModel);
        }

        /// <summary>
        /// Returns true if TourTagModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TourTagModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TourTagModel input)
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
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.HexColor == input.HexColor ||
                    (this.HexColor != null &&
                    this.HexColor.Equals(input.HexColor))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.Functions == input.Functions ||
                    this.Functions != null &&
                    input.Functions != null &&
                    this.Functions.SequenceEqual(input.Functions)
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
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                if (this.HexColor != null)
                {
                    hashCode = (hashCode * 59) + this.HexColor.GetHashCode();
                }
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                if (this.Functions != null)
                {
                    hashCode = (hashCode * 59) + this.Functions.GetHashCode();
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

/*
 * Simplic.OxS.Organization
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

namespace Simplic.OxS.SDK.Organization
{
    /// <summary>
    /// Represents an team.
    /// </summary>
    [DataContract(Name = "TeamModel")]
    public partial class TeamModel : IEquatable<TeamModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the unique id of the team..</param>
        /// <param name="organizationId">Gets or sets the organization id..</param>
        /// <param name="name">Gets or sets the team name..</param>
        /// <param name="teamMember">Gets or sets the users list..</param>
        public TeamModel(Guid id = default(Guid), Guid organizationId = default(Guid), string name = default(string), List<TeamMember> teamMember = default(List<TeamMember>))
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.Name = name;
            this.TeamMember = teamMember;
        }

        /// <summary>
        /// Gets or sets the unique id of the team.
        /// </summary>
        /// <value>Gets or sets the unique id of the team.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the organization id.
        /// </summary>
        /// <value>Gets or sets the organization id.</value>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the team name.
        /// </summary>
        /// <value>Gets or sets the team name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the users list.
        /// </summary>
        /// <value>Gets or sets the users list.</value>
        [DataMember(Name = "teamMember", EmitDefaultValue = true)]
        public List<TeamMember> TeamMember { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TeamMember: ").Append(TeamMember).Append("\n");
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
            return this.Equals(input as TeamModel);
        }

        /// <summary>
        /// Returns true if TeamModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamModel input)
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
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TeamMember == input.TeamMember ||
                    this.TeamMember != null &&
                    input.TeamMember != null &&
                    this.TeamMember.SequenceEqual(input.TeamMember)
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
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.TeamMember != null)
                {
                    hashCode = (hashCode * 59) + this.TeamMember.GetHashCode();
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

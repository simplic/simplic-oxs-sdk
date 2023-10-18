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
    /// Represents a membership (user -&gt; organization)
    /// </summary>
    [DataContract(Name = "OrganizationMemberModel")]
    public partial class OrganizationMemberModel : IEquatable<OrganizationMemberModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public MemberState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the member-ship.</param>
        /// <param name="organizationId">Gets or sets the organization id.</param>
        /// <param name="organizationName">Gets or sets the organization name.</param>
        /// <param name="userId">Gets or sets the user id of the membership.</param>
        /// <param name="userEmailAddress">Gets or sets the user email address.</param>
        /// <param name="roles">Gets or sets the roles of the membership (owner, member).</param>
        /// <param name="state">state.</param>
        public OrganizationMemberModel(Guid id = default(Guid), Guid organizationId = default(Guid), string organizationName = default(string), Guid userId = default(Guid), string userEmailAddress = default(string), List<string> roles = default(List<string>), MemberState? state = default(MemberState?))
        {
            this.Id = id;
            this.OrganizationId = organizationId;
            this.OrganizationName = organizationName;
            this.UserId = userId;
            this.UserEmailAddress = userEmailAddress;
            this.Roles = roles;
            this.State = state;
        }

        /// <summary>
        /// Gets or sets the id of the member-ship
        /// </summary>
        /// <value>Gets or sets the id of the member-ship</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the organization id
        /// </summary>
        /// <value>Gets or sets the organization id</value>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the organization name
        /// </summary>
        /// <value>Gets or sets the organization name</value>
        [DataMember(Name = "organizationName", EmitDefaultValue = true)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets the user id of the membership
        /// </summary>
        /// <value>Gets or sets the user id of the membership</value>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the user email address
        /// </summary>
        /// <value>Gets or sets the user email address</value>
        [DataMember(Name = "userEmailAddress", EmitDefaultValue = true)]
        public string UserEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the roles of the membership (owner, member)
        /// </summary>
        /// <value>Gets or sets the roles of the membership (owner, member)</value>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationMemberModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserEmailAddress: ").Append(UserEmailAddress).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as OrganizationMemberModel);
        }

        /// <summary>
        /// Returns true if OrganizationMemberModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationMemberModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationMemberModel input)
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
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserEmailAddress == input.UserEmailAddress ||
                    (this.UserEmailAddress != null &&
                    this.UserEmailAddress.Equals(input.UserEmailAddress))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
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
                if (this.OrganizationName != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationName.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.UserEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.UserEmailAddress.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
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

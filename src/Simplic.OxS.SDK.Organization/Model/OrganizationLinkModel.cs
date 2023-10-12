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
using OpenAPIDateConverter = Simplic.OxS.SDK.Organization.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Organization
{
    /// <summary>
    /// Represents an organization link. A connection between two organizations
    /// </summary>
    [DataContract(Name = "OrganizationLinkModel")]
    public partial class OrganizationLinkModel : IEquatable<OrganizationLinkModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public OrganizationLinkState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationLinkModel" /> class.
        /// </summary>
        /// <param name="foreignOrganizationId">Gets or sets the foreign organization id (organization-id - -&gt; foreign organization).</param>
        /// <param name="organizationId">Gets or sets the organization id of the owner of the connection.</param>
        /// <param name="modules">Gets or sets the enabled modules.</param>
        /// <param name="state">state.</param>
        /// <param name="createDateTime">Gets or sets the create date time of the link.</param>
        /// <param name="createUserId">Gets or sets the create user of the link.</param>
        /// <param name="createUserName">Gets or sets the create user name of the link.</param>
        /// <param name="updateDateTime">Gets or sets the latest update date time of the link.</param>
        /// <param name="updateUserId">gets or sets the update user id of the link.</param>
        /// <param name="updateUserName">Gets or sets the update user name of the link.</param>
        /// <param name="originator">Gets or sets the name of the member who created the initial invitation link.</param>
        /// <param name="acceptedBy">Gets or sets the name of the member who accepted the invitation.</param>
        /// <param name="invitationId">Gets or sets the id of the invitation that initiated the link.</param>
        /// <param name="organizationName">Gets or sets the owner organization id (link owner).</param>
        /// <param name="foreignOrganizationName">Gets or sets the organization name of the linked (foreign) organization.</param>
        public OrganizationLinkModel(Guid foreignOrganizationId = default(Guid), Guid organizationId = default(Guid), List<string> modules = default(List<string>), OrganizationLinkState? state = default(OrganizationLinkState?), DateTime createDateTime = default(DateTime), Guid? createUserId = default(Guid?), string createUserName = default(string), DateTime updateDateTime = default(DateTime), Guid? updateUserId = default(Guid?), string updateUserName = default(string), string originator = default(string), string acceptedBy = default(string), Guid invitationId = default(Guid), string organizationName = default(string), string foreignOrganizationName = default(string))
        {
            this.ForeignOrganizationId = foreignOrganizationId;
            this.OrganizationId = organizationId;
            this.Modules = modules;
            this.State = state;
            this.CreateDateTime = createDateTime;
            this.CreateUserId = createUserId;
            this.CreateUserName = createUserName;
            this.UpdateDateTime = updateDateTime;
            this.UpdateUserId = updateUserId;
            this.UpdateUserName = updateUserName;
            this.Originator = originator;
            this.AcceptedBy = acceptedBy;
            this.InvitationId = invitationId;
            this.OrganizationName = organizationName;
            this.ForeignOrganizationName = foreignOrganizationName;
        }

        /// <summary>
        /// Gets or sets the foreign organization id (organization-id - -&gt; foreign organization)
        /// </summary>
        /// <value>Gets or sets the foreign organization id (organization-id - -&gt; foreign organization)</value>
        [DataMember(Name = "foreignOrganizationId", EmitDefaultValue = false)]
        public Guid ForeignOrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the organization id of the owner of the connection
        /// </summary>
        /// <value>Gets or sets the organization id of the owner of the connection</value>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the enabled modules
        /// </summary>
        /// <value>Gets or sets the enabled modules</value>
        [DataMember(Name = "modules", EmitDefaultValue = true)]
        public List<string> Modules { get; set; }

        /// <summary>
        /// Gets or sets the create date time of the link
        /// </summary>
        /// <value>Gets or sets the create date time of the link</value>
        [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or sets the create user of the link
        /// </summary>
        /// <value>Gets or sets the create user of the link</value>
        [DataMember(Name = "createUserId", EmitDefaultValue = true)]
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create user name of the link
        /// </summary>
        /// <value>Gets or sets the create user name of the link</value>
        [DataMember(Name = "createUserName", EmitDefaultValue = true)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or sets the latest update date time of the link
        /// </summary>
        /// <value>Gets or sets the latest update date time of the link</value>
        [DataMember(Name = "updateDateTime", EmitDefaultValue = false)]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// gets or sets the update user id of the link
        /// </summary>
        /// <value>gets or sets the update user id of the link</value>
        [DataMember(Name = "updateUserId", EmitDefaultValue = true)]
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or sets the update user name of the link
        /// </summary>
        /// <value>Gets or sets the update user name of the link</value>
        [DataMember(Name = "updateUserName", EmitDefaultValue = true)]
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Gets or sets the name of the member who created the initial invitation link
        /// </summary>
        /// <value>Gets or sets the name of the member who created the initial invitation link</value>
        [DataMember(Name = "originator", EmitDefaultValue = true)]
        public string Originator { get; set; }

        /// <summary>
        /// Gets or sets the name of the member who accepted the invitation
        /// </summary>
        /// <value>Gets or sets the name of the member who accepted the invitation</value>
        [DataMember(Name = "acceptedBy", EmitDefaultValue = true)]
        public string AcceptedBy { get; set; }

        /// <summary>
        /// Gets or sets the id of the invitation that initiated the link
        /// </summary>
        /// <value>Gets or sets the id of the invitation that initiated the link</value>
        [DataMember(Name = "invitationId", EmitDefaultValue = false)]
        public Guid InvitationId { get; set; }

        /// <summary>
        /// Gets or sets the owner organization id (link owner)
        /// </summary>
        /// <value>Gets or sets the owner organization id (link owner)</value>
        [DataMember(Name = "organizationName", EmitDefaultValue = true)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets the organization name of the linked (foreign) organization
        /// </summary>
        /// <value>Gets or sets the organization name of the linked (foreign) organization</value>
        [DataMember(Name = "foreignOrganizationName", EmitDefaultValue = true)]
        public string ForeignOrganizationName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationLinkModel {\n");
            sb.Append("  ForeignOrganizationId: ").Append(ForeignOrganizationId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  CreateUserName: ").Append(CreateUserName).Append("\n");
            sb.Append("  UpdateDateTime: ").Append(UpdateDateTime).Append("\n");
            sb.Append("  UpdateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("  UpdateUserName: ").Append(UpdateUserName).Append("\n");
            sb.Append("  Originator: ").Append(Originator).Append("\n");
            sb.Append("  AcceptedBy: ").Append(AcceptedBy).Append("\n");
            sb.Append("  InvitationId: ").Append(InvitationId).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  ForeignOrganizationName: ").Append(ForeignOrganizationName).Append("\n");
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
            return this.Equals(input as OrganizationLinkModel);
        }

        /// <summary>
        /// Returns true if OrganizationLinkModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationLinkModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationLinkModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ForeignOrganizationId == input.ForeignOrganizationId ||
                    (this.ForeignOrganizationId != null &&
                    this.ForeignOrganizationId.Equals(input.ForeignOrganizationId))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Modules == input.Modules ||
                    this.Modules != null &&
                    input.Modules != null &&
                    this.Modules.SequenceEqual(input.Modules)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.CreateDateTime == input.CreateDateTime ||
                    (this.CreateDateTime != null &&
                    this.CreateDateTime.Equals(input.CreateDateTime))
                ) && 
                (
                    this.CreateUserId == input.CreateUserId ||
                    (this.CreateUserId != null &&
                    this.CreateUserId.Equals(input.CreateUserId))
                ) && 
                (
                    this.CreateUserName == input.CreateUserName ||
                    (this.CreateUserName != null &&
                    this.CreateUserName.Equals(input.CreateUserName))
                ) && 
                (
                    this.UpdateDateTime == input.UpdateDateTime ||
                    (this.UpdateDateTime != null &&
                    this.UpdateDateTime.Equals(input.UpdateDateTime))
                ) && 
                (
                    this.UpdateUserId == input.UpdateUserId ||
                    (this.UpdateUserId != null &&
                    this.UpdateUserId.Equals(input.UpdateUserId))
                ) && 
                (
                    this.UpdateUserName == input.UpdateUserName ||
                    (this.UpdateUserName != null &&
                    this.UpdateUserName.Equals(input.UpdateUserName))
                ) && 
                (
                    this.Originator == input.Originator ||
                    (this.Originator != null &&
                    this.Originator.Equals(input.Originator))
                ) && 
                (
                    this.AcceptedBy == input.AcceptedBy ||
                    (this.AcceptedBy != null &&
                    this.AcceptedBy.Equals(input.AcceptedBy))
                ) && 
                (
                    this.InvitationId == input.InvitationId ||
                    (this.InvitationId != null &&
                    this.InvitationId.Equals(input.InvitationId))
                ) && 
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
                ) && 
                (
                    this.ForeignOrganizationName == input.ForeignOrganizationName ||
                    (this.ForeignOrganizationName != null &&
                    this.ForeignOrganizationName.Equals(input.ForeignOrganizationName))
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
                if (this.ForeignOrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignOrganizationId.GetHashCode();
                }
                if (this.OrganizationId != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                }
                if (this.Modules != null)
                {
                    hashCode = (hashCode * 59) + this.Modules.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.CreateDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateDateTime.GetHashCode();
                }
                if (this.CreateUserId != null)
                {
                    hashCode = (hashCode * 59) + this.CreateUserId.GetHashCode();
                }
                if (this.CreateUserName != null)
                {
                    hashCode = (hashCode * 59) + this.CreateUserName.GetHashCode();
                }
                if (this.UpdateDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateDateTime.GetHashCode();
                }
                if (this.UpdateUserId != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateUserId.GetHashCode();
                }
                if (this.UpdateUserName != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateUserName.GetHashCode();
                }
                if (this.Originator != null)
                {
                    hashCode = (hashCode * 59) + this.Originator.GetHashCode();
                }
                if (this.AcceptedBy != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptedBy.GetHashCode();
                }
                if (this.InvitationId != null)
                {
                    hashCode = (hashCode * 59) + this.InvitationId.GetHashCode();
                }
                if (this.OrganizationName != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationName.GetHashCode();
                }
                if (this.ForeignOrganizationName != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignOrganizationName.GetHashCode();
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

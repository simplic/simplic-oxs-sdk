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
    /// Containing all information for requesting an organization link invitation (one-time invitation)
    /// </summary>
    [DataContract(Name = "OrganizationLinkInvitationRequest")]
    public partial class OrganizationLinkInvitationRequest : IEquatable<OrganizationLinkInvitationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationLinkInvitationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationLinkInvitationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationLinkInvitationRequest" /> class.
        /// </summary>
        /// <param name="sendAsMail">Gets or sets whether to send the one-time invitation as mail.</param>
        /// <param name="targetOrganization">Gets or sets the name of the target organization (required).</param>
        /// <param name="email">Gets or sets the email address of the invited organization-user (for accepting the one-time link) (required).</param>
        /// <param name="modules">Gets or sets a list of modules that should be added to the organization link  when accepting the invitation..</param>
        public OrganizationLinkInvitationRequest(bool sendAsMail = default(bool), string targetOrganization = default(string), string email = default(string), List<string> modules = default(List<string>))
        {
            // to ensure "targetOrganization" is required (not null)
            if (targetOrganization == null)
            {
                throw new ArgumentNullException("targetOrganization is a required property for OrganizationLinkInvitationRequest and cannot be null");
            }
            this.TargetOrganization = targetOrganization;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for OrganizationLinkInvitationRequest and cannot be null");
            }
            this.Email = email;
            this.SendAsMail = sendAsMail;
            this.Modules = modules;
        }

        /// <summary>
        /// Gets or sets whether to send the one-time invitation as mail
        /// </summary>
        /// <value>Gets or sets whether to send the one-time invitation as mail</value>
        [DataMember(Name = "sendAsMail", EmitDefaultValue = true)]
        public bool SendAsMail { get; set; }

        /// <summary>
        /// Gets or sets the name of the target organization
        /// </summary>
        /// <value>Gets or sets the name of the target organization</value>
        [DataMember(Name = "targetOrganization", IsRequired = true, EmitDefaultValue = true)]
        public string TargetOrganization { get; set; }

        /// <summary>
        /// Gets or sets the email address of the invited organization-user (for accepting the one-time link)
        /// </summary>
        /// <value>Gets or sets the email address of the invited organization-user (for accepting the one-time link)</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a list of modules that should be added to the organization link  when accepting the invitation.
        /// </summary>
        /// <value>Gets or sets a list of modules that should be added to the organization link  when accepting the invitation.</value>
        [DataMember(Name = "modules", EmitDefaultValue = true)]
        public List<string> Modules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationLinkInvitationRequest {\n");
            sb.Append("  SendAsMail: ").Append(SendAsMail).Append("\n");
            sb.Append("  TargetOrganization: ").Append(TargetOrganization).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
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
            return this.Equals(input as OrganizationLinkInvitationRequest);
        }

        /// <summary>
        /// Returns true if OrganizationLinkInvitationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationLinkInvitationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationLinkInvitationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SendAsMail == input.SendAsMail ||
                    this.SendAsMail.Equals(input.SendAsMail)
                ) && 
                (
                    this.TargetOrganization == input.TargetOrganization ||
                    (this.TargetOrganization != null &&
                    this.TargetOrganization.Equals(input.TargetOrganization))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Modules == input.Modules ||
                    this.Modules != null &&
                    input.Modules != null &&
                    this.Modules.SequenceEqual(input.Modules)
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
                hashCode = (hashCode * 59) + this.SendAsMail.GetHashCode();
                if (this.TargetOrganization != null)
                {
                    hashCode = (hashCode * 59) + this.TargetOrganization.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Modules != null)
                {
                    hashCode = (hashCode * 59) + this.Modules.GetHashCode();
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
            // TargetOrganization (string) minLength
            if (this.TargetOrganization != null && this.TargetOrganization.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TargetOrganization, length must be greater than 1.", new [] { "TargetOrganization" });
            }

            // Email (string) minLength
            if (this.Email != null && this.Email.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 1.", new [] { "Email" });
            }

            yield break;
        }
    }

}

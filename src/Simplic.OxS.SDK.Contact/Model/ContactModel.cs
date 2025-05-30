/*
 * Simplic.OxS.Contact
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

namespace Simplic.OxS.SDK.Contact
{
    /// <summary>
    /// ContactModel
    /// </summary>
    [DataContract(Name = "ContactModel")]
    public partial class ContactModel : IEquatable<ContactModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactModel" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="primaryEmailAddress">primaryEmailAddress.</param>
        /// <param name="primaryPhoneNumber">primaryPhoneNumber.</param>
        /// <param name="emailAddresses">emailAddresses.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="matchCode">matchCode.</param>
        /// <param name="functions">functions.</param>
        /// <param name="id">id.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="createDateTime">createDateTime.</param>
        /// <param name="createUserId">createUserId.</param>
        /// <param name="createUserName">createUserName.</param>
        /// <param name="updateDateTime">updateDateTime.</param>
        /// <param name="updateUserId">updateUserId.</param>
        /// <param name="updateUserName">updateUserName.</param>
        /// <param name="organizationId">organizationId.</param>
        public ContactModel(AddressModel address = default(AddressModel), EmailAddressModel primaryEmailAddress = default(EmailAddressModel), PhoneNumber primaryPhoneNumber = default(PhoneNumber), List<EmailAddressModel> emailAddresses = default(List<EmailAddressModel>), List<PhoneNumberModel> phoneNumbers = default(List<PhoneNumberModel>), string matchCode = default(string), List<string> functions = default(List<string>), Guid id = default(Guid), bool isDeleted = default(bool), DateTime createDateTime = default(DateTime), Guid? createUserId = default(Guid?), string createUserName = default(string), DateTime updateDateTime = default(DateTime), Guid? updateUserId = default(Guid?), string updateUserName = default(string), Guid organizationId = default(Guid))
        {
            this.Address = address;
            this.PrimaryEmailAddress = primaryEmailAddress;
            this.PrimaryPhoneNumber = primaryPhoneNumber;
            this.EmailAddresses = emailAddresses;
            this.PhoneNumbers = phoneNumbers;
            this.MatchCode = matchCode;
            this.Functions = functions;
            this.Id = id;
            this.IsDeleted = isDeleted;
            this.CreateDateTime = createDateTime;
            this.CreateUserId = createUserId;
            this.CreateUserName = createUserName;
            this.UpdateDateTime = updateDateTime;
            this.UpdateUserId = updateUserId;
            this.UpdateUserName = updateUserName;
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AddressModel Address { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryEmailAddress
        /// </summary>
        [DataMember(Name = "primaryEmailAddress", EmitDefaultValue = false)]
        public EmailAddressModel PrimaryEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryPhoneNumber
        /// </summary>
        [DataMember(Name = "primaryPhoneNumber", EmitDefaultValue = false)]
        public PhoneNumber PrimaryPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddresses
        /// </summary>
        [DataMember(Name = "emailAddresses", EmitDefaultValue = true)]
        public List<EmailAddressModel> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name = "phoneNumbers", EmitDefaultValue = true)]
        public List<PhoneNumberModel> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or Sets MatchCode
        /// </summary>
        [DataMember(Name = "matchCode", EmitDefaultValue = true)]
        public string MatchCode { get; set; }

        /// <summary>
        /// Gets or Sets Functions
        /// </summary>
        [DataMember(Name = "functions", EmitDefaultValue = true)]
        public List<string> Functions { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateTime
        /// </summary>
        [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreateUserId
        /// </summary>
        [DataMember(Name = "createUserId", EmitDefaultValue = true)]
        public Guid? CreateUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreateUserName
        /// </summary>
        [DataMember(Name = "createUserName", EmitDefaultValue = true)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or Sets UpdateDateTime
        /// </summary>
        [DataMember(Name = "updateDateTime", EmitDefaultValue = false)]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdateUserId
        /// </summary>
        [DataMember(Name = "updateUserId", EmitDefaultValue = true)]
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// Gets or Sets UpdateUserName
        /// </summary>
        [DataMember(Name = "updateUserName", EmitDefaultValue = true)]
        public string UpdateUserName { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContactModel {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PrimaryEmailAddress: ").Append(PrimaryEmailAddress).Append("\n");
            sb.Append("  PrimaryPhoneNumber: ").Append(PrimaryPhoneNumber).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  CreateUserName: ").Append(CreateUserName).Append("\n");
            sb.Append("  UpdateDateTime: ").Append(UpdateDateTime).Append("\n");
            sb.Append("  UpdateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("  UpdateUserName: ").Append(UpdateUserName).Append("\n");
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
            return this.Equals(input as ContactModel);
        }

        /// <summary>
        /// Returns true if ContactModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PrimaryEmailAddress == input.PrimaryEmailAddress ||
                    (this.PrimaryEmailAddress != null &&
                    this.PrimaryEmailAddress.Equals(input.PrimaryEmailAddress))
                ) && 
                (
                    this.PrimaryPhoneNumber == input.PrimaryPhoneNumber ||
                    (this.PrimaryPhoneNumber != null &&
                    this.PrimaryPhoneNumber.Equals(input.PrimaryPhoneNumber))
                ) && 
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    input.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.MatchCode == input.MatchCode ||
                    (this.MatchCode != null &&
                    this.MatchCode.Equals(input.MatchCode))
                ) && 
                (
                    this.Functions == input.Functions ||
                    this.Functions != null &&
                    input.Functions != null &&
                    this.Functions.SequenceEqual(input.Functions)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.PrimaryEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryEmailAddress.GetHashCode();
                }
                if (this.PrimaryPhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryPhoneNumber.GetHashCode();
                }
                if (this.EmailAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddresses.GetHashCode();
                }
                if (this.PhoneNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumbers.GetHashCode();
                }
                if (this.MatchCode != null)
                {
                    hashCode = (hashCode * 59) + this.MatchCode.GetHashCode();
                }
                if (this.Functions != null)
                {
                    hashCode = (hashCode * 59) + this.Functions.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
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

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
    /// Shared model of billable contact.
    /// </summary>
    [DataContract(Name = "BillableContactModel")]
    public partial class BillableContactModel : IEquatable<BillableContactModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillableContactModel" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="accountNumber">Gets or sets the account number..</param>
        /// <param name="personalAccountId">Gets or sets the personal account id.     Represents the id of a personal account from the Simplic.ApplicationCollection project.  .</param>
        public BillableContactModel(AddressModel address = default(AddressModel), string accountNumber = default(string), Guid? personalAccountId = default(Guid?))
        {
            this.Address = address;
            this.AccountNumber = accountNumber;
            this.PersonalAccountId = personalAccountId;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AddressModel Address { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>Gets or sets the account number.</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the personal account id.     Represents the id of a personal account from the Simplic.ApplicationCollection project.  
        /// </summary>
        /// <value>Gets or sets the personal account id.     Represents the id of a personal account from the Simplic.ApplicationCollection project.  </value>
        [DataMember(Name = "personalAccountId", EmitDefaultValue = true)]
        public Guid? PersonalAccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillableContactModel {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  PersonalAccountId: ").Append(PersonalAccountId).Append("\n");
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
            return this.Equals(input as BillableContactModel);
        }

        /// <summary>
        /// Returns true if BillableContactModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BillableContactModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillableContactModel input)
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
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.PersonalAccountId == input.PersonalAccountId ||
                    (this.PersonalAccountId != null &&
                    this.PersonalAccountId.Equals(input.PersonalAccountId))
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
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.PersonalAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalAccountId.GetHashCode();
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

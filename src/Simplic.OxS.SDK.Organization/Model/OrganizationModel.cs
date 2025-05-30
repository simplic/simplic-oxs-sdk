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
    /// Represents an organization
    /// </summary>
    [DataContract(Name = "OrganizationModel")]
    public partial class OrganizationModel : IEquatable<OrganizationModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the organization id.</param>
        /// <param name="name">Gets or sets the organization name.</param>
        /// <param name="address">address.</param>
        /// <param name="billingAddressModel">billingAddressModel.</param>
        /// <param name="isDummy">Whether this organization is used for testing purposes.  This allows for deleting it.</param>
        public OrganizationModel(Guid id = default(Guid), string name = default(string), AddressModel address = default(AddressModel), BillingAddressModel billingAddressModel = default(BillingAddressModel), bool isDummy = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.BillingAddressModel = billingAddressModel;
            this.IsDummy = isDummy;
        }

        /// <summary>
        /// Gets or sets the organization id
        /// </summary>
        /// <value>Gets or sets the organization id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the organization name
        /// </summary>
        /// <value>Gets or sets the organization name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AddressModel Address { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddressModel
        /// </summary>
        [DataMember(Name = "billingAddressModel", EmitDefaultValue = false)]
        public BillingAddressModel BillingAddressModel { get; set; }

        /// <summary>
        /// Whether this organization is used for testing purposes.  This allows for deleting it
        /// </summary>
        /// <value>Whether this organization is used for testing purposes.  This allows for deleting it</value>
        [DataMember(Name = "isDummy", EmitDefaultValue = true)]
        public bool IsDummy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BillingAddressModel: ").Append(BillingAddressModel).Append("\n");
            sb.Append("  IsDummy: ").Append(IsDummy).Append("\n");
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
            return this.Equals(input as OrganizationModel);
        }

        /// <summary>
        /// Returns true if OrganizationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationModel input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BillingAddressModel == input.BillingAddressModel ||
                    (this.BillingAddressModel != null &&
                    this.BillingAddressModel.Equals(input.BillingAddressModel))
                ) && 
                (
                    this.IsDummy == input.IsDummy ||
                    this.IsDummy.Equals(input.IsDummy)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.BillingAddressModel != null)
                {
                    hashCode = (hashCode * 59) + this.BillingAddressModel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDummy.GetHashCode();
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

/*
 * Simplic.OxS.Telematic
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

namespace Simplic.OxS.SDK.Telematic
{
    /// <summary>
    /// TelematicConfigurationResponse
    /// </summary>
    [DataContract(Name = "TelematicConfigurationResponse")]
    public partial class TelematicConfigurationResponse : IEquatable<TelematicConfigurationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelematicConfigurationResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="providerName">providerName.</param>
        /// <param name="providerConfiguration">providerConfiguration.</param>
        /// <param name="createDateTime">createDateTime.</param>
        /// <param name="createUserId">createUserId.</param>
        /// <param name="createUserName">createUserName.</param>
        /// <param name="updateDateTime">updateDateTime.</param>
        /// <param name="updateUserId">updateUserId.</param>
        /// <param name="updateUserName">updateUserName.</param>
        public TelematicConfigurationResponse(Guid id = default(Guid), string providerName = default(string), ProviderConfigurationModel providerConfiguration = default(ProviderConfigurationModel), DateTime createDateTime = default(DateTime), Guid? createUserId = default(Guid?), string createUserName = default(string), DateTime updateDateTime = default(DateTime), Guid? updateUserId = default(Guid?), string updateUserName = default(string))
        {
            this.Id = id;
            this.ProviderName = providerName;
            this.ProviderConfiguration = providerConfiguration;
            this.CreateDateTime = createDateTime;
            this.CreateUserId = createUserId;
            this.CreateUserName = createUserName;
            this.UpdateDateTime = updateDateTime;
            this.UpdateUserId = updateUserId;
            this.UpdateUserName = updateUserName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name = "providerName", EmitDefaultValue = true)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or Sets ProviderConfiguration
        /// </summary>
        [DataMember(Name = "providerConfiguration", EmitDefaultValue = false)]
        public ProviderConfigurationModel ProviderConfiguration { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TelematicConfigurationResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  ProviderConfiguration: ").Append(ProviderConfiguration).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  CreateUserName: ").Append(CreateUserName).Append("\n");
            sb.Append("  UpdateDateTime: ").Append(UpdateDateTime).Append("\n");
            sb.Append("  UpdateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("  UpdateUserName: ").Append(UpdateUserName).Append("\n");
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
            return this.Equals(input as TelematicConfigurationResponse);
        }

        /// <summary>
        /// Returns true if TelematicConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TelematicConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelematicConfigurationResponse input)
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
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.ProviderConfiguration == input.ProviderConfiguration ||
                    (this.ProviderConfiguration != null &&
                    this.ProviderConfiguration.Equals(input.ProviderConfiguration))
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
                if (this.ProviderName != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderName.GetHashCode();
                }
                if (this.ProviderConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderConfiguration.GetHashCode();
                }
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

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
using OpenAPIDateConverter = Simplic.OxS.SDK.Telematic.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Telematic
{
    /// <summary>
    /// ProviderConfigurationModel
    /// </summary>
    [DataContract(Name = "ProviderConfigurationModel")]
    public partial class ProviderConfigurationModel : IEquatable<ProviderConfigurationModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderConfigurationModel" /> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="apiKey">apiKey.</param>
        /// <param name="systemNr">systemNr.</param>
        /// <param name="integrator">integrator.</param>
        public ProviderConfigurationModel(string username = default(string), string password = default(string), string accountName = default(string), string apiKey = default(string), int systemNr = default(int), string integrator = default(string))
        {
            this.Username = username;
            this.Password = password;
            this.AccountName = accountName;
            this.ApiKey = apiKey;
            this.SystemNr = systemNr;
            this.Integrator = integrator;
        }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name = "accountName", EmitDefaultValue = true)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name = "apiKey", EmitDefaultValue = true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets SystemNr
        /// </summary>
        [DataMember(Name = "systemNr", EmitDefaultValue = false)]
        public int SystemNr { get; set; }

        /// <summary>
        /// Gets or Sets Integrator
        /// </summary>
        [DataMember(Name = "integrator", EmitDefaultValue = true)]
        public string Integrator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProviderConfigurationModel {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  SystemNr: ").Append(SystemNr).Append("\n");
            sb.Append("  Integrator: ").Append(Integrator).Append("\n");
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
            return this.Equals(input as ProviderConfigurationModel);
        }

        /// <summary>
        /// Returns true if ProviderConfigurationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProviderConfigurationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProviderConfigurationModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.SystemNr == input.SystemNr ||
                    this.SystemNr.Equals(input.SystemNr)
                ) && 
                (
                    this.Integrator == input.Integrator ||
                    (this.Integrator != null &&
                    this.Integrator.Equals(input.Integrator))
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
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.ApiKey != null)
                {
                    hashCode = (hashCode * 59) + this.ApiKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SystemNr.GetHashCode();
                if (this.Integrator != null)
                {
                    hashCode = (hashCode * 59) + this.Integrator.GetHashCode();
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

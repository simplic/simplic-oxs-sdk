/*
 * Simplic.OxS.storage-management
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

namespace Simplic.OxS.SDK.Storage.Management
{
    /// <summary>
    /// SignatureUserModel
    /// </summary>
    [DataContract(Name = "SignatureUserModel")]
    public partial class SignatureUserModel : IEquatable<SignatureUserModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureUserModel" /> class.
        /// </summary>
        /// <param name="signatureUrl">signatureUrl.</param>
        /// <param name="userId">userId.</param>
        /// <param name="name">name.</param>
        public SignatureUserModel(Guid signatureUrl = default(Guid), Guid? userId = default(Guid?), string name = default(string))
        {
            this.SignatureUrl = signatureUrl;
            this.UserId = userId;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets SignatureUrl
        /// </summary>
        [DataMember(Name = "signatureUrl", EmitDefaultValue = false)]
        public Guid SignatureUrl { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureUserModel {\n");
            sb.Append("  SignatureUrl: ").Append(SignatureUrl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as SignatureUserModel);
        }

        /// <summary>
        /// Returns true if SignatureUserModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureUserModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureUserModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignatureUrl == input.SignatureUrl ||
                    (this.SignatureUrl != null &&
                    this.SignatureUrl.Equals(input.SignatureUrl))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.SignatureUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureUrl.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
/*
 * Simplic.OxS.Auth
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

namespace Simplic.OxS.SDK.Auth
{
    /// <summary>
    /// VerifyMailRequest
    /// </summary>
    [DataContract(Name = "VerifyMailRequest")]
    public partial class VerifyMailRequest : IEquatable<VerifyMailRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyMailRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyMailRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyMailRequest" /> class.
        /// </summary>
        /// <param name="email">Gets or sets the mail-address to verify (required).</param>
        /// <param name="code">Gets or sets the verification code (required).</param>
        public VerifyMailRequest(string email = default(string), string code = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for VerifyMailRequest and cannot be null");
            }
            this.Email = email;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for VerifyMailRequest and cannot be null");
            }
            this.Code = code;
        }

        /// <summary>
        /// Gets or sets the mail-address to verify
        /// </summary>
        /// <value>Gets or sets the mail-address to verify</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the verification code
        /// </summary>
        /// <value>Gets or sets the verification code</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerifyMailRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as VerifyMailRequest);
        }

        /// <summary>
        /// Returns true if VerifyMailRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyMailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyMailRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
            // Email (string) minLength
            if (this.Email != null && this.Email.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 1.", new [] { "Email" });
            }

            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            yield break;
        }
    }

}

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
    /// RegisterRequest
    /// </summary>
    [DataContract(Name = "RegisterRequest")]
    public partial class RegisterRequest : IEquatable<RegisterRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRequest" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="password">password (required).</param>
        public RegisterRequest(string email = default(string), string password = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for RegisterRequest and cannot be null");
            }
            this.Email = email;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for RegisterRequest and cannot be null");
            }
            this.Password = password;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegisterRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as RegisterRequest);
        }

        /// <summary>
        /// Returns true if RegisterRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterRequest input)
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
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
            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 255.", new [] { "Email" });
            }

            // Email (string) minLength
            if (this.Email != null && this.Email.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 5.", new [] { "Email" });
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 100.", new [] { "Password" });
            }

            // Password (string) minLength
            if (this.Password != null && this.Password.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 8.", new [] { "Password" });
            }

            yield break;
        }
    }

}
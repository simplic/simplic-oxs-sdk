/*
 * Simplic.OxS.Document
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

namespace Simplic.OxS.SDK.Document
{
    /// <summary>
    /// ValidateDocumentSignatureResponse
    /// </summary>
    [DataContract(Name = "ValidateDocumentSignatureResponse")]
    public partial class ValidateDocumentSignatureResponse : IEquatable<ValidateDocumentSignatureResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateDocumentSignatureResponse" /> class.
        /// </summary>
        /// <param name="isValid">isValid.</param>
        /// <param name="signatures">signatures.</param>
        public ValidateDocumentSignatureResponse(bool? isValid = default(bool?), List<Signature> signatures = default(List<Signature>))
        {
            this.IsValid = isValid;
            this.Signatures = signatures;
        }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "isValid", EmitDefaultValue = true)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Gets or Sets Signatures
        /// </summary>
        [DataMember(Name = "signatures", EmitDefaultValue = true)]
        public List<Signature> Signatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidateDocumentSignatureResponse {\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Signatures: ").Append(Signatures).Append("\n");
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
            return this.Equals(input as ValidateDocumentSignatureResponse);
        }

        /// <summary>
        /// Returns true if ValidateDocumentSignatureResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateDocumentSignatureResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateDocumentSignatureResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsValid == input.IsValid ||
                    (this.IsValid != null &&
                    this.IsValid.Equals(input.IsValid))
                ) && 
                (
                    this.Signatures == input.Signatures ||
                    this.Signatures != null &&
                    input.Signatures != null &&
                    this.Signatures.SequenceEqual(input.Signatures)
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
                if (this.IsValid != null)
                {
                    hashCode = (hashCode * 59) + this.IsValid.GetHashCode();
                }
                if (this.Signatures != null)
                {
                    hashCode = (hashCode * 59) + this.Signatures.GetHashCode();
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

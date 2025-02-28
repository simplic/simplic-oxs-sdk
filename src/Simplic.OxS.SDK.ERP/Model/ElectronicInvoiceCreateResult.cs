/*
 * Simplic.OxS.ERP
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

namespace Simplic.OxS.SDK.ERP
{
    /// <summary>
    /// ElectronicInvoiceCreateResult
    /// </summary>
    [DataContract(Name = "ElectronicInvoiceCreateResult")]
    public partial class ElectronicInvoiceCreateResult : IEquatable<ElectronicInvoiceCreateResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicInvoiceCreateResult" /> class.
        /// </summary>
        /// <param name="electronicInvoice">electronicInvoice.</param>
        /// <param name="validationResult">validationResult.</param>
        public ElectronicInvoiceCreateResult(byte[] electronicInvoice = default(byte[]), InvoiceValidationResult validationResult = default(InvoiceValidationResult))
        {
            this.ElectronicInvoice = electronicInvoice;
            this.ValidationResult = validationResult;
        }

        /// <summary>
        /// Gets or Sets ElectronicInvoice
        /// </summary>
        [DataMember(Name = "electronicInvoice", EmitDefaultValue = true)]
        public byte[] ElectronicInvoice { get; set; }

        /// <summary>
        /// Gets or Sets ValidationResult
        /// </summary>
        [DataMember(Name = "validationResult", EmitDefaultValue = false)]
        public InvoiceValidationResult ValidationResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ElectronicInvoiceCreateResult {\n");
            sb.Append("  ElectronicInvoice: ").Append(ElectronicInvoice).Append("\n");
            sb.Append("  ValidationResult: ").Append(ValidationResult).Append("\n");
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
            return this.Equals(input as ElectronicInvoiceCreateResult);
        }

        /// <summary>
        /// Returns true if ElectronicInvoiceCreateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectronicInvoiceCreateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectronicInvoiceCreateResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ElectronicInvoice == input.ElectronicInvoice ||
                    (this.ElectronicInvoice != null &&
                    this.ElectronicInvoice.Equals(input.ElectronicInvoice))
                ) && 
                (
                    this.ValidationResult == input.ValidationResult ||
                    (this.ValidationResult != null &&
                    this.ValidationResult.Equals(input.ValidationResult))
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
                if (this.ElectronicInvoice != null)
                {
                    hashCode = (hashCode * 59) + this.ElectronicInvoice.GetHashCode();
                }
                if (this.ValidationResult != null)
                {
                    hashCode = (hashCode * 59) + this.ValidationResult.GetHashCode();
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

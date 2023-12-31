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
    /// ConvertTransactionRequest
    /// </summary>
    [DataContract(Name = "ConvertTransactionRequest")]
    public partial class ConvertTransactionRequest : IEquatable<ConvertTransactionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertTransactionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConvertTransactionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertTransactionRequest" /> class.
        /// </summary>
        /// <param name="transactionSubsets">transactionSubsets (required).</param>
        /// <param name="targetTypeId">targetTypeId (required).</param>
        /// <param name="checkCompatibleProperties">checkCompatibleProperties.</param>
        public ConvertTransactionRequest(Dictionary<string, Dictionary<string, double>> transactionSubsets = default(Dictionary<string, Dictionary<string, double>>), Guid targetTypeId = default(Guid), List<string> checkCompatibleProperties = default(List<string>))
        {
            // to ensure "transactionSubsets" is required (not null)
            if (transactionSubsets == null)
            {
                throw new ArgumentNullException("transactionSubsets is a required property for ConvertTransactionRequest and cannot be null");
            }
            this.TransactionSubsets = transactionSubsets;
            this.TargetTypeId = targetTypeId;
            this.CheckCompatibleProperties = checkCompatibleProperties;
        }

        /// <summary>
        /// Gets or Sets TransactionSubsets
        /// </summary>
        [DataMember(Name = "transactionSubsets", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Dictionary<string, double>> TransactionSubsets { get; set; }

        /// <summary>
        /// Gets or Sets TargetTypeId
        /// </summary>
        [DataMember(Name = "targetTypeId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TargetTypeId { get; set; }

        /// <summary>
        /// Gets or Sets CheckCompatibleProperties
        /// </summary>
        [DataMember(Name = "checkCompatibleProperties", EmitDefaultValue = true)]
        public List<string> CheckCompatibleProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConvertTransactionRequest {\n");
            sb.Append("  TransactionSubsets: ").Append(TransactionSubsets).Append("\n");
            sb.Append("  TargetTypeId: ").Append(TargetTypeId).Append("\n");
            sb.Append("  CheckCompatibleProperties: ").Append(CheckCompatibleProperties).Append("\n");
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
            return this.Equals(input as ConvertTransactionRequest);
        }

        /// <summary>
        /// Returns true if ConvertTransactionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvertTransactionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertTransactionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionSubsets == input.TransactionSubsets ||
                    this.TransactionSubsets != null &&
                    input.TransactionSubsets != null &&
                    this.TransactionSubsets.SequenceEqual(input.TransactionSubsets)
                ) && 
                (
                    this.TargetTypeId == input.TargetTypeId ||
                    (this.TargetTypeId != null &&
                    this.TargetTypeId.Equals(input.TargetTypeId))
                ) && 
                (
                    this.CheckCompatibleProperties == input.CheckCompatibleProperties ||
                    this.CheckCompatibleProperties != null &&
                    input.CheckCompatibleProperties != null &&
                    this.CheckCompatibleProperties.SequenceEqual(input.CheckCompatibleProperties)
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
                if (this.TransactionSubsets != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionSubsets.GetHashCode();
                }
                if (this.TargetTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetTypeId.GetHashCode();
                }
                if (this.CheckCompatibleProperties != null)
                {
                    hashCode = (hashCode * 59) + this.CheckCompatibleProperties.GetHashCode();
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

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
    /// Represents the shared model for the result of converting a transaction.
    /// </summary>
    [DataContract(Name = "ConvertResultModel")]
    public partial class ConvertResultModel : IEquatable<ConvertResultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertResultModel" /> class.
        /// </summary>
        /// <param name="transaction">transaction.</param>
        /// <param name="errors">Gets or sets a set of Simplic.OxS.ERP.ConvertErrorInfo objects..</param>
        /// <param name="convertStates">Gets or sets a set of convert states.  For each converted transaction the convert state is given as the value of a dictionary entry, the key being the transaction&#39;s ID.  &lt;para&gt;&lt;/para&gt;.</param>
        public ConvertResultModel(TransactionModel transaction = default(TransactionModel), List<ConvertErrorInfoModel> errors = default(List<ConvertErrorInfoModel>), Dictionary<string, TransactionConvertState> convertStates = default(Dictionary<string, TransactionConvertState>))
        {
            this.Transaction = transaction;
            this.Errors = errors;
            this.ConvertStates = convertStates;
        }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public TransactionModel Transaction { get; set; }

        /// <summary>
        /// Gets or sets a set of Simplic.OxS.ERP.ConvertErrorInfo objects.
        /// </summary>
        /// <value>Gets or sets a set of Simplic.OxS.ERP.ConvertErrorInfo objects.</value>
        [DataMember(Name = "errors", EmitDefaultValue = true)]
        public List<ConvertErrorInfoModel> Errors { get; set; }

        /// <summary>
        /// Gets or sets a set of convert states.  For each converted transaction the convert state is given as the value of a dictionary entry, the key being the transaction&#39;s ID.  &lt;para&gt;&lt;/para&gt;
        /// </summary>
        /// <value>Gets or sets a set of convert states.  For each converted transaction the convert state is given as the value of a dictionary entry, the key being the transaction&#39;s ID.  &lt;para&gt;&lt;/para&gt;</value>
        [DataMember(Name = "convertStates", EmitDefaultValue = true)]
        public Dictionary<string, TransactionConvertState> ConvertStates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConvertResultModel {\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  ConvertStates: ").Append(ConvertStates).Append("\n");
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
            return this.Equals(input as ConvertResultModel);
        }

        /// <summary>
        /// Returns true if ConvertResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvertResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertResultModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.ConvertStates == input.ConvertStates ||
                    this.ConvertStates != null &&
                    input.ConvertStates != null &&
                    this.ConvertStates.SequenceEqual(input.ConvertStates)
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
                if (this.Transaction != null)
                {
                    hashCode = (hashCode * 59) + this.Transaction.GetHashCode();
                }
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                }
                if (this.ConvertStates != null)
                {
                    hashCode = (hashCode * 59) + this.ConvertStates.GetHashCode();
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

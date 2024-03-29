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
    /// TransactionPriceObjectModel
    /// </summary>
    [DataContract(Name = "TransactionPriceObjectModel")]
    public partial class TransactionPriceObjectModel : IEquatable<TransactionPriceObjectModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPriceObjectModel" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="singlePriceNet">singlePriceNet.</param>
        /// <param name="totalPriceNet">totalPriceNet.</param>
        /// <param name="singlePriceGross">singlePriceGross.</param>
        /// <param name="totalPriceGross">totalPriceGross.</param>
        /// <param name="singlePriceVat">singlePriceVat.</param>
        /// <param name="totalPriceVat">totalPriceVat.</param>
        public TransactionPriceObjectModel(string description = default(string), double singlePriceNet = default(double), double totalPriceNet = default(double), double singlePriceGross = default(double), double totalPriceGross = default(double), double singlePriceVat = default(double), double totalPriceVat = default(double))
        {
            this.Description = description;
            this.SinglePriceNet = singlePriceNet;
            this.TotalPriceNet = totalPriceNet;
            this.SinglePriceGross = singlePriceGross;
            this.TotalPriceGross = totalPriceGross;
            this.SinglePriceVat = singlePriceVat;
            this.TotalPriceVat = totalPriceVat;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SinglePriceNet
        /// </summary>
        [DataMember(Name = "singlePriceNet", EmitDefaultValue = false)]
        public double SinglePriceNet { get; set; }

        /// <summary>
        /// Gets or Sets TotalPriceNet
        /// </summary>
        [DataMember(Name = "totalPriceNet", EmitDefaultValue = false)]
        public double TotalPriceNet { get; set; }

        /// <summary>
        /// Gets or Sets SinglePriceGross
        /// </summary>
        [DataMember(Name = "singlePriceGross", EmitDefaultValue = false)]
        public double SinglePriceGross { get; set; }

        /// <summary>
        /// Gets or Sets TotalPriceGross
        /// </summary>
        [DataMember(Name = "totalPriceGross", EmitDefaultValue = false)]
        public double TotalPriceGross { get; set; }

        /// <summary>
        /// Gets or Sets SinglePriceVat
        /// </summary>
        [DataMember(Name = "singlePriceVat", EmitDefaultValue = false)]
        public double SinglePriceVat { get; set; }

        /// <summary>
        /// Gets or Sets TotalPriceVat
        /// </summary>
        [DataMember(Name = "totalPriceVat", EmitDefaultValue = false)]
        public double TotalPriceVat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionPriceObjectModel {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SinglePriceNet: ").Append(SinglePriceNet).Append("\n");
            sb.Append("  TotalPriceNet: ").Append(TotalPriceNet).Append("\n");
            sb.Append("  SinglePriceGross: ").Append(SinglePriceGross).Append("\n");
            sb.Append("  TotalPriceGross: ").Append(TotalPriceGross).Append("\n");
            sb.Append("  SinglePriceVat: ").Append(SinglePriceVat).Append("\n");
            sb.Append("  TotalPriceVat: ").Append(TotalPriceVat).Append("\n");
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
            return this.Equals(input as TransactionPriceObjectModel);
        }

        /// <summary>
        /// Returns true if TransactionPriceObjectModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionPriceObjectModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionPriceObjectModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SinglePriceNet == input.SinglePriceNet ||
                    this.SinglePriceNet.Equals(input.SinglePriceNet)
                ) && 
                (
                    this.TotalPriceNet == input.TotalPriceNet ||
                    this.TotalPriceNet.Equals(input.TotalPriceNet)
                ) && 
                (
                    this.SinglePriceGross == input.SinglePriceGross ||
                    this.SinglePriceGross.Equals(input.SinglePriceGross)
                ) && 
                (
                    this.TotalPriceGross == input.TotalPriceGross ||
                    this.TotalPriceGross.Equals(input.TotalPriceGross)
                ) && 
                (
                    this.SinglePriceVat == input.SinglePriceVat ||
                    this.SinglePriceVat.Equals(input.SinglePriceVat)
                ) && 
                (
                    this.TotalPriceVat == input.TotalPriceVat ||
                    this.TotalPriceVat.Equals(input.TotalPriceVat)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SinglePriceNet.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPriceNet.GetHashCode();
                hashCode = (hashCode * 59) + this.SinglePriceGross.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPriceGross.GetHashCode();
                hashCode = (hashCode * 59) + this.SinglePriceVat.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPriceVat.GetHashCode();
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

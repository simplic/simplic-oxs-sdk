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
    /// CreditLimitModel
    /// </summary>
    [DataContract(Name = "CreditLimitModel")]
    public partial class CreditLimitModel : IEquatable<CreditLimitModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditLimitModel" /> class.
        /// </summary>
        /// <param name="insurance">insurance.</param>
        /// <param name="creditworthiness">creditworthiness.</param>
        /// <param name="limit">limit.</param>
        public CreditLimitModel(double insurance = default(double), string creditworthiness = default(string), string limit = default(string))
        {
            this.Insurance = insurance;
            this.Creditworthiness = creditworthiness;
            this.Limit = limit;
        }

        /// <summary>
        /// Gets or Sets Insurance
        /// </summary>
        [DataMember(Name = "insurance", EmitDefaultValue = false)]
        public double Insurance { get; set; }

        /// <summary>
        /// Gets or Sets Creditworthiness
        /// </summary>
        [DataMember(Name = "creditworthiness", EmitDefaultValue = true)]
        public string Creditworthiness { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public string Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditLimitModel {\n");
            sb.Append("  Insurance: ").Append(Insurance).Append("\n");
            sb.Append("  Creditworthiness: ").Append(Creditworthiness).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as CreditLimitModel);
        }

        /// <summary>
        /// Returns true if CreditLimitModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditLimitModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditLimitModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Insurance == input.Insurance ||
                    this.Insurance.Equals(input.Insurance)
                ) && 
                (
                    this.Creditworthiness == input.Creditworthiness ||
                    (this.Creditworthiness != null &&
                    this.Creditworthiness.Equals(input.Creditworthiness))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                hashCode = (hashCode * 59) + this.Insurance.GetHashCode();
                if (this.Creditworthiness != null)
                {
                    hashCode = (hashCode * 59) + this.Creditworthiness.GetHashCode();
                }
                if (this.Limit != null)
                {
                    hashCode = (hashCode * 59) + this.Limit.GetHashCode();
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
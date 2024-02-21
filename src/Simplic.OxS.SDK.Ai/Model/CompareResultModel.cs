/*
 * Simplic.OxS.ai
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

namespace Simplic.OxS.SDK.Ai
{
    /// <summary>
    /// CompareResultModel
    /// </summary>
    [DataContract(Name = "CompareResultModel")]
    public partial class CompareResultModel : IEquatable<CompareResultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompareResultModel" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="similarity">similarity.</param>
        /// <param name="predictedLabel">predictedLabel.</param>
        public CompareResultModel(string key = default(string), double similarity = default(double), string predictedLabel = default(string))
        {
            this.Key = key;
            this.Similarity = similarity;
            this.PredictedLabel = predictedLabel;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Similarity
        /// </summary>
        [DataMember(Name = "similarity", EmitDefaultValue = false)]
        public double Similarity { get; set; }

        /// <summary>
        /// Gets or Sets PredictedLabel
        /// </summary>
        [DataMember(Name = "predictedLabel", EmitDefaultValue = true)]
        public string PredictedLabel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompareResultModel {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Similarity: ").Append(Similarity).Append("\n");
            sb.Append("  PredictedLabel: ").Append(PredictedLabel).Append("\n");
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
            return this.Equals(input as CompareResultModel);
        }

        /// <summary>
        /// Returns true if CompareResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CompareResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompareResultModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Similarity == input.Similarity ||
                    this.Similarity.Equals(input.Similarity)
                ) && 
                (
                    this.PredictedLabel == input.PredictedLabel ||
                    (this.PredictedLabel != null &&
                    this.PredictedLabel.Equals(input.PredictedLabel))
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Similarity.GetHashCode();
                if (this.PredictedLabel != null)
                {
                    hashCode = (hashCode * 59) + this.PredictedLabel.GetHashCode();
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
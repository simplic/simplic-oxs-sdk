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
    /// SearchRequest
    /// </summary>
    [DataContract(Name = "SearchRequest")]
    public partial class SearchRequest : IEquatable<SearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="minSimilarity">minSimilarity.</param>
        /// <param name="maxResults">maxResults.</param>
        /// <param name="input">input (required).</param>
        /// <param name="hashAlgorithm">hashAlgorithm.</param>
        /// <param name="aiSettings">aiSettings.</param>
        public SearchRequest(double minSimilarity = default(double), int maxResults = default(int), string input = default(string), string hashAlgorithm = default(string), AISettings aiSettings = default(AISettings))
        {
            // to ensure "input" is required (not null)
            if (input == null)
            {
                throw new ArgumentNullException("input is a required property for SearchRequest and cannot be null");
            }
            this.Input = input;
            this.MinSimilarity = minSimilarity;
            this.MaxResults = maxResults;
            this.HashAlgorithm = hashAlgorithm;
            this.AiSettings = aiSettings;
        }

        /// <summary>
        /// Gets or Sets MinSimilarity
        /// </summary>
        [DataMember(Name = "minSimilarity", EmitDefaultValue = false)]
        public double MinSimilarity { get; set; }

        /// <summary>
        /// Gets or Sets MaxResults
        /// </summary>
        [DataMember(Name = "maxResults", EmitDefaultValue = false)]
        public int MaxResults { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name = "input", IsRequired = true, EmitDefaultValue = true)]
        public string Input { get; set; }

        /// <summary>
        /// Gets or Sets HashAlgorithm
        /// </summary>
        [DataMember(Name = "hashAlgorithm", EmitDefaultValue = true)]
        public string HashAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets AiSettings
        /// </summary>
        [DataMember(Name = "aiSettings", EmitDefaultValue = false)]
        public AISettings AiSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchRequest {\n");
            sb.Append("  MinSimilarity: ").Append(MinSimilarity).Append("\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
            sb.Append("  AiSettings: ").Append(AiSettings).Append("\n");
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
            return this.Equals(input as SearchRequest);
        }

        /// <summary>
        /// Returns true if SearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MinSimilarity == input.MinSimilarity ||
                    this.MinSimilarity.Equals(input.MinSimilarity)
                ) && 
                (
                    this.MaxResults == input.MaxResults ||
                    this.MaxResults.Equals(input.MaxResults)
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.HashAlgorithm == input.HashAlgorithm ||
                    (this.HashAlgorithm != null &&
                    this.HashAlgorithm.Equals(input.HashAlgorithm))
                ) && 
                (
                    this.AiSettings == input.AiSettings ||
                    (this.AiSettings != null &&
                    this.AiSettings.Equals(input.AiSettings))
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
                hashCode = (hashCode * 59) + this.MinSimilarity.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxResults.GetHashCode();
                if (this.Input != null)
                {
                    hashCode = (hashCode * 59) + this.Input.GetHashCode();
                }
                if (this.HashAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.HashAlgorithm.GetHashCode();
                }
                if (this.AiSettings != null)
                {
                    hashCode = (hashCode * 59) + this.AiSettings.GetHashCode();
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
            // Input (string) minLength
            if (this.Input != null && this.Input.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Input, length must be greater than 1.", new [] { "Input" });
            }

            yield break;
        }
    }

}
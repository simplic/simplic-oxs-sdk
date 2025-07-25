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
    /// EmbeddedDocumentModel
    /// </summary>
    [DataContract(Name = "EmbeddedDocumentModel")]
    public partial class EmbeddedDocumentModel : IEquatable<EmbeddedDocumentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedDocumentModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedDocumentModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedDocumentModel" /> class.
        /// </summary>
        /// <param name="content">content (required).</param>
        /// <param name="dataType">dataType (required).</param>
        /// <param name="addToSearchIndex">addToSearchIndex (default to false).</param>
        public EmbeddedDocumentModel(string content = default(string), string dataType = default(string), bool addToSearchIndex = false)
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for EmbeddedDocumentModel and cannot be null");
            }
            this.Content = content;
            // to ensure "dataType" is required (not null)
            if (dataType == null)
            {
                throw new ArgumentNullException("dataType is a required property for EmbeddedDocumentModel and cannot be null");
            }
            this.DataType = dataType;
            this.AddToSearchIndex = addToSearchIndex;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "dataType", IsRequired = true, EmitDefaultValue = true)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets AddToSearchIndex
        /// </summary>
        [DataMember(Name = "addToSearchIndex", EmitDefaultValue = true)]
        public bool AddToSearchIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmbeddedDocumentModel {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  AddToSearchIndex: ").Append(AddToSearchIndex).Append("\n");
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
            return this.Equals(input as EmbeddedDocumentModel);
        }

        /// <summary>
        /// Returns true if EmbeddedDocumentModel instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedDocumentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedDocumentModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.AddToSearchIndex == input.AddToSearchIndex ||
                    this.AddToSearchIndex.Equals(input.AddToSearchIndex)
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.DataType != null)
                {
                    hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AddToSearchIndex.GetHashCode();
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
            // Content (string) minLength
            if (this.Content != null && this.Content.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Content, length must be greater than 1.", new [] { "Content" });
            }

            // DataType (string) minLength
            if (this.DataType != null && this.DataType.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DataType, length must be greater than 3.", new [] { "DataType" });
            }

            yield break;
        }
    }

}

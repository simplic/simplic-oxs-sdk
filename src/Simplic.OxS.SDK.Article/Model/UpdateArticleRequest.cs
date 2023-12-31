/*
 * Simplic.OxS.Article
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

namespace Simplic.OxS.SDK.Article
{
    /// <summary>
    /// UpdateArticleRequest
    /// </summary>
    [DataContract(Name = "UpdateArticleRequest")]
    public partial class UpdateArticleRequest : IEquatable<UpdateArticleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateArticleRequest" /> class.
        /// </summary>
        /// <param name="shortName">shortName.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="number">number.</param>
        /// <param name="ean">ean.</param>
        /// <param name="articleGroupId">articleGroupId.</param>
        public UpdateArticleRequest(string shortName = default(string), string fullName = default(string), string number = default(string), string ean = default(string), Guid? articleGroupId = default(Guid?))
        {
            this.ShortName = shortName;
            this.FullName = fullName;
            this.Number = number;
            this.Ean = ean;
            this.ArticleGroupId = articleGroupId;
        }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = true)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "fullName", EmitDefaultValue = true)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Ean
        /// </summary>
        [DataMember(Name = "ean", EmitDefaultValue = true)]
        public string Ean { get; set; }

        /// <summary>
        /// Gets or Sets ArticleGroupId
        /// </summary>
        [DataMember(Name = "articleGroupId", EmitDefaultValue = true)]
        public Guid? ArticleGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateArticleRequest {\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Ean: ").Append(Ean).Append("\n");
            sb.Append("  ArticleGroupId: ").Append(ArticleGroupId).Append("\n");
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
            return this.Equals(input as UpdateArticleRequest);
        }

        /// <summary>
        /// Returns true if UpdateArticleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateArticleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateArticleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Ean == input.Ean ||
                    (this.Ean != null &&
                    this.Ean.Equals(input.Ean))
                ) && 
                (
                    this.ArticleGroupId == input.ArticleGroupId ||
                    (this.ArticleGroupId != null &&
                    this.ArticleGroupId.Equals(input.ArticleGroupId))
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
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Ean != null)
                {
                    hashCode = (hashCode * 59) + this.Ean.GetHashCode();
                }
                if (this.ArticleGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.ArticleGroupId.GetHashCode();
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

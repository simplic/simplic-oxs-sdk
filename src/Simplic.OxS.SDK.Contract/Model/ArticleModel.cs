/*
 * Simplic.OxS.Contract
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

namespace Simplic.OxS.SDK.Contract
{
    /// <summary>
    /// ArticleModel
    /// </summary>
    [DataContract(Name = "ArticleModel")]
    public partial class ArticleModel : IEquatable<ArticleModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="number">number.</param>
        /// <param name="uniqueNumber">uniqueNumber.</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="articleGroup">articleGroup.</param>
        public ArticleModel(Guid id = default(Guid), string description = default(string), int number = default(int), int uniqueNumber = default(int), string shortName = default(string), string fullName = default(string), ArticleGroupModel articleGroup = default(ArticleGroupModel))
        {
            this.Id = id;
            this.Description = description;
            this.Number = number;
            this.UniqueNumber = uniqueNumber;
            this.ShortName = shortName;
            this.FullName = fullName;
            this.ArticleGroup = articleGroup;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets UniqueNumber
        /// </summary>
        [DataMember(Name = "uniqueNumber", EmitDefaultValue = false)]
        public int UniqueNumber { get; set; }

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
        /// Gets or Sets ArticleGroup
        /// </summary>
        [DataMember(Name = "articleGroup", EmitDefaultValue = false)]
        public ArticleGroupModel ArticleGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArticleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  UniqueNumber: ").Append(UniqueNumber).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  ArticleGroup: ").Append(ArticleGroup).Append("\n");
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
            return this.Equals(input as ArticleModel);
        }

        /// <summary>
        /// Returns true if ArticleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ArticleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.UniqueNumber == input.UniqueNumber ||
                    this.UniqueNumber.Equals(input.UniqueNumber)
                ) && 
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
                    this.ArticleGroup == input.ArticleGroup ||
                    (this.ArticleGroup != null &&
                    this.ArticleGroup.Equals(input.ArticleGroup))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                hashCode = (hashCode * 59) + this.UniqueNumber.GetHashCode();
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.ArticleGroup != null)
                {
                    hashCode = (hashCode * 59) + this.ArticleGroup.GetHashCode();
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

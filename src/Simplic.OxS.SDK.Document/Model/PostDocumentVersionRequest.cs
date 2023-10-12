/*
 * Simplic.OxS.Document
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
using OpenAPIDateConverter = Simplic.OxS.SDK.Document.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Document
{
    /// <summary>
    /// PostDocumentVersionRequest
    /// </summary>
    [DataContract(Name = "PostDocumentVersionRequest")]
    public partial class PostDocumentVersionRequest : IEquatable<PostDocumentVersionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDocumentVersionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostDocumentVersionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDocumentVersionRequest" /> class.
        /// </summary>
        /// <param name="url">url (required).</param>
        /// <param name="fileExtension">fileExtension.</param>
        /// <param name="mimeType">mimeType (required).</param>
        /// <param name="comment">comment.</param>
        /// <param name="fileSize">fileSize (required).</param>
        public PostDocumentVersionRequest(string url = default(string), string fileExtension = default(string), string mimeType = default(string), string comment = default(string), long fileSize = default(long))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for PostDocumentVersionRequest and cannot be null");
            }
            this.Url = url;
            // to ensure "mimeType" is required (not null)
            if (mimeType == null)
            {
                throw new ArgumentNullException("mimeType is a required property for PostDocumentVersionRequest and cannot be null");
            }
            this.MimeType = mimeType;
            this.FileSize = fileSize;
            this.FileExtension = fileExtension;
            this.Comment = comment;
        }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets FileExtension
        /// </summary>
        [DataMember(Name = "fileExtension", EmitDefaultValue = true)]
        public string FileExtension { get; set; }

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name = "mimeType", IsRequired = true, EmitDefaultValue = true)]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name = "fileSize", IsRequired = true, EmitDefaultValue = true)]
        public long FileSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostDocumentVersionRequest {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
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
            return this.Equals(input as PostDocumentVersionRequest);
        }

        /// <summary>
        /// Returns true if PostDocumentVersionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostDocumentVersionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostDocumentVersionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.FileExtension == input.FileExtension ||
                    (this.FileExtension != null &&
                    this.FileExtension.Equals(input.FileExtension))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    this.FileSize.Equals(input.FileSize)
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.FileExtension != null)
                {
                    hashCode = (hashCode * 59) + this.FileExtension.GetHashCode();
                }
                if (this.MimeType != null)
                {
                    hashCode = (hashCode * 59) + this.MimeType.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FileSize.GetHashCode();
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
            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            // MimeType (string) minLength
            if (this.MimeType != null && this.MimeType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MimeType, length must be greater than 1.", new [] { "MimeType" });
            }

            yield break;
        }
    }

}

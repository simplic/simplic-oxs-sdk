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
using OpenAPIDateConverter = Simplic.OxS.SDK.Client.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Model
{
    /// <summary>
    /// PatchDocumentRequest
    /// </summary>
    [DataContract(Name = "PatchDocumentRequest")]
    public partial class PatchDocumentRequest : IEquatable<PatchDocumentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDocumentRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="versions">versions.</param>
        /// <param name="reference">reference.</param>
        /// <param name="barcode">barcode.</param>
        public PatchDocumentRequest(string name = default(string), DateTime? dateTime = default(DateTime?), List<PatchDocumentVersionRequest> versions = default(List<PatchDocumentVersionRequest>), string reference = default(string), string barcode = default(string))
        {
            this.Name = name;
            this.DateTime = dateTime;
            this.Versions = versions;
            this.Reference = reference;
            this.Barcode = barcode;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name = "dateTime", EmitDefaultValue = true)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Versions
        /// </summary>
        [DataMember(Name = "versions", EmitDefaultValue = true)]
        public List<PatchDocumentVersionRequest> Versions { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Barcode
        /// </summary>
        [DataMember(Name = "barcode", EmitDefaultValue = true)]
        public string Barcode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchDocumentRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
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
            return this.Equals(input as PatchDocumentRequest);
        }

        /// <summary>
        /// Returns true if PatchDocumentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchDocumentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    input.Versions != null &&
                    this.Versions.SequenceEqual(input.Versions)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DateTime != null)
                {
                    hashCode = (hashCode * 59) + this.DateTime.GetHashCode();
                }
                if (this.Versions != null)
                {
                    hashCode = (hashCode * 59) + this.Versions.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Barcode != null)
                {
                    hashCode = (hashCode * 59) + this.Barcode.GetHashCode();
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

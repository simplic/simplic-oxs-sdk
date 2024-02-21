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
    /// DataSetCsvUploadRequest
    /// </summary>
    [DataContract(Name = "DataSetCsvUploadRequest")]
    public partial class DataSetCsvUploadRequest : IEquatable<DataSetCsvUploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetCsvUploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataSetCsvUploadRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetCsvUploadRequest" /> class.
        /// </summary>
        /// <param name="dataSetId">dataSetId (required).</param>
        /// <param name="delimiter">delimiter (required).</param>
        /// <param name="hasHeaderRow">hasHeaderRow.</param>
        /// <param name="append">append.</param>
        /// <param name="keyColumnIndex">keyColumnIndex.</param>
        /// <param name="labelColumnIndex">labelColumnIndex.</param>
        /// <param name="data">data (required).</param>
        public DataSetCsvUploadRequest(Guid dataSetId = default(Guid), string delimiter = default(string), bool hasHeaderRow = default(bool), bool append = default(bool), int keyColumnIndex = default(int), int labelColumnIndex = default(int), byte[] data = default(byte[]))
        {
            this.DataSetId = dataSetId;
            // to ensure "delimiter" is required (not null)
            if (delimiter == null)
            {
                throw new ArgumentNullException("delimiter is a required property for DataSetCsvUploadRequest and cannot be null");
            }
            this.Delimiter = delimiter;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for DataSetCsvUploadRequest and cannot be null");
            }
            this.Data = data;
            this.HasHeaderRow = hasHeaderRow;
            this.Append = append;
            this.KeyColumnIndex = keyColumnIndex;
            this.LabelColumnIndex = labelColumnIndex;
        }

        /// <summary>
        /// Gets or Sets DataSetId
        /// </summary>
        [DataMember(Name = "dataSetId", IsRequired = true, EmitDefaultValue = true)]
        public Guid DataSetId { get; set; }

        /// <summary>
        /// Gets or Sets Delimiter
        /// </summary>
        [DataMember(Name = "delimiter", IsRequired = true, EmitDefaultValue = true)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Gets or Sets HasHeaderRow
        /// </summary>
        [DataMember(Name = "hasHeaderRow", EmitDefaultValue = true)]
        public bool HasHeaderRow { get; set; }

        /// <summary>
        /// Gets or Sets Append
        /// </summary>
        [DataMember(Name = "append", EmitDefaultValue = true)]
        public bool Append { get; set; }

        /// <summary>
        /// Gets or Sets KeyColumnIndex
        /// </summary>
        [DataMember(Name = "keyColumnIndex", EmitDefaultValue = false)]
        public int KeyColumnIndex { get; set; }

        /// <summary>
        /// Gets or Sets LabelColumnIndex
        /// </summary>
        [DataMember(Name = "labelColumnIndex", EmitDefaultValue = false)]
        public int LabelColumnIndex { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public byte[] Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSetCsvUploadRequest {\n");
            sb.Append("  DataSetId: ").Append(DataSetId).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  HasHeaderRow: ").Append(HasHeaderRow).Append("\n");
            sb.Append("  Append: ").Append(Append).Append("\n");
            sb.Append("  KeyColumnIndex: ").Append(KeyColumnIndex).Append("\n");
            sb.Append("  LabelColumnIndex: ").Append(LabelColumnIndex).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as DataSetCsvUploadRequest);
        }

        /// <summary>
        /// Returns true if DataSetCsvUploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSetCsvUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSetCsvUploadRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataSetId == input.DataSetId ||
                    (this.DataSetId != null &&
                    this.DataSetId.Equals(input.DataSetId))
                ) && 
                (
                    this.Delimiter == input.Delimiter ||
                    (this.Delimiter != null &&
                    this.Delimiter.Equals(input.Delimiter))
                ) && 
                (
                    this.HasHeaderRow == input.HasHeaderRow ||
                    this.HasHeaderRow.Equals(input.HasHeaderRow)
                ) && 
                (
                    this.Append == input.Append ||
                    this.Append.Equals(input.Append)
                ) && 
                (
                    this.KeyColumnIndex == input.KeyColumnIndex ||
                    this.KeyColumnIndex.Equals(input.KeyColumnIndex)
                ) && 
                (
                    this.LabelColumnIndex == input.LabelColumnIndex ||
                    this.LabelColumnIndex.Equals(input.LabelColumnIndex)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.DataSetId != null)
                {
                    hashCode = (hashCode * 59) + this.DataSetId.GetHashCode();
                }
                if (this.Delimiter != null)
                {
                    hashCode = (hashCode * 59) + this.Delimiter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasHeaderRow.GetHashCode();
                hashCode = (hashCode * 59) + this.Append.GetHashCode();
                hashCode = (hashCode * 59) + this.KeyColumnIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.LabelColumnIndex.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
            // Delimiter (string) maxLength
            if (this.Delimiter != null && this.Delimiter.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Delimiter, length must be less than 1.", new [] { "Delimiter" });
            }

            // Delimiter (string) minLength
            if (this.Delimiter != null && this.Delimiter.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Delimiter, length must be greater than 1.", new [] { "Delimiter" });
            }

            yield break;
        }
    }

}

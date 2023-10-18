/*
 * Simplic.OxS.vehicle-temperature
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

namespace Simplic.OxS.SDK.Vehicle.Temperature
{
    /// <summary>
    /// AgoraBeeTag
    /// </summary>
    [DataContract(Name = "AgoraBeeTag")]
    public partial class AgoraBeeTag : IEquatable<AgoraBeeTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgoraBeeTag" /> class.
        /// </summary>
        /// <param name="tagId">tagId.</param>
        /// <param name="rfr">rfr.</param>
        /// <param name="status">status.</param>
        /// <param name="statusId">statusId.</param>
        /// <param name="temperature">temperature.</param>
        public AgoraBeeTag(long tagId = default(long), int rfr = default(int), string status = default(string), int statusId = default(int), double? temperature = default(double?))
        {
            this.TagId = tagId;
            this.Rfr = rfr;
            this.Status = status;
            this.StatusId = statusId;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name = "tagId", EmitDefaultValue = false)]
        public long TagId { get; set; }

        /// <summary>
        /// Gets or Sets Rfr
        /// </summary>
        [DataMember(Name = "rfr", EmitDefaultValue = false)]
        public int Rfr { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusId
        /// </summary>
        [DataMember(Name = "statusId", EmitDefaultValue = false)]
        public int StatusId { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name = "temperature", EmitDefaultValue = true)]
        public double? Temperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgoraBeeTag {\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  Rfr: ").Append(Rfr).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
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
            return this.Equals(input as AgoraBeeTag);
        }

        /// <summary>
        /// Returns true if AgoraBeeTag instances are equal
        /// </summary>
        /// <param name="input">Instance of AgoraBeeTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgoraBeeTag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TagId == input.TagId ||
                    this.TagId.Equals(input.TagId)
                ) && 
                (
                    this.Rfr == input.Rfr ||
                    this.Rfr.Equals(input.Rfr)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusId == input.StatusId ||
                    this.StatusId.Equals(input.StatusId)
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
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
                hashCode = (hashCode * 59) + this.TagId.GetHashCode();
                hashCode = (hashCode * 59) + this.Rfr.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StatusId.GetHashCode();
                if (this.Temperature != null)
                {
                    hashCode = (hashCode * 59) + this.Temperature.GetHashCode();
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

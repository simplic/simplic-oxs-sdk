/*
 * Simplic.OxS.Logistics
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

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// Response containing composed tractor unit information.
    /// </summary>
    [DataContract(Name = "GetComposedTractorUnitResponse")]
    public partial class GetComposedTractorUnitResponse : IEquatable<GetComposedTractorUnitResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetComposedTractorUnitResponse" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the tractor unit resource..</param>
        /// <param name="matchCode">Gets or sets the match code of the tractor unit..</param>
        /// <param name="details">details.</param>
        public GetComposedTractorUnitResponse(Guid id = default(Guid), string matchCode = default(string), GetComposedTractorUnitDetailsResponse details = default(GetComposedTractorUnitDetailsResponse))
        {
            this.Id = id;
            this.MatchCode = matchCode;
            this.Details = details;
        }

        /// <summary>
        /// Gets or sets the id of the tractor unit resource.
        /// </summary>
        /// <value>Gets or sets the id of the tractor unit resource.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the match code of the tractor unit.
        /// </summary>
        /// <value>Gets or sets the match code of the tractor unit.</value>
        [DataMember(Name = "matchCode", EmitDefaultValue = true)]
        public string MatchCode { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public GetComposedTractorUnitDetailsResponse Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetComposedTractorUnitResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as GetComposedTractorUnitResponse);
        }

        /// <summary>
        /// Returns true if GetComposedTractorUnitResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetComposedTractorUnitResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetComposedTractorUnitResponse input)
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
                    this.MatchCode == input.MatchCode ||
                    (this.MatchCode != null &&
                    this.MatchCode.Equals(input.MatchCode))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.MatchCode != null)
                {
                    hashCode = (hashCode * 59) + this.MatchCode.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
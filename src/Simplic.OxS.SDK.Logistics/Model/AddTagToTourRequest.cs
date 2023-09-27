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

namespace Simplic.OxS.SDK.Logistics.Model
{
    /// <summary>
    /// Request to add a tag to a tour.
    /// </summary>
    [DataContract(Name = "AddTagToTourRequest")]
    public partial class AddTagToTourRequest : IEquatable<AddTagToTourRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagToTourRequest" /> class.
        /// </summary>
        /// <param name="tourId">Gets or sets the tour id..</param>
        /// <param name="tagId">Gets or sets the tag id..</param>
        public AddTagToTourRequest(Guid tourId = default(Guid), Guid tagId = default(Guid))
        {
            this.TourId = tourId;
            this.TagId = tagId;
        }

        /// <summary>
        /// Gets or sets the tour id.
        /// </summary>
        /// <value>Gets or sets the tour id.</value>
        [DataMember(Name = "tourId", EmitDefaultValue = false)]
        public Guid TourId { get; set; }

        /// <summary>
        /// Gets or sets the tag id.
        /// </summary>
        /// <value>Gets or sets the tag id.</value>
        [DataMember(Name = "tagId", EmitDefaultValue = false)]
        public Guid TagId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddTagToTourRequest {\n");
            sb.Append("  TourId: ").Append(TourId).Append("\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
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
            return this.Equals(input as AddTagToTourRequest);
        }

        /// <summary>
        /// Returns true if AddTagToTourRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddTagToTourRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddTagToTourRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TourId == input.TourId ||
                    (this.TourId != null &&
                    this.TourId.Equals(input.TourId))
                ) && 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
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
                if (this.TourId != null)
                {
                    hashCode = (hashCode * 59) + this.TourId.GetHashCode();
                }
                if (this.TagId != null)
                {
                    hashCode = (hashCode * 59) + this.TagId.GetHashCode();
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

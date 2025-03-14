/*
 * Simplic.OxS.Geo
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

namespace Simplic.OxS.SDK.Geo
{
    /// <summary>
    /// LocationResponse
    /// </summary>
    [DataContract(Name = "LocationResponse")]
    public partial class LocationResponse : IEquatable<LocationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResponse" /> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="roadAccessPosition">roadAccessPosition.</param>
        /// <param name="formattedAddress">formattedAddress.</param>
        /// <param name="score">score.</param>
        public LocationResponse(double latitude = default(double), double longitude = default(double), RoadAccessPosition roadAccessPosition = default(RoadAccessPosition), string formattedAddress = default(string), double score = default(double))
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.RoadAccessPosition = roadAccessPosition;
            this.FormattedAddress = formattedAddress;
            this.Score = score;
        }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or Sets RoadAccessPosition
        /// </summary>
        [DataMember(Name = "roadAccessPosition", EmitDefaultValue = false)]
        public RoadAccessPosition RoadAccessPosition { get; set; }

        /// <summary>
        /// Gets or Sets FormattedAddress
        /// </summary>
        [DataMember(Name = "formattedAddress", EmitDefaultValue = true)]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public double Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LocationResponse {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  RoadAccessPosition: ").Append(RoadAccessPosition).Append("\n");
            sb.Append("  FormattedAddress: ").Append(FormattedAddress).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(input as LocationResponse);
        }

        /// <summary>
        /// Returns true if LocationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.RoadAccessPosition == input.RoadAccessPosition ||
                    (this.RoadAccessPosition != null &&
                    this.RoadAccessPosition.Equals(input.RoadAccessPosition))
                ) && 
                (
                    this.FormattedAddress == input.FormattedAddress ||
                    (this.FormattedAddress != null &&
                    this.FormattedAddress.Equals(input.FormattedAddress))
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
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
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                if (this.RoadAccessPosition != null)
                {
                    hashCode = (hashCode * 59) + this.RoadAccessPosition.GetHashCode();
                }
                if (this.FormattedAddress != null)
                {
                    hashCode = (hashCode * 59) + this.FormattedAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
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

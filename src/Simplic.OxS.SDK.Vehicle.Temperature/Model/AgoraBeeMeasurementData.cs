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
    /// AgoraBeeMeasurementData
    /// </summary>
    [DataContract(Name = "AgoraBeeMeasurementData")]
    public partial class AgoraBeeMeasurementData : IEquatable<AgoraBeeMeasurementData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgoraBeeMeasurementData" /> class.
        /// </summary>
        /// <param name="imei">imei.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="speed">speed.</param>
        /// <param name="heading">heading.</param>
        /// <param name="devTimestamp">devTimestamp.</param>
        /// <param name="srvTimestamp">srvTimestamp.</param>
        /// <param name="tags">tags.</param>
        /// <param name="readerId">readerId.</param>
        public AgoraBeeMeasurementData(string imei = default(string), double latitude = default(double), double longitude = default(double), double speed = default(double), int heading = default(int), long devTimestamp = default(long), long srvTimestamp = default(long), List<AgoraBeeTag> tags = default(List<AgoraBeeTag>), string readerId = default(string))
        {
            this.Imei = imei;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Speed = speed;
            this.Heading = heading;
            this.DevTimestamp = devTimestamp;
            this.SrvTimestamp = srvTimestamp;
            this.Tags = tags;
            this.ReaderId = readerId;
        }

        /// <summary>
        /// Gets or Sets Imei
        /// </summary>
        [DataMember(Name = "imei", EmitDefaultValue = true)]
        public string Imei { get; set; }

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
        /// Gets or Sets Speed
        /// </summary>
        [DataMember(Name = "speed", EmitDefaultValue = false)]
        public double Speed { get; set; }

        /// <summary>
        /// Gets or Sets Heading
        /// </summary>
        [DataMember(Name = "heading", EmitDefaultValue = false)]
        public int Heading { get; set; }

        /// <summary>
        /// Gets or Sets DevTimestamp
        /// </summary>
        [DataMember(Name = "devTimestamp", EmitDefaultValue = false)]
        public long DevTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets SrvTimestamp
        /// </summary>
        [DataMember(Name = "srvTimestamp", EmitDefaultValue = false)]
        public long SrvTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<AgoraBeeTag> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ReaderId
        /// </summary>
        [DataMember(Name = "readerId", EmitDefaultValue = true)]
        public string ReaderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgoraBeeMeasurementData {\n");
            sb.Append("  Imei: ").Append(Imei).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
            sb.Append("  Heading: ").Append(Heading).Append("\n");
            sb.Append("  DevTimestamp: ").Append(DevTimestamp).Append("\n");
            sb.Append("  SrvTimestamp: ").Append(SrvTimestamp).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ReaderId: ").Append(ReaderId).Append("\n");
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
            return this.Equals(input as AgoraBeeMeasurementData);
        }

        /// <summary>
        /// Returns true if AgoraBeeMeasurementData instances are equal
        /// </summary>
        /// <param name="input">Instance of AgoraBeeMeasurementData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgoraBeeMeasurementData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Imei == input.Imei ||
                    (this.Imei != null &&
                    this.Imei.Equals(input.Imei))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.Speed == input.Speed ||
                    this.Speed.Equals(input.Speed)
                ) && 
                (
                    this.Heading == input.Heading ||
                    this.Heading.Equals(input.Heading)
                ) && 
                (
                    this.DevTimestamp == input.DevTimestamp ||
                    this.DevTimestamp.Equals(input.DevTimestamp)
                ) && 
                (
                    this.SrvTimestamp == input.SrvTimestamp ||
                    this.SrvTimestamp.Equals(input.SrvTimestamp)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ReaderId == input.ReaderId ||
                    (this.ReaderId != null &&
                    this.ReaderId.Equals(input.ReaderId))
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
                if (this.Imei != null)
                {
                    hashCode = (hashCode * 59) + this.Imei.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Speed.GetHashCode();
                hashCode = (hashCode * 59) + this.Heading.GetHashCode();
                hashCode = (hashCode * 59) + this.DevTimestamp.GetHashCode();
                hashCode = (hashCode * 59) + this.SrvTimestamp.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.ReaderId != null)
                {
                    hashCode = (hashCode * 59) + this.ReaderId.GetHashCode();
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

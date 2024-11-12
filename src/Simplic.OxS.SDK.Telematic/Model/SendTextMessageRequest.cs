/*
 * Simplic.OxS.Telematic
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

namespace Simplic.OxS.SDK.Telematic
{
    /// <summary>
    /// SendTextMessageRequest
    /// </summary>
    [DataContract(Name = "SendTextMessageRequest")]
    public partial class SendTextMessageRequest : IEquatable<SendTextMessageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTextMessageRequest" /> class.
        /// </summary>
        /// <param name="vehicleId">vehicleId.</param>
        /// <param name="driverId">driverId.</param>
        /// <param name="message">message.</param>
        public SendTextMessageRequest(Guid? vehicleId = default(Guid?), Guid? driverId = default(Guid?), string message = default(string))
        {
            this.VehicleId = vehicleId;
            this.DriverId = driverId;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets VehicleId
        /// </summary>
        [DataMember(Name = "vehicleId", EmitDefaultValue = true)]
        public Guid? VehicleId { get; set; }

        /// <summary>
        /// Gets or Sets DriverId
        /// </summary>
        [DataMember(Name = "driverId", EmitDefaultValue = true)]
        public Guid? DriverId { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendTextMessageRequest {\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
            sb.Append("  DriverId: ").Append(DriverId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as SendTextMessageRequest);
        }

        /// <summary>
        /// Returns true if SendTextMessageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SendTextMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendTextMessageRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VehicleId == input.VehicleId ||
                    (this.VehicleId != null &&
                    this.VehicleId.Equals(input.VehicleId))
                ) && 
                (
                    this.DriverId == input.DriverId ||
                    (this.DriverId != null &&
                    this.DriverId.Equals(input.DriverId))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.VehicleId != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleId.GetHashCode();
                }
                if (this.DriverId != null)
                {
                    hashCode = (hashCode * 59) + this.DriverId.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
